using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bullshit
{
    public partial class MainForm : Form
    {
        Chat _chat;
        public MainForm()
        {
            InitializeComponent();
            _chat = new Chat();
            FormBorderStyle = FormBorderStyle.None;
            TextChat.Hide();
            // Icon setup
            IntPtr handle = Properties.Resources.icon.GetHicon();
            Icon = Icon.FromHandle(handle);
            // Button Setup
            ButtonExit.DisableSelect();
            ButtonMaximize.DisableSelect();
            ButtonMinimize.DisableSelect();
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
        #endregion

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    _chat.Show();
                    break;
            }
        }

        private void ChatFade_Tick(object sender, EventArgs e)
        {
            TextChat.Hide();
            ChatFade.Stop();
        }

        private void TextChat_TextChanged(object sender, EventArgs e)
        {
            TextChat.Show();
            ChatFade.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            TextChat.Text = _chat.ChatText;
        }
    }
}
