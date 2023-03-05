namespace Integrated_Robot_Interface
{
    partial class FrmInformation
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
            this.components = new System.ComponentModel.Container();
            this.lblInformation1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbInformation1 = new System.Windows.Forms.GroupBox();
            this.gbInformation2 = new System.Windows.Forms.GroupBox();
            this.gbInformation3 = new System.Windows.Forms.GroupBox();
            this.gbInformation4 = new System.Windows.Forms.GroupBox();
            this.lblInformation2 = new System.Windows.Forms.Label();
            this.lblInformation3 = new System.Windows.Forms.Label();
            this.lblInformation4 = new System.Windows.Forms.Label();
            this.gbInformation1.SuspendLayout();
            this.gbInformation2.SuspendLayout();
            this.gbInformation3.SuspendLayout();
            this.gbInformation4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInformation1
            // 
            this.lblInformation1.AutoSize = true;
            this.lblInformation1.Location = new System.Drawing.Point(6, 29);
            this.lblInformation1.Name = "lblInformation1";
            this.lblInformation1.Size = new System.Drawing.Size(115, 21);
            this.lblInformation1.TabIndex = 0;
            this.lblInformation1.Text = "Information1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbInformation1
            // 
            this.gbInformation1.Controls.Add(this.lblInformation1);
            this.gbInformation1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbInformation1.Location = new System.Drawing.Point(12, 12);
            this.gbInformation1.Name = "gbInformation1";
            this.gbInformation1.Size = new System.Drawing.Size(244, 476);
            this.gbInformation1.TabIndex = 2;
            this.gbInformation1.TabStop = false;
            this.gbInformation1.Text = "Information1";
            // 
            // gbInformation2
            // 
            this.gbInformation2.Controls.Add(this.lblInformation2);
            this.gbInformation2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbInformation2.Location = new System.Drawing.Point(262, 12);
            this.gbInformation2.Name = "gbInformation2";
            this.gbInformation2.Size = new System.Drawing.Size(244, 476);
            this.gbInformation2.TabIndex = 3;
            this.gbInformation2.TabStop = false;
            this.gbInformation2.Text = "Information2";
            // 
            // gbInformation3
            // 
            this.gbInformation3.Controls.Add(this.lblInformation3);
            this.gbInformation3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbInformation3.Location = new System.Drawing.Point(512, 12);
            this.gbInformation3.Name = "gbInformation3";
            this.gbInformation3.Size = new System.Drawing.Size(244, 476);
            this.gbInformation3.TabIndex = 3;
            this.gbInformation3.TabStop = false;
            this.gbInformation3.Text = "Information3";
            // 
            // gbInformation4
            // 
            this.gbInformation4.Controls.Add(this.lblInformation4);
            this.gbInformation4.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbInformation4.Location = new System.Drawing.Point(762, 12);
            this.gbInformation4.Name = "gbInformation4";
            this.gbInformation4.Size = new System.Drawing.Size(244, 476);
            this.gbInformation4.TabIndex = 3;
            this.gbInformation4.TabStop = false;
            this.gbInformation4.Text = "Information4";
            // 
            // lblInformation2
            // 
            this.lblInformation2.AutoSize = true;
            this.lblInformation2.Location = new System.Drawing.Point(6, 29);
            this.lblInformation2.Name = "lblInformation2";
            this.lblInformation2.Size = new System.Drawing.Size(115, 21);
            this.lblInformation2.TabIndex = 1;
            this.lblInformation2.Text = "Information2";
            // 
            // lblInformation3
            // 
            this.lblInformation3.AutoSize = true;
            this.lblInformation3.Location = new System.Drawing.Point(6, 29);
            this.lblInformation3.Name = "lblInformation3";
            this.lblInformation3.Size = new System.Drawing.Size(115, 21);
            this.lblInformation3.TabIndex = 1;
            this.lblInformation3.Text = "Information3";
            // 
            // lblInformation4
            // 
            this.lblInformation4.AutoSize = true;
            this.lblInformation4.Location = new System.Drawing.Point(6, 29);
            this.lblInformation4.Name = "lblInformation4";
            this.lblInformation4.Size = new System.Drawing.Size(115, 21);
            this.lblInformation4.TabIndex = 2;
            this.lblInformation4.Text = "Information4";
            // 
            // FrmInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 502);
            this.ControlBox = false;
            this.Controls.Add(this.gbInformation4);
            this.Controls.Add(this.gbInformation3);
            this.Controls.Add(this.gbInformation2);
            this.Controls.Add(this.gbInformation1);
            this.Name = "FrmInformation";
            this.Text = "FrmFanuc";
            this.Load += new System.EventHandler(this.FrmFanuc_Load);
            this.gbInformation1.ResumeLayout(false);
            this.gbInformation1.PerformLayout();
            this.gbInformation2.ResumeLayout(false);
            this.gbInformation2.PerformLayout();
            this.gbInformation3.ResumeLayout(false);
            this.gbInformation3.PerformLayout();
            this.gbInformation4.ResumeLayout(false);
            this.gbInformation4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblInformation1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gbInformation1;
        private System.Windows.Forms.GroupBox gbInformation2;
        private System.Windows.Forms.Label lblInformation2;
        private System.Windows.Forms.GroupBox gbInformation3;
        private System.Windows.Forms.Label lblInformation3;
        private System.Windows.Forms.GroupBox gbInformation4;
        private System.Windows.Forms.Label lblInformation4;
    }
}