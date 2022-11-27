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
            this.TextServerIP = new System.Windows.Forms.TextBox();
            this.TextServerPort = new System.Windows.Forms.TextBox();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.TextMyPort = new System.Windows.Forms.TextBox();
            this.ButtonOffline = new System.Windows.Forms.Button();
            this.TextMyIP = new System.Windows.Forms.TextBox();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PanelTop.Controls.Add(this.ButtonExit);
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(386, 22);
            this.PanelTop.TabIndex = 1;
            this.PanelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseDown);
            this.PanelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseMove);
            this.PanelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseUp);
            // 
            // TextServerIP
            // 
            this.TextServerIP.Location = new System.Drawing.Point(13, 29);
            this.TextServerIP.Name = "TextServerIP";
            this.TextServerIP.Size = new System.Drawing.Size(100, 20);
            this.TextServerIP.TabIndex = 2;
            this.TextServerIP.Text = "ip";
            // 
            // TextServerPort
            // 
            this.TextServerPort.Location = new System.Drawing.Point(119, 29);
            this.TextServerPort.Name = "TextServerPort";
            this.TextServerPort.Size = new System.Drawing.Size(100, 20);
            this.TextServerPort.TabIndex = 3;
            this.TextServerPort.Text = "port";
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Location = new System.Drawing.Point(13, 55);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(75, 23);
            this.ButtonConnect.TabIndex = 4;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Location = new System.Drawing.Point(13, 110);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(75, 23);
            this.ButtonCreate.TabIndex = 6;
            this.ButtonCreate.Text = "Create";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(197, 0);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(22, 22);
            this.ButtonExit.TabIndex = 0;
            this.ButtonExit.Text = "X";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // TextMyPort
            // 
            this.TextMyPort.Location = new System.Drawing.Point(119, 82);
            this.TextMyPort.Name = "TextMyPort";
            this.TextMyPort.Size = new System.Drawing.Size(100, 20);
            this.TextMyPort.TabIndex = 7;
            this.TextMyPort.Text = "port";
            // 
            // ButtonOffline
            // 
            this.ButtonOffline.Location = new System.Drawing.Point(119, 110);
            this.ButtonOffline.Name = "ButtonOffline";
            this.ButtonOffline.Size = new System.Drawing.Size(75, 23);
            this.ButtonOffline.TabIndex = 8;
            this.ButtonOffline.Text = "Offline";
            this.ButtonOffline.UseVisualStyleBackColor = true;
            this.ButtonOffline.Click += new System.EventHandler(this.ButtonOffline_Click);
            // 
            // TextMyIP
            // 
            this.TextMyIP.Location = new System.Drawing.Point(13, 82);
            this.TextMyIP.Name = "TextMyIP";
            this.TextMyIP.Size = new System.Drawing.Size(100, 20);
            this.TextMyIP.TabIndex = 9;
            this.TextMyIP.Text = "Your ip";
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(234, 141);
            this.Controls.Add(this.TextMyIP);
            this.Controls.Add(this.ButtonOffline);
            this.Controls.Add(this.TextMyPort);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.ButtonConnect);
            this.Controls.Add(this.TextServerPort);
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
        private System.Windows.Forms.TextBox TextServerPort;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.TextBox TextMyPort;
        private System.Windows.Forms.Button ButtonOffline;
        private System.Windows.Forms.TextBox TextMyIP;
    }
}

