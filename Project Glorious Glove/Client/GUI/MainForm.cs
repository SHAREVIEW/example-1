using System;
using System.Drawing;
using System.Windows.Forms;

namespace Client.GUI
{
    public partial class MainForm : Form
    {
        #region Frame Type Constants

        // ID Frames, shown frame is choosen by Selected Index in ListBox,
        private const int DevicesType = 0;
        private const int GesturesType = 1;
        private const int SettingsType = 2;
        private const int HelpType = 3;

        #endregion

        #region Mouse Event's Variables

        private bool _isDragged;
        private Point _oldMousePosition;
        private int _lastSelectedIndex;

        #endregion
        public MainForm()
        {
            InitializeComponent();

            settingsUserControl.Hide();

            menuListBox.SelectedIndex = 0;
            _lastSelectedIndex = 0;
        }

        #region Control Form (Управление формой и обработка событий)
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void nameLabel_MouseDown(object sender, MouseEventArgs e)
        {
            _isDragged = true;
            _oldMousePosition = e.Location;
        }

        private void nameLabel_MouseUp(object sender, MouseEventArgs e)
        {
            _isDragged = false;
        }

        private void nameLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragged)
                Location = new Point(Location.X + (e.X - _oldMousePosition.X), Location.Y + (e.Y - _oldMousePosition.Y));
        }

        private void menuListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hide last frame and show necessary frame.

            switch (_lastSelectedIndex)
            {
                case DevicesType:
                    devicesUserControl.Hide();
                    break;

                case GesturesType:
                    break;

                case HelpType:
                    break;

                case SettingsType:
                    settingsUserControl.Hide();
                    break;
            }

            switch (menuListBox.SelectedIndex)
            {
                case DevicesType:
                    devicesUserControl.Show();
                    break;

                case GesturesType:
                    break;

                case HelpType:
                    break;

                case SettingsType:
                    settingsUserControl.Show();
                    settingsUserControl.UpdateComPortNames();
                    break;
            }
            _lastSelectedIndex = menuListBox.SelectedIndex;
        }

        #endregion
        private void showAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
