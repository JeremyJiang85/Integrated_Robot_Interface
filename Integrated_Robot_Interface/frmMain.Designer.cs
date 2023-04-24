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
            this.btnPositionHome = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbOverride = new System.Windows.Forms.GroupBox();
            this.btnPercentdown = new System.Windows.Forms.Button();
            this.btnPercentup = new System.Windows.Forms.Button();
            this.lblOverride = new System.Windows.Forms.Label();
            this.gbPointMove = new System.Windows.Forms.GroupBox();
            this.lblPTPRJ6Unit = new System.Windows.Forms.Label();
            this.lblPTPPJ5Unit = new System.Windows.Forms.Label();
            this.lblPTPWJ4Unit = new System.Windows.Forms.Label();
            this.lblPTPZJ3Unit = new System.Windows.Forms.Label();
            this.lblPTPYJ2Unit = new System.Windows.Forms.Label();
            this.lblPTPXJ1Unit = new System.Windows.Forms.Label();
            this.lblPTPCoordinate = new System.Windows.Forms.Label();
            this.btnPTPSet = new System.Windows.Forms.Button();
            this.btnPTPCopy = new System.Windows.Forms.Button();
            this.lblPTPYJ2 = new System.Windows.Forms.Label();
            this.lblPTPRJ6 = new System.Windows.Forms.Label();
            this.lblPTPWJ4 = new System.Windows.Forms.Label();
            this.lblPTPPJ5 = new System.Windows.Forms.Label();
            this.lblPTPZJ3 = new System.Windows.Forms.Label();
            this.lblPTPXJ1 = new System.Windows.Forms.Label();
            this.txtPTPRJ6 = new System.Windows.Forms.TextBox();
            this.txtPTPPJ5 = new System.Windows.Forms.TextBox();
            this.txtPTPWJ4 = new System.Windows.Forms.TextBox();
            this.txtPTPZJ3 = new System.Windows.Forms.TextBox();
            this.txtPTPYJ2 = new System.Windows.Forms.TextBox();
            this.txtPTPXJ1 = new System.Windows.Forms.TextBox();
            this.cboPTPCoordinate = new System.Windows.Forms.ComboBox();
            this.gbRegister = new System.Windows.Forms.GroupBox();
            this.btnRegisterSet = new System.Windows.Forms.Button();
            this.txtR5 = new System.Windows.Forms.TextBox();
            this.txtR4 = new System.Windows.Forms.TextBox();
            this.txtR3 = new System.Windows.Forms.TextBox();
            this.txtR2 = new System.Windows.Forms.TextBox();
            this.lblR5 = new System.Windows.Forms.Label();
            this.txtR1 = new System.Windows.Forms.TextBox();
            this.lblR4 = new System.Windows.Forms.Label();
            this.lblR3 = new System.Windows.Forms.Label();
            this.lblR1 = new System.Windows.Forms.Label();
            this.lblR2 = new System.Windows.Forms.Label();
            this.gbJogMove = new System.Windows.Forms.GroupBox();
            this.cboJogCoordinate = new System.Windows.Forms.ComboBox();
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
            this.btnInformation = new System.Windows.Forms.Button();
            this.gbLineMove = new System.Windows.Forms.GroupBox();
            this.lblLineVelocityUnit = new System.Windows.Forms.Label();
            this.lblLineRJ6Unit = new System.Windows.Forms.Label();
            this.txtLineVelocity = new System.Windows.Forms.TextBox();
            this.lblLinePJ5Unit = new System.Windows.Forms.Label();
            this.lblLineVelocity = new System.Windows.Forms.Label();
            this.lblLineWJ4Unit = new System.Windows.Forms.Label();
            this.btnLineSet = new System.Windows.Forms.Button();
            this.lblLineZJ3Unit = new System.Windows.Forms.Label();
            this.btnLineCopy = new System.Windows.Forms.Button();
            this.lblLineYJ2Unit = new System.Windows.Forms.Label();
            this.lblLineXJ1Unit = new System.Windows.Forms.Label();
            this.lblLineYJ2 = new System.Windows.Forms.Label();
            this.lblLineRJ6 = new System.Windows.Forms.Label();
            this.lblLineWJ4 = new System.Windows.Forms.Label();
            this.lblLinePJ5 = new System.Windows.Forms.Label();
            this.lblLineZJ3 = new System.Windows.Forms.Label();
            this.lblLineXJ1 = new System.Windows.Forms.Label();
            this.txtLineRJ6 = new System.Windows.Forms.TextBox();
            this.txtLinePJ5 = new System.Windows.Forms.TextBox();
            this.txtLineWJ4 = new System.Windows.Forms.TextBox();
            this.txtLineZJ3 = new System.Windows.Forms.TextBox();
            this.txtLineYJ2 = new System.Windows.Forms.TextBox();
            this.txtLineXJ1 = new System.Windows.Forms.TextBox();
            this.gbSafeRange = new System.Windows.Forms.GroupBox();
            this.txtSafeRangeVelocitymax = new System.Windows.Forms.TextBox();
            this.txtSafeRangeVelocitymin = new System.Windows.Forms.TextBox();
            this.lblSafeRangeVelocity = new System.Windows.Forms.Label();
            this.cboSafeRangeCoordinate = new System.Windows.Forms.ComboBox();
            this.lblSafeRangeCoordinate = new System.Windows.Forms.Label();
            this.txtSafeRangeRJ6max = new System.Windows.Forms.TextBox();
            this.txtSafeRangePJ5max = new System.Windows.Forms.TextBox();
            this.txtSafeRangeWJ4max = new System.Windows.Forms.TextBox();
            this.txtSafeRangeRJ6min = new System.Windows.Forms.TextBox();
            this.lblSafeRangeRJ6 = new System.Windows.Forms.Label();
            this.txtSafeRangeWJ4min = new System.Windows.Forms.TextBox();
            this.lblSafeRangeWJ4 = new System.Windows.Forms.Label();
            this.txtSafeRangePJ5min = new System.Windows.Forms.TextBox();
            this.lblSafeRangePJ5 = new System.Windows.Forms.Label();
            this.txtSafeRangeZJ3max = new System.Windows.Forms.TextBox();
            this.txtSafeRangeYJ2max = new System.Windows.Forms.TextBox();
            this.txtSafeRangeXJ1max = new System.Windows.Forms.TextBox();
            this.txtSafeRangeZJ3min = new System.Windows.Forms.TextBox();
            this.lblSafeRangeZJ3 = new System.Windows.Forms.Label();
            this.txtSafeRangeXJ1min = new System.Windows.Forms.TextBox();
            this.lblSafeRangeXJ1 = new System.Windows.Forms.Label();
            this.txtSafeRangeYJ2min = new System.Windows.Forms.TextBox();
            this.lblSafeRangeYJ2 = new System.Windows.Forms.Label();
            this.btnSafeRangeSet = new System.Windows.Forms.Button();
            this.gbPoints = new System.Windows.Forms.GroupBox();
            this.btnPointsMoveSet = new System.Windows.Forms.Button();
            this.btnPointsMoveLoad = new System.Windows.Forms.Button();
            this.btnPointsMoveCopy = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbProgram = new System.Windows.Forms.GroupBox();
            this.lblProgramValue = new System.Windows.Forms.Label();
            this.txtProgramValue = new System.Windows.Forms.TextBox();
            this.lblProgramUnit = new System.Windows.Forms.Label();
            this.lblProgramInstruction = new System.Windows.Forms.Label();
            this.cboProgramCoordinate = new System.Windows.Forms.ComboBox();
            this.lblProgramCoordinate = new System.Windows.Forms.Label();
            this.btnProgramCopy = new System.Windows.Forms.Button();
            this.btnProgramCompile = new System.Windows.Forms.Button();
            this.btnProgramClear = new System.Windows.Forms.Button();
            this.btnProgramDelete = new System.Windows.Forms.Button();
            this.btnProgramEdit = new System.Windows.Forms.Button();
            this.btnProgramInsert = new System.Windows.Forms.Button();
            this.btnProgramAdd = new System.Windows.Forms.Button();
            this.txtProgramVelocity = new System.Windows.Forms.TextBox();
            this.lblProgramVelocity = new System.Windows.Forms.Label();
            this.cboProgramInstruction = new System.Windows.Forms.ComboBox();
            this.lblProgramYJ2 = new System.Windows.Forms.Label();
            this.txtProgramName = new System.Windows.Forms.TextBox();
            this.lblProgramRJ6 = new System.Windows.Forms.Label();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.lblProgramWJ4 = new System.Windows.Forms.Label();
            this.lstProgram = new System.Windows.Forms.ListBox();
            this.lblProgramPJ5 = new System.Windows.Forms.Label();
            this.txtProgramXJ1 = new System.Windows.Forms.TextBox();
            this.lblProgramZJ3 = new System.Windows.Forms.Label();
            this.txtProgramYJ2 = new System.Windows.Forms.TextBox();
            this.lblProgramXJ1 = new System.Windows.Forms.Label();
            this.txtProgramZJ3 = new System.Windows.Forms.TextBox();
            this.txtProgramRJ6 = new System.Windows.Forms.TextBox();
            this.txtProgramWJ4 = new System.Windows.Forms.TextBox();
            this.txtProgramPJ5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.gbConnection.SuspendLayout();
            this.gbCurrentPosition.SuspendLayout();
            this.gbOverride.SuspendLayout();
            this.gbPointMove.SuspendLayout();
            this.gbRegister.SuspendLayout();
            this.gbJogMove.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.gbLineMove.SuspendLayout();
            this.gbSafeRange.SuspendLayout();
            this.gbPoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbProgram.SuspendLayout();
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
            this.btnEsc.Size = new System.Drawing.Size(100, 52);
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
            // gbCurrentPosition
            // 
            this.gbCurrentPosition.Controls.Add(this.lblJoint);
            this.gbCurrentPosition.Controls.Add(this.lblXyzwpr);
            this.gbCurrentPosition.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbCurrentPosition.Location = new System.Drawing.Point(132, 146);
            this.gbCurrentPosition.Name = "gbCurrentPosition";
            this.gbCurrentPosition.Size = new System.Drawing.Size(279, 185);
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
            // gbPointMove
            // 
            this.gbPointMove.Controls.Add(this.lblPTPRJ6Unit);
            this.gbPointMove.Controls.Add(this.lblPTPPJ5Unit);
            this.gbPointMove.Controls.Add(this.lblPTPWJ4Unit);
            this.gbPointMove.Controls.Add(this.lblPTPZJ3Unit);
            this.gbPointMove.Controls.Add(this.lblPTPYJ2Unit);
            this.gbPointMove.Controls.Add(this.lblPTPXJ1Unit);
            this.gbPointMove.Controls.Add(this.lblPTPCoordinate);
            this.gbPointMove.Controls.Add(this.btnPTPSet);
            this.gbPointMove.Controls.Add(this.btnPTPCopy);
            this.gbPointMove.Controls.Add(this.lblPTPYJ2);
            this.gbPointMove.Controls.Add(this.lblPTPRJ6);
            this.gbPointMove.Controls.Add(this.lblPTPWJ4);
            this.gbPointMove.Controls.Add(this.lblPTPPJ5);
            this.gbPointMove.Controls.Add(this.lblPTPZJ3);
            this.gbPointMove.Controls.Add(this.lblPTPXJ1);
            this.gbPointMove.Controls.Add(this.txtPTPRJ6);
            this.gbPointMove.Controls.Add(this.txtPTPPJ5);
            this.gbPointMove.Controls.Add(this.txtPTPWJ4);
            this.gbPointMove.Controls.Add(this.txtPTPZJ3);
            this.gbPointMove.Controls.Add(this.txtPTPYJ2);
            this.gbPointMove.Controls.Add(this.txtPTPXJ1);
            this.gbPointMove.Controls.Add(this.cboPTPCoordinate);
            this.gbPointMove.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbPointMove.Location = new System.Drawing.Point(417, 146);
            this.gbPointMove.Name = "gbPointMove";
            this.gbPointMove.Size = new System.Drawing.Size(216, 353);
            this.gbPointMove.TabIndex = 6;
            this.gbPointMove.TabStop = false;
            this.gbPointMove.Text = "Point Move";
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
            this.btnPTPSet.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPTPSet.Location = new System.Drawing.Point(111, 237);
            this.btnPTPSet.Name = "btnPTPSet";
            this.btnPTPSet.Size = new System.Drawing.Size(94, 50);
            this.btnPTPSet.TabIndex = 14;
            this.btnPTPSet.Text = "Set";
            this.btnPTPSet.UseVisualStyleBackColor = true;
            this.btnPTPSet.Click += new System.EventHandler(this.btnPTPSet_Click);
            // 
            // btnPTPCopy
            // 
            this.btnPTPCopy.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPTPCopy.Location = new System.Drawing.Point(10, 236);
            this.btnPTPCopy.Name = "btnPTPCopy";
            this.btnPTPCopy.Size = new System.Drawing.Size(95, 50);
            this.btnPTPCopy.TabIndex = 13;
            this.btnPTPCopy.Text = "Copy";
            this.btnPTPCopy.UseVisualStyleBackColor = true;
            this.btnPTPCopy.Click += new System.EventHandler(this.btnPTPCopy_Click);
            // 
            // lblPTPYJ2
            // 
            this.lblPTPYJ2.AutoSize = true;
            this.lblPTPYJ2.Location = new System.Drawing.Point(6, 91);
            this.lblPTPYJ2.Name = "lblPTPYJ2";
            this.lblPTPYJ2.Size = new System.Drawing.Size(34, 21);
            this.lblPTPYJ2.TabIndex = 12;
            this.lblPTPYJ2.Text = "Y :";
            // 
            // lblPTPRJ6
            // 
            this.lblPTPRJ6.AutoSize = true;
            this.lblPTPRJ6.Location = new System.Drawing.Point(6, 207);
            this.lblPTPRJ6.Name = "lblPTPRJ6";
            this.lblPTPRJ6.Size = new System.Drawing.Size(33, 21);
            this.lblPTPRJ6.TabIndex = 11;
            this.lblPTPRJ6.Text = "R :";
            // 
            // lblPTPWJ4
            // 
            this.lblPTPWJ4.AutoSize = true;
            this.lblPTPWJ4.Location = new System.Drawing.Point(6, 149);
            this.lblPTPWJ4.Name = "lblPTPWJ4";
            this.lblPTPWJ4.Size = new System.Drawing.Size(34, 21);
            this.lblPTPWJ4.TabIndex = 10;
            this.lblPTPWJ4.Text = "W:";
            // 
            // lblPTPPJ5
            // 
            this.lblPTPPJ5.AutoSize = true;
            this.lblPTPPJ5.Location = new System.Drawing.Point(6, 178);
            this.lblPTPPJ5.Name = "lblPTPPJ5";
            this.lblPTPPJ5.Size = new System.Drawing.Size(31, 21);
            this.lblPTPPJ5.TabIndex = 9;
            this.lblPTPPJ5.Text = "P :";
            // 
            // lblPTPZJ3
            // 
            this.lblPTPZJ3.AutoSize = true;
            this.lblPTPZJ3.Location = new System.Drawing.Point(6, 120);
            this.lblPTPZJ3.Name = "lblPTPZJ3";
            this.lblPTPZJ3.Size = new System.Drawing.Size(32, 21);
            this.lblPTPZJ3.TabIndex = 8;
            this.lblPTPZJ3.Text = "Z :";
            // 
            // lblPTPXJ1
            // 
            this.lblPTPXJ1.AutoSize = true;
            this.lblPTPXJ1.Location = new System.Drawing.Point(6, 62);
            this.lblPTPXJ1.Name = "lblPTPXJ1";
            this.lblPTPXJ1.Size = new System.Drawing.Size(34, 21);
            this.lblPTPXJ1.TabIndex = 7;
            this.lblPTPXJ1.Text = "X :";
            // 
            // txtPTPRJ6
            // 
            this.txtPTPRJ6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPTPRJ6.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPTPRJ6.Location = new System.Drawing.Point(46, 207);
            this.txtPTPRJ6.Name = "txtPTPRJ6";
            this.txtPTPRJ6.Size = new System.Drawing.Size(110, 23);
            this.txtPTPRJ6.TabIndex = 6;
            this.txtPTPRJ6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPTPPJ5
            // 
            this.txtPTPPJ5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPTPPJ5.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPTPPJ5.Location = new System.Drawing.Point(46, 178);
            this.txtPTPPJ5.Name = "txtPTPPJ5";
            this.txtPTPPJ5.Size = new System.Drawing.Size(110, 23);
            this.txtPTPPJ5.TabIndex = 5;
            this.txtPTPPJ5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPTPWJ4
            // 
            this.txtPTPWJ4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPTPWJ4.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPTPWJ4.Location = new System.Drawing.Point(46, 149);
            this.txtPTPWJ4.Name = "txtPTPWJ4";
            this.txtPTPWJ4.Size = new System.Drawing.Size(110, 23);
            this.txtPTPWJ4.TabIndex = 4;
            this.txtPTPWJ4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPTPZJ3
            // 
            this.txtPTPZJ3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPTPZJ3.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPTPZJ3.Location = new System.Drawing.Point(46, 120);
            this.txtPTPZJ3.Name = "txtPTPZJ3";
            this.txtPTPZJ3.Size = new System.Drawing.Size(110, 23);
            this.txtPTPZJ3.TabIndex = 3;
            this.txtPTPZJ3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPTPYJ2
            // 
            this.txtPTPYJ2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPTPYJ2.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPTPYJ2.Location = new System.Drawing.Point(46, 91);
            this.txtPTPYJ2.Name = "txtPTPYJ2";
            this.txtPTPYJ2.Size = new System.Drawing.Size(110, 23);
            this.txtPTPYJ2.TabIndex = 2;
            this.txtPTPYJ2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPTPXJ1
            // 
            this.txtPTPXJ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPTPXJ1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPTPXJ1.Location = new System.Drawing.Point(46, 62);
            this.txtPTPXJ1.Name = "txtPTPXJ1";
            this.txtPTPXJ1.Size = new System.Drawing.Size(110, 23);
            this.txtPTPXJ1.TabIndex = 1;
            this.txtPTPXJ1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.gbRegister.Controls.Add(this.txtR5);
            this.gbRegister.Controls.Add(this.txtR4);
            this.gbRegister.Controls.Add(this.txtR3);
            this.gbRegister.Controls.Add(this.txtR2);
            this.gbRegister.Controls.Add(this.lblR5);
            this.gbRegister.Controls.Add(this.txtR1);
            this.gbRegister.Controls.Add(this.lblR4);
            this.gbRegister.Controls.Add(this.lblR3);
            this.gbRegister.Controls.Add(this.lblR1);
            this.gbRegister.Controls.Add(this.lblR2);
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
            this.btnRegisterSet.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRegisterSet.Location = new System.Drawing.Point(10, 174);
            this.btnRegisterSet.Name = "btnRegisterSet";
            this.btnRegisterSet.Size = new System.Drawing.Size(101, 58);
            this.btnRegisterSet.TabIndex = 25;
            this.btnRegisterSet.Text = "Set";
            this.btnRegisterSet.UseVisualStyleBackColor = true;
            this.btnRegisterSet.Click += new System.EventHandler(this.btnRegisterSet_Click);
            // 
            // txtR5
            // 
            this.txtR5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtR5.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtR5.Location = new System.Drawing.Point(61, 145);
            this.txtR5.Name = "txtR5";
            this.txtR5.Size = new System.Drawing.Size(50, 23);
            this.txtR5.TabIndex = 24;
            this.txtR5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtR4
            // 
            this.txtR4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtR4.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtR4.Location = new System.Drawing.Point(61, 116);
            this.txtR4.Name = "txtR4";
            this.txtR4.Size = new System.Drawing.Size(50, 23);
            this.txtR4.TabIndex = 23;
            this.txtR4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtR3
            // 
            this.txtR3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtR3.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtR3.Location = new System.Drawing.Point(61, 87);
            this.txtR3.Name = "txtR3";
            this.txtR3.Size = new System.Drawing.Size(50, 23);
            this.txtR3.TabIndex = 22;
            this.txtR3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtR2
            // 
            this.txtR2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtR2.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtR2.Location = new System.Drawing.Point(61, 58);
            this.txtR2.Name = "txtR2";
            this.txtR2.Size = new System.Drawing.Size(50, 23);
            this.txtR2.TabIndex = 21;
            this.txtR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblR5
            // 
            this.lblR5.AutoSize = true;
            this.lblR5.Location = new System.Drawing.Point(6, 145);
            this.lblR5.Name = "lblR5";
            this.lblR5.Size = new System.Drawing.Size(49, 21);
            this.lblR5.TabIndex = 20;
            this.lblR5.Text = "R5 =";
            // 
            // txtR1
            // 
            this.txtR1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtR1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtR1.Location = new System.Drawing.Point(61, 29);
            this.txtR1.Name = "txtR1";
            this.txtR1.Size = new System.Drawing.Size(50, 23);
            this.txtR1.TabIndex = 16;
            this.txtR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblR4
            // 
            this.lblR4.AutoSize = true;
            this.lblR4.Location = new System.Drawing.Point(6, 116);
            this.lblR4.Name = "lblR4";
            this.lblR4.Size = new System.Drawing.Size(49, 21);
            this.lblR4.TabIndex = 19;
            this.lblR4.Text = "R4 =";
            // 
            // lblR3
            // 
            this.lblR3.AutoSize = true;
            this.lblR3.Location = new System.Drawing.Point(6, 87);
            this.lblR3.Name = "lblR3";
            this.lblR3.Size = new System.Drawing.Size(49, 21);
            this.lblR3.TabIndex = 18;
            this.lblR3.Text = "R3 =";
            // 
            // lblR1
            // 
            this.lblR1.AutoSize = true;
            this.lblR1.Location = new System.Drawing.Point(6, 29);
            this.lblR1.Name = "lblR1";
            this.lblR1.Size = new System.Drawing.Size(49, 21);
            this.lblR1.TabIndex = 16;
            this.lblR1.Text = "R1 =";
            // 
            // lblR2
            // 
            this.lblR2.AutoSize = true;
            this.lblR2.Location = new System.Drawing.Point(6, 58);
            this.lblR2.Name = "lblR2";
            this.lblR2.Size = new System.Drawing.Size(49, 21);
            this.lblR2.TabIndex = 17;
            this.lblR2.Text = "R2 =";
            // 
            // gbJogMove
            // 
            this.gbJogMove.Controls.Add(this.cboJogCoordinate);
            this.gbJogMove.Controls.Add(this.lblLineCoordinate);
            this.gbJogMove.Controls.Add(this.cboJogStep);
            this.gbJogMove.Controls.Add(this.lblJogStep);
            this.gbJogMove.Controls.Add(this.btnJogRJ6Positive);
            this.gbJogMove.Controls.Add(this.btnJogRJ6Negative);
            this.gbJogMove.Controls.Add(this.btnJogPJ5Positive);
            this.gbJogMove.Controls.Add(this.btnJogPJ5Negative);
            this.gbJogMove.Controls.Add(this.btnJogWJ4Positive);
            this.gbJogMove.Controls.Add(this.btnJogWJ4Negative);
            this.gbJogMove.Controls.Add(this.btnJogZJ3Positive);
            this.gbJogMove.Controls.Add(this.btnJogZJ3Negative);
            this.gbJogMove.Controls.Add(this.btnJogYJ2Positive);
            this.gbJogMove.Controls.Add(this.btnJogYJ2Negative);
            this.gbJogMove.Controls.Add(this.btnJogXJ1Positive);
            this.gbJogMove.Controls.Add(this.btnJogXJ1Negative);
            this.gbJogMove.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbJogMove.Location = new System.Drawing.Point(642, 146);
            this.gbJogMove.Name = "gbJogMove";
            this.gbJogMove.Size = new System.Drawing.Size(216, 353);
            this.gbJogMove.TabIndex = 8;
            this.gbJogMove.TabStop = false;
            this.gbJogMove.Text = "Jog Move";
            // 
            // cboJogCoordinate
            // 
            this.cboJogCoordinate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJogCoordinate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboJogCoordinate.FormattingEnabled = true;
            this.cboJogCoordinate.Location = new System.Drawing.Point(120, 29);
            this.cboJogCoordinate.Name = "cboJogCoordinate";
            this.cboJogCoordinate.Size = new System.Drawing.Size(85, 24);
            this.cboJogCoordinate.TabIndex = 25;
            this.cboJogCoordinate.SelectedIndexChanged += new System.EventHandler(this.cboJogCoordinate_SelectedIndexChanged);
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
            this.gbControl.Controls.Add(this.btnEnable);
            this.gbControl.Controls.Add(this.btnPositionHome);
            this.gbControl.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbControl.Location = new System.Drawing.Point(12, 146);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(114, 332);
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
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnHold
            // 
            this.btnHold.Location = new System.Drawing.Point(6, 188);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(100, 43);
            this.btnHold.TabIndex = 16;
            this.btnHold.Text = "Hold";
            this.btnHold.UseVisualStyleBackColor = true;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInformation.Location = new System.Drawing.Point(926, 84);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(100, 52);
            this.btnInformation.TabIndex = 19;
            this.btnInformation.Text = "Information";
            this.btnInformation.UseVisualStyleBackColor = true;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // gbLineMove
            // 
            this.gbLineMove.Controls.Add(this.lblLineVelocityUnit);
            this.gbLineMove.Controls.Add(this.lblLineRJ6Unit);
            this.gbLineMove.Controls.Add(this.txtLineVelocity);
            this.gbLineMove.Controls.Add(this.lblLinePJ5Unit);
            this.gbLineMove.Controls.Add(this.lblLineVelocity);
            this.gbLineMove.Controls.Add(this.lblLineWJ4Unit);
            this.gbLineMove.Controls.Add(this.btnLineSet);
            this.gbLineMove.Controls.Add(this.lblLineZJ3Unit);
            this.gbLineMove.Controls.Add(this.btnLineCopy);
            this.gbLineMove.Controls.Add(this.lblLineYJ2Unit);
            this.gbLineMove.Controls.Add(this.lblLineXJ1Unit);
            this.gbLineMove.Controls.Add(this.lblLineYJ2);
            this.gbLineMove.Controls.Add(this.lblLineRJ6);
            this.gbLineMove.Controls.Add(this.lblLineWJ4);
            this.gbLineMove.Controls.Add(this.lblLinePJ5);
            this.gbLineMove.Controls.Add(this.lblLineZJ3);
            this.gbLineMove.Controls.Add(this.lblLineXJ1);
            this.gbLineMove.Controls.Add(this.txtLineRJ6);
            this.gbLineMove.Controls.Add(this.txtLinePJ5);
            this.gbLineMove.Controls.Add(this.txtLineWJ4);
            this.gbLineMove.Controls.Add(this.txtLineZJ3);
            this.gbLineMove.Controls.Add(this.txtLineYJ2);
            this.gbLineMove.Controls.Add(this.txtLineXJ1);
            this.gbLineMove.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbLineMove.Location = new System.Drawing.Point(866, 146);
            this.gbLineMove.Name = "gbLineMove";
            this.gbLineMove.Size = new System.Drawing.Size(215, 353);
            this.gbLineMove.TabIndex = 18;
            this.gbLineMove.TabStop = false;
            this.gbLineMove.Text = "Line Move";
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
            // txtLineVelocity
            // 
            this.txtLineVelocity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLineVelocity.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLineVelocity.Location = new System.Drawing.Point(46, 203);
            this.txtLineVelocity.Name = "txtLineVelocity";
            this.txtLineVelocity.Size = new System.Drawing.Size(81, 23);
            this.txtLineVelocity.TabIndex = 17;
            this.txtLineVelocity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // lblLineVelocity
            // 
            this.lblLineVelocity.AutoSize = true;
            this.lblLineVelocity.Location = new System.Drawing.Point(6, 203);
            this.lblLineVelocity.Name = "lblLineVelocity";
            this.lblLineVelocity.Size = new System.Drawing.Size(34, 21);
            this.lblLineVelocity.TabIndex = 16;
            this.lblLineVelocity.Text = "V :";
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
            this.btnLineSet.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLineSet.Location = new System.Drawing.Point(110, 232);
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
            this.btnLineCopy.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLineCopy.Location = new System.Drawing.Point(10, 232);
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
            // lblLineYJ2
            // 
            this.lblLineYJ2.AutoSize = true;
            this.lblLineYJ2.Location = new System.Drawing.Point(6, 58);
            this.lblLineYJ2.Name = "lblLineYJ2";
            this.lblLineYJ2.Size = new System.Drawing.Size(34, 21);
            this.lblLineYJ2.TabIndex = 12;
            this.lblLineYJ2.Text = "Y :";
            // 
            // lblLineRJ6
            // 
            this.lblLineRJ6.AutoSize = true;
            this.lblLineRJ6.Location = new System.Drawing.Point(6, 174);
            this.lblLineRJ6.Name = "lblLineRJ6";
            this.lblLineRJ6.Size = new System.Drawing.Size(33, 21);
            this.lblLineRJ6.TabIndex = 11;
            this.lblLineRJ6.Text = "R :";
            // 
            // lblLineWJ4
            // 
            this.lblLineWJ4.AutoSize = true;
            this.lblLineWJ4.Location = new System.Drawing.Point(6, 116);
            this.lblLineWJ4.Name = "lblLineWJ4";
            this.lblLineWJ4.Size = new System.Drawing.Size(34, 21);
            this.lblLineWJ4.TabIndex = 10;
            this.lblLineWJ4.Text = "W:";
            // 
            // lblLinePJ5
            // 
            this.lblLinePJ5.AutoSize = true;
            this.lblLinePJ5.Location = new System.Drawing.Point(6, 145);
            this.lblLinePJ5.Name = "lblLinePJ5";
            this.lblLinePJ5.Size = new System.Drawing.Size(31, 21);
            this.lblLinePJ5.TabIndex = 9;
            this.lblLinePJ5.Text = "P :";
            // 
            // lblLineZJ3
            // 
            this.lblLineZJ3.AutoSize = true;
            this.lblLineZJ3.Location = new System.Drawing.Point(6, 87);
            this.lblLineZJ3.Name = "lblLineZJ3";
            this.lblLineZJ3.Size = new System.Drawing.Size(32, 21);
            this.lblLineZJ3.TabIndex = 8;
            this.lblLineZJ3.Text = "Z :";
            // 
            // lblLineXJ1
            // 
            this.lblLineXJ1.AutoSize = true;
            this.lblLineXJ1.Location = new System.Drawing.Point(6, 29);
            this.lblLineXJ1.Name = "lblLineXJ1";
            this.lblLineXJ1.Size = new System.Drawing.Size(34, 21);
            this.lblLineXJ1.TabIndex = 7;
            this.lblLineXJ1.Text = "X :";
            // 
            // txtLineRJ6
            // 
            this.txtLineRJ6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLineRJ6.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLineRJ6.Location = new System.Drawing.Point(46, 174);
            this.txtLineRJ6.Name = "txtLineRJ6";
            this.txtLineRJ6.Size = new System.Drawing.Size(110, 23);
            this.txtLineRJ6.TabIndex = 6;
            this.txtLineRJ6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLinePJ5
            // 
            this.txtLinePJ5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLinePJ5.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLinePJ5.Location = new System.Drawing.Point(46, 145);
            this.txtLinePJ5.Name = "txtLinePJ5";
            this.txtLinePJ5.Size = new System.Drawing.Size(110, 23);
            this.txtLinePJ5.TabIndex = 5;
            this.txtLinePJ5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLineWJ4
            // 
            this.txtLineWJ4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLineWJ4.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLineWJ4.Location = new System.Drawing.Point(46, 116);
            this.txtLineWJ4.Name = "txtLineWJ4";
            this.txtLineWJ4.Size = new System.Drawing.Size(110, 23);
            this.txtLineWJ4.TabIndex = 4;
            this.txtLineWJ4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLineZJ3
            // 
            this.txtLineZJ3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLineZJ3.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLineZJ3.Location = new System.Drawing.Point(46, 87);
            this.txtLineZJ3.Name = "txtLineZJ3";
            this.txtLineZJ3.Size = new System.Drawing.Size(110, 23);
            this.txtLineZJ3.TabIndex = 3;
            this.txtLineZJ3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLineYJ2
            // 
            this.txtLineYJ2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLineYJ2.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLineYJ2.Location = new System.Drawing.Point(46, 58);
            this.txtLineYJ2.Name = "txtLineYJ2";
            this.txtLineYJ2.Size = new System.Drawing.Size(110, 23);
            this.txtLineYJ2.TabIndex = 2;
            this.txtLineYJ2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLineXJ1
            // 
            this.txtLineXJ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLineXJ1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLineXJ1.Location = new System.Drawing.Point(46, 29);
            this.txtLineXJ1.Name = "txtLineXJ1";
            this.txtLineXJ1.Size = new System.Drawing.Size(110, 23);
            this.txtLineXJ1.TabIndex = 1;
            this.txtLineXJ1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbSafeRange
            // 
            this.gbSafeRange.Controls.Add(this.txtSafeRangeVelocitymax);
            this.gbSafeRange.Controls.Add(this.txtSafeRangeVelocitymin);
            this.gbSafeRange.Controls.Add(this.lblSafeRangeVelocity);
            this.gbSafeRange.Controls.Add(this.cboSafeRangeCoordinate);
            this.gbSafeRange.Controls.Add(this.lblSafeRangeCoordinate);
            this.gbSafeRange.Controls.Add(this.txtSafeRangeRJ6max);
            this.gbSafeRange.Controls.Add(this.txtSafeRangePJ5max);
            this.gbSafeRange.Controls.Add(this.txtSafeRangeWJ4max);
            this.gbSafeRange.Controls.Add(this.txtSafeRangeRJ6min);
            this.gbSafeRange.Controls.Add(this.lblSafeRangeRJ6);
            this.gbSafeRange.Controls.Add(this.txtSafeRangeWJ4min);
            this.gbSafeRange.Controls.Add(this.lblSafeRangeWJ4);
            this.gbSafeRange.Controls.Add(this.txtSafeRangePJ5min);
            this.gbSafeRange.Controls.Add(this.lblSafeRangePJ5);
            this.gbSafeRange.Controls.Add(this.txtSafeRangeZJ3max);
            this.gbSafeRange.Controls.Add(this.txtSafeRangeYJ2max);
            this.gbSafeRange.Controls.Add(this.txtSafeRangeXJ1max);
            this.gbSafeRange.Controls.Add(this.txtSafeRangeZJ3min);
            this.gbSafeRange.Controls.Add(this.lblSafeRangeZJ3);
            this.gbSafeRange.Controls.Add(this.txtSafeRangeXJ1min);
            this.gbSafeRange.Controls.Add(this.lblSafeRangeXJ1);
            this.gbSafeRange.Controls.Add(this.txtSafeRangeYJ2min);
            this.gbSafeRange.Controls.Add(this.lblSafeRangeYJ2);
            this.gbSafeRange.Controls.Add(this.btnSafeRangeSet);
            this.gbSafeRange.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbSafeRange.Location = new System.Drawing.Point(132, 337);
            this.gbSafeRange.Name = "gbSafeRange";
            this.gbSafeRange.Size = new System.Drawing.Size(279, 281);
            this.gbSafeRange.TabIndex = 19;
            this.gbSafeRange.TabStop = false;
            this.gbSafeRange.Text = "Safe Range";
            // 
            // txtSafeRangeVelocitymax
            // 
            this.txtSafeRangeVelocitymax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSafeRangeVelocitymax.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSafeRangeVelocitymax.Location = new System.Drawing.Point(144, 234);
            this.txtSafeRangeVelocitymax.Name = "txtSafeRangeVelocitymax";
            this.txtSafeRangeVelocitymax.Size = new System.Drawing.Size(60, 23);
            this.txtSafeRangeVelocitymax.TabIndex = 40;
            this.txtSafeRangeVelocitymax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSafeRangeVelocitymin
            // 
            this.txtSafeRangeVelocitymin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSafeRangeVelocitymin.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSafeRangeVelocitymin.Location = new System.Drawing.Point(46, 234);
            this.txtSafeRangeVelocitymin.Name = "txtSafeRangeVelocitymin";
            this.txtSafeRangeVelocitymin.Size = new System.Drawing.Size(60, 23);
            this.txtSafeRangeVelocitymin.TabIndex = 38;
            this.txtSafeRangeVelocitymin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSafeRangeVelocity
            // 
            this.lblSafeRangeVelocity.AutoSize = true;
            this.lblSafeRangeVelocity.Location = new System.Drawing.Point(6, 234);
            this.lblSafeRangeVelocity.Name = "lblSafeRangeVelocity";
            this.lblSafeRangeVelocity.Size = new System.Drawing.Size(130, 21);
            this.lblSafeRangeVelocity.TabIndex = 39;
            this.lblSafeRangeVelocity.Text = "V :                 ~";
            // 
            // cboSafeRangeCoordinate
            // 
            this.cboSafeRangeCoordinate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSafeRangeCoordinate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboSafeRangeCoordinate.FormattingEnabled = true;
            this.cboSafeRangeCoordinate.Location = new System.Drawing.Point(120, 30);
            this.cboSafeRangeCoordinate.Name = "cboSafeRangeCoordinate";
            this.cboSafeRangeCoordinate.Size = new System.Drawing.Size(151, 24);
            this.cboSafeRangeCoordinate.TabIndex = 25;
            this.cboSafeRangeCoordinate.SelectedIndexChanged += new System.EventHandler(this.cboSafeRangeCoordinate_SelectedIndexChanged);
            // 
            // lblSafeRangeCoordinate
            // 
            this.lblSafeRangeCoordinate.AutoSize = true;
            this.lblSafeRangeCoordinate.Location = new System.Drawing.Point(6, 29);
            this.lblSafeRangeCoordinate.Name = "lblSafeRangeCoordinate";
            this.lblSafeRangeCoordinate.Size = new System.Drawing.Size(108, 21);
            this.lblSafeRangeCoordinate.TabIndex = 25;
            this.lblSafeRangeCoordinate.Text = "Coordinate :";
            // 
            // txtSafeRangeRJ6max
            // 
            this.txtSafeRangeRJ6max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSafeRangeRJ6max.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSafeRangeRJ6max.Location = new System.Drawing.Point(144, 205);
            this.txtSafeRangeRJ6max.Name = "txtSafeRangeRJ6max";
            this.txtSafeRangeRJ6max.Size = new System.Drawing.Size(60, 23);
            this.txtSafeRangeRJ6max.TabIndex = 37;
            this.txtSafeRangeRJ6max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSafeRangePJ5max
            // 
            this.txtSafeRangePJ5max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSafeRangePJ5max.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSafeRangePJ5max.Location = new System.Drawing.Point(144, 176);
            this.txtSafeRangePJ5max.Name = "txtSafeRangePJ5max";
            this.txtSafeRangePJ5max.Size = new System.Drawing.Size(60, 23);
            this.txtSafeRangePJ5max.TabIndex = 36;
            this.txtSafeRangePJ5max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSafeRangeWJ4max
            // 
            this.txtSafeRangeWJ4max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSafeRangeWJ4max.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSafeRangeWJ4max.Location = new System.Drawing.Point(144, 147);
            this.txtSafeRangeWJ4max.Name = "txtSafeRangeWJ4max";
            this.txtSafeRangeWJ4max.Size = new System.Drawing.Size(60, 23);
            this.txtSafeRangeWJ4max.TabIndex = 35;
            this.txtSafeRangeWJ4max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSafeRangeRJ6min
            // 
            this.txtSafeRangeRJ6min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSafeRangeRJ6min.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSafeRangeRJ6min.Location = new System.Drawing.Point(46, 205);
            this.txtSafeRangeRJ6min.Name = "txtSafeRangeRJ6min";
            this.txtSafeRangeRJ6min.Size = new System.Drawing.Size(60, 23);
            this.txtSafeRangeRJ6min.TabIndex = 33;
            this.txtSafeRangeRJ6min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSafeRangeRJ6
            // 
            this.lblSafeRangeRJ6.AutoSize = true;
            this.lblSafeRangeRJ6.Location = new System.Drawing.Point(6, 205);
            this.lblSafeRangeRJ6.Name = "lblSafeRangeRJ6";
            this.lblSafeRangeRJ6.Size = new System.Drawing.Size(129, 21);
            this.lblSafeRangeRJ6.TabIndex = 34;
            this.lblSafeRangeRJ6.Text = "R :                 ~";
            // 
            // txtSafeRangeWJ4min
            // 
            this.txtSafeRangeWJ4min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSafeRangeWJ4min.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSafeRangeWJ4min.Location = new System.Drawing.Point(46, 147);
            this.txtSafeRangeWJ4min.Name = "txtSafeRangeWJ4min";
            this.txtSafeRangeWJ4min.Size = new System.Drawing.Size(60, 23);
            this.txtSafeRangeWJ4min.TabIndex = 29;
            this.txtSafeRangeWJ4min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSafeRangeWJ4
            // 
            this.lblSafeRangeWJ4.AutoSize = true;
            this.lblSafeRangeWJ4.Location = new System.Drawing.Point(6, 147);
            this.lblSafeRangeWJ4.Name = "lblSafeRangeWJ4";
            this.lblSafeRangeWJ4.Size = new System.Drawing.Size(130, 21);
            this.lblSafeRangeWJ4.TabIndex = 30;
            this.lblSafeRangeWJ4.Text = "W:                 ~";
            // 
            // txtSafeRangePJ5min
            // 
            this.txtSafeRangePJ5min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSafeRangePJ5min.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSafeRangePJ5min.Location = new System.Drawing.Point(46, 176);
            this.txtSafeRangePJ5min.Name = "txtSafeRangePJ5min";
            this.txtSafeRangePJ5min.Size = new System.Drawing.Size(60, 23);
            this.txtSafeRangePJ5min.TabIndex = 32;
            this.txtSafeRangePJ5min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSafeRangePJ5
            // 
            this.lblSafeRangePJ5.AutoSize = true;
            this.lblSafeRangePJ5.Location = new System.Drawing.Point(6, 176);
            this.lblSafeRangePJ5.Name = "lblSafeRangePJ5";
            this.lblSafeRangePJ5.Size = new System.Drawing.Size(132, 21);
            this.lblSafeRangePJ5.TabIndex = 31;
            this.lblSafeRangePJ5.Text = "P :                  ~";
            // 
            // txtSafeRangeZJ3max
            // 
            this.txtSafeRangeZJ3max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSafeRangeZJ3max.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSafeRangeZJ3max.Location = new System.Drawing.Point(144, 118);
            this.txtSafeRangeZJ3max.Name = "txtSafeRangeZJ3max";
            this.txtSafeRangeZJ3max.Size = new System.Drawing.Size(60, 23);
            this.txtSafeRangeZJ3max.TabIndex = 28;
            this.txtSafeRangeZJ3max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSafeRangeYJ2max
            // 
            this.txtSafeRangeYJ2max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSafeRangeYJ2max.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSafeRangeYJ2max.Location = new System.Drawing.Point(144, 89);
            this.txtSafeRangeYJ2max.Name = "txtSafeRangeYJ2max";
            this.txtSafeRangeYJ2max.Size = new System.Drawing.Size(60, 23);
            this.txtSafeRangeYJ2max.TabIndex = 27;
            this.txtSafeRangeYJ2max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSafeRangeXJ1max
            // 
            this.txtSafeRangeXJ1max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSafeRangeXJ1max.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSafeRangeXJ1max.Location = new System.Drawing.Point(144, 60);
            this.txtSafeRangeXJ1max.Name = "txtSafeRangeXJ1max";
            this.txtSafeRangeXJ1max.Size = new System.Drawing.Size(60, 23);
            this.txtSafeRangeXJ1max.TabIndex = 26;
            this.txtSafeRangeXJ1max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSafeRangeZJ3min
            // 
            this.txtSafeRangeZJ3min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSafeRangeZJ3min.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSafeRangeZJ3min.Location = new System.Drawing.Point(46, 118);
            this.txtSafeRangeZJ3min.Name = "txtSafeRangeZJ3min";
            this.txtSafeRangeZJ3min.Size = new System.Drawing.Size(60, 23);
            this.txtSafeRangeZJ3min.TabIndex = 24;
            this.txtSafeRangeZJ3min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSafeRangeZJ3
            // 
            this.lblSafeRangeZJ3.AutoSize = true;
            this.lblSafeRangeZJ3.Location = new System.Drawing.Point(6, 118);
            this.lblSafeRangeZJ3.Name = "lblSafeRangeZJ3";
            this.lblSafeRangeZJ3.Size = new System.Drawing.Size(128, 21);
            this.lblSafeRangeZJ3.TabIndex = 25;
            this.lblSafeRangeZJ3.Text = "Z :                 ~";
            // 
            // txtSafeRangeXJ1min
            // 
            this.txtSafeRangeXJ1min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSafeRangeXJ1min.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSafeRangeXJ1min.Location = new System.Drawing.Point(46, 60);
            this.txtSafeRangeXJ1min.Name = "txtSafeRangeXJ1min";
            this.txtSafeRangeXJ1min.Size = new System.Drawing.Size(60, 23);
            this.txtSafeRangeXJ1min.TabIndex = 20;
            this.txtSafeRangeXJ1min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSafeRangeXJ1
            // 
            this.lblSafeRangeXJ1.AutoSize = true;
            this.lblSafeRangeXJ1.Location = new System.Drawing.Point(6, 60);
            this.lblSafeRangeXJ1.Name = "lblSafeRangeXJ1";
            this.lblSafeRangeXJ1.Size = new System.Drawing.Size(130, 21);
            this.lblSafeRangeXJ1.TabIndex = 21;
            this.lblSafeRangeXJ1.Text = "X :                 ~";
            // 
            // txtSafeRangeYJ2min
            // 
            this.txtSafeRangeYJ2min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSafeRangeYJ2min.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSafeRangeYJ2min.Location = new System.Drawing.Point(46, 89);
            this.txtSafeRangeYJ2min.Name = "txtSafeRangeYJ2min";
            this.txtSafeRangeYJ2min.Size = new System.Drawing.Size(60, 23);
            this.txtSafeRangeYJ2min.TabIndex = 23;
            this.txtSafeRangeYJ2min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSafeRangeYJ2
            // 
            this.lblSafeRangeYJ2.AutoSize = true;
            this.lblSafeRangeYJ2.Location = new System.Drawing.Point(6, 89);
            this.lblSafeRangeYJ2.Name = "lblSafeRangeYJ2";
            this.lblSafeRangeYJ2.Size = new System.Drawing.Size(130, 21);
            this.lblSafeRangeYJ2.TabIndex = 22;
            this.lblSafeRangeYJ2.Text = "Y :                 ~";
            // 
            // btnSafeRangeSet
            // 
            this.btnSafeRangeSet.Location = new System.Drawing.Point(210, 114);
            this.btnSafeRangeSet.Name = "btnSafeRangeSet";
            this.btnSafeRangeSet.Size = new System.Drawing.Size(61, 48);
            this.btnSafeRangeSet.TabIndex = 19;
            this.btnSafeRangeSet.Text = "Set";
            this.btnSafeRangeSet.UseVisualStyleBackColor = true;
            this.btnSafeRangeSet.Click += new System.EventHandler(this.btnSafeRangeSet_Click);
            // 
            // gbPoints
            // 
            this.gbPoints.Controls.Add(this.btnPointsMoveSet);
            this.gbPoints.Controls.Add(this.btnPointsMoveLoad);
            this.gbPoints.Controls.Add(this.btnPointsMoveCopy);
            this.gbPoints.Controls.Add(this.dataGridView1);
            this.gbPoints.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbPoints.Location = new System.Drawing.Point(5, 624);
            this.gbPoints.Name = "gbPoints";
            this.gbPoints.Size = new System.Drawing.Size(796, 218);
            this.gbPoints.TabIndex = 20;
            this.gbPoints.TabStop = false;
            this.gbPoints.Text = "Points";
            // 
            // btnPointsMoveSet
            // 
            this.btnPointsMoveSet.Location = new System.Drawing.Point(689, 144);
            this.btnPointsMoveSet.Name = "btnPointsMoveSet";
            this.btnPointsMoveSet.Size = new System.Drawing.Size(94, 50);
            this.btnPointsMoveSet.TabIndex = 23;
            this.btnPointsMoveSet.Text = "Set";
            this.btnPointsMoveSet.UseVisualStyleBackColor = true;
            // 
            // btnPointsMoveLoad
            // 
            this.btnPointsMoveLoad.Location = new System.Drawing.Point(689, 88);
            this.btnPointsMoveLoad.Name = "btnPointsMoveLoad";
            this.btnPointsMoveLoad.Size = new System.Drawing.Size(94, 50);
            this.btnPointsMoveLoad.TabIndex = 22;
            this.btnPointsMoveLoad.Text = "Load";
            this.btnPointsMoveLoad.UseVisualStyleBackColor = true;
            // 
            // btnPointsMoveCopy
            // 
            this.btnPointsMoveCopy.Location = new System.Drawing.Point(689, 32);
            this.btnPointsMoveCopy.Name = "btnPointsMoveCopy";
            this.btnPointsMoveCopy.Size = new System.Drawing.Size(94, 50);
            this.btnPointsMoveCopy.TabIndex = 21;
            this.btnPointsMoveCopy.Text = "Copy";
            this.btnPointsMoveCopy.UseVisualStyleBackColor = true;
            this.btnPointsMoveCopy.Click += new System.EventHandler(this.btnPointsMoveCopy_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnX,
            this.ColumnY,
            this.ColumnZ,
            this.ColumnW,
            this.ColumnP,
            this.ColumnR,
            this.ColumnV});
            this.dataGridView1.Location = new System.Drawing.Point(6, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(665, 218);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.HeaderText = "Num";
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.Width = 55;
            // 
            // ColumnX
            // 
            this.ColumnX.HeaderText = "X";
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.Width = 85;
            // 
            // ColumnY
            // 
            this.ColumnY.HeaderText = "Y";
            this.ColumnY.Name = "ColumnY";
            this.ColumnY.Width = 85;
            // 
            // ColumnZ
            // 
            this.ColumnZ.HeaderText = "Z";
            this.ColumnZ.Name = "ColumnZ";
            this.ColumnZ.Width = 85;
            // 
            // ColumnW
            // 
            this.ColumnW.HeaderText = "W";
            this.ColumnW.Name = "ColumnW";
            this.ColumnW.Width = 85;
            // 
            // ColumnP
            // 
            this.ColumnP.HeaderText = "P";
            this.ColumnP.Name = "ColumnP";
            this.ColumnP.Width = 85;
            // 
            // ColumnR
            // 
            this.ColumnR.HeaderText = "R";
            this.ColumnR.Name = "ColumnR";
            this.ColumnR.Width = 85;
            // 
            // ColumnV
            // 
            this.ColumnV.HeaderText = "V";
            this.ColumnV.Name = "ColumnV";
            this.ColumnV.Width = 45;
            // 
            // gbProgram
            // 
            this.gbProgram.Controls.Add(this.lblProgramValue);
            this.gbProgram.Controls.Add(this.txtProgramValue);
            this.gbProgram.Controls.Add(this.lblProgramUnit);
            this.gbProgram.Controls.Add(this.lblProgramInstruction);
            this.gbProgram.Controls.Add(this.cboProgramCoordinate);
            this.gbProgram.Controls.Add(this.lblProgramCoordinate);
            this.gbProgram.Controls.Add(this.btnProgramCopy);
            this.gbProgram.Controls.Add(this.btnProgramCompile);
            this.gbProgram.Controls.Add(this.btnProgramClear);
            this.gbProgram.Controls.Add(this.btnProgramDelete);
            this.gbProgram.Controls.Add(this.btnProgramEdit);
            this.gbProgram.Controls.Add(this.btnProgramInsert);
            this.gbProgram.Controls.Add(this.btnProgramAdd);
            this.gbProgram.Controls.Add(this.txtProgramVelocity);
            this.gbProgram.Controls.Add(this.lblProgramVelocity);
            this.gbProgram.Controls.Add(this.cboProgramInstruction);
            this.gbProgram.Controls.Add(this.lblProgramYJ2);
            this.gbProgram.Controls.Add(this.txtProgramName);
            this.gbProgram.Controls.Add(this.lblProgramRJ6);
            this.gbProgram.Controls.Add(this.lblProgramName);
            this.gbProgram.Controls.Add(this.lblProgramWJ4);
            this.gbProgram.Controls.Add(this.lstProgram);
            this.gbProgram.Controls.Add(this.lblProgramPJ5);
            this.gbProgram.Controls.Add(this.txtProgramXJ1);
            this.gbProgram.Controls.Add(this.lblProgramZJ3);
            this.gbProgram.Controls.Add(this.txtProgramYJ2);
            this.gbProgram.Controls.Add(this.lblProgramXJ1);
            this.gbProgram.Controls.Add(this.txtProgramZJ3);
            this.gbProgram.Controls.Add(this.txtProgramRJ6);
            this.gbProgram.Controls.Add(this.txtProgramWJ4);
            this.gbProgram.Controls.Add(this.txtProgramPJ5);
            this.gbProgram.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbProgram.Location = new System.Drawing.Point(639, 349);
            this.gbProgram.Name = "gbProgram";
            this.gbProgram.Size = new System.Drawing.Size(694, 354);
            this.gbProgram.TabIndex = 21;
            this.gbProgram.TabStop = false;
            this.gbProgram.Text = "Program";
            // 
            // lblProgramValue
            // 
            this.lblProgramValue.AutoSize = true;
            this.lblProgramValue.Location = new System.Drawing.Point(320, 128);
            this.lblProgramValue.Name = "lblProgramValue";
            this.lblProgramValue.Size = new System.Drawing.Size(67, 21);
            this.lblProgramValue.TabIndex = 58;
            this.lblProgramValue.Text = "Value :";
            // 
            // txtProgramValue
            // 
            this.txtProgramValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProgramValue.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProgramValue.Location = new System.Drawing.Point(393, 128);
            this.txtProgramValue.Name = "txtProgramValue";
            this.txtProgramValue.Size = new System.Drawing.Size(87, 23);
            this.txtProgramValue.TabIndex = 55;
            this.txtProgramValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProgramUnit
            // 
            this.lblProgramUnit.AutoSize = true;
            this.lblProgramUnit.Location = new System.Drawing.Point(486, 128);
            this.lblProgramUnit.Name = "lblProgramUnit";
            this.lblProgramUnit.Size = new System.Drawing.Size(40, 21);
            this.lblProgramUnit.TabIndex = 56;
            this.lblProgramUnit.Text = "(%)";
            // 
            // lblProgramInstruction
            // 
            this.lblProgramInstruction.AutoSize = true;
            this.lblProgramInstruction.Location = new System.Drawing.Point(319, 98);
            this.lblProgramInstruction.Name = "lblProgramInstruction";
            this.lblProgramInstruction.Size = new System.Drawing.Size(106, 21);
            this.lblProgramInstruction.TabIndex = 54;
            this.lblProgramInstruction.Text = "Instruction :";
            // 
            // cboProgramCoordinate
            // 
            this.cboProgramCoordinate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProgramCoordinate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboProgramCoordinate.FormattingEnabled = true;
            this.cboProgramCoordinate.Location = new System.Drawing.Point(433, 68);
            this.cboProgramCoordinate.Name = "cboProgramCoordinate";
            this.cboProgramCoordinate.Size = new System.Drawing.Size(154, 24);
            this.cboProgramCoordinate.TabIndex = 26;
            this.cboProgramCoordinate.SelectedIndexChanged += new System.EventHandler(this.cboProgramCoordinate_SelectedIndexChanged);
            // 
            // lblProgramCoordinate
            // 
            this.lblProgramCoordinate.AutoSize = true;
            this.lblProgramCoordinate.Location = new System.Drawing.Point(320, 68);
            this.lblProgramCoordinate.Name = "lblProgramCoordinate";
            this.lblProgramCoordinate.Size = new System.Drawing.Size(108, 21);
            this.lblProgramCoordinate.TabIndex = 27;
            this.lblProgramCoordinate.Text = "Coordinate :";
            // 
            // btnProgramCopy
            // 
            this.btnProgramCopy.Location = new System.Drawing.Point(435, 244);
            this.btnProgramCopy.Name = "btnProgramCopy";
            this.btnProgramCopy.Size = new System.Drawing.Size(96, 56);
            this.btnProgramCopy.TabIndex = 53;
            this.btnProgramCopy.Text = "Copy";
            this.btnProgramCopy.UseVisualStyleBackColor = true;
            this.btnProgramCopy.Click += new System.EventHandler(this.btnProgramCopy_Click);
            // 
            // btnProgramCompile
            // 
            this.btnProgramCompile.Location = new System.Drawing.Point(593, 29);
            this.btnProgramCompile.Name = "btnProgramCompile";
            this.btnProgramCompile.Size = new System.Drawing.Size(94, 29);
            this.btnProgramCompile.TabIndex = 52;
            this.btnProgramCompile.Text = "Compile";
            this.btnProgramCompile.UseVisualStyleBackColor = true;
            this.btnProgramCompile.Click += new System.EventHandler(this.btnProgramCompile_Click);
            // 
            // btnProgramClear
            // 
            this.btnProgramClear.Location = new System.Drawing.Point(592, 272);
            this.btnProgramClear.Name = "btnProgramClear";
            this.btnProgramClear.Size = new System.Drawing.Size(95, 30);
            this.btnProgramClear.TabIndex = 51;
            this.btnProgramClear.Text = "Clear";
            this.btnProgramClear.UseVisualStyleBackColor = true;
            this.btnProgramClear.Click += new System.EventHandler(this.btnProgramClear_Click);
            // 
            // btnProgramDelete
            // 
            this.btnProgramDelete.Location = new System.Drawing.Point(592, 236);
            this.btnProgramDelete.Name = "btnProgramDelete";
            this.btnProgramDelete.Size = new System.Drawing.Size(95, 30);
            this.btnProgramDelete.TabIndex = 50;
            this.btnProgramDelete.Text = "Delete";
            this.btnProgramDelete.UseVisualStyleBackColor = true;
            this.btnProgramDelete.Click += new System.EventHandler(this.btnProgramDelete_Click);
            // 
            // btnProgramEdit
            // 
            this.btnProgramEdit.Location = new System.Drawing.Point(592, 200);
            this.btnProgramEdit.Name = "btnProgramEdit";
            this.btnProgramEdit.Size = new System.Drawing.Size(95, 30);
            this.btnProgramEdit.TabIndex = 49;
            this.btnProgramEdit.Text = "Edit";
            this.btnProgramEdit.UseVisualStyleBackColor = true;
            this.btnProgramEdit.Click += new System.EventHandler(this.btnProgramEdit_Click);
            // 
            // btnProgramInsert
            // 
            this.btnProgramInsert.Location = new System.Drawing.Point(592, 164);
            this.btnProgramInsert.Name = "btnProgramInsert";
            this.btnProgramInsert.Size = new System.Drawing.Size(95, 30);
            this.btnProgramInsert.TabIndex = 48;
            this.btnProgramInsert.Text = "Insert";
            this.btnProgramInsert.UseVisualStyleBackColor = true;
            this.btnProgramInsert.Click += new System.EventHandler(this.btnProgramInsert_Click);
            // 
            // btnProgramAdd
            // 
            this.btnProgramAdd.Location = new System.Drawing.Point(592, 128);
            this.btnProgramAdd.Name = "btnProgramAdd";
            this.btnProgramAdd.Size = new System.Drawing.Size(95, 30);
            this.btnProgramAdd.TabIndex = 47;
            this.btnProgramAdd.Text = "Add";
            this.btnProgramAdd.UseVisualStyleBackColor = true;
            this.btnProgramAdd.Click += new System.EventHandler(this.btnProgramAdd_Click);
            // 
            // txtProgramVelocity
            // 
            this.txtProgramVelocity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProgramVelocity.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProgramVelocity.Location = new System.Drawing.Point(365, 245);
            this.txtProgramVelocity.Name = "txtProgramVelocity";
            this.txtProgramVelocity.Size = new System.Drawing.Size(60, 23);
            this.txtProgramVelocity.TabIndex = 46;
            this.txtProgramVelocity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProgramVelocity
            // 
            this.lblProgramVelocity.AutoSize = true;
            this.lblProgramVelocity.Location = new System.Drawing.Point(325, 245);
            this.lblProgramVelocity.Name = "lblProgramVelocity";
            this.lblProgramVelocity.Size = new System.Drawing.Size(34, 21);
            this.lblProgramVelocity.TabIndex = 45;
            this.lblProgramVelocity.Text = "V :";
            // 
            // cboProgramInstruction
            // 
            this.cboProgramInstruction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProgramInstruction.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboProgramInstruction.FormattingEnabled = true;
            this.cboProgramInstruction.Location = new System.Drawing.Point(431, 98);
            this.cboProgramInstruction.Name = "cboProgramInstruction";
            this.cboProgramInstruction.Size = new System.Drawing.Size(198, 24);
            this.cboProgramInstruction.TabIndex = 3;
            this.cboProgramInstruction.SelectedIndexChanged += new System.EventHandler(this.cboProgramInstruction_SelectedIndexChanged);
            // 
            // lblProgramYJ2
            // 
            this.lblProgramYJ2.AutoSize = true;
            this.lblProgramYJ2.Location = new System.Drawing.Point(325, 186);
            this.lblProgramYJ2.Name = "lblProgramYJ2";
            this.lblProgramYJ2.Size = new System.Drawing.Size(34, 21);
            this.lblProgramYJ2.TabIndex = 44;
            this.lblProgramYJ2.Text = "Y :";
            // 
            // txtProgramName
            // 
            this.txtProgramName.Location = new System.Drawing.Point(466, 29);
            this.txtProgramName.Name = "txtProgramName";
            this.txtProgramName.Size = new System.Drawing.Size(121, 33);
            this.txtProgramName.TabIndex = 2;
            // 
            // lblProgramRJ6
            // 
            this.lblProgramRJ6.AutoSize = true;
            this.lblProgramRJ6.Location = new System.Drawing.Point(431, 215);
            this.lblProgramRJ6.Name = "lblProgramRJ6";
            this.lblProgramRJ6.Size = new System.Drawing.Size(33, 21);
            this.lblProgramRJ6.TabIndex = 43;
            this.lblProgramRJ6.Text = "R :";
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.Location = new System.Drawing.Point(319, 32);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(141, 21);
            this.lblProgramName.TabIndex = 1;
            this.lblProgramName.Text = "Program Name :";
            // 
            // lblProgramWJ4
            // 
            this.lblProgramWJ4.AutoSize = true;
            this.lblProgramWJ4.Location = new System.Drawing.Point(431, 157);
            this.lblProgramWJ4.Name = "lblProgramWJ4";
            this.lblProgramWJ4.Size = new System.Drawing.Size(34, 21);
            this.lblProgramWJ4.TabIndex = 42;
            this.lblProgramWJ4.Text = "W:";
            // 
            // lstProgram
            // 
            this.lstProgram.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstProgram.FormattingEnabled = true;
            this.lstProgram.HorizontalScrollbar = true;
            this.lstProgram.ItemHeight = 19;
            this.lstProgram.Location = new System.Drawing.Point(6, 32);
            this.lstProgram.Name = "lstProgram";
            this.lstProgram.Size = new System.Drawing.Size(307, 289);
            this.lstProgram.TabIndex = 0;
            // 
            // lblProgramPJ5
            // 
            this.lblProgramPJ5.AutoSize = true;
            this.lblProgramPJ5.Location = new System.Drawing.Point(431, 186);
            this.lblProgramPJ5.Name = "lblProgramPJ5";
            this.lblProgramPJ5.Size = new System.Drawing.Size(31, 21);
            this.lblProgramPJ5.TabIndex = 41;
            this.lblProgramPJ5.Text = "P :";
            // 
            // txtProgramXJ1
            // 
            this.txtProgramXJ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProgramXJ1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProgramXJ1.Location = new System.Drawing.Point(365, 157);
            this.txtProgramXJ1.Name = "txtProgramXJ1";
            this.txtProgramXJ1.Size = new System.Drawing.Size(60, 23);
            this.txtProgramXJ1.TabIndex = 33;
            this.txtProgramXJ1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProgramZJ3
            // 
            this.lblProgramZJ3.AutoSize = true;
            this.lblProgramZJ3.Location = new System.Drawing.Point(325, 215);
            this.lblProgramZJ3.Name = "lblProgramZJ3";
            this.lblProgramZJ3.Size = new System.Drawing.Size(32, 21);
            this.lblProgramZJ3.TabIndex = 40;
            this.lblProgramZJ3.Text = "Z :";
            // 
            // txtProgramYJ2
            // 
            this.txtProgramYJ2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProgramYJ2.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProgramYJ2.Location = new System.Drawing.Point(365, 186);
            this.txtProgramYJ2.Name = "txtProgramYJ2";
            this.txtProgramYJ2.Size = new System.Drawing.Size(60, 23);
            this.txtProgramYJ2.TabIndex = 34;
            this.txtProgramYJ2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProgramXJ1
            // 
            this.lblProgramXJ1.AutoSize = true;
            this.lblProgramXJ1.Location = new System.Drawing.Point(325, 157);
            this.lblProgramXJ1.Name = "lblProgramXJ1";
            this.lblProgramXJ1.Size = new System.Drawing.Size(34, 21);
            this.lblProgramXJ1.TabIndex = 39;
            this.lblProgramXJ1.Text = "X :";
            // 
            // txtProgramZJ3
            // 
            this.txtProgramZJ3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProgramZJ3.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProgramZJ3.Location = new System.Drawing.Point(365, 215);
            this.txtProgramZJ3.Name = "txtProgramZJ3";
            this.txtProgramZJ3.Size = new System.Drawing.Size(60, 23);
            this.txtProgramZJ3.TabIndex = 35;
            this.txtProgramZJ3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProgramRJ6
            // 
            this.txtProgramRJ6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProgramRJ6.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProgramRJ6.Location = new System.Drawing.Point(471, 215);
            this.txtProgramRJ6.Name = "txtProgramRJ6";
            this.txtProgramRJ6.Size = new System.Drawing.Size(60, 23);
            this.txtProgramRJ6.TabIndex = 38;
            this.txtProgramRJ6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProgramWJ4
            // 
            this.txtProgramWJ4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProgramWJ4.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProgramWJ4.Location = new System.Drawing.Point(471, 157);
            this.txtProgramWJ4.Name = "txtProgramWJ4";
            this.txtProgramWJ4.Size = new System.Drawing.Size(60, 23);
            this.txtProgramWJ4.TabIndex = 36;
            this.txtProgramWJ4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProgramPJ5
            // 
            this.txtProgramPJ5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProgramPJ5.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProgramPJ5.Location = new System.Drawing.Point(471, 186);
            this.txtProgramPJ5.Name = "txtProgramPJ5";
            this.txtProgramPJ5.Size = new System.Drawing.Size(60, 23);
            this.txtProgramPJ5.TabIndex = 37;
            this.txtProgramPJ5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 705);
            this.Controls.Add(this.gbProgram);
            this.Controls.Add(this.btnInformation);
            this.Controls.Add(this.gbPoints);
            this.Controls.Add(this.gbSafeRange);
            this.Controls.Add(this.gbLineMove);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.gbJogMove);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.gbRegister);
            this.Controls.Add(this.gbPointMove);
            this.Controls.Add(this.gbOverride);
            this.Controls.Add(this.gbCurrentPosition);
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
            this.gbCurrentPosition.ResumeLayout(false);
            this.gbCurrentPosition.PerformLayout();
            this.gbOverride.ResumeLayout(false);
            this.gbOverride.PerformLayout();
            this.gbPointMove.ResumeLayout(false);
            this.gbPointMove.PerformLayout();
            this.gbRegister.ResumeLayout(false);
            this.gbRegister.PerformLayout();
            this.gbJogMove.ResumeLayout(false);
            this.gbJogMove.PerformLayout();
            this.gbControl.ResumeLayout(false);
            this.gbLineMove.ResumeLayout(false);
            this.gbLineMove.PerformLayout();
            this.gbSafeRange.ResumeLayout(false);
            this.gbSafeRange.PerformLayout();
            this.gbPoints.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbProgram.ResumeLayout(false);
            this.gbProgram.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbPointMove;
        private System.Windows.Forms.ComboBox cboPTPCoordinate;
        private System.Windows.Forms.Label lblPTPYJ2;
        private System.Windows.Forms.Label lblPTPRJ6;
        private System.Windows.Forms.Label lblPTPWJ4;
        private System.Windows.Forms.Label lblPTPPJ5;
        private System.Windows.Forms.Label lblPTPZJ3;
        private System.Windows.Forms.Label lblPTPXJ1;
        private System.Windows.Forms.TextBox txtPTPRJ6;
        private System.Windows.Forms.TextBox txtPTPPJ5;
        private System.Windows.Forms.TextBox txtPTPWJ4;
        private System.Windows.Forms.TextBox txtPTPZJ3;
        private System.Windows.Forms.TextBox txtPTPYJ2;
        private System.Windows.Forms.TextBox txtPTPXJ1;
        private System.Windows.Forms.Button btnPTPCopy;
        private System.Windows.Forms.Button btnPTPSet;
        private System.Windows.Forms.Button btnPositionHome;
        private System.Windows.Forms.GroupBox gbRegister;
        private System.Windows.Forms.TextBox txtR1;
        private System.Windows.Forms.TextBox txtR5;
        private System.Windows.Forms.TextBox txtR4;
        private System.Windows.Forms.TextBox txtR3;
        private System.Windows.Forms.TextBox txtR2;
        private System.Windows.Forms.Label lblR5;
        private System.Windows.Forms.Label lblR4;
        private System.Windows.Forms.Label lblR3;
        private System.Windows.Forms.Label lblR1;
        private System.Windows.Forms.Label lblR2;
        private System.Windows.Forms.Button btnRegisterSet;
        private System.Windows.Forms.GroupBox gbJogMove;
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
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.Button btnPercentdown;
        private System.Windows.Forms.Button btnPercentup;
        private System.Windows.Forms.GroupBox gbLineMove;
        private System.Windows.Forms.TextBox txtLineVelocity;
        private System.Windows.Forms.Label lblLineVelocity;
        private System.Windows.Forms.Button btnLineSet;
        private System.Windows.Forms.Button btnLineCopy;
        private System.Windows.Forms.Label lblLineYJ2;
        private System.Windows.Forms.Label lblLineRJ6;
        private System.Windows.Forms.Label lblLineWJ4;
        private System.Windows.Forms.Label lblLinePJ5;
        private System.Windows.Forms.Label lblLineZJ3;
        private System.Windows.Forms.Label lblLineXJ1;
        private System.Windows.Forms.TextBox txtLineRJ6;
        private System.Windows.Forms.TextBox txtLinePJ5;
        private System.Windows.Forms.TextBox txtLineWJ4;
        private System.Windows.Forms.TextBox txtLineZJ3;
        private System.Windows.Forms.TextBox txtLineYJ2;
        private System.Windows.Forms.TextBox txtLineXJ1;
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
        private System.Windows.Forms.ComboBox cboJogCoordinate;
        private System.Windows.Forms.Label lblLineCoordinate;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.GroupBox gbSafeRange;
        private System.Windows.Forms.Label lblSafeRangeYJ2;
        private System.Windows.Forms.Label lblSafeRangeXJ1;
        private System.Windows.Forms.TextBox txtSafeRangeXJ1min;
        private System.Windows.Forms.Button btnSafeRangeSet;
        private System.Windows.Forms.TextBox txtSafeRangeZJ3max;
        private System.Windows.Forms.TextBox txtSafeRangeYJ2max;
        private System.Windows.Forms.TextBox txtSafeRangeXJ1max;
        private System.Windows.Forms.TextBox txtSafeRangeZJ3min;
        private System.Windows.Forms.Label lblSafeRangeZJ3;
        private System.Windows.Forms.TextBox txtSafeRangeYJ2min;
        private System.Windows.Forms.TextBox txtSafeRangeRJ6max;
        private System.Windows.Forms.TextBox txtSafeRangePJ5max;
        private System.Windows.Forms.TextBox txtSafeRangeWJ4max;
        private System.Windows.Forms.TextBox txtSafeRangeRJ6min;
        private System.Windows.Forms.Label lblSafeRangeRJ6;
        private System.Windows.Forms.TextBox txtSafeRangeWJ4min;
        private System.Windows.Forms.Label lblSafeRangeWJ4;
        private System.Windows.Forms.TextBox txtSafeRangePJ5min;
        private System.Windows.Forms.Label lblSafeRangePJ5;
        private System.Windows.Forms.ComboBox cboSafeRangeCoordinate;
        private System.Windows.Forms.Label lblSafeRangeCoordinate;
        private System.Windows.Forms.GroupBox gbPoints;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnW;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnV;
        private System.Windows.Forms.Button btnPointsMoveSet;
        private System.Windows.Forms.Button btnPointsMoveLoad;
        private System.Windows.Forms.Button btnPointsMoveCopy;
        private System.Windows.Forms.GroupBox gbProgram;
        private System.Windows.Forms.ListBox lstProgram;
        private System.Windows.Forms.TextBox txtProgramName;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.TextBox txtProgramVelocity;
        private System.Windows.Forms.Label lblProgramVelocity;
        private System.Windows.Forms.ComboBox cboProgramInstruction;
        private System.Windows.Forms.Label lblProgramYJ2;
        private System.Windows.Forms.Label lblProgramRJ6;
        private System.Windows.Forms.Label lblProgramWJ4;
        private System.Windows.Forms.Label lblProgramPJ5;
        private System.Windows.Forms.TextBox txtProgramXJ1;
        private System.Windows.Forms.Label lblProgramZJ3;
        private System.Windows.Forms.TextBox txtProgramYJ2;
        private System.Windows.Forms.Label lblProgramXJ1;
        private System.Windows.Forms.TextBox txtProgramZJ3;
        private System.Windows.Forms.TextBox txtProgramRJ6;
        private System.Windows.Forms.TextBox txtProgramWJ4;
        private System.Windows.Forms.TextBox txtProgramPJ5;
        private System.Windows.Forms.Button btnProgramCompile;
        private System.Windows.Forms.Button btnProgramClear;
        private System.Windows.Forms.Button btnProgramDelete;
        private System.Windows.Forms.Button btnProgramEdit;
        private System.Windows.Forms.Button btnProgramInsert;
        private System.Windows.Forms.Button btnProgramAdd;
        private System.Windows.Forms.Label lblProgramInstruction;
        private System.Windows.Forms.ComboBox cboProgramCoordinate;
        private System.Windows.Forms.Label lblProgramCoordinate;
        private System.Windows.Forms.Button btnProgramCopy;
        private System.Windows.Forms.TextBox txtProgramValue;
        private System.Windows.Forms.Label lblProgramUnit;
        private System.Windows.Forms.Label lblProgramValue;
        private System.Windows.Forms.TextBox txtSafeRangeVelocitymax;
        private System.Windows.Forms.TextBox txtSafeRangeVelocitymin;
        private System.Windows.Forms.Label lblSafeRangeVelocity;
    }
}

