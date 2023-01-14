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
            this.lblIP = new System.Windows.Forms.Label();
            this.cboRobot = new System.Windows.Forms.ComboBox();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.btnConnection = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbCurrentPosition = new System.Windows.Forms.GroupBox();
            this.lblJoint = new System.Windows.Forms.Label();
            this.lblXyzwpr = new System.Windows.Forms.Label();
            this.gbOverride = new System.Windows.Forms.GroupBox();
            this.lblOverride = new System.Windows.Forms.Label();
            this.gbPositionSet = new System.Windows.Forms.GroupBox();
            this.lblRange = new System.Windows.Forms.Label();
            this.tbVelocity = new System.Windows.Forms.TextBox();
            this.lblVelocity = new System.Windows.Forms.Label();
            this.btnPositionHome = new System.Windows.Forms.Button();
            this.btnPositionSet = new System.Windows.Forms.Button();
            this.btnPositionCopy = new System.Windows.Forms.Button();
            this.lblYJ2Set = new System.Windows.Forms.Label();
            this.lblRJ6Set = new System.Windows.Forms.Label();
            this.lblWJ4Set = new System.Windows.Forms.Label();
            this.lblPJ5Set = new System.Windows.Forms.Label();
            this.lblZJ3Set = new System.Windows.Forms.Label();
            this.lblXJ1Set = new System.Windows.Forms.Label();
            this.tbRJ6Set = new System.Windows.Forms.TextBox();
            this.tbPJ5Set = new System.Windows.Forms.TextBox();
            this.tbWJ4Set = new System.Windows.Forms.TextBox();
            this.tbZJ3Set = new System.Windows.Forms.TextBox();
            this.tbYJ2Set = new System.Windows.Forms.TextBox();
            this.tbXJ1Set = new System.Windows.Forms.TextBox();
            this.cboCoordinate = new System.Windows.Forms.ComboBox();
            this.gbRegister = new System.Windows.Forms.GroupBox();
            this.btnRegisterSet = new System.Windows.Forms.Button();
            this.tbR5Set = new System.Windows.Forms.TextBox();
            this.tbR4Set = new System.Windows.Forms.TextBox();
            this.tbR3Set = new System.Windows.Forms.TextBox();
            this.tbR2Set = new System.Windows.Forms.TextBox();
            this.lblR5Set = new System.Windows.Forms.Label();
            this.tbR1Set = new System.Windows.Forms.TextBox();
            this.lblR4Set = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblR3Set = new System.Windows.Forms.Label();
            this.lblR1Set = new System.Windows.Forms.Label();
            this.lblR2Set = new System.Windows.Forms.Label();
            this.gbPositionMove = new System.Windows.Forms.GroupBox();
            this.cboStep = new System.Windows.Forms.ComboBox();
            this.lblStep = new System.Windows.Forms.Label();
            this.btnRJ6Positive = new System.Windows.Forms.Button();
            this.btnRJ6Negative = new System.Windows.Forms.Button();
            this.btnPJ5Positive = new System.Windows.Forms.Button();
            this.btnPJ5Negative = new System.Windows.Forms.Button();
            this.btnWJ4Positive = new System.Windows.Forms.Button();
            this.btnWJ4Negative = new System.Windows.Forms.Button();
            this.btnZJ3Positive = new System.Windows.Forms.Button();
            this.btnZJ3Negative = new System.Windows.Forms.Button();
            this.btnYJ2Positive = new System.Windows.Forms.Button();
            this.btnYJ2Negative = new System.Windows.Forms.Button();
            this.btnXJ1Positive = new System.Windows.Forms.Button();
            this.btnXJ1Negative = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.gbConnection.SuspendLayout();
            this.gbCurrentPosition.SuspendLayout();
            this.gbOverride.SuspendLayout();
            this.gbPositionSet.SuspendLayout();
            this.gbRegister.SuspendLayout();
            this.gbPositionMove.SuspendLayout();
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
            this.btnEsc.Location = new System.Drawing.Point(807, 12);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(96, 55);
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
            // gbCurrentPosition
            // 
            this.gbCurrentPosition.Controls.Add(this.lblJoint);
            this.gbCurrentPosition.Controls.Add(this.lblXyzwpr);
            this.gbCurrentPosition.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbCurrentPosition.Location = new System.Drawing.Point(12, 146);
            this.gbCurrentPosition.Name = "gbCurrentPosition";
            this.gbCurrentPosition.Size = new System.Drawing.Size(279, 353);
            this.gbCurrentPosition.TabIndex = 4;
            this.gbCurrentPosition.TabStop = false;
            this.gbCurrentPosition.Text = "Current Position";
            // 
            // lblJoint
            // 
            this.lblJoint.AutoSize = true;
            this.lblJoint.Location = new System.Drawing.Point(140, 29);
            this.lblJoint.Name = "lblJoint";
            this.lblJoint.Size = new System.Drawing.Size(48, 147);
            this.lblJoint.TabIndex = 1;
            this.lblJoint.Text = "Joint\r\nJ1 :\r\nJ2 :\r\nJ3 :\r\nJ4 :\r\nJ5 :\r\nJ6 :";
            // 
            // lblXyzwpr
            // 
            this.lblXyzwpr.AutoSize = true;
            this.lblXyzwpr.Location = new System.Drawing.Point(6, 29);
            this.lblXyzwpr.Name = "lblXyzwpr";
            this.lblXyzwpr.Size = new System.Drawing.Size(85, 147);
            this.lblXyzwpr.TabIndex = 0;
            this.lblXyzwpr.Text = "Cartesian\r\nX :\r\nY :\r\nZ :\r\nW:\r\nP :\r\nR :";
            // 
            // gbOverride
            // 
            this.gbOverride.Controls.Add(this.lblOverride);
            this.gbOverride.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbOverride.Location = new System.Drawing.Point(807, 70);
            this.gbOverride.Name = "gbOverride";
            this.gbOverride.Size = new System.Drawing.Size(96, 70);
            this.gbOverride.TabIndex = 5;
            this.gbOverride.TabStop = false;
            this.gbOverride.Text = "Override";
            // 
            // lblOverride
            // 
            this.lblOverride.AutoSize = true;
            this.lblOverride.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOverride.Location = new System.Drawing.Point(6, 29);
            this.lblOverride.Name = "lblOverride";
            this.lblOverride.Size = new System.Drawing.Size(0, 32);
            this.lblOverride.TabIndex = 0;
            // 
            // gbPositionSet
            // 
            this.gbPositionSet.Controls.Add(this.lblRange);
            this.gbPositionSet.Controls.Add(this.tbVelocity);
            this.gbPositionSet.Controls.Add(this.lblVelocity);
            this.gbPositionSet.Controls.Add(this.btnPositionHome);
            this.gbPositionSet.Controls.Add(this.btnPositionSet);
            this.gbPositionSet.Controls.Add(this.btnPositionCopy);
            this.gbPositionSet.Controls.Add(this.lblYJ2Set);
            this.gbPositionSet.Controls.Add(this.lblRJ6Set);
            this.gbPositionSet.Controls.Add(this.lblWJ4Set);
            this.gbPositionSet.Controls.Add(this.lblPJ5Set);
            this.gbPositionSet.Controls.Add(this.lblZJ3Set);
            this.gbPositionSet.Controls.Add(this.lblXJ1Set);
            this.gbPositionSet.Controls.Add(this.tbRJ6Set);
            this.gbPositionSet.Controls.Add(this.tbPJ5Set);
            this.gbPositionSet.Controls.Add(this.tbWJ4Set);
            this.gbPositionSet.Controls.Add(this.tbZJ3Set);
            this.gbPositionSet.Controls.Add(this.tbYJ2Set);
            this.gbPositionSet.Controls.Add(this.tbXJ1Set);
            this.gbPositionSet.Controls.Add(this.cboCoordinate);
            this.gbPositionSet.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbPositionSet.Location = new System.Drawing.Point(297, 146);
            this.gbPositionSet.Name = "gbPositionSet";
            this.gbPositionSet.Size = new System.Drawing.Size(249, 353);
            this.gbPositionSet.TabIndex = 6;
            this.gbPositionSet.TabStop = false;
            this.gbPositionSet.Text = "Position Set";
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(6, 262);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(87, 84);
            this.lblRange.TabIndex = 18;
            this.lblRange.Text = "X :\r\nY :\r\nZ :\r\nVelocity :";
            // 
            // tbVelocity
            // 
            this.tbVelocity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbVelocity.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbVelocity.Location = new System.Drawing.Point(46, 236);
            this.tbVelocity.Name = "tbVelocity";
            this.tbVelocity.Size = new System.Drawing.Size(100, 23);
            this.tbVelocity.TabIndex = 17;
            this.tbVelocity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVelocity
            // 
            this.lblVelocity.AutoSize = true;
            this.lblVelocity.Location = new System.Drawing.Point(6, 236);
            this.lblVelocity.Name = "lblVelocity";
            this.lblVelocity.Size = new System.Drawing.Size(34, 21);
            this.lblVelocity.TabIndex = 16;
            this.lblVelocity.Text = "V :";
            // 
            // btnPositionHome
            // 
            this.btnPositionHome.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPositionHome.Location = new System.Drawing.Point(152, 209);
            this.btnPositionHome.Name = "btnPositionHome";
            this.btnPositionHome.Size = new System.Drawing.Size(85, 50);
            this.btnPositionHome.TabIndex = 15;
            this.btnPositionHome.Text = "Home";
            this.btnPositionHome.UseVisualStyleBackColor = true;
            this.btnPositionHome.Click += new System.EventHandler(this.btnPositionHome_Click);
            // 
            // btnPositionSet
            // 
            this.btnPositionSet.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPositionSet.Location = new System.Drawing.Point(152, 134);
            this.btnPositionSet.Name = "btnPositionSet";
            this.btnPositionSet.Size = new System.Drawing.Size(85, 50);
            this.btnPositionSet.TabIndex = 14;
            this.btnPositionSet.Text = "Set";
            this.btnPositionSet.UseVisualStyleBackColor = true;
            this.btnPositionSet.Click += new System.EventHandler(this.btnPositionSet_Click);
            // 
            // btnPositionCopy
            // 
            this.btnPositionCopy.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPositionCopy.Location = new System.Drawing.Point(152, 62);
            this.btnPositionCopy.Name = "btnPositionCopy";
            this.btnPositionCopy.Size = new System.Drawing.Size(85, 50);
            this.btnPositionCopy.TabIndex = 13;
            this.btnPositionCopy.Text = "Copy";
            this.btnPositionCopy.UseVisualStyleBackColor = true;
            this.btnPositionCopy.Click += new System.EventHandler(this.btnPositionCopy_Click);
            // 
            // lblYJ2Set
            // 
            this.lblYJ2Set.AutoSize = true;
            this.lblYJ2Set.Location = new System.Drawing.Point(6, 91);
            this.lblYJ2Set.Name = "lblYJ2Set";
            this.lblYJ2Set.Size = new System.Drawing.Size(34, 21);
            this.lblYJ2Set.TabIndex = 12;
            this.lblYJ2Set.Text = "Y :";
            // 
            // lblRJ6Set
            // 
            this.lblRJ6Set.AutoSize = true;
            this.lblRJ6Set.Location = new System.Drawing.Point(6, 207);
            this.lblRJ6Set.Name = "lblRJ6Set";
            this.lblRJ6Set.Size = new System.Drawing.Size(33, 21);
            this.lblRJ6Set.TabIndex = 11;
            this.lblRJ6Set.Text = "R :";
            // 
            // lblWJ4Set
            // 
            this.lblWJ4Set.AutoSize = true;
            this.lblWJ4Set.Location = new System.Drawing.Point(6, 149);
            this.lblWJ4Set.Name = "lblWJ4Set";
            this.lblWJ4Set.Size = new System.Drawing.Size(34, 21);
            this.lblWJ4Set.TabIndex = 10;
            this.lblWJ4Set.Text = "W:";
            // 
            // lblPJ5Set
            // 
            this.lblPJ5Set.AutoSize = true;
            this.lblPJ5Set.Location = new System.Drawing.Point(6, 178);
            this.lblPJ5Set.Name = "lblPJ5Set";
            this.lblPJ5Set.Size = new System.Drawing.Size(31, 21);
            this.lblPJ5Set.TabIndex = 9;
            this.lblPJ5Set.Text = "P :";
            // 
            // lblZJ3Set
            // 
            this.lblZJ3Set.AutoSize = true;
            this.lblZJ3Set.Location = new System.Drawing.Point(6, 120);
            this.lblZJ3Set.Name = "lblZJ3Set";
            this.lblZJ3Set.Size = new System.Drawing.Size(32, 21);
            this.lblZJ3Set.TabIndex = 8;
            this.lblZJ3Set.Text = "Z :";
            // 
            // lblXJ1Set
            // 
            this.lblXJ1Set.AutoSize = true;
            this.lblXJ1Set.Location = new System.Drawing.Point(6, 62);
            this.lblXJ1Set.Name = "lblXJ1Set";
            this.lblXJ1Set.Size = new System.Drawing.Size(34, 21);
            this.lblXJ1Set.TabIndex = 7;
            this.lblXJ1Set.Text = "X :";
            // 
            // tbRJ6Set
            // 
            this.tbRJ6Set.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRJ6Set.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbRJ6Set.Location = new System.Drawing.Point(46, 207);
            this.tbRJ6Set.Name = "tbRJ6Set";
            this.tbRJ6Set.Size = new System.Drawing.Size(100, 23);
            this.tbRJ6Set.TabIndex = 6;
            this.tbRJ6Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPJ5Set
            // 
            this.tbPJ5Set.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPJ5Set.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbPJ5Set.Location = new System.Drawing.Point(46, 178);
            this.tbPJ5Set.Name = "tbPJ5Set";
            this.tbPJ5Set.Size = new System.Drawing.Size(100, 23);
            this.tbPJ5Set.TabIndex = 5;
            this.tbPJ5Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbWJ4Set
            // 
            this.tbWJ4Set.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbWJ4Set.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbWJ4Set.Location = new System.Drawing.Point(46, 149);
            this.tbWJ4Set.Name = "tbWJ4Set";
            this.tbWJ4Set.Size = new System.Drawing.Size(100, 23);
            this.tbWJ4Set.TabIndex = 4;
            this.tbWJ4Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbZJ3Set
            // 
            this.tbZJ3Set.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbZJ3Set.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbZJ3Set.Location = new System.Drawing.Point(46, 120);
            this.tbZJ3Set.Name = "tbZJ3Set";
            this.tbZJ3Set.Size = new System.Drawing.Size(100, 23);
            this.tbZJ3Set.TabIndex = 3;
            this.tbZJ3Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbYJ2Set
            // 
            this.tbYJ2Set.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbYJ2Set.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbYJ2Set.Location = new System.Drawing.Point(46, 91);
            this.tbYJ2Set.Name = "tbYJ2Set";
            this.tbYJ2Set.Size = new System.Drawing.Size(100, 23);
            this.tbYJ2Set.TabIndex = 2;
            this.tbYJ2Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbXJ1Set
            // 
            this.tbXJ1Set.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbXJ1Set.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbXJ1Set.Location = new System.Drawing.Point(46, 62);
            this.tbXJ1Set.Name = "tbXJ1Set";
            this.tbXJ1Set.Size = new System.Drawing.Size(100, 23);
            this.tbXJ1Set.TabIndex = 1;
            this.tbXJ1Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboCoordinate
            // 
            this.cboCoordinate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCoordinate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboCoordinate.FormattingEnabled = true;
            this.cboCoordinate.Location = new System.Drawing.Point(6, 32);
            this.cboCoordinate.Name = "cboCoordinate";
            this.cboCoordinate.Size = new System.Drawing.Size(140, 24);
            this.cboCoordinate.TabIndex = 0;
            this.cboCoordinate.SelectedIndexChanged += new System.EventHandler(this.cboCoordinate_SelectedIndexChanged);
            // 
            // gbRegister
            // 
            this.gbRegister.Controls.Add(this.btnRegisterSet);
            this.gbRegister.Controls.Add(this.tbR5Set);
            this.gbRegister.Controls.Add(this.tbR4Set);
            this.gbRegister.Controls.Add(this.tbR3Set);
            this.gbRegister.Controls.Add(this.tbR2Set);
            this.gbRegister.Controls.Add(this.lblR5Set);
            this.gbRegister.Controls.Add(this.tbR1Set);
            this.gbRegister.Controls.Add(this.lblR4Set);
            this.gbRegister.Controls.Add(this.lblRegister);
            this.gbRegister.Controls.Add(this.lblR3Set);
            this.gbRegister.Controls.Add(this.lblR1Set);
            this.gbRegister.Controls.Add(this.lblR2Set);
            this.gbRegister.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbRegister.Location = new System.Drawing.Point(777, 146);
            this.gbRegister.Name = "gbRegister";
            this.gbRegister.Size = new System.Drawing.Size(126, 353);
            this.gbRegister.TabIndex = 7;
            this.gbRegister.TabStop = false;
            this.gbRegister.Text = "Register";
            // 
            // btnRegisterSet
            // 
            this.btnRegisterSet.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRegisterSet.Location = new System.Drawing.Point(10, 289);
            this.btnRegisterSet.Name = "btnRegisterSet";
            this.btnRegisterSet.Size = new System.Drawing.Size(101, 58);
            this.btnRegisterSet.TabIndex = 25;
            this.btnRegisterSet.Text = "Set";
            this.btnRegisterSet.UseVisualStyleBackColor = true;
            this.btnRegisterSet.Click += new System.EventHandler(this.btnRegisterSet_Click);
            // 
            // tbR5Set
            // 
            this.tbR5Set.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbR5Set.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbR5Set.Location = new System.Drawing.Point(61, 260);
            this.tbR5Set.Name = "tbR5Set";
            this.tbR5Set.Size = new System.Drawing.Size(50, 23);
            this.tbR5Set.TabIndex = 24;
            this.tbR5Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbR4Set
            // 
            this.tbR4Set.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbR4Set.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbR4Set.Location = new System.Drawing.Point(61, 231);
            this.tbR4Set.Name = "tbR4Set";
            this.tbR4Set.Size = new System.Drawing.Size(50, 23);
            this.tbR4Set.TabIndex = 23;
            this.tbR4Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbR3Set
            // 
            this.tbR3Set.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbR3Set.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbR3Set.Location = new System.Drawing.Point(61, 202);
            this.tbR3Set.Name = "tbR3Set";
            this.tbR3Set.Size = new System.Drawing.Size(50, 23);
            this.tbR3Set.TabIndex = 22;
            this.tbR3Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbR2Set
            // 
            this.tbR2Set.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbR2Set.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbR2Set.Location = new System.Drawing.Point(61, 173);
            this.tbR2Set.Name = "tbR2Set";
            this.tbR2Set.Size = new System.Drawing.Size(50, 23);
            this.tbR2Set.TabIndex = 21;
            this.tbR2Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblR5Set
            // 
            this.lblR5Set.AutoSize = true;
            this.lblR5Set.Location = new System.Drawing.Point(6, 260);
            this.lblR5Set.Name = "lblR5Set";
            this.lblR5Set.Size = new System.Drawing.Size(49, 21);
            this.lblR5Set.TabIndex = 20;
            this.lblR5Set.Text = "R5 =";
            // 
            // tbR1Set
            // 
            this.tbR1Set.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbR1Set.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbR1Set.Location = new System.Drawing.Point(61, 144);
            this.tbR1Set.Name = "tbR1Set";
            this.tbR1Set.Size = new System.Drawing.Size(50, 23);
            this.tbR1Set.TabIndex = 16;
            this.tbR1Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblR4Set
            // 
            this.lblR4Set.AutoSize = true;
            this.lblR4Set.Location = new System.Drawing.Point(6, 231);
            this.lblR4Set.Name = "lblR4Set";
            this.lblR4Set.Size = new System.Drawing.Size(49, 21);
            this.lblR4Set.TabIndex = 19;
            this.lblR4Set.Text = "R4 =";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(6, 29);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(49, 105);
            this.lblRegister.TabIndex = 0;
            this.lblRegister.Text = "R1 =\r\nR2 =\r\nR3 =\r\nR4 =\r\nR5 =";
            // 
            // lblR3Set
            // 
            this.lblR3Set.AutoSize = true;
            this.lblR3Set.Location = new System.Drawing.Point(6, 202);
            this.lblR3Set.Name = "lblR3Set";
            this.lblR3Set.Size = new System.Drawing.Size(49, 21);
            this.lblR3Set.TabIndex = 18;
            this.lblR3Set.Text = "R3 =";
            // 
            // lblR1Set
            // 
            this.lblR1Set.AutoSize = true;
            this.lblR1Set.Location = new System.Drawing.Point(6, 144);
            this.lblR1Set.Name = "lblR1Set";
            this.lblR1Set.Size = new System.Drawing.Size(49, 21);
            this.lblR1Set.TabIndex = 16;
            this.lblR1Set.Text = "R1 =";
            // 
            // lblR2Set
            // 
            this.lblR2Set.AutoSize = true;
            this.lblR2Set.Location = new System.Drawing.Point(6, 173);
            this.lblR2Set.Name = "lblR2Set";
            this.lblR2Set.Size = new System.Drawing.Size(49, 21);
            this.lblR2Set.TabIndex = 17;
            this.lblR2Set.Text = "R2 =";
            // 
            // gbPositionMove
            // 
            this.gbPositionMove.Controls.Add(this.cboStep);
            this.gbPositionMove.Controls.Add(this.lblStep);
            this.gbPositionMove.Controls.Add(this.btnRJ6Positive);
            this.gbPositionMove.Controls.Add(this.btnRJ6Negative);
            this.gbPositionMove.Controls.Add(this.btnPJ5Positive);
            this.gbPositionMove.Controls.Add(this.btnPJ5Negative);
            this.gbPositionMove.Controls.Add(this.btnWJ4Positive);
            this.gbPositionMove.Controls.Add(this.btnWJ4Negative);
            this.gbPositionMove.Controls.Add(this.btnZJ3Positive);
            this.gbPositionMove.Controls.Add(this.btnZJ3Negative);
            this.gbPositionMove.Controls.Add(this.btnYJ2Positive);
            this.gbPositionMove.Controls.Add(this.btnYJ2Negative);
            this.gbPositionMove.Controls.Add(this.btnXJ1Positive);
            this.gbPositionMove.Controls.Add(this.btnXJ1Negative);
            this.gbPositionMove.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbPositionMove.Location = new System.Drawing.Point(552, 146);
            this.gbPositionMove.Name = "gbPositionMove";
            this.gbPositionMove.Size = new System.Drawing.Size(219, 353);
            this.gbPositionMove.TabIndex = 8;
            this.gbPositionMove.TabStop = false;
            this.gbPositionMove.Text = "Position Move";
            // 
            // cboStep
            // 
            this.cboStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStep.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboStep.FormattingEnabled = true;
            this.cboStep.Location = new System.Drawing.Point(67, 30);
            this.cboStep.Name = "cboStep";
            this.cboStep.Size = new System.Drawing.Size(145, 24);
            this.cboStep.TabIndex = 13;
            this.cboStep.SelectedIndexChanged += new System.EventHandler(this.cboStep_SelectedIndexChanged);
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Location = new System.Drawing.Point(6, 29);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(55, 21);
            this.lblStep.TabIndex = 12;
            this.lblStep.Text = "Step :";
            // 
            // btnRJ6Positive
            // 
            this.btnRJ6Positive.Location = new System.Drawing.Point(112, 240);
            this.btnRJ6Positive.Name = "btnRJ6Positive";
            this.btnRJ6Positive.Size = new System.Drawing.Size(100, 30);
            this.btnRJ6Positive.TabIndex = 11;
            this.btnRJ6Positive.Tag = "10";
            this.btnRJ6Positive.Text = "+R";
            this.btnRJ6Positive.UseVisualStyleBackColor = true;
            this.btnRJ6Positive.Click += new System.EventHandler(this.btnXJ1Positive_Click);
            // 
            // btnRJ6Negative
            // 
            this.btnRJ6Negative.Location = new System.Drawing.Point(6, 240);
            this.btnRJ6Negative.Name = "btnRJ6Negative";
            this.btnRJ6Negative.Size = new System.Drawing.Size(100, 30);
            this.btnRJ6Negative.TabIndex = 10;
            this.btnRJ6Negative.Tag = "11";
            this.btnRJ6Negative.Text = "-R";
            this.btnRJ6Negative.UseVisualStyleBackColor = true;
            this.btnRJ6Negative.Click += new System.EventHandler(this.btnXJ1Positive_Click);
            // 
            // btnPJ5Positive
            // 
            this.btnPJ5Positive.Location = new System.Drawing.Point(112, 204);
            this.btnPJ5Positive.Name = "btnPJ5Positive";
            this.btnPJ5Positive.Size = new System.Drawing.Size(100, 30);
            this.btnPJ5Positive.TabIndex = 9;
            this.btnPJ5Positive.Tag = "8";
            this.btnPJ5Positive.Text = "+P";
            this.btnPJ5Positive.UseVisualStyleBackColor = true;
            this.btnPJ5Positive.Click += new System.EventHandler(this.btnXJ1Positive_Click);
            // 
            // btnPJ5Negative
            // 
            this.btnPJ5Negative.Location = new System.Drawing.Point(6, 204);
            this.btnPJ5Negative.Name = "btnPJ5Negative";
            this.btnPJ5Negative.Size = new System.Drawing.Size(100, 30);
            this.btnPJ5Negative.TabIndex = 8;
            this.btnPJ5Negative.Tag = "9";
            this.btnPJ5Negative.Text = "-P";
            this.btnPJ5Negative.UseVisualStyleBackColor = true;
            this.btnPJ5Negative.Click += new System.EventHandler(this.btnXJ1Positive_Click);
            // 
            // btnWJ4Positive
            // 
            this.btnWJ4Positive.Location = new System.Drawing.Point(112, 168);
            this.btnWJ4Positive.Name = "btnWJ4Positive";
            this.btnWJ4Positive.Size = new System.Drawing.Size(100, 30);
            this.btnWJ4Positive.TabIndex = 7;
            this.btnWJ4Positive.Tag = "6";
            this.btnWJ4Positive.Text = "+W";
            this.btnWJ4Positive.UseVisualStyleBackColor = true;
            this.btnWJ4Positive.Click += new System.EventHandler(this.btnXJ1Positive_Click);
            // 
            // btnWJ4Negative
            // 
            this.btnWJ4Negative.Location = new System.Drawing.Point(6, 168);
            this.btnWJ4Negative.Name = "btnWJ4Negative";
            this.btnWJ4Negative.Size = new System.Drawing.Size(100, 30);
            this.btnWJ4Negative.TabIndex = 6;
            this.btnWJ4Negative.Tag = "7";
            this.btnWJ4Negative.Text = "-W";
            this.btnWJ4Negative.UseVisualStyleBackColor = true;
            this.btnWJ4Negative.Click += new System.EventHandler(this.btnXJ1Positive_Click);
            // 
            // btnZJ3Positive
            // 
            this.btnZJ3Positive.Location = new System.Drawing.Point(112, 132);
            this.btnZJ3Positive.Name = "btnZJ3Positive";
            this.btnZJ3Positive.Size = new System.Drawing.Size(100, 30);
            this.btnZJ3Positive.TabIndex = 5;
            this.btnZJ3Positive.Tag = "4";
            this.btnZJ3Positive.Text = "+Z";
            this.btnZJ3Positive.UseVisualStyleBackColor = true;
            this.btnZJ3Positive.Click += new System.EventHandler(this.btnXJ1Positive_Click);
            // 
            // btnZJ3Negative
            // 
            this.btnZJ3Negative.Location = new System.Drawing.Point(6, 132);
            this.btnZJ3Negative.Name = "btnZJ3Negative";
            this.btnZJ3Negative.Size = new System.Drawing.Size(100, 30);
            this.btnZJ3Negative.TabIndex = 4;
            this.btnZJ3Negative.Tag = "5";
            this.btnZJ3Negative.Text = "-Z";
            this.btnZJ3Negative.UseVisualStyleBackColor = true;
            this.btnZJ3Negative.Click += new System.EventHandler(this.btnXJ1Positive_Click);
            // 
            // btnYJ2Positive
            // 
            this.btnYJ2Positive.Location = new System.Drawing.Point(112, 96);
            this.btnYJ2Positive.Name = "btnYJ2Positive";
            this.btnYJ2Positive.Size = new System.Drawing.Size(100, 30);
            this.btnYJ2Positive.TabIndex = 3;
            this.btnYJ2Positive.Tag = "2";
            this.btnYJ2Positive.Text = "+Y";
            this.btnYJ2Positive.UseVisualStyleBackColor = true;
            this.btnYJ2Positive.Click += new System.EventHandler(this.btnXJ1Positive_Click);
            // 
            // btnYJ2Negative
            // 
            this.btnYJ2Negative.Location = new System.Drawing.Point(6, 96);
            this.btnYJ2Negative.Name = "btnYJ2Negative";
            this.btnYJ2Negative.Size = new System.Drawing.Size(100, 30);
            this.btnYJ2Negative.TabIndex = 2;
            this.btnYJ2Negative.Tag = "3";
            this.btnYJ2Negative.Text = "-Y";
            this.btnYJ2Negative.UseVisualStyleBackColor = true;
            this.btnYJ2Negative.Click += new System.EventHandler(this.btnXJ1Positive_Click);
            // 
            // btnXJ1Positive
            // 
            this.btnXJ1Positive.Location = new System.Drawing.Point(112, 60);
            this.btnXJ1Positive.Name = "btnXJ1Positive";
            this.btnXJ1Positive.Size = new System.Drawing.Size(100, 30);
            this.btnXJ1Positive.TabIndex = 1;
            this.btnXJ1Positive.Tag = "0";
            this.btnXJ1Positive.Text = "+X";
            this.btnXJ1Positive.UseVisualStyleBackColor = true;
            this.btnXJ1Positive.Click += new System.EventHandler(this.btnXJ1Positive_Click);
            // 
            // btnXJ1Negative
            // 
            this.btnXJ1Negative.Location = new System.Drawing.Point(6, 60);
            this.btnXJ1Negative.Name = "btnXJ1Negative";
            this.btnXJ1Negative.Size = new System.Drawing.Size(100, 30);
            this.btnXJ1Negative.TabIndex = 0;
            this.btnXJ1Negative.Tag = "1";
            this.btnXJ1Negative.Text = "-X";
            this.btnXJ1Negative.UseVisualStyleBackColor = true;
            this.btnXJ1Negative.Click += new System.EventHandler(this.btnXJ1Positive_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 503);
            this.Controls.Add(this.gbPositionMove);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.gbRegister);
            this.Controls.Add(this.gbPositionSet);
            this.Controls.Add(this.gbOverride);
            this.Controls.Add(this.gbCurrentPosition);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.gbConnection);
            this.Controls.Add(this.pblogo);
            this.Name = "FrmMain";
            this.Tag = "0";
            this.Text = "Integrated Robot Interface";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            this.gbCurrentPosition.ResumeLayout(false);
            this.gbCurrentPosition.PerformLayout();
            this.gbOverride.ResumeLayout(false);
            this.gbOverride.PerformLayout();
            this.gbPositionSet.ResumeLayout(false);
            this.gbPositionSet.PerformLayout();
            this.gbRegister.ResumeLayout(false);
            this.gbRegister.PerformLayout();
            this.gbPositionMove.ResumeLayout(false);
            this.gbPositionMove.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbCurrentPosition;
        private System.Windows.Forms.Label lblJoint;
        private System.Windows.Forms.Label lblXyzwpr;
        private System.Windows.Forms.GroupBox gbOverride;
        private System.Windows.Forms.Label lblOverride;
        private System.Windows.Forms.GroupBox gbPositionSet;
        private System.Windows.Forms.ComboBox cboCoordinate;
        private System.Windows.Forms.Label lblYJ2Set;
        private System.Windows.Forms.Label lblRJ6Set;
        private System.Windows.Forms.Label lblWJ4Set;
        private System.Windows.Forms.Label lblPJ5Set;
        private System.Windows.Forms.Label lblZJ3Set;
        private System.Windows.Forms.Label lblXJ1Set;
        private System.Windows.Forms.TextBox tbRJ6Set;
        private System.Windows.Forms.TextBox tbPJ5Set;
        private System.Windows.Forms.TextBox tbWJ4Set;
        private System.Windows.Forms.TextBox tbZJ3Set;
        private System.Windows.Forms.TextBox tbYJ2Set;
        private System.Windows.Forms.TextBox tbXJ1Set;
        private System.Windows.Forms.Button btnPositionCopy;
        private System.Windows.Forms.Button btnPositionSet;
        private System.Windows.Forms.Button btnPositionHome;
        private System.Windows.Forms.GroupBox gbRegister;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.TextBox tbR1Set;
        private System.Windows.Forms.TextBox tbR5Set;
        private System.Windows.Forms.TextBox tbR4Set;
        private System.Windows.Forms.TextBox tbR3Set;
        private System.Windows.Forms.TextBox tbR2Set;
        private System.Windows.Forms.Label lblR5Set;
        private System.Windows.Forms.Label lblR4Set;
        private System.Windows.Forms.Label lblR3Set;
        private System.Windows.Forms.Label lblR1Set;
        private System.Windows.Forms.Label lblR2Set;
        private System.Windows.Forms.Button btnRegisterSet;
        private System.Windows.Forms.GroupBox gbPositionMove;
        private System.Windows.Forms.Button btnRJ6Positive;
        private System.Windows.Forms.Button btnRJ6Negative;
        private System.Windows.Forms.Button btnPJ5Positive;
        private System.Windows.Forms.Button btnPJ5Negative;
        private System.Windows.Forms.Button btnWJ4Positive;
        private System.Windows.Forms.Button btnWJ4Negative;
        private System.Windows.Forms.Button btnZJ3Positive;
        private System.Windows.Forms.Button btnZJ3Negative;
        private System.Windows.Forms.Button btnYJ2Positive;
        private System.Windows.Forms.Button btnYJ2Negative;
        private System.Windows.Forms.Button btnXJ1Positive;
        private System.Windows.Forms.Button btnXJ1Negative;
        private System.Windows.Forms.ComboBox cboStep;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox tbVelocity;
        private System.Windows.Forms.Label lblVelocity;
        private System.Windows.Forms.Label lblRange;
    }
}

