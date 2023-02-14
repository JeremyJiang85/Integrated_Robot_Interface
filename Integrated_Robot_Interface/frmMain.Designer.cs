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
            this.gbCurrentState = new System.Windows.Forms.GroupBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblJoint = new System.Windows.Forms.Label();
            this.lblXyzwpr = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbOverride = new System.Windows.Forms.GroupBox();
            this.lblOverride = new System.Windows.Forms.Label();
            this.gbPTP = new System.Windows.Forms.GroupBox();
            this.lblRange = new System.Windows.Forms.Label();
            this.tbVelocity = new System.Windows.Forms.TextBox();
            this.lblVelocity = new System.Windows.Forms.Label();
            this.btnPositionHome = new System.Windows.Forms.Button();
            this.btnPTPSet = new System.Windows.Forms.Button();
            this.btnPTPCopy = new System.Windows.Forms.Button();
            this.lblPTPYJ2Set = new System.Windows.Forms.Label();
            this.lblPTPRJ6Set = new System.Windows.Forms.Label();
            this.lblPTPWJ4Set = new System.Windows.Forms.Label();
            this.lblPTPPJ5Set = new System.Windows.Forms.Label();
            this.lblPTPZJ3Set = new System.Windows.Forms.Label();
            this.lblPTPXJ1Set = new System.Windows.Forms.Label();
            this.tbPTPRJ6Set = new System.Windows.Forms.TextBox();
            this.tbPTPPJ5Set = new System.Windows.Forms.TextBox();
            this.tbPTPWJ4Set = new System.Windows.Forms.TextBox();
            this.tbPTPZJ3Set = new System.Windows.Forms.TextBox();
            this.tbPTPYJ2Set = new System.Windows.Forms.TextBox();
            this.tbPTPXJ1Set = new System.Windows.Forms.TextBox();
            this.cboPTPCoordinate = new System.Windows.Forms.ComboBox();
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
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.btnPercentup = new System.Windows.Forms.Button();
            this.btnPercentdown = new System.Windows.Forms.Button();
            this.gbLine = new System.Windows.Forms.GroupBox();
            this.tbLineVelocitySet = new System.Windows.Forms.TextBox();
            this.lblLineVelocitySet = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblLineYJ2Set = new System.Windows.Forms.Label();
            this.lblLineRJ6Set = new System.Windows.Forms.Label();
            this.lblLineWJ4Set = new System.Windows.Forms.Label();
            this.lblLinePJ5Set = new System.Windows.Forms.Label();
            this.lblLineZJ3Set = new System.Windows.Forms.Label();
            this.lblLineXJ1Set = new System.Windows.Forms.Label();
            this.tbLineRJ6Set = new System.Windows.Forms.TextBox();
            this.tbLinePJ5Set = new System.Windows.Forms.TextBox();
            this.tbLineWJ4Set = new System.Windows.Forms.TextBox();
            this.tbLineZJ3Set = new System.Windows.Forms.TextBox();
            this.tbLineYJ2Set = new System.Windows.Forms.TextBox();
            this.tbLineXJ1Set = new System.Windows.Forms.TextBox();
            this.lblPTPCoordinate = new System.Windows.Forms.Label();
            this.lblPTPXJ1Unit = new System.Windows.Forms.Label();
            this.lblPTPYJ2Unit = new System.Windows.Forms.Label();
            this.lblPTPZJ3Unit = new System.Windows.Forms.Label();
            this.lblPTPWJ4Unit = new System.Windows.Forms.Label();
            this.lblPTPPJ5Unit = new System.Windows.Forms.Label();
            this.lblPTPRJ6Unit = new System.Windows.Forms.Label();
            this.lblLineRJ6Unit = new System.Windows.Forms.Label();
            this.lblLinePJ5Unit = new System.Windows.Forms.Label();
            this.lblLineWJ4Unit = new System.Windows.Forms.Label();
            this.lblLineZJ3Unit = new System.Windows.Forms.Label();
            this.lblLineYJ2Unit = new System.Windows.Forms.Label();
            this.lblLineXJ1Unit = new System.Windows.Forms.Label();
            this.lblLineVelocityUnit = new System.Windows.Forms.Label();
            this.lblLineVelocityRange = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.gbConnection.SuspendLayout();
            this.gbCurrentState.SuspendLayout();
            this.gbOverride.SuspendLayout();
            this.gbPTP.SuspendLayout();
            this.gbRegister.SuspendLayout();
            this.gbPositionMove.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.gbLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // pblogo
            // 
            this.pblogo.Image = global::Integrated_Robot_Interface.Properties.Resources.lion;
            this.pblogo.Location = new System.Drawing.Point(12, 12);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(125, 125);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblogo.TabIndex = 0;
            this.pblogo.TabStop = false;
            // 
            // btnEsc
            // 
            this.btnEsc.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEsc.Location = new System.Drawing.Point(973, 12);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(96, 52);
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
            this.gbConnection.Size = new System.Drawing.Size(294, 125);
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
            this.richTextBox1.Size = new System.Drawing.Size(355, 125);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbCurrentState
            // 
            this.gbCurrentState.Controls.Add(this.lblRange);
            this.gbCurrentState.Controls.Add(this.lblState);
            this.gbCurrentState.Controls.Add(this.lblJoint);
            this.gbCurrentState.Controls.Add(this.lblXyzwpr);
            this.gbCurrentState.Controls.Add(this.btnPositionHome);
            this.gbCurrentState.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbCurrentState.Location = new System.Drawing.Point(12, 146);
            this.gbCurrentState.Name = "gbCurrentState";
            this.gbCurrentState.Size = new System.Drawing.Size(279, 353);
            this.gbCurrentState.TabIndex = 4;
            this.gbCurrentState.TabStop = false;
            this.gbCurrentState.Text = "Current State";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(6, 180);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(49, 21);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "State";
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
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(6, 142);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 45);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gbOverride
            // 
            this.gbOverride.Controls.Add(this.btnPercentdown);
            this.gbOverride.Controls.Add(this.btnPercentup);
            this.gbOverride.Controls.Add(this.lblOverride);
            this.gbOverride.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbOverride.Location = new System.Drawing.Point(807, 12);
            this.gbOverride.Name = "gbOverride";
            this.gbOverride.Size = new System.Drawing.Size(110, 125);
            this.gbOverride.TabIndex = 5;
            this.gbOverride.TabStop = false;
            this.gbOverride.Text = "Override";
            // 
            // lblOverride
            // 
            this.lblOverride.AutoSize = true;
            this.lblOverride.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOverride.Location = new System.Drawing.Point(6, 29);
            this.lblOverride.Name = "lblOverride";
            this.lblOverride.Size = new System.Drawing.Size(0, 37);
            this.lblOverride.TabIndex = 0;
            // 
            // gbPTP
            // 
            this.gbPTP.Controls.Add(this.lblPTPRJ6Unit);
            this.gbPTP.Controls.Add(this.lblPTPPJ5Unit);
            this.gbPTP.Controls.Add(this.lblPTPWJ4Unit);
            this.gbPTP.Controls.Add(this.lblPTPZJ3Unit);
            this.gbPTP.Controls.Add(this.lblPTPYJ2Unit);
            this.gbPTP.Controls.Add(this.lblPTPXJ1Unit);
            this.gbPTP.Controls.Add(this.lblPTPCoordinate);
            this.gbPTP.Controls.Add(this.tbVelocity);
            this.gbPTP.Controls.Add(this.lblVelocity);
            this.gbPTP.Controls.Add(this.btnPTPSet);
            this.gbPTP.Controls.Add(this.btnPTPCopy);
            this.gbPTP.Controls.Add(this.lblPTPYJ2Set);
            this.gbPTP.Controls.Add(this.lblPTPRJ6Set);
            this.gbPTP.Controls.Add(this.lblPTPWJ4Set);
            this.gbPTP.Controls.Add(this.lblPTPPJ5Set);
            this.gbPTP.Controls.Add(this.lblPTPZJ3Set);
            this.gbPTP.Controls.Add(this.lblPTPXJ1Set);
            this.gbPTP.Controls.Add(this.tbPTPRJ6Set);
            this.gbPTP.Controls.Add(this.tbPTPPJ5Set);
            this.gbPTP.Controls.Add(this.tbPTPWJ4Set);
            this.gbPTP.Controls.Add(this.tbPTPZJ3Set);
            this.gbPTP.Controls.Add(this.tbPTPYJ2Set);
            this.gbPTP.Controls.Add(this.tbPTPXJ1Set);
            this.gbPTP.Controls.Add(this.cboPTPCoordinate);
            this.gbPTP.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbPTP.Location = new System.Drawing.Point(297, 146);
            this.gbPTP.Name = "gbPTP";
            this.gbPTP.Size = new System.Drawing.Size(216, 353);
            this.gbPTP.TabIndex = 6;
            this.gbPTP.TabStop = false;
            this.gbPTP.Text = "PTP";
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(140, 186);
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
            this.btnPositionHome.Location = new System.Drawing.Point(206, 297);
            this.btnPositionHome.Name = "btnPositionHome";
            this.btnPositionHome.Size = new System.Drawing.Size(60, 50);
            this.btnPositionHome.TabIndex = 15;
            this.btnPositionHome.Text = "Home";
            this.btnPositionHome.UseVisualStyleBackColor = true;
            this.btnPositionHome.Click += new System.EventHandler(this.btnPositionHome_Click);
            // 
            // btnPTPSet
            // 
            this.btnPTPSet.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPTPSet.Location = new System.Drawing.Point(110, 265);
            this.btnPTPSet.Name = "btnPTPSet";
            this.btnPTPSet.Size = new System.Drawing.Size(94, 50);
            this.btnPTPSet.TabIndex = 14;
            this.btnPTPSet.Text = "Set";
            this.btnPTPSet.UseVisualStyleBackColor = true;
            this.btnPTPSet.Click += new System.EventHandler(this.btnPTPSet_Click);
            // 
            // btnPTPCopy
            // 
            this.btnPTPCopy.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPTPCopy.Location = new System.Drawing.Point(10, 265);
            this.btnPTPCopy.Name = "btnPTPCopy";
            this.btnPTPCopy.Size = new System.Drawing.Size(94, 50);
            this.btnPTPCopy.TabIndex = 13;
            this.btnPTPCopy.Text = "Copy";
            this.btnPTPCopy.UseVisualStyleBackColor = true;
            this.btnPTPCopy.Click += new System.EventHandler(this.btnPTPCopy_Click);
            // 
            // lblPTPYJ2Set
            // 
            this.lblPTPYJ2Set.AutoSize = true;
            this.lblPTPYJ2Set.Location = new System.Drawing.Point(6, 91);
            this.lblPTPYJ2Set.Name = "lblPTPYJ2Set";
            this.lblPTPYJ2Set.Size = new System.Drawing.Size(34, 21);
            this.lblPTPYJ2Set.TabIndex = 12;
            this.lblPTPYJ2Set.Text = "Y :";
            // 
            // lblPTPRJ6Set
            // 
            this.lblPTPRJ6Set.AutoSize = true;
            this.lblPTPRJ6Set.Location = new System.Drawing.Point(6, 207);
            this.lblPTPRJ6Set.Name = "lblPTPRJ6Set";
            this.lblPTPRJ6Set.Size = new System.Drawing.Size(33, 21);
            this.lblPTPRJ6Set.TabIndex = 11;
            this.lblPTPRJ6Set.Text = "R :";
            // 
            // lblPTPWJ4Set
            // 
            this.lblPTPWJ4Set.AutoSize = true;
            this.lblPTPWJ4Set.Location = new System.Drawing.Point(6, 149);
            this.lblPTPWJ4Set.Name = "lblPTPWJ4Set";
            this.lblPTPWJ4Set.Size = new System.Drawing.Size(34, 21);
            this.lblPTPWJ4Set.TabIndex = 10;
            this.lblPTPWJ4Set.Text = "W:";
            // 
            // lblPTPPJ5Set
            // 
            this.lblPTPPJ5Set.AutoSize = true;
            this.lblPTPPJ5Set.Location = new System.Drawing.Point(6, 178);
            this.lblPTPPJ5Set.Name = "lblPTPPJ5Set";
            this.lblPTPPJ5Set.Size = new System.Drawing.Size(31, 21);
            this.lblPTPPJ5Set.TabIndex = 9;
            this.lblPTPPJ5Set.Text = "P :";
            // 
            // lblPTPZJ3Set
            // 
            this.lblPTPZJ3Set.AutoSize = true;
            this.lblPTPZJ3Set.Location = new System.Drawing.Point(6, 120);
            this.lblPTPZJ3Set.Name = "lblPTPZJ3Set";
            this.lblPTPZJ3Set.Size = new System.Drawing.Size(32, 21);
            this.lblPTPZJ3Set.TabIndex = 8;
            this.lblPTPZJ3Set.Text = "Z :";
            // 
            // lblPTPXJ1Set
            // 
            this.lblPTPXJ1Set.AutoSize = true;
            this.lblPTPXJ1Set.Location = new System.Drawing.Point(6, 62);
            this.lblPTPXJ1Set.Name = "lblPTPXJ1Set";
            this.lblPTPXJ1Set.Size = new System.Drawing.Size(34, 21);
            this.lblPTPXJ1Set.TabIndex = 7;
            this.lblPTPXJ1Set.Text = "X :";
            // 
            // tbPTPRJ6Set
            // 
            this.tbPTPRJ6Set.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPTPRJ6Set.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbPTPRJ6Set.Location = new System.Drawing.Point(46, 207);
            this.tbPTPRJ6Set.Name = "tbPTPRJ6Set";
            this.tbPTPRJ6Set.Size = new System.Drawing.Size(110, 23);
            this.tbPTPRJ6Set.TabIndex = 6;
            this.tbPTPRJ6Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPTPPJ5Set
            // 
            this.tbPTPPJ5Set.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPTPPJ5Set.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbPTPPJ5Set.Location = new System.Drawing.Point(46, 178);
            this.tbPTPPJ5Set.Name = "tbPTPPJ5Set";
            this.tbPTPPJ5Set.Size = new System.Drawing.Size(110, 23);
            this.tbPTPPJ5Set.TabIndex = 5;
            this.tbPTPPJ5Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPTPWJ4Set
            // 
            this.tbPTPWJ4Set.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPTPWJ4Set.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbPTPWJ4Set.Location = new System.Drawing.Point(46, 149);
            this.tbPTPWJ4Set.Name = "tbPTPWJ4Set";
            this.tbPTPWJ4Set.Size = new System.Drawing.Size(110, 23);
            this.tbPTPWJ4Set.TabIndex = 4;
            this.tbPTPWJ4Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPTPZJ3Set
            // 
            this.tbPTPZJ3Set.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPTPZJ3Set.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbPTPZJ3Set.Location = new System.Drawing.Point(46, 120);
            this.tbPTPZJ3Set.Name = "tbPTPZJ3Set";
            this.tbPTPZJ3Set.Size = new System.Drawing.Size(110, 23);
            this.tbPTPZJ3Set.TabIndex = 3;
            this.tbPTPZJ3Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPTPYJ2Set
            // 
            this.tbPTPYJ2Set.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPTPYJ2Set.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbPTPYJ2Set.Location = new System.Drawing.Point(46, 91);
            this.tbPTPYJ2Set.Name = "tbPTPYJ2Set";
            this.tbPTPYJ2Set.Size = new System.Drawing.Size(110, 23);
            this.tbPTPYJ2Set.TabIndex = 2;
            this.tbPTPYJ2Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPTPXJ1Set
            // 
            this.tbPTPXJ1Set.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPTPXJ1Set.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbPTPXJ1Set.Location = new System.Drawing.Point(46, 62);
            this.tbPTPXJ1Set.Name = "tbPTPXJ1Set";
            this.tbPTPXJ1Set.Size = new System.Drawing.Size(110, 23);
            this.tbPTPXJ1Set.TabIndex = 1;
            this.tbPTPXJ1Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboPTPCoordinate
            // 
            this.cboPTPCoordinate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPTPCoordinate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboPTPCoordinate.FormattingEnabled = true;
            this.cboPTPCoordinate.Location = new System.Drawing.Point(120, 30);
            this.cboPTPCoordinate.Name = "cboPTPCoordinate";
            this.cboPTPCoordinate.Size = new System.Drawing.Size(85, 24);
            this.cboPTPCoordinate.TabIndex = 0;
            this.cboPTPCoordinate.SelectedIndexChanged += new System.EventHandler(this.cboCoordinate_SelectedIndexChanged);
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
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(6, 88);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(100, 48);
            this.btnDisable.TabIndex = 15;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(6, 29);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(100, 48);
            this.btnEnable.TabIndex = 14;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.btnReset);
            this.gbControl.Controls.Add(this.btnDisable);
            this.gbControl.Controls.Add(this.btnEnable);
            this.gbControl.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbControl.Location = new System.Drawing.Point(909, 146);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(114, 207);
            this.gbControl.TabIndex = 9;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Control";
            // 
            // btnPercentup
            // 
            this.btnPercentup.Location = new System.Drawing.Point(6, 74);
            this.btnPercentup.Name = "btnPercentup";
            this.btnPercentup.Size = new System.Drawing.Size(45, 45);
            this.btnPercentup.TabIndex = 1;
            this.btnPercentup.Text = "+%";
            this.btnPercentup.UseVisualStyleBackColor = true;
            this.btnPercentup.Click += new System.EventHandler(this.btnPercentup_Click);
            // 
            // btnPercentdown
            // 
            this.btnPercentdown.Location = new System.Drawing.Point(57, 74);
            this.btnPercentdown.Name = "btnPercentdown";
            this.btnPercentdown.Size = new System.Drawing.Size(45, 45);
            this.btnPercentdown.TabIndex = 2;
            this.btnPercentdown.Text = "-%";
            this.btnPercentdown.UseVisualStyleBackColor = true;
            this.btnPercentdown.Click += new System.EventHandler(this.btnPercentdown_Click);
            // 
            // gbLine
            // 
            this.gbLine.Controls.Add(this.lblLineVelocityRange);
            this.gbLine.Controls.Add(this.lblLineVelocityUnit);
            this.gbLine.Controls.Add(this.lblLineRJ6Unit);
            this.gbLine.Controls.Add(this.tbLineVelocitySet);
            this.gbLine.Controls.Add(this.lblLinePJ5Unit);
            this.gbLine.Controls.Add(this.lblLineVelocitySet);
            this.gbLine.Controls.Add(this.lblLineWJ4Unit);
            this.gbLine.Controls.Add(this.button2);
            this.gbLine.Controls.Add(this.lblLineZJ3Unit);
            this.gbLine.Controls.Add(this.button3);
            this.gbLine.Controls.Add(this.lblLineYJ2Unit);
            this.gbLine.Controls.Add(this.lblLineXJ1Unit);
            this.gbLine.Controls.Add(this.lblLineYJ2Set);
            this.gbLine.Controls.Add(this.lblLineRJ6Set);
            this.gbLine.Controls.Add(this.lblLineWJ4Set);
            this.gbLine.Controls.Add(this.lblLinePJ5Set);
            this.gbLine.Controls.Add(this.lblLineZJ3Set);
            this.gbLine.Controls.Add(this.lblLineXJ1Set);
            this.gbLine.Controls.Add(this.tbLineRJ6Set);
            this.gbLine.Controls.Add(this.tbLinePJ5Set);
            this.gbLine.Controls.Add(this.tbLineWJ4Set);
            this.gbLine.Controls.Add(this.tbLineZJ3Set);
            this.gbLine.Controls.Add(this.tbLineYJ2Set);
            this.gbLine.Controls.Add(this.tbLineXJ1Set);
            this.gbLine.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbLine.Location = new System.Drawing.Point(1029, 146);
            this.gbLine.Name = "gbLine";
            this.gbLine.Size = new System.Drawing.Size(215, 353);
            this.gbLine.TabIndex = 18;
            this.gbLine.TabStop = false;
            this.gbLine.Text = "Line";
            // 
            // tbLineVelocitySet
            // 
            this.tbLineVelocitySet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLineVelocitySet.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbLineVelocitySet.Location = new System.Drawing.Point(46, 203);
            this.tbLineVelocitySet.Name = "tbLineVelocitySet";
            this.tbLineVelocitySet.Size = new System.Drawing.Size(81, 23);
            this.tbLineVelocitySet.TabIndex = 17;
            this.tbLineVelocitySet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLineVelocitySet
            // 
            this.lblLineVelocitySet.AutoSize = true;
            this.lblLineVelocitySet.Location = new System.Drawing.Point(6, 203);
            this.lblLineVelocitySet.Name = "lblLineVelocitySet";
            this.lblLineVelocitySet.Size = new System.Drawing.Size(34, 21);
            this.lblLineVelocitySet.TabIndex = 16;
            this.lblLineVelocitySet.Text = "V :";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(110, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 50);
            this.button2.TabIndex = 14;
            this.button2.Text = "Set";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(10, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 50);
            this.button3.TabIndex = 13;
            this.button3.Text = "Copy";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblLineYJ2Set
            // 
            this.lblLineYJ2Set.AutoSize = true;
            this.lblLineYJ2Set.Location = new System.Drawing.Point(6, 58);
            this.lblLineYJ2Set.Name = "lblLineYJ2Set";
            this.lblLineYJ2Set.Size = new System.Drawing.Size(34, 21);
            this.lblLineYJ2Set.TabIndex = 12;
            this.lblLineYJ2Set.Text = "Y :";
            // 
            // lblLineRJ6Set
            // 
            this.lblLineRJ6Set.AutoSize = true;
            this.lblLineRJ6Set.Location = new System.Drawing.Point(6, 174);
            this.lblLineRJ6Set.Name = "lblLineRJ6Set";
            this.lblLineRJ6Set.Size = new System.Drawing.Size(33, 21);
            this.lblLineRJ6Set.TabIndex = 11;
            this.lblLineRJ6Set.Text = "R :";
            // 
            // lblLineWJ4Set
            // 
            this.lblLineWJ4Set.AutoSize = true;
            this.lblLineWJ4Set.Location = new System.Drawing.Point(6, 116);
            this.lblLineWJ4Set.Name = "lblLineWJ4Set";
            this.lblLineWJ4Set.Size = new System.Drawing.Size(34, 21);
            this.lblLineWJ4Set.TabIndex = 10;
            this.lblLineWJ4Set.Text = "W:";
            // 
            // lblLinePJ5Set
            // 
            this.lblLinePJ5Set.AutoSize = true;
            this.lblLinePJ5Set.Location = new System.Drawing.Point(6, 145);
            this.lblLinePJ5Set.Name = "lblLinePJ5Set";
            this.lblLinePJ5Set.Size = new System.Drawing.Size(31, 21);
            this.lblLinePJ5Set.TabIndex = 9;
            this.lblLinePJ5Set.Text = "P :";
            // 
            // lblLineZJ3Set
            // 
            this.lblLineZJ3Set.AutoSize = true;
            this.lblLineZJ3Set.Location = new System.Drawing.Point(6, 87);
            this.lblLineZJ3Set.Name = "lblLineZJ3Set";
            this.lblLineZJ3Set.Size = new System.Drawing.Size(32, 21);
            this.lblLineZJ3Set.TabIndex = 8;
            this.lblLineZJ3Set.Text = "Z :";
            // 
            // lblLineXJ1Set
            // 
            this.lblLineXJ1Set.AutoSize = true;
            this.lblLineXJ1Set.Location = new System.Drawing.Point(6, 29);
            this.lblLineXJ1Set.Name = "lblLineXJ1Set";
            this.lblLineXJ1Set.Size = new System.Drawing.Size(34, 21);
            this.lblLineXJ1Set.TabIndex = 7;
            this.lblLineXJ1Set.Text = "X :";
            // 
            // tbLineRJ6Set
            // 
            this.tbLineRJ6Set.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLineRJ6Set.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbLineRJ6Set.Location = new System.Drawing.Point(46, 174);
            this.tbLineRJ6Set.Name = "tbLineRJ6Set";
            this.tbLineRJ6Set.Size = new System.Drawing.Size(110, 23);
            this.tbLineRJ6Set.TabIndex = 6;
            this.tbLineRJ6Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLinePJ5Set
            // 
            this.tbLinePJ5Set.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLinePJ5Set.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbLinePJ5Set.Location = new System.Drawing.Point(46, 145);
            this.tbLinePJ5Set.Name = "tbLinePJ5Set";
            this.tbLinePJ5Set.Size = new System.Drawing.Size(110, 23);
            this.tbLinePJ5Set.TabIndex = 5;
            this.tbLinePJ5Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLineWJ4Set
            // 
            this.tbLineWJ4Set.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLineWJ4Set.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbLineWJ4Set.Location = new System.Drawing.Point(46, 116);
            this.tbLineWJ4Set.Name = "tbLineWJ4Set";
            this.tbLineWJ4Set.Size = new System.Drawing.Size(110, 23);
            this.tbLineWJ4Set.TabIndex = 4;
            this.tbLineWJ4Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLineZJ3Set
            // 
            this.tbLineZJ3Set.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLineZJ3Set.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbLineZJ3Set.Location = new System.Drawing.Point(46, 87);
            this.tbLineZJ3Set.Name = "tbLineZJ3Set";
            this.tbLineZJ3Set.Size = new System.Drawing.Size(110, 23);
            this.tbLineZJ3Set.TabIndex = 3;
            this.tbLineZJ3Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLineYJ2Set
            // 
            this.tbLineYJ2Set.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLineYJ2Set.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbLineYJ2Set.Location = new System.Drawing.Point(46, 58);
            this.tbLineYJ2Set.Name = "tbLineYJ2Set";
            this.tbLineYJ2Set.Size = new System.Drawing.Size(110, 23);
            this.tbLineYJ2Set.TabIndex = 2;
            this.tbLineYJ2Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLineXJ1Set
            // 
            this.tbLineXJ1Set.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLineXJ1Set.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbLineXJ1Set.Location = new System.Drawing.Point(46, 29);
            this.tbLineXJ1Set.Name = "tbLineXJ1Set";
            this.tbLineXJ1Set.Size = new System.Drawing.Size(110, 23);
            this.tbLineXJ1Set.TabIndex = 1;
            this.tbLineXJ1Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPTPCoordinate
            // 
            this.lblPTPCoordinate.AutoSize = true;
            this.lblPTPCoordinate.Location = new System.Drawing.Point(6, 29);
            this.lblPTPCoordinate.Name = "lblPTPCoordinate";
            this.lblPTPCoordinate.Size = new System.Drawing.Size(108, 21);
            this.lblPTPCoordinate.TabIndex = 18;
            this.lblPTPCoordinate.Text = "Coordinate :";
            // 
            // lblPTPXJ1Unit
            // 
            this.lblPTPXJ1Unit.AutoSize = true;
            this.lblPTPXJ1Unit.Location = new System.Drawing.Point(165, 62);
            this.lblPTPXJ1Unit.Name = "lblPTPXJ1Unit";
            this.lblPTPXJ1Unit.Size = new System.Drawing.Size(40, 21);
            this.lblPTPXJ1Unit.TabIndex = 19;
            this.lblPTPXJ1Unit.Text = "mm";
            // 
            // lblPTPYJ2Unit
            // 
            this.lblPTPYJ2Unit.AutoSize = true;
            this.lblPTPYJ2Unit.Location = new System.Drawing.Point(165, 91);
            this.lblPTPYJ2Unit.Name = "lblPTPYJ2Unit";
            this.lblPTPYJ2Unit.Size = new System.Drawing.Size(40, 21);
            this.lblPTPYJ2Unit.TabIndex = 20;
            this.lblPTPYJ2Unit.Text = "mm";
            // 
            // lblPTPZJ3Unit
            // 
            this.lblPTPZJ3Unit.AutoSize = true;
            this.lblPTPZJ3Unit.Location = new System.Drawing.Point(165, 120);
            this.lblPTPZJ3Unit.Name = "lblPTPZJ3Unit";
            this.lblPTPZJ3Unit.Size = new System.Drawing.Size(40, 21);
            this.lblPTPZJ3Unit.TabIndex = 21;
            this.lblPTPZJ3Unit.Text = "mm";
            // 
            // lblPTPWJ4Unit
            // 
            this.lblPTPWJ4Unit.AutoSize = true;
            this.lblPTPWJ4Unit.Location = new System.Drawing.Point(166, 149);
            this.lblPTPWJ4Unit.Name = "lblPTPWJ4Unit";
            this.lblPTPWJ4Unit.Size = new System.Drawing.Size(39, 21);
            this.lblPTPWJ4Unit.TabIndex = 22;
            this.lblPTPWJ4Unit.Text = "deg";
            // 
            // lblPTPPJ5Unit
            // 
            this.lblPTPPJ5Unit.AutoSize = true;
            this.lblPTPPJ5Unit.Location = new System.Drawing.Point(166, 178);
            this.lblPTPPJ5Unit.Name = "lblPTPPJ5Unit";
            this.lblPTPPJ5Unit.Size = new System.Drawing.Size(39, 21);
            this.lblPTPPJ5Unit.TabIndex = 23;
            this.lblPTPPJ5Unit.Text = "deg";
            // 
            // lblPTPRJ6Unit
            // 
            this.lblPTPRJ6Unit.AutoSize = true;
            this.lblPTPRJ6Unit.Location = new System.Drawing.Point(166, 207);
            this.lblPTPRJ6Unit.Name = "lblPTPRJ6Unit";
            this.lblPTPRJ6Unit.Size = new System.Drawing.Size(39, 21);
            this.lblPTPRJ6Unit.TabIndex = 24;
            this.lblPTPRJ6Unit.Text = "deg";
            // 
            // lblLineRJ6Unit
            // 
            this.lblLineRJ6Unit.AutoSize = true;
            this.lblLineRJ6Unit.Location = new System.Drawing.Point(165, 174);
            this.lblLineRJ6Unit.Name = "lblLineRJ6Unit";
            this.lblLineRJ6Unit.Size = new System.Drawing.Size(39, 21);
            this.lblLineRJ6Unit.TabIndex = 30;
            this.lblLineRJ6Unit.Text = "deg";
            // 
            // lblLinePJ5Unit
            // 
            this.lblLinePJ5Unit.AutoSize = true;
            this.lblLinePJ5Unit.Location = new System.Drawing.Point(165, 145);
            this.lblLinePJ5Unit.Name = "lblLinePJ5Unit";
            this.lblLinePJ5Unit.Size = new System.Drawing.Size(39, 21);
            this.lblLinePJ5Unit.TabIndex = 29;
            this.lblLinePJ5Unit.Text = "deg";
            // 
            // lblLineWJ4Unit
            // 
            this.lblLineWJ4Unit.AutoSize = true;
            this.lblLineWJ4Unit.Location = new System.Drawing.Point(165, 116);
            this.lblLineWJ4Unit.Name = "lblLineWJ4Unit";
            this.lblLineWJ4Unit.Size = new System.Drawing.Size(39, 21);
            this.lblLineWJ4Unit.TabIndex = 28;
            this.lblLineWJ4Unit.Text = "deg";
            // 
            // lblLineZJ3Unit
            // 
            this.lblLineZJ3Unit.AutoSize = true;
            this.lblLineZJ3Unit.Location = new System.Drawing.Point(164, 87);
            this.lblLineZJ3Unit.Name = "lblLineZJ3Unit";
            this.lblLineZJ3Unit.Size = new System.Drawing.Size(40, 21);
            this.lblLineZJ3Unit.TabIndex = 27;
            this.lblLineZJ3Unit.Text = "mm";
            // 
            // lblLineYJ2Unit
            // 
            this.lblLineYJ2Unit.AutoSize = true;
            this.lblLineYJ2Unit.Location = new System.Drawing.Point(164, 58);
            this.lblLineYJ2Unit.Name = "lblLineYJ2Unit";
            this.lblLineYJ2Unit.Size = new System.Drawing.Size(40, 21);
            this.lblLineYJ2Unit.TabIndex = 26;
            this.lblLineYJ2Unit.Text = "mm";
            // 
            // lblLineXJ1Unit
            // 
            this.lblLineXJ1Unit.AutoSize = true;
            this.lblLineXJ1Unit.Location = new System.Drawing.Point(164, 29);
            this.lblLineXJ1Unit.Name = "lblLineXJ1Unit";
            this.lblLineXJ1Unit.Size = new System.Drawing.Size(40, 21);
            this.lblLineXJ1Unit.TabIndex = 25;
            this.lblLineXJ1Unit.Text = "mm";
            // 
            // lblLineVelocityUnit
            // 
            this.lblLineVelocityUnit.AutoSize = true;
            this.lblLineVelocityUnit.Location = new System.Drawing.Point(133, 203);
            this.lblLineVelocityUnit.Name = "lblLineVelocityUnit";
            this.lblLineVelocityUnit.Size = new System.Drawing.Size(71, 21);
            this.lblLineVelocityUnit.TabIndex = 31;
            this.lblLineVelocityUnit.Text = "unit/sec";
            // 
            // lblLineVelocityRange
            // 
            this.lblLineVelocityRange.AutoSize = true;
            this.lblLineVelocityRange.Location = new System.Drawing.Point(6, 229);
            this.lblLineVelocityRange.Name = "lblLineVelocityRange";
            this.lblLineVelocityRange.Size = new System.Drawing.Size(34, 21);
            this.lblLineVelocityRange.TabIndex = 32;
            this.lblLineVelocityRange.Text = "V :";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 541);
            this.Controls.Add(this.gbLine);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.gbPositionMove);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.gbRegister);
            this.Controls.Add(this.gbPTP);
            this.Controls.Add(this.gbOverride);
            this.Controls.Add(this.gbCurrentState);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.gbConnection);
            this.Controls.Add(this.pblogo);
            this.Name = "FrmMain";
            this.Tag = "0";
            this.Text = "`";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            this.gbCurrentState.ResumeLayout(false);
            this.gbCurrentState.PerformLayout();
            this.gbOverride.ResumeLayout(false);
            this.gbOverride.PerformLayout();
            this.gbPTP.ResumeLayout(false);
            this.gbPTP.PerformLayout();
            this.gbRegister.ResumeLayout(false);
            this.gbRegister.PerformLayout();
            this.gbPositionMove.ResumeLayout(false);
            this.gbPositionMove.PerformLayout();
            this.gbControl.ResumeLayout(false);
            this.gbLine.ResumeLayout(false);
            this.gbLine.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbCurrentState;
        private System.Windows.Forms.Label lblJoint;
        private System.Windows.Forms.Label lblXyzwpr;
        private System.Windows.Forms.GroupBox gbOverride;
        private System.Windows.Forms.Label lblOverride;
        private System.Windows.Forms.GroupBox gbPTP;
        private System.Windows.Forms.ComboBox cboPTPCoordinate;
        private System.Windows.Forms.Label lblPTPYJ2Set;
        private System.Windows.Forms.Label lblPTPRJ6Set;
        private System.Windows.Forms.Label lblPTPWJ4Set;
        private System.Windows.Forms.Label lblPTPPJ5Set;
        private System.Windows.Forms.Label lblPTPZJ3Set;
        private System.Windows.Forms.Label lblPTPXJ1Set;
        private System.Windows.Forms.TextBox tbPTPRJ6Set;
        private System.Windows.Forms.TextBox tbPTPPJ5Set;
        private System.Windows.Forms.TextBox tbPTPWJ4Set;
        private System.Windows.Forms.TextBox tbPTPZJ3Set;
        private System.Windows.Forms.TextBox tbPTPYJ2Set;
        private System.Windows.Forms.TextBox tbPTPXJ1Set;
        private System.Windows.Forms.Button btnPTPCopy;
        private System.Windows.Forms.Button btnPTPSet;
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
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.Button btnPercentdown;
        private System.Windows.Forms.Button btnPercentup;
        private System.Windows.Forms.GroupBox gbLine;
        private System.Windows.Forms.TextBox tbLineVelocitySet;
        private System.Windows.Forms.Label lblLineVelocitySet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblLineYJ2Set;
        private System.Windows.Forms.Label lblLineRJ6Set;
        private System.Windows.Forms.Label lblLineWJ4Set;
        private System.Windows.Forms.Label lblLinePJ5Set;
        private System.Windows.Forms.Label lblLineZJ3Set;
        private System.Windows.Forms.Label lblLineXJ1Set;
        private System.Windows.Forms.TextBox tbLineRJ6Set;
        private System.Windows.Forms.TextBox tbLinePJ5Set;
        private System.Windows.Forms.TextBox tbLineWJ4Set;
        private System.Windows.Forms.TextBox tbLineZJ3Set;
        private System.Windows.Forms.TextBox tbLineYJ2Set;
        private System.Windows.Forms.TextBox tbLineXJ1Set;
        private System.Windows.Forms.Label lblPTPCoordinate;
        private System.Windows.Forms.Label lblPTPRJ6Unit;
        private System.Windows.Forms.Label lblPTPPJ5Unit;
        private System.Windows.Forms.Label lblPTPWJ4Unit;
        private System.Windows.Forms.Label lblPTPZJ3Unit;
        private System.Windows.Forms.Label lblPTPYJ2Unit;
        private System.Windows.Forms.Label lblPTPXJ1Unit;
        private System.Windows.Forms.Label lblLineVelocityUnit;
        private System.Windows.Forms.Label lblLineRJ6Unit;
        private System.Windows.Forms.Label lblLinePJ5Unit;
        private System.Windows.Forms.Label lblLineWJ4Unit;
        private System.Windows.Forms.Label lblLineZJ3Unit;
        private System.Windows.Forms.Label lblLineYJ2Unit;
        private System.Windows.Forms.Label lblLineXJ1Unit;
        private System.Windows.Forms.Label lblLineVelocityRange;
    }
}

