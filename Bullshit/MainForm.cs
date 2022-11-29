using System;
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
        private bool Maximized { get =>
                WindowState == FormWindowState.Maximized; }

        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Location = MousePosition;
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonMaximize_Click(object sender, EventArgs e)
        {
            if (Maximized)
            {
                WindowState = FormWindowState.Normal;
                ButtonMaximize.Text = "+";
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                ButtonMaximize.Text = "-";
            }
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
