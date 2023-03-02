namespace Integrated_Robot_Interface
{
    partial class FrmFanuc
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
            this.gbUI = new System.Windows.Forms.GroupBox();
            this.lblUI = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUI
            // 
            this.gbUI.Controls.Add(this.lblUI);
            this.gbUI.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbUI.Location = new System.Drawing.Point(12, 12);
            this.gbUI.Name = "gbUI";
            this.gbUI.Size = new System.Drawing.Size(140, 420);
            this.gbUI.TabIndex = 0;
            this.gbUI.TabStop = false;
            this.gbUI.Text = "UI";
            // 
            // lblUI
            // 
            this.lblUI.AutoSize = true;
            this.lblUI.Location = new System.Drawing.Point(6, 29);
            this.lblUI.Name = "lblUI";
            this.lblUI.Size = new System.Drawing.Size(0, 21);
            this.lblUI.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmFanuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 544);
            this.Controls.Add(this.gbUI);
            this.Name = "FrmFanuc";
            this.Text = "FrmFanuc";
            this.Load += new System.EventHandler(this.FrmFanuc_Load);
            this.gbUI.ResumeLayout(false);
            this.gbUI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUI;
        private System.Windows.Forms.Label lblUI;
        private System.Windows.Forms.Timer timer1;
    }
}