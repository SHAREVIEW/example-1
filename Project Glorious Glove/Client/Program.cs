using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Client.GUI;
using Client.Input.SingleProcessing;
using InTheHand.Net.Bluetooth;

namespace Client
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SingleHandler singleHandler = new SingleHandler();
            singleHandler.Start();
            /*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            //*/
        }
    }
}
