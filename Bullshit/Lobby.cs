using System;
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
            NetworkServer.MyIP();
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            NetworkClient.Connect(TextServerIP.Text);
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            NetworkServer.Create(TextServerIP.Text);
        }
    }
}
