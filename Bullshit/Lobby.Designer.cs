namespace Bullshit
{
    partial class Lobby
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelTop = new System.Windows.Forms.Panel();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.TextIP = new System.Windows.Forms.TextBox();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.ButtonOffline = new System.Windows.Forms.Button();
            this.TextName = new System.Windows.Forms.TextBox();
            this.LinkIPCopy = new System.Windows.Forms.LinkLabel();
            this.LinkIPShow = new System.Windows.Forms.LinkLabel();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.Gray;
            this.PanelTop.Controls.Add(this.ButtonExit);
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(236, 22);
            this.PanelTop.TabIndex = 1;
            this.PanelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseMove);
            // 
            // ButtonExit
            // 
            this.ButtonExit.ForeColor = System.Drawing.Color.Black;
            this.ButtonExit.Location = new System.Drawing.Point(13, 0);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(22, 22);
            this.ButtonExit.TabIndex = 0;
            this.ButtonExit.Text = "X";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // TextIP
            // 
            this.TextIP.BackColor = System.Drawing.Color.White;
            this.TextIP.ForeColor = System.Drawing.Color.Black;
            this.TextIP.Location = new System.Drawing.Point(12, 55);
            this.TextIP.Name = "TextIP";
            this.TextIP.Size = new System.Drawing.Size(100, 20);
            this.TextIP.TabIndex = 2;
            this.TextIP.Text = "127.0.0.1:44444";
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.BackColor = System.Drawing.Color.White;
            this.ButtonConnect.ForeColor = System.Drawing.Color.Black;
            this.ButtonConnect.Location = new System.Drawing.Point(134, 53);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(75, 23);
            this.ButtonConnect.TabIndex = 4;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = false;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.BackColor = System.Drawing.Color.White;
            this.ButtonCreate.ForeColor = System.Drawing.Color.Black;
            this.ButtonCreate.Location = new System.Drawing.Point(134, 79);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(75, 23);
            this.ButtonCreate.TabIndex = 6;
            this.ButtonCreate.Text = "Create";
            this.ButtonCreate.UseVisualStyleBackColor = false;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // ButtonOffline
            // 
            this.ButtonOffline.BackColor = System.Drawing.Color.White;
            this.ButtonOffline.ForeColor = System.Drawing.Color.Black;
            this.ButtonOffline.Location = new System.Drawing.Point(134, 27);
            this.ButtonOffline.Name = "ButtonOffline";
            this.ButtonOffline.Size = new System.Drawing.Size(75, 23);
            this.ButtonOffline.TabIndex = 8;
            this.ButtonOffline.Text = "Offline";
            this.ButtonOffline.UseVisualStyleBackColor = false;
            this.ButtonOffline.Click += new System.EventHandler(this.ButtonOffline_Click);
            // 
            // TextName
            // 
            this.TextName.BackColor = System.Drawing.Color.White;
            this.TextName.ForeColor = System.Drawing.Color.Black;
            this.TextName.Location = new System.Drawing.Point(12, 29);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(100, 20);
            this.TextName.TabIndex = 10;
            this.TextName.Text = "Player";
            // 
            // LinkIPCopy
            // 
            this.LinkIPCopy.ActiveLinkColor = System.Drawing.Color.Silver;
            this.LinkIPCopy.AutoSize = true;
            this.LinkIPCopy.ForeColor = System.Drawing.Color.Black;
            this.LinkIPCopy.LinkColor = System.Drawing.Color.White;
            this.LinkIPCopy.Location = new System.Drawing.Point(12, 84);
            this.LinkIPCopy.Name = "LinkIPCopy";
            this.LinkIPCopy.Size = new System.Drawing.Size(44, 13);
            this.LinkIPCopy.TabIndex = 12;
            this.LinkIPCopy.TabStop = true;
            this.LinkIPCopy.Text = "Copy IP";
            this.LinkIPCopy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkIPCopy_LinkClicked);
            // 
            // LinkIPShow
            // 
            this.LinkIPShow.ActiveLinkColor = System.Drawing.Color.Silver;
            this.LinkIPShow.AutoSize = true;
            this.LinkIPShow.ForeColor = System.Drawing.Color.Black;
            this.LinkIPShow.LinkColor = System.Drawing.Color.White;
            this.LinkIPShow.Location = new System.Drawing.Point(68, 84);
            this.LinkIPShow.Name = "LinkIPShow";
            this.LinkIPShow.Size = new System.Drawing.Size(47, 13);
            this.LinkIPShow.TabIndex = 13;
            this.LinkIPShow.TabStop = true;
            this.LinkIPShow.Text = "Show IP";
            this.LinkIPShow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkIPShow_LinkClicked);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(234, 111);
            this.Controls.Add(this.LinkIPShow);
            this.Controls.Add(this.LinkIPCopy);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.ButtonOffline);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.ButtonConnect);
            this.Controls.Add(this.TextIP);
            this.Controls.Add(this.PanelTop);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Lobby";
            this.Text = "Bull Shoot - Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lobby_FormClosing);
            this.PanelTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.TextBox TextIP;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonOffline;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.LinkLabel LinkIPCopy;
        private System.Windows.Forms.LinkLabel LinkIPShow;
    }
}

