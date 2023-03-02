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
            this.lblRange = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblJoint = new System.Windows.Forms.Label();
            this.lblXyzwpr = new System.Windows.Forms.Label();
            this.btnPositionHome = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbOverride = new System.Windows.Forms.GroupBox();
            this.btnPercentdown = new System.Windows.Forms.Button();
            this.btnPercentup = new System.Windows.Forms.Button();
            this.lblOverride = new System.Windows.Forms.Label();
            this.gbPTP = new System.Windows.Forms.GroupBox();
            this.lblPTPRJ6Unit = new System.Windows.Forms.Label();
            this.lblPTPPJ5Unit = new System.Windows.Forms.Label();
            this.lblPTPWJ4Unit = new System.Windows.Forms.Label();
            this.lblPTPZJ3Unit = new System.Windows.Forms.Label();
            this.lblPTPYJ2Unit = new System.Windows.Forms.Label();
            this.lblPTPXJ1Unit = new System.Windows.Forms.Label();
            this.lblPTPCoordinate = new System.Windows.Forms.Label();
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
            this.gbJog = new System.Windows.Forms.GroupBox();
            this.cboLineCoordinate = new System.Windows.Forms.ComboBox();
            this.lblLineCoordinate = new System.Windows.Forms.Label();
            this.cboJogStep = new System.Windows.Forms.ComboBox();
            this.lblJogStep = new System.Windows.Forms.Label();
            this.btnJogRJ6Positive = new System.Windows.Forms.Button();
            this.btnJogRJ6Negative = new System.Windows.Forms.Button();
            this.btnJogPJ5Positive = new System.Windows.Forms.Button();
            this.btnJogPJ5Negative = new System.Windows.Forms.Button();
            this.btnJogWJ4Positive = new System.Windows.Forms.Button();
            this.btnJogWJ4Negative = new System.Windows.Forms.Button();
            this.btnJogZJ3Positive = new System.Windows.Forms.Button();
            this.btnJogZJ3Negative = new System.Windows.Forms.Button();
            this.btnJogYJ2Positive = new System.Windows.Forms.Button();
            this.btnJogYJ2Negative = new System.Windows.Forms.Button();
            this.btnJogXJ1Positive = new System.Windows.Forms.Button();
            this.btnJogXJ1Negative = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnHold = new System.Windows.Forms.Button();
            this.gbLine = new System.Windows.Forms.GroupBox();
            this.lblLineVelocityRange = new System.Windows.Forms.Label();
            this.lblLineVelocityUnit = new System.Windows.Forms.Label();
            this.lblLineRJ6Unit = new System.Windows.Forms.Label();
            this.tbLineVelocitySet = new System.Windows.Forms.TextBox();
            this.lblLinePJ5Unit = new System.Windows.Forms.Label();
            this.lblLineVelocitySet = new System.Windows.Forms.Label();
            this.lblLineWJ4Unit = new System.Windows.Forms.Label();
            this.btnLineSet = new System.Windows.Forms.Button();
            this.lblLineZJ3Unit = new System.Windows.Forms.Label();
            this.btnLineCopy = new System.Windows.Forms.Button();
            this.lblLineYJ2Unit = new System.Windows.Forms.Label();
            this.lblLineXJ1Unit = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.gbConnection.SuspendLayout();
            this.gbCurrentState.SuspendLayout();
            this.gbOverride.SuspendLayout();
            this.gbPTP.SuspendLayout();
            this.gbRegister.SuspendLayout();
            this.gbJog.SuspendLayout();
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
            this.btnEsc.Location = new System.Drawing.Point(926, 12);
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
            this.gbCurrentState.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbCurrentState.Location = new System.Drawing.Point(132, 146);
            this.gbCurrentState.Name = "gbCurrentState";
            this.gbCurrentState.Size = new System.Drawing.Size(279, 353);
            this.gbCurrentState.TabIndex = 4;
            this.gbCurrentState.TabStop = false;
            this.gbCurrentState.Text = "Current State";
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
            // btnPositionHome
            // 
            this.btnPositionHome.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPositionHome.Location = new System.Drawing.Point(6, 285);
            this.btnPositionHome.Name = "btnPositionHome";
            this.btnPositionHome.Size = new System.Drawing.Size(100, 42);
            this.btnPositionHome.TabIndex = 15;
            this.btnPositionHome.Text = "Home";
            this.btnPositionHome.UseVisualStyleBackColor = true;
            this.btnPositionHome.Click += new System.EventHandler(this.btnPositionHome_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(6, 137);
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
            // btnPercentdown
            // 
            this.btnPercentdown.Location = new System.Drawing.Point(6, 74);
            this.btnPercentdown.Name = "btnPercentdown";
            this.btnPercentdown.Size = new System.Drawing.Size(45, 45);
            this.btnPercentdown.TabIndex = 2;
            this.btnPercentdown.Text = "-%";
            this.btnPercentdown.UseVisualStyleBackColor = true;
            this.btnPercentdown.Click += new System.EventHandler(this.btnPercentdown_Click);
            // 
            // btnPercentup
            // 
            this.btnPercentup.Location = new System.Drawing.Point(59, 74);
            this.btnPercentup.Name = "btnPercentup";
            this.btnPercentup.Size = new System.Drawing.Size(45, 45);
            this.btnPercentup.TabIndex = 1;
            this.btnPercentup.Text = "+%";
            this.btnPercentup.UseVisualStyleBackColor = true;
            this.btnPercentup.Click += new System.EventHandler(this.btnPercentup_Click);
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
            this.gbPTP.Location = new System.Drawing.Point(417, 146);
            this.gbPTP.Name = "gbPTP";
            this.gbPTP.Size = new System.Drawing.Size(216, 353);
            this.gbPTP.TabIndex = 6;
            this.gbPTP.TabStop = false;
            this.gbPTP.Text = "PTP";
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
            // lblPTPPJ5Unit
            // 
            this.lblPTPPJ5Unit.AutoSize = true;
            this.lblPTPPJ5Unit.Location = new System.Drawing.Point(166, 178);
            this.lblPTPPJ5Unit.Name = "lblPTPPJ5Unit";
            this.lblPTPPJ5Unit.Size = new System.Drawing.Size(39, 21);
            this.lblPTPPJ5Unit.TabIndex = 23;
            this.lblPTPPJ5Unit.Text = "deg";
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
            // lblPTPZJ3Unit
            // 
            this.lblPTPZJ3Unit.AutoSize = true;
            this.lblPTPZJ3Unit.Location = new System.Drawing.Point(165, 120);
            this.lblPTPZJ3Unit.Name = "lblPTPZJ3Unit";
            this.lblPTPZJ3Unit.Size = new System.Drawing.Size(40, 21);
            this.lblPTPZJ3Unit.TabIndex = 21;
            this.lblPTPZJ3Unit.Text = "mm";
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
            // lblPTPXJ1Unit
            // 
            this.lblPTPXJ1Unit.AutoSize = true;
            this.lblPTPXJ1Unit.Location = new System.Drawing.Point(165, 62);
            this.lblPTPXJ1Unit.Name = "lblPTPXJ1Unit";
            this.lblPTPXJ1Unit.Size = new System.Drawing.Size(40, 21);
            this.lblPTPXJ1Unit.TabIndex = 19;
            this.lblPTPXJ1Unit.Text = "mm";
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
            // btnPTPSet
            // 
            this.btnPTPSet.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPTPSet.Location = new System.Drawing.Point(111, 236);
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
            this.btnPTPCopy.Location = new System.Drawing.Point(10, 236);
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
            this.gbRegister.Location = new System.Drawing.Point(1087, 146);
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
            // gbJog
            // 
            this.gbJog.Controls.Add(this.cboLineCoordinate);
            this.gbJog.Controls.Add(this.lblLineCoordinate);
            this.gbJog.Controls.Add(this.cboJogStep);
            this.gbJog.Controls.Add(this.lblJogStep);
            this.gbJog.Controls.Add(this.btnJogRJ6Positive);
            this.gbJog.Controls.Add(this.btnJogRJ6Negative);
            this.gbJog.Controls.Add(this.btnJogPJ5Positive);
            this.gbJog.Controls.Add(this.btnJogPJ5Negative);
            this.gbJog.Controls.Add(this.btnJogWJ4Positive);
            this.gbJog.Controls.Add(this.btnJogWJ4Negative);
            this.gbJog.Controls.Add(this.btnJogZJ3Positive);
            this.gbJog.Controls.Add(this.btnJogZJ3Negative);
            this.gbJog.Controls.Add(this.btnJogYJ2Positive);
            this.gbJog.Controls.Add(this.btnJogYJ2Negative);
            this.gbJog.Controls.Add(this.btnJogXJ1Positive);
            this.gbJog.Controls.Add(this.btnJogXJ1Negative);
            this.gbJog.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbJog.Location = new System.Drawing.Point(642, 146);
            this.gbJog.Name = "gbJog";
            this.gbJog.Size = new System.Drawing.Size(216, 353);
            this.gbJog.TabIndex = 8;
            this.gbJog.TabStop = false;
            this.gbJog.Text = "Jog";
            // 
            // cboLineCoordinate
            // 
            this.cboLineCoordinate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLineCoordinate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboLineCoordinate.FormattingEnabled = true;
            this.cboLineCoordinate.Location = new System.Drawing.Point(120, 29);
            this.cboLineCoordinate.Name = "cboLineCoordinate";
            this.cboLineCoordinate.Size = new System.Drawing.Size(85, 24);
            this.cboLineCoordinate.TabIndex = 25;
            this.cboLineCoordinate.SelectedIndexChanged += new System.EventHandler(this.cboLineCoordinate_SelectedIndexChanged);
            // 
            // lblLineCoordinate
            // 
            this.lblLineCoordinate.AutoSize = true;
            this.lblLineCoordinate.Location = new System.Drawing.Point(6, 29);
            this.lblLineCoordinate.Name = "lblLineCoordinate";
            this.lblLineCoordinate.Size = new System.Drawing.Size(108, 21);
            this.lblLineCoordinate.TabIndex = 25;
            this.lblLineCoordinate.Text = "Coordinate :";
            // 
            // cboJogStep
            // 
            this.cboJogStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJogStep.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboJogStep.FormattingEnabled = true;
            this.cboJogStep.Location = new System.Drawing.Point(67, 59);
            this.cboJogStep.Name = "cboJogStep";
            this.cboJogStep.Size = new System.Drawing.Size(138, 24);
            this.cboJogStep.TabIndex = 13;
            this.cboJogStep.SelectedIndexChanged += new System.EventHandler(this.cboStep_SelectedIndexChanged);
            // 
            // lblJogStep
            // 
            this.lblJogStep.AutoSize = true;
            this.lblJogStep.Location = new System.Drawing.Point(6, 58);
            this.lblJogStep.Name = "lblJogStep";
            this.lblJogStep.Size = new System.Drawing.Size(55, 21);
            this.lblJogStep.TabIndex = 12;
            this.lblJogStep.Text = "Step :";
            // 
            // btnJogRJ6Positive
            // 
            this.btnJogRJ6Positive.Location = new System.Drawing.Point(110, 269);
            this.btnJogRJ6Positive.Name = "btnJogRJ6Positive";
            this.btnJogRJ6Positive.Size = new System.Drawing.Size(95, 30);
            this.btnJogRJ6Positive.TabIndex = 11;
            this.btnJogRJ6Positive.Tag = "10";
            this.btnJogRJ6Positive.Text = "+R";
            this.btnJogRJ6Positive.UseVisualStyleBackColor = true;
            this.btnJogRJ6Positive.Click += new System.EventHandler(this.btnJogXJ1Positive_Click);
            this.btnJogRJ6Positive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogXJ1Positive_MouseDown);
            this.btnJogRJ6Positive.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogXJ1Positive_MouseUp);
            // 
            // btnJogRJ6Negative
            // 
            this.btnJogRJ6Negative.Location = new System.Drawing.Point(10, 269);
            this.btnJogRJ6Negative.Name = "btnJogRJ6Negative";
            this.btnJogRJ6Negative.Size = new System.Drawing.Size(94, 30);
            this.btnJogRJ6Negative.TabIndex = 10;
            this.btnJogRJ6Negative.Tag = "11";
            this.btnJogRJ6Negative.Text = "-R";
            this.btnJogRJ6Negative.UseVisualStyleBackColor = true;
            this.btnJogRJ6Negative.Click += new System.EventHandler(this.btnJogXJ1Positive_Click);
            this.btnJogRJ6Negative.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogXJ1Positive_MouseDown);
            this.btnJogRJ6Negative.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogXJ1Positive_MouseUp);
            // 
            // btnJogPJ5Positive
            // 
            this.btnJogPJ5Positive.Location = new System.Drawing.Point(110, 233);
            this.btnJogPJ5Positive.Name = "btnJogPJ5Positive";
            this.btnJogPJ5Positive.Size = new System.Drawing.Size(95, 30);
            this.btnJogPJ5Positive.TabIndex = 9;
            this.btnJogPJ5Positive.Tag = "8";
            this.btnJogPJ5Positive.Text = "+P";
            this.btnJogPJ5Positive.UseVisualStyleBackColor = true;
            this.btnJogPJ5Positive.Click += new System.EventHandler(this.btnJogXJ1Positive_Click);
            this.btnJogPJ5Positive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogXJ1Positive_MouseDown);
            this.btnJogPJ5Positive.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogXJ1Positive_MouseUp);
            // 
            // btnJogPJ5Negative
            // 
            this.btnJogPJ5Negative.Location = new System.Drawing.Point(10, 233);
            this.btnJogPJ5Negative.Name = "btnJogPJ5Negative";
            this.btnJogPJ5Negative.Size = new System.Drawing.Size(94, 30);
            this.btnJogPJ5Negative.TabIndex = 8;
            this.btnJogPJ5Negative.Tag = "9";
            this.btnJogPJ5Negative.Text = "-P";
            this.btnJogPJ5Negative.UseVisualStyleBackColor = true;
            this.btnJogPJ5Negative.Click += new System.EventHandler(this.btnJogXJ1Positive_Click);
            this.btnJogPJ5Negative.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogXJ1Positive_MouseDown);
            this.btnJogPJ5Negative.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogXJ1Positive_MouseUp);
            // 
            // btnJogWJ4Positive
            // 
            this.btnJogWJ4Positive.Location = new System.Drawing.Point(110, 197);
            this.btnJogWJ4Positive.Name = "btnJogWJ4Positive";
            this.btnJogWJ4Positive.Size = new System.Drawing.Size(95, 30);
            this.btnJogWJ4Positive.TabIndex = 7;
            this.btnJogWJ4Positive.Tag = "6";
            this.btnJogWJ4Positive.Text = "+W";
            this.btnJogWJ4Positive.UseVisualStyleBackColor = true;
            this.btnJogWJ4Positive.Click += new System.EventHandler(this.btnJogXJ1Positive_Click);
            this.btnJogWJ4Positive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogXJ1Positive_MouseDown);
            this.btnJogWJ4Positive.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogXJ1Positive_MouseUp);
            // 
            // btnJogWJ4Negative
            // 
            this.btnJogWJ4Negative.Location = new System.Drawing.Point(10, 197);
            this.btnJogWJ4Negative.Name = "btnJogWJ4Negative";
            this.btnJogWJ4Negative.Size = new System.Drawing.Size(94, 30);
            this.btnJogWJ4Negative.TabIndex = 6;
            this.btnJogWJ4Negative.Tag = "7";
            this.btnJogWJ4Negative.Text = "-W";
            this.btnJogWJ4Negative.UseVisualStyleBackColor = true;
            this.btnJogWJ4Negative.Click += new System.EventHandler(this.btnJogXJ1Positive_Click);
            this.btnJogWJ4Negative.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogXJ1Positive_MouseDown);
            this.btnJogWJ4Negative.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogXJ1Positive_MouseUp);
            // 
            // btnJogZJ3Positive
            // 
            this.btnJogZJ3Positive.Location = new System.Drawing.Point(111, 161);
            this.btnJogZJ3Positive.Name = "btnJogZJ3Positive";
            this.btnJogZJ3Positive.Size = new System.Drawing.Size(94, 30);
            this.btnJogZJ3Positive.TabIndex = 5;
            this.btnJogZJ3Positive.Tag = "4";
            this.btnJogZJ3Positive.Text = "+Z";
            this.btnJogZJ3Positive.UseVisualStyleBackColor = true;
            this.btnJogZJ3Positive.Click += new System.EventHandler(this.btnJogXJ1Positive_Click);
            this.btnJogZJ3Positive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogXJ1Positive_MouseDown);
            this.btnJogZJ3Positive.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogXJ1Positive_MouseUp);
            // 
            // btnJogZJ3Negative
            // 
            this.btnJogZJ3Negative.Location = new System.Drawing.Point(10, 161);
            this.btnJogZJ3Negative.Name = "btnJogZJ3Negative";
            this.btnJogZJ3Negative.Size = new System.Drawing.Size(94, 30);
            this.btnJogZJ3Negative.TabIndex = 4;
            this.btnJogZJ3Negative.Tag = "5";
            this.btnJogZJ3Negative.Text = "-Z";
            this.btnJogZJ3Negative.UseVisualStyleBackColor = true;
            this.btnJogZJ3Negative.Click += new System.EventHandler(this.btnJogXJ1Positive_Click);
            this.btnJogZJ3Negative.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogXJ1Positive_MouseDown);
            this.btnJogZJ3Negative.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogXJ1Positive_MouseUp);
            // 
            // btnJogYJ2Positive
            // 
            this.btnJogYJ2Positive.Location = new System.Drawing.Point(110, 125);
            this.btnJogYJ2Positive.Name = "btnJogYJ2Positive";
            this.btnJogYJ2Positive.Size = new System.Drawing.Size(95, 30);
            this.btnJogYJ2Positive.TabIndex = 3;
            this.btnJogYJ2Positive.Tag = "2";
            this.btnJogYJ2Positive.Text = "+Y";
            this.btnJogYJ2Positive.UseVisualStyleBackColor = true;
            this.btnJogYJ2Positive.Click += new System.EventHandler(this.btnJogXJ1Positive_Click);
            this.btnJogYJ2Positive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogXJ1Positive_MouseDown);
            this.btnJogYJ2Positive.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogXJ1Positive_MouseUp);
            // 
            // btnJogYJ2Negative
            // 
            this.btnJogYJ2Negative.Location = new System.Drawing.Point(10, 125);
            this.btnJogYJ2Negative.Name = "btnJogYJ2Negative";
            this.btnJogYJ2Negative.Size = new System.Drawing.Size(94, 30);
            this.btnJogYJ2Negative.TabIndex = 2;
            this.btnJogYJ2Negative.Tag = "3";
            this.btnJogYJ2Negative.Text = "-Y";
            this.btnJogYJ2Negative.UseVisualStyleBackColor = true;
            this.btnJogYJ2Negative.Click += new System.EventHandler(this.btnJogXJ1Positive_Click);
            this.btnJogYJ2Negative.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogXJ1Positive_MouseDown);
            this.btnJogYJ2Negative.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogXJ1Positive_MouseUp);
            // 
            // btnJogXJ1Positive
            // 
            this.btnJogXJ1Positive.Location = new System.Drawing.Point(111, 89);
            this.btnJogXJ1Positive.Name = "btnJogXJ1Positive";
            this.btnJogXJ1Positive.Size = new System.Drawing.Size(94, 30);
            this.btnJogXJ1Positive.TabIndex = 1;
            this.btnJogXJ1Positive.Tag = "0";
            this.btnJogXJ1Positive.Text = "+X";
            this.btnJogXJ1Positive.UseVisualStyleBackColor = true;
            this.btnJogXJ1Positive.Click += new System.EventHandler(this.btnJogXJ1Positive_Click);
            this.btnJogXJ1Positive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogXJ1Positive_MouseDown);
            this.btnJogXJ1Positive.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogXJ1Positive_MouseUp);
            // 
            // btnJogXJ1Negative
            // 
            this.btnJogXJ1Negative.Location = new System.Drawing.Point(10, 89);
            this.btnJogXJ1Negative.Name = "btnJogXJ1Negative";
            this.btnJogXJ1Negative.Size = new System.Drawing.Size(94, 30);
            this.btnJogXJ1Negative.TabIndex = 0;
            this.btnJogXJ1Negative.Tag = "1";
            this.btnJogXJ1Negative.Text = "-X";
            this.btnJogXJ1Negative.UseVisualStyleBackColor = true;
            this.btnJogXJ1Negative.Click += new System.EventHandler(this.btnJogXJ1Positive_Click);
            this.btnJogXJ1Negative.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogXJ1Positive_MouseDown);
            this.btnJogXJ1Negative.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogXJ1Positive_MouseUp);
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(6, 83);
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
            // gbControl
            // 
            this.gbControl.Controls.Add(this.btnStop);
            this.gbControl.Controls.Add(this.btnHold);
            this.gbControl.Controls.Add(this.btnReset);
            this.gbControl.Controls.Add(this.btnDisable);
            this.gbControl.Controls.Add(this.btnPositionHome);
            this.gbControl.Controls.Add(this.btnEnable);
            this.gbControl.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbControl.Location = new System.Drawing.Point(12, 146);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(114, 353);
            this.gbControl.TabIndex = 9;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Control";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(6, 237);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 42);
            this.btnStop.TabIndex = 17;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnHold
            // 
            this.btnHold.Location = new System.Drawing.Point(6, 188);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(100, 43);
            this.btnHold.TabIndex = 16;
            this.btnHold.Text = "Hold";
            this.btnHold.UseVisualStyleBackColor = true;
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
            this.gbLine.Controls.Add(this.btnLineSet);
            this.gbLine.Controls.Add(this.lblLineZJ3Unit);
            this.gbLine.Controls.Add(this.btnLineCopy);
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
            this.gbLine.Location = new System.Drawing.Point(866, 146);
            this.gbLine.Name = "gbLine";
            this.gbLine.Size = new System.Drawing.Size(215, 353);
            this.gbLine.TabIndex = 18;
            this.gbLine.TabStop = false;
            this.gbLine.Text = "Line";
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
            // lblLineVelocityUnit
            // 
            this.lblLineVelocityUnit.AutoSize = true;
            this.lblLineVelocityUnit.Location = new System.Drawing.Point(133, 203);
            this.lblLineVelocityUnit.Name = "lblLineVelocityUnit";
            this.lblLineVelocityUnit.Size = new System.Drawing.Size(71, 21);
            this.lblLineVelocityUnit.TabIndex = 31;
            this.lblLineVelocityUnit.Text = "unit/sec";
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
            // lblLinePJ5Unit
            // 
            this.lblLinePJ5Unit.AutoSize = true;
            this.lblLinePJ5Unit.Location = new System.Drawing.Point(165, 145);
            this.lblLinePJ5Unit.Name = "lblLinePJ5Unit";
            this.lblLinePJ5Unit.Size = new System.Drawing.Size(39, 21);
            this.lblLinePJ5Unit.TabIndex = 29;
            this.lblLinePJ5Unit.Text = "deg";
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
            // lblLineWJ4Unit
            // 
            this.lblLineWJ4Unit.AutoSize = true;
            this.lblLineWJ4Unit.Location = new System.Drawing.Point(165, 116);
            this.lblLineWJ4Unit.Name = "lblLineWJ4Unit";
            this.lblLineWJ4Unit.Size = new System.Drawing.Size(39, 21);
            this.lblLineWJ4Unit.TabIndex = 28;
            this.lblLineWJ4Unit.Text = "deg";
            // 
            // btnLineSet
            // 
            this.btnLineSet.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLineSet.Location = new System.Drawing.Point(110, 253);
            this.btnLineSet.Name = "btnLineSet";
            this.btnLineSet.Size = new System.Drawing.Size(94, 50);
            this.btnLineSet.TabIndex = 14;
            this.btnLineSet.Text = "Set";
            this.btnLineSet.UseVisualStyleBackColor = true;
            this.btnLineSet.Click += new System.EventHandler(this.btnLineSet_Click);
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
            // btnLineCopy
            // 
            this.btnLineCopy.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLineCopy.Location = new System.Drawing.Point(10, 253);
            this.btnLineCopy.Name = "btnLineCopy";
            this.btnLineCopy.Size = new System.Drawing.Size(94, 50);
            this.btnLineCopy.TabIndex = 13;
            this.btnLineCopy.Text = "Copy";
            this.btnLineCopy.UseVisualStyleBackColor = true;
            this.btnLineCopy.Click += new System.EventHandler(this.btnLineCopy_Click);
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 541);
            this.Controls.Add(this.gbLine);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.gbJog);
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
            this.Text = "FrmMain";
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
            this.gbJog.ResumeLayout(false);
            this.gbJog.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbJog;
        private System.Windows.Forms.Button btnJogRJ6Positive;
        private System.Windows.Forms.Button btnJogRJ6Negative;
        private System.Windows.Forms.Button btnJogPJ5Positive;
        private System.Windows.Forms.Button btnJogPJ5Negative;
        private System.Windows.Forms.Button btnJogWJ4Positive;
        private System.Windows.Forms.Button btnJogWJ4Negative;
        private System.Windows.Forms.Button btnJogZJ3Positive;
        private System.Windows.Forms.Button btnJogZJ3Negative;
        private System.Windows.Forms.Button btnJogYJ2Positive;
        private System.Windows.Forms.Button btnJogYJ2Negative;
        private System.Windows.Forms.Button btnJogXJ1Positive;
        private System.Windows.Forms.Button btnJogXJ1Negative;
        private System.Windows.Forms.ComboBox cboJogStep;
        private System.Windows.Forms.Label lblJogStep;
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
        private System.Windows.Forms.Button btnLineSet;
        private System.Windows.Forms.Button btnLineCopy;
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
        private System.Windows.Forms.ComboBox cboLineCoordinate;
        private System.Windows.Forms.Label lblLineCoordinate;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnHold;
    }
}

