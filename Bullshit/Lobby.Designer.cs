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
            this.TextServerIP = new System.Windows.Forms.TextBox();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.ButtonOffline = new System.Windows.Forms.Button();
            this.TextName = new System.Windows.Forms.TextBox();
            this.LinkIP = new System.Windows.Forms.LinkLabel();
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
            // TextServerIP
            // 
            this.TextServerIP.BackColor = System.Drawing.Color.White;
            this.TextServerIP.ForeColor = System.Drawing.Color.Black;
            this.TextServerIP.Location = new System.Drawing.Point(12, 55);
            this.TextServerIP.Name = "TextServerIP";
            this.TextServerIP.Size = new System.Drawing.Size(100, 20);
            this.TextServerIP.TabIndex = 2;
            this.TextServerIP.Text = "127.0.0.1:44444";
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
            // LinkIP
            // 
            this.LinkIP.ActiveLinkColor = System.Drawing.Color.Silver;
            this.LinkIP.AutoSize = true;
            this.LinkIP.ForeColor = System.Drawing.Color.Black;
            this.LinkIP.LinkColor = System.Drawing.Color.White;
            this.LinkIP.Location = new System.Drawing.Point(12, 84);
            this.LinkIP.Name = "LinkIP";
            this.LinkIP.Size = new System.Drawing.Size(47, 13);
            this.LinkIP.TabIndex = 12;
            this.LinkIP.TabStop = true;
            this.LinkIP.Text = "Show IP";
            this.LinkIP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkIP_LinkClicked);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(234, 111);
            this.Controls.Add(this.LinkIP);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.ButtonOffline);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.ButtonConnect);
            this.Controls.Add(this.TextServerIP);
            this.Controls.Add(this.PanelTop);
            this.Name = "Lobby";
            this.Text = "Bull Shoot - Menu";
            this.PanelTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.TextBox TextServerIP;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonOffline;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.LinkLabel LinkIP;
    }
}

