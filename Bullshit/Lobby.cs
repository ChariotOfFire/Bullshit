using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bullshit
{
    public partial class Lobby : Form
    {
        public Lobby()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }
        #region Custom Window Controls
        private bool _mouseDown;
        private Point _lastMousePosition;

        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastMousePosition = MousePosition;
        }

        private void PanelTop_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                int xoffset = MousePosition.X - _lastMousePosition.X;
                int yoffset = MousePosition.Y - _lastMousePosition.Y;
                Left += xoffset;
                Top += yoffset;
                _lastMousePosition = MousePosition;
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void ShowMainForm()
        {
            Hide();
            new MainForm().ShowDialog();
            Show();
        }

        private void ButtonOffline_Click(object sender, EventArgs e)
        {
            ShowMainForm();
        }

        private void LinkIP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Console.WriteLine("Your IP of all devices:");
            NetworkServer.MyIP();
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            NetworkClient.Connect();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            NetworkServer.Create();
        }
    }
}
