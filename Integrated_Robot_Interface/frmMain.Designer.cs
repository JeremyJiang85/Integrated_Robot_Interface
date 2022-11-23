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
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.BtnEsc = new System.Windows.Forms.Button();
            this.gbConnection = new System.Windows.Forms.GroupBox();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.btnConnection = new System.Windows.Forms.Button();
            this.txtConnection = new System.Windows.Forms.TextBox();
            this.rdbOurarm = new System.Windows.Forms.RadioButton();
            this.rdbNexcom = new System.Windows.Forms.RadioButton();
            this.rdbFanuc = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.gbConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // pblogo
            // 
            this.pblogo.Image = global::Integrated_Robot_Interface.Properties.Resources.lion;
            this.pblogo.Location = new System.Drawing.Point(12, 12);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(147, 147);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblogo.TabIndex = 0;
            this.pblogo.TabStop = false;
            // 
            // BtnEsc
            // 
            this.BtnEsc.Location = new System.Drawing.Point(1068, 12);
            this.BtnEsc.Name = "BtnEsc";
            this.BtnEsc.Size = new System.Drawing.Size(75, 75);
            this.BtnEsc.TabIndex = 1;
            this.BtnEsc.Text = "ESC";
            this.BtnEsc.UseVisualStyleBackColor = true;
            // 
            // gbConnection
            // 
            this.gbConnection.Controls.Add(this.lblConnectionStatus);
            this.gbConnection.Controls.Add(this.lblSelect);
            this.gbConnection.Controls.Add(this.btnConnection);
            this.gbConnection.Controls.Add(this.txtConnection);
            this.gbConnection.Controls.Add(this.rdbOurarm);
            this.gbConnection.Controls.Add(this.rdbNexcom);
            this.gbConnection.Controls.Add(this.rdbFanuc);
            this.gbConnection.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbConnection.Location = new System.Drawing.Point(165, 12);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Size = new System.Drawing.Size(276, 147);
            this.gbConnection.TabIndex = 2;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "Connection";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblConnectionStatus.Location = new System.Drawing.Point(6, 84);
            this.lblConnectionStatus.Margin = new System.Windows.Forms.Padding(3);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(263, 20);
            this.lblConnectionStatus.TabIndex = 7;
            this.lblConnectionStatus.Text = "Connection Status : Disconnected";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSelect.Location = new System.Drawing.Point(6, 31);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(158, 20);
            this.lblSelect.TabIndex = 6;
            this.lblSelect.Text = "Select Robot : None";
            // 
            // btnConnection
            // 
            this.btnConnection.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConnection.Location = new System.Drawing.Point(139, 110);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(130, 29);
            this.btnConnection.TabIndex = 0;
            this.btnConnection.Text = "Connect";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // txtConnection
            // 
            this.txtConnection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConnection.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtConnection.Location = new System.Drawing.Point(10, 110);
            this.txtConnection.Name = "txtConnection";
            this.txtConnection.Size = new System.Drawing.Size(123, 29);
            this.txtConnection.TabIndex = 2;
            this.txtConnection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdbOurarm
            // 
            this.rdbOurarm.AutoSize = true;
            this.rdbOurarm.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdbOurarm.Location = new System.Drawing.Point(184, 54);
            this.rdbOurarm.Name = "rdbOurarm";
            this.rdbOurarm.Size = new System.Drawing.Size(86, 24);
            this.rdbOurarm.TabIndex = 5;
            this.rdbOurarm.TabStop = true;
            this.rdbOurarm.Text = "Ourarm";
            this.rdbOurarm.UseVisualStyleBackColor = true;
            this.rdbOurarm.CheckedChanged += new System.EventHandler(this.rdbOurarm_CheckedChanged);
            // 
            // rdbNexcom
            // 
            this.rdbNexcom.AutoSize = true;
            this.rdbNexcom.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdbNexcom.Location = new System.Drawing.Point(88, 54);
            this.rdbNexcom.Name = "rdbNexcom";
            this.rdbNexcom.Size = new System.Drawing.Size(90, 24);
            this.rdbNexcom.TabIndex = 4;
            this.rdbNexcom.TabStop = true;
            this.rdbNexcom.Text = "Nexcom";
            this.rdbNexcom.UseVisualStyleBackColor = true;
            this.rdbNexcom.CheckedChanged += new System.EventHandler(this.rdbNexcom_CheckedChanged);
            // 
            // rdbFanuc
            // 
            this.rdbFanuc.AutoSize = true;
            this.rdbFanuc.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdbFanuc.Location = new System.Drawing.Point(10, 54);
            this.rdbFanuc.Name = "rdbFanuc";
            this.rdbFanuc.Size = new System.Drawing.Size(72, 24);
            this.rdbFanuc.TabIndex = 3;
            this.rdbFanuc.Text = "Fanuc";
            this.rdbFanuc.UseVisualStyleBackColor = true;
            this.rdbFanuc.CheckedChanged += new System.EventHandler(this.rdbFanuc_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 642);
            this.Controls.Add(this.gbConnection);
            this.Controls.Add(this.BtnEsc);
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
        private System.Windows.Forms.Button BtnEsc;
        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.TextBox txtConnection;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.RadioButton rdbFanuc;
        private System.Windows.Forms.RadioButton rdbOurarm;
        private System.Windows.Forms.RadioButton rdbNexcom;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblConnectionStatus;
    }
}

