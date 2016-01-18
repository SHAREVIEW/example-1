using System;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;



namespace Client.Input.SingleProcessing
{
    public class SingleHandler
    {
        private BluetoothListener _listener;
        private BluetoothClient _client;

        /// <summary>
        /// Value must set "True", if device is Arduino glove. 
        /// </summary>
        public bool IsGlove;

        public int PacketSize = 6;
        /// <summary>
        /// Value must not to be null, if device is Arduino glove. 
        /// </summary>
        public string MacAddress;

        public static HandlerState State
        { get; protected set; }

        public enum HandlerState
        {
            Ignoring,
            Pause,
            Working,
            Finished
        }

        public SingleHandler()
        {

        }

        public SingleHandler(bool isGlove = false, string macAddress = null, int packetSize = 6)
        {
            PacketSize = packetSize;
            IsGlove = isGlove;
            MacAddress = macAddress;
        }

        /// <summary>
        /// Start handler
        /// </summary>
        public void Start()
        {
            if (BluetoothRadio.IsSupported)
            {
                State = HandlerState.Working;
                Thread thread = new Thread(EstabilishBtConnection);
                thread.Start();
            }
            else
                MessageBox.Show(@"Error to start SingleHandler. Reasons:
1. Bluetooth-module is not supported.
2. Bluetooth is turn off.
");
        }

        /// <summary>
        /// Continue to get data from external device to queue, but do not processing.
        /// Action`s data from external device is saved for future processing.
        /// </summary>
        public void Pause()
        {
            State = HandlerState.Pause;
        }

        /// <summary>
        /// Get data but do not save actions in queue. Ignore = Save in SingleHandler, not MultiHandler.
        /// </summary>
        public void Ignore()
        {
            State = HandlerState.Ignoring;
        }

        /// <summary>
        /// ;).
        /// </summary>
        /// <param name="data">Data byte packet.
        /// data[0] - Type Device; 
        /// data[1] - Non used;
        /// data[2] - Mouse`s move type; 
        /// data[3] - For Android - X-axis move, for Arduino Glove - non used; 
        /// data[4] - For Android - Y-axis move, for Arduino Glove - id direction of cursor motion; 
        /// data[5] - Only Arduino Glove - movement speed of cursor;
        /// </param>
        private static void Action(byte[] data)
        {
            byte typeDevice = data[0];
            uint typeEventMouseControl = InputControl.MOUSEEVENTF_ABSOLUTE;

            switch (data[2])
            {
                case 0x01:
                    typeEventMouseControl = InputControl.MOUSEEVENTF_MOVE;
                    break;

                case 0x41:
                    typeEventMouseControl = InputControl.MOUSEEVENTF_RIGHTDOWN;
                    break;

                case 0x02:
                    typeEventMouseControl = InputControl.MOUSEEVENTF_LEFTDOWN;
                    break;

                case 0x42:
                    typeEventMouseControl = InputControl.MOUSEEVENTF_RIGHTDOWN;
                    break;

                case 0x03:
                    typeEventMouseControl = InputControl.MOUSEEVENTF_LEFTDOWN;
                    break;

                case 0x43:
                    typeEventMouseControl = InputControl.MOUSEEVENTF_RIGHTUP;
                    break;

                case 0x0c:
                    typeEventMouseControl = InputControl.MOUSEEVENTF_LEFTUP;
                    break;
            }

            if (typeDevice == 0x30)
                InputControl.mouse_event(typeEventMouseControl, (data[3] / 128 == 1 ? -1 : 1) * (data[3] % 128), (data[4] / 128 == 1 ? -1 : 1) * (data[4] % 128), 0, 0);

            if (typeDevice != 0x7c)
                return;

            int xRotate = data[4] == 0x02 ? 1 : data[4] == 0x04 ? -1 : 0;
            int yRotate = data[4] == 0x03 ? 1 : data[4] == 0x01 ? -1 : 0;

            int x = data[5] * xRotate;
            int y = data[5] * yRotate;

            InputControl.mouse_event(typeEventMouseControl, x, y, 0, 0);
        }

        /// <summary>
        /// Connect to device and handle received packets from connected device.
        /// </summary>
        private void EstabilishBtConnection()
        {
            bool isConnected = false;

            while (State != HandlerState.Finished)
            {
                // Try listen. 
                if (isConnected)
                {
                    NetworkStream stream = _client.GetStream();
                    
                    byte[] data = new byte[PacketSize];
                    // If device is disconnected... infinity loop, i guess. Because value of ReadTimeout is -1.
                    stream.Read(data, 0, PacketSize);
                    stream.Flush();
                    Action(data);
                }
                else
                // Try connect, if is not connected
                {
                    isConnected = IsGlove ? ConnectArduino(ref _client, MacAddress) : ConnectAndroid(ref _listener, ref _client);
                    if (isConnected)
                        isConnected = _client != null && _client.Connected;
                }
            }

            if (_client != null)
            {
                _client.GetStream().Close();
                _client.Dispose();
            }

            if (_listener != null)
            {
                _listener.Server.Dispose();
                _listener.Stop();
            }

            State = HandlerState.Finished;
        }

        /// <summary>
        /// Connect to Arduino. (PC as Master)
        /// </summary>
        /// <param name="client">Ref class BluetoothClient</param>
        /// <param name="macAdress">Mac Address from Single Handler</param>
        /// <returns></returns>
        private static bool ConnectArduino(ref BluetoothClient client, string macAdress)
        {
            try
            {
                client = new BluetoothClient();
                client.Connect(new BluetoothEndPoint(BluetoothAddress.Parse(macAdress), BluetoothService.SerialPort));
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show(@"Error. Connection is failed!");
                return false;
            }
        }

        /// <summary>
        /// Waiting to accept connection with Android. (PC as Slave)
        /// </summary>
        /// <param name="listener">Listen requests to accept and connect</param>
        /// <param name="client">Created from accepted connection</param>
        /// <returns></returns>
        private static bool ConnectAndroid(ref BluetoothListener listener, ref BluetoothClient client)
        {
            try
            {
                listener = new BluetoothListener(BluetoothService.RFCommProtocol);
                listener.Start();
                client = listener.AcceptBluetoothClient();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show(@"Error. Connection is failed!");
                return false;
            }
        }
    }
}
