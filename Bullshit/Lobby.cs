using System;
using System.Net.Sockets;
using System.Drawing;
using System.Windows.Forms;

namespace Bullshit
{
    public partial class Lobby : Form
    {
        public Lobby()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            TextIP.Text = Properties.Settings.Default.IPAddress;
            TextName.Text = Properties.Settings.Default.Username;

            // Icon setup
            IntPtr handle = Properties.Resources.icon.GetHicon();
            Icon = Icon.FromHandle(handle);
            // Controls setup
            ButtonOffline.Select();
            ButtonExit.DisableSelect();
            LinkIPCopy.DisableSelect();
            LinkIPShow.DisableSelect();
            TextName.DisableSelect();
            TextIP.DisableSelect();
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

        private void LinkIPCopy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkIPCopy.Text = "Copied";
        }
        private void LinkIPShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
        }

        private void Lobby_FormClosing(object sender, FormClosingEventArgs e)
        {
            var host = TextIP.Text;
            if (host.Contains(":"))
                Properties.Settings.Default.IPAddress = host;
            Properties.Settings.Default.Username = TextName.Text;
            Properties.Settings.Default.Save();
        }
    }
}
