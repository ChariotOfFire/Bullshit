using System;
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
            // Icon setup
            System.IntPtr handle = Properties.Resources.icon.GetHicon();
            Icon = Icon.FromHandle(handle);
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
            Clipboard.SetText(NetworkServer.MyIP());
            LinkIPCopy.Name = "Copied";
        }
        private void LinkIPShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(NetworkServer.MyIP(), "Your IP",
                MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2);
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            NetworkClient.Connect(TextIP.Text);
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            NetworkServer.Create(TextIP.Text);
        }

        private void Lobby_FormClosing(object sender, FormClosingEventArgs e)
        {
            var host = TextIP.Text;
            if (host.Contains(":") == false)
                return;
            Properties.Settings.Default.IPAddress = host;
            Properties.Settings.Default.Save();
        }

    }
}
