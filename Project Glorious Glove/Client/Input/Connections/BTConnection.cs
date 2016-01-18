using System;
using System.IO.Ports;

namespace Client.Input.Connections
{
	[Obsolete]
    public class BTConnection
    {
        private const int BufferSize = 12;
        private SerialPort _currentSerialPort;

        public BTConnection(string namePort)
        {
            _currentSerialPort = new SerialPort(namePort);
        }

        public BTConnection(SerialPort port)
        {
            _currentSerialPort = port;
        }

        /// <summary>
        /// Пытается открыть соединение с устройством по указанному порту
        /// </summary>
        /// <param name="port">Последовательный COM-порт</param>
        /// <returns></returns>
        public bool TryConnect()
        {
            _currentSerialPort.ReadTimeout = 15 * 1000;
            _currentSerialPort.WriteTimeout = 15 * 1000;
            if (_currentSerialPort == null)
                return false;
            _currentSerialPort.Open();
            return _currentSerialPort.IsOpen;
        }

        /// <summary>
        /// Пытается получить массив байтов по указанному порту
        /// </summary>
        /// <returns>Считанный массив байтов или null</returns>
        public byte[] TryRead()
        {
            byte[] result = null;
            if (_currentSerialPort != null)
                if (!_currentSerialPort.IsOpen)
                {
                    result = new byte[BufferSize];
                    _currentSerialPort.Read(result, 0, BufferSize);
                }
            return result;
        }
        /// <summary>
        /// Пытается передать массив-байт по указанному порту
        /// </summary>
        /// <param name="data">Массив байтов для передачи</param>
        /// <returns></returns>
        public bool TryWrite(byte[] data)
        {
            bool result = false;
            if (_currentSerialPort != null)
                if (!_currentSerialPort.IsOpen)
                    if (data != null)
                        try
                        {
                            _currentSerialPort.Write(data, 0, BufferSize);
                            result = true;
                        }
                        catch (TimeoutException)
                        {
                            // ignored. Reason: default value is false.
                        }
            return result;
        }

        /// <summary>
        /// Пытается закрыть соединение с устройством по указанному порту
        /// </summary>
        /// <returns></returns>
        public bool TryDisconnect()
        {
            if (_currentSerialPort == null)
                return true;
            _currentSerialPort.Close();
            return !_currentSerialPort.IsOpen;
        }
    }
}
