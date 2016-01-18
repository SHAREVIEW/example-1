using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client.GUI.Controls
{
    public partial class SettingsUserControl : UserControl
    {
        private const string None = "None";
        public string ChoosenComPort
        { get; protected set; }

        public SettingsUserControl()
        {
            InitializeComponent();
            comPortComboBox.Items.Add(None);
            comPortComboBox.SelectedIndex = 0;
            ChoosenComPort = null;
        }

        /// <summary>
        /// Refresh available COM-ports collection
        /// </summary>
        public void UpdateComPortNames()
        {
            comPortComboBox.Items.Clear();
            comPortComboBox.Items.Add(None);
            comPortComboBox.Items.AddRange(SerialPort.GetPortNames());
            if (ChoosenComPort != null)
            {
                if (comPortComboBox.Items.Contains(ChoosenComPort))
                    comPortComboBox.SelectedIndex = comPortComboBox.Items.IndexOf(ChoosenComPort);
            }
            else
                comPortComboBox.SelectedIndex = 0;
        }

        private void comPortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comPortComboBox.SelectedIndex > 0)
                ChoosenComPort = (string)comPortComboBox.Items[comPortComboBox.SelectedIndex];
            else
                ChoosenComPort = null;
        }
    }
}
