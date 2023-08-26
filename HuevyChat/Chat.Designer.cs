namespace HueChat
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
            this.MessageUser = new System.Windows.Forms.TextBox();
            this.bSend = new System.Windows.Forms.Button();
            this.TextChat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MessageUser
            // 
            this.MessageUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageUser.Location = new System.Drawing.Point(3, 404);
            this.MessageUser.Multiline = true;
            this.MessageUser.Name = "MessageUser";
            this.MessageUser.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MessageUser.ShortcutsEnabled = false;
            this.MessageUser.Size = new System.Drawing.Size(605, 45);
            this.MessageUser.TabIndex = 0;
            this.MessageUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageUser_KeyDown);
            // 
            // bSend
            // 
            this.bSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bSend.Location = new System.Drawing.Point(609, 410);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(151, 38);
            this.bSend.TabIndex = 1;
            this.bSend.Text = "Send/Отправить";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // TextChat
            // 
            this.TextChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextChat.Location = new System.Drawing.Point(3, 2);
            this.TextChat.MaxLength = 1000000000;
            this.TextChat.Multiline = true;
            this.TextChat.Name = "TextChat";
            this.TextChat.ReadOnly = true;
            this.TextChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextChat.Size = new System.Drawing.Size(757, 405);
            this.TextChat.TabIndex = 2;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 452);
            this.Controls.Add(this.TextChat);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.MessageUser);
            this.Name = "Chat";
            this.Text = "HuevyChat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Chat_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.TextBox TextChat;
        private System.Windows.Forms.TextBox MessageUser;
    }
}