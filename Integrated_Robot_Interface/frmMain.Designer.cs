namespace Integrated_Robot_Interface
{
    partial class FrmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.btnEsc = new System.Windows.Forms.Button();
            this.gbConnection = new System.Windows.Forms.GroupBox();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.btnConnection = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.cboRobot = new System.Windows.Forms.ComboBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.gbConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // pblogo
            // 
            this.pblogo.Image = global::Integrated_Robot_Interface.Properties.Resources.lion;
            this.pblogo.Location = new System.Drawing.Point(12, 12);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(128, 128);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblogo.TabIndex = 0;
            this.pblogo.TabStop = false;
            // 
            // btnEsc
            // 
            this.btnEsc.Location = new System.Drawing.Point(1068, 12);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(75, 75);
            this.btnEsc.TabIndex = 1;
            this.btnEsc.Text = "ESC";
            this.btnEsc.UseVisualStyleBackColor = true;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // gbConnection
            // 
            this.gbConnection.Controls.Add(this.lblIP);
            this.gbConnection.Controls.Add(this.cboRobot);
            this.gbConnection.Controls.Add(this.lblConnectionStatus);
            this.gbConnection.Controls.Add(this.btnConnection);
            this.gbConnection.Controls.Add(this.txtIP);
            this.gbConnection.Controls.Add(this.lblSelect);
            this.gbConnection.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbConnection.Location = new System.Drawing.Point(146, 12);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Size = new System.Drawing.Size(294, 128);
            this.gbConnection.TabIndex = 2;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "Connection";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblConnectionStatus.Location = new System.Drawing.Point(6, 61);
            this.lblConnectionStatus.Margin = new System.Windows.Forms.Padding(3);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(277, 21);
            this.lblConnectionStatus.TabIndex = 7;
            this.lblConnectionStatus.Text = "Connection Status : Disconnected";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSelect.Location = new System.Drawing.Point(6, 31);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(126, 21);
            this.lblSelect.TabIndex = 6;
            this.lblSelect.Text = "Select Robot : ";
            // 
            // btnConnection
            // 
            this.btnConnection.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConnection.Location = new System.Drawing.Point(167, 88);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(116, 27);
            this.btnConnection.TabIndex = 0;
            this.btnConnection.Text = "Connect";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // txtIP
            // 
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIP.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtIP.Location = new System.Drawing.Point(50, 88);
            this.txtIP.Name = "txtIP";
            this.txtIP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIP.Size = new System.Drawing.Size(111, 27);
            this.txtIP.TabIndex = 2;
            this.txtIP.Text = "127.0.0.1";
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboRobot
            // 
            this.cboRobot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRobot.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboRobot.FormattingEnabled = true;
            this.cboRobot.ItemHeight = 16;
            this.cboRobot.Location = new System.Drawing.Point(128, 31);
            this.cboRobot.Name = "cboRobot";
            this.cboRobot.Size = new System.Drawing.Size(155, 24);
            this.cboRobot.TabIndex = 8;
            this.cboRobot.SelectedIndexChanged += new System.EventHandler(this.cboRobot_SelectedIndexChanged);
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(6, 88);
            this.lblIP.Margin = new System.Windows.Forms.Padding(3);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(38, 21);
            this.lblIP.TabIndex = 9;
            this.lblIP.Text = "IP :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(446, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(355, 128);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 534);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.gbConnection);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.pblogo);
            this.Name = "FrmMain";
            this.Text = "Integrated Robot Interface";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Button btnEsc;
        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.ComboBox cboRobot;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

