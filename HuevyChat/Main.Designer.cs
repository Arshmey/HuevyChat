namespace HueChat
{
    partial class Main
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
            this.ServerTITLE = new System.Windows.Forms.Label();
            this.NicknameTITLE = new System.Windows.Forms.Label();
            this.EnterNick = new System.Windows.Forms.TextBox();
            this.PORTTITLE = new System.Windows.Forms.Label();
            this.EnterPort = new System.Windows.Forms.TextBox();
            this.ClientTITLE = new System.Windows.Forms.Label();
            this.hostName = new System.Windows.Forms.TextBox();
            this.IPPORTTITLE = new System.Windows.Forms.Label();
            this.bCreate = new System.Windows.Forms.Button();
            this.bConncet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ServerTITLE
            // 
            this.ServerTITLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerTITLE.Location = new System.Drawing.Point(233, 135);
            this.ServerTITLE.Name = "ServerTITLE";
            this.ServerTITLE.Size = new System.Drawing.Size(115, 23);
            this.ServerTITLE.TabIndex = 0;
            this.ServerTITLE.Text = "Server/Сервер";
            // 
            // NicknameTITLE
            // 
            this.NicknameTITLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NicknameTITLE.Location = new System.Drawing.Point(233, 61);
            this.NicknameTITLE.Name = "NicknameTITLE";
            this.NicknameTITLE.Size = new System.Drawing.Size(115, 23);
            this.NicknameTITLE.TabIndex = 2;
            this.NicknameTITLE.Text = "Nickname/ник*";
            // 
            // EnterNick
            // 
            this.EnterNick.Location = new System.Drawing.Point(188, 87);
            this.EnterNick.Name = "EnterNick";
            this.EnterNick.Size = new System.Drawing.Size(202, 20);
            this.EnterNick.TabIndex = 3;
            // 
            // PORTTITLE
            // 
            this.PORTTITLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PORTTITLE.Location = new System.Drawing.Point(44, 161);
            this.PORTTITLE.Name = "PORTTITLE";
            this.PORTTITLE.Size = new System.Drawing.Size(85, 23);
            this.PORTTITLE.TabIndex = 4;
            this.PORTTITLE.Text = "Port/Порт";
            // 
            // EnterPort
            // 
            this.EnterPort.Location = new System.Drawing.Point(188, 161);
            this.EnterPort.Name = "EnterPort";
            this.EnterPort.Size = new System.Drawing.Size(202, 20);
            this.EnterPort.TabIndex = 5;
            // 
            // ClientTITLE
            // 
            this.ClientTITLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientTITLE.Location = new System.Drawing.Point(233, 206);
            this.ClientTITLE.Name = "ClientTITLE";
            this.ClientTITLE.Size = new System.Drawing.Size(115, 23);
            this.ClientTITLE.TabIndex = 6;
            this.ClientTITLE.Text = "Client/Клиент";
            // 
            // hostName
            // 
            this.hostName.Location = new System.Drawing.Point(188, 232);
            this.hostName.Name = "hostName";
            this.hostName.Size = new System.Drawing.Size(202, 20);
            this.hostName.TabIndex = 8;
            // 
            // IPPORTTITLE
            // 
            this.IPPORTTITLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPPORTTITLE.Location = new System.Drawing.Point(8, 230);
            this.IPPORTTITLE.Name = "IPPORTTITLE";
            this.IPPORTTITLE.Size = new System.Drawing.Size(174, 23);
            this.IPPORTTITLE.TabIndex = 7;
            this.IPPORTTITLE.Text = "IP:PORT/АЙПИ:ПОРТ";
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(406, 161);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(170, 23);
            this.bCreate.TabIndex = 9;
            this.bCreate.Text = "Create/Создать";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // bConncet
            // 
            this.bConncet.Location = new System.Drawing.Point(406, 232);
            this.bConncet.Name = "bConncet";
            this.bConncet.Size = new System.Drawing.Size(170, 23);
            this.bConncet.TabIndex = 10;
            this.bConncet.Text = "Connect/Подключиться";
            this.bConncet.UseVisualStyleBackColor = true;
            this.bConncet.Click += new System.EventHandler(this.bConncet_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 389);
            this.Controls.Add(this.bConncet);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.hostName);
            this.Controls.Add(this.IPPORTTITLE);
            this.Controls.Add(this.ClientTITLE);
            this.Controls.Add(this.EnterPort);
            this.Controls.Add(this.PORTTITLE);
            this.Controls.Add(this.EnterNick);
            this.Controls.Add(this.NicknameTITLE);
            this.Controls.Add(this.ServerTITLE);
            this.Name = "Main";
            this.Text = "Main HuevyChat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ServerTITLE;
        private System.Windows.Forms.Label NicknameTITLE;
        private System.Windows.Forms.TextBox EnterNick;
        private System.Windows.Forms.Label PORTTITLE;
        private System.Windows.Forms.TextBox EnterPort;
        private System.Windows.Forms.Label ClientTITLE;
        private System.Windows.Forms.TextBox hostName;
        private System.Windows.Forms.Label IPPORTTITLE;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.Button bConncet;
    }
}

