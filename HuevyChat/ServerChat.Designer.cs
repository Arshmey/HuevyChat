namespace HueChat
{
    partial class ServerChat
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
            this.label1 = new System.Windows.Forms.Label();
            this.CountClient = new System.Windows.Forms.Label();
            this.LogViwer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Working/Работает";
            // 
            // CountClient
            // 
            this.CountClient.AutoSize = true;
            this.CountClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountClient.Location = new System.Drawing.Point(2, 248);
            this.CountClient.Name = "CountClient";
            this.CountClient.Size = new System.Drawing.Size(0, 29);
            this.CountClient.TabIndex = 1;
            // 
            // LogViwer
            // 
            this.LogViwer.Location = new System.Drawing.Point(7, 44);
            this.LogViwer.MaxLength = 1000000000;
            this.LogViwer.Multiline = true;
            this.LogViwer.Name = "LogViwer";
            this.LogViwer.ReadOnly = true;
            this.LogViwer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogViwer.Size = new System.Drawing.Size(594, 189);
            this.LogViwer.TabIndex = 2;
            // 
            // ServerChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(613, 279);
            this.Controls.Add(this.LogViwer);
            this.Controls.Add(this.CountClient);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ServerChat";
            this.Text = "Server HuevyChat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerrChat_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CountClient;
        private System.Windows.Forms.TextBox LogViwer;
    }
}