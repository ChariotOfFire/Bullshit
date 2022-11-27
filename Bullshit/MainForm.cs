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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }
        #region Custom Window Controls
        private bool _mouseDown;
        private Point _lastMousePosition;
        private bool Maximized { get =>
                WindowState == FormWindowState.Maximized; }

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

        private void ButtonMaximize_Click(object sender, EventArgs e)
        {
            if (Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            PanelTop.Width = Width;
        }
        #endregion
    }
}
