
namespace Bullshit
{
    partial class Chat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.Gray;
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.ForeColor = System.Drawing.Color.White;
            this.TextBox.HideSelection = false;
            this.TextBox.Location = new System.Drawing.Point(12, 285);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(217, 21);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "";
            this.TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // ButtonSend
            // 
            this.ButtonSend.BackColor = System.Drawing.Color.White;
            this.ButtonSend.ForeColor = System.Drawing.Color.Black;
            this.ButtonSend.Location = new System.Drawing.Point(206, 285);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(44, 21);
            this.ButtonSend.TabIndex = 1;
            this.ButtonSend.Text = "Send";
            this.ButtonSend.UseVisualStyleBackColor = false;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // ListBox
            // 
            this.ListBox.BackColor = System.Drawing.Color.Black;
            this.ListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBox.ForeColor = System.Drawing.Color.White;
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(12, 12);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(238, 247);
            this.ListBox.TabIndex = 2;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(262, 318);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.ButtonSend);
            this.Controls.Add(this.TextBox);
            this.Name = "Chat";
            this.Text = "Chat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.ListBox ListBox;
    }
}