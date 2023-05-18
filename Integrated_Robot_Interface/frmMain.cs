using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Integrated_Robot_Interface
{
    public partial class FrmMain : Form
    {
        //變數宣告
        private Controller myController;
        private DataTable dataTable;
        private StreamWriter sw;
        private StreamReader sr;
        private bool fgConnectionState { get; set; } = false;
        private bool fgGripperConnectionState { get; set; } = false;
        private bool fgGripperState { get; set; } = false;


        public FrmMain()
        {
            InitializeComponent();
            myController = new Controller();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            Initialize();
        }
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fgConnectionState)
            {
                if (myController.Disconnect())
                {
                    Initialize();
                }
                else
                {
                    richTextBox1.Text += $"手臂離線失敗\r\n{RobotAdapter.apierrtext}";
                    MessageBox.Show($"手臂離線失敗\r\n{RobotAdapter.apierrtext}");
                    RobotAdapter.apierrtext = "";
                    if (!myController.Alarm())
                    {
                        richTextBox1.Text += RobotAdapter.alarmtext + "\r\n";
                        MessageBox.Show("讀取警示失敗", "讀取警示狀態");
                        return;
                    }
                    else
                    {
                        if (RobotAdapter.alarmtext != "")
                        {
                            richTextBox1.Text += RobotAdapter.alarmtext + "\r\n";
                            MessageBox.Show(RobotAdapter.alarmtext, "讀取警示狀態");
                            return;
                        }
                    }
                }
            }
        }

        #region <object status>
        private void Initialize()
        {
            string[] Robot = new string[] { Controller.Robotnum.None.ToString(), Controller.Robotnum.Fanuc.ToString(),
                                            Controller.Robotnum.Nexcom.ToString(), Controller.Robotnum.Ourarm.ToString() };
            cboRobot.Items.Clear();
            cboRobot.Items.AddRange(Robot);
            string[] Coordinate = new string[] { Controller.Coordinatenum.Cartesian.ToString(), Controller.Coordinatenum.Joint.ToString() };
            cboCoordinate.Items.Clear();
            cboCoordinate.Items.AddRange(Coordinate);
            string[] Step = new string[] { Controller.Stepnum.One.ToString(), Controller.Stepnum.Five.ToString(),
                                           Controller.Stepnum.Ten.ToString() };
            cboJogStep.Items.Clear();
            cboJogStep.Items.AddRange(Step);
            string[] Instruction = new string[] {Controller.Instructionnum.OVERRIDE.ToString() + " = ? %",
                                                 Controller.Instructionnum.MOVEC.ToString() + "(X,Y,Z,W,P,R)",
                                                 Controller.Instructionnum.MOVEJ.ToString() + "(J1,J2,J3,J4,J5,J6)",
                                                 Controller.Instructionnum.MOVEL.ToString() + "(X,Y,Z,W,P,R,V)",
                                                 Controller.Instructionnum.WAIT.ToString() + " ? sec",
                                                 Controller.Instructionnum.TOOL.ToString() + " = ?",
                                                 Controller.Instructionnum.FRAME.ToString() + " = ?"};
            cboProgramInstruction.Items.Clear();
            cboProgramInstruction.Items.AddRange(Instruction);
            txtInitialize();
            cboRobot.SelectedIndex = 0;
            timer1.Interval = 500;
            timer1.Enabled = false;
            txtIP.Enabled = false;
            fgConnectionState = false;
            cboRobot.Enabled = true;
            gbEnbleControl(false);
            tbSafeRangeEnbleControl(false);
            dataTable = new DataTable();
            dataGridView1.DataSource = dataTable;
            dataTable.Columns.Add("Num", typeof(int));
            dataTable.Columns.Add("Mov", typeof(string));
            dataTable.Columns.Add("X/J1", typeof(float));
            dataTable.Columns.Add("Y/J2", typeof(float));
            dataTable.Columns.Add("Z/J3", typeof(float));
            dataTable.Columns.Add("W/J4", typeof(float));
            dataTable.Columns.Add("P/J5", typeof(float));
            dataTable.Columns.Add("R/J6", typeof(float));
            dataTable.Columns.Add("V", typeof(float));
            dataGridView1.Columns[0].Width = 90;
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[2].Width = 90;
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[5].Width = 90;
            dataGridView1.Columns[6].Width = 90;
            dataGridView1.Columns[7].Width = 90;
            dataGridView1.Columns[8].Width = 90;
        }
        private void gbEnbleControl(bool tf)
        {
            gbOverride.Enabled = tf;
            gbCurrentPosition.Enabled = tf;
            gbPointMove.Enabled = tf;
            gbRegister.Enabled = tf;
            gbJogMove.Enabled = tf;
            gbControl.Enabled = tf;
            gbLineMove.Enabled = tf;
            gbSafeRange.Enabled = tf;
            gbPoints.Enabled = tf;
            gbProgram.Enabled = tf;
            gbGripper.Enabled = tf;
        }
        private void tbSafeRangeEnbleControl(bool tf)
        {
            txtSafeRangeXJ1min.Enabled = tf;
            txtSafeRangeXJ1max.Enabled = tf;
            txtSafeRangeYJ2min.Enabled = tf;
            txtSafeRangeYJ2max.Enabled = tf;
            txtSafeRangeZJ3min.Enabled = tf;
            txtSafeRangeZJ3max.Enabled = tf;
            txtSafeRangeWJ4min.Enabled = tf;
            txtSafeRangeWJ4max.Enabled = tf;
            txtSafeRangePJ5min.Enabled = tf;
            txtSafeRangePJ5max.Enabled = tf;
            txtSafeRangeRJ6min.Enabled = tf;
            txtSafeRangeRJ6max.Enabled = tf;
            txtSafeRangeVelocitymin.Enabled = tf;
            txtSafeRangeVelocitymax.Enabled = tf;
        }
        private void txtInitialize()
        {
            btnConnection.Text = "Connect";
            lblConnectionStatus.Text = "Connection Status : Disconnected";
            lblXyzwpr.Text = "Cartesian\r\nX : \r\nY : \r\nZ : \r\nW: \r\nP : \r\nR : ";
            lblJoint.Text = "Joint\r\nJ1 : \r\nJ2 : \r\nJ3 : \r\nJ4 : \r\nJ5 : \r\nJ6 : ";
            lblOverride.Text = "";
            txtPTPXJ1.Text = "";
            txtPTPYJ2.Text = "";
            txtPTPZJ3.Text = "";
            txtPTPWJ4.Text = "";
            txtPTPPJ5.Text = "";
            txtPTPRJ6.Text = "";
            txtLineXJ1.Text = "";
            txtLineYJ2.Text = "";
            txtLineZJ3.Text = "";
            txtLineWJ4.Text = "";
            txtLinePJ5.Text = "";
            txtLineRJ6.Text = "";
            txtLineVelocity.Text = "";
            lblOverride.Text = "";
            txtR1.Text = "";
            txtR2.Text = "";
            txtR3.Text = "";
            txtR4.Text = "";
            txtR5.Text = "";
            txtSafeRangeXJ1max.Text = "";
            txtSafeRangeXJ1min.Text = "";
            txtSafeRangeYJ2max.Text = "";
            txtSafeRangeYJ2min.Text = "";
            txtSafeRangeZJ3max.Text = "";
            txtSafeRangeZJ3min.Text = "";
            txtSafeRangeWJ4max.Text = "";
            txtSafeRangeWJ4min.Text = "";
            txtSafeRangePJ5max.Text = "";
            txtSafeRangePJ5min.Text = "";
            txtSafeRangeRJ6max.Text = "";
            txtSafeRangeRJ6min.Text = "";
            txtSafeRangeVelocitymax.Text = "";
            txtSafeRangeVelocitymin.Text = "";
            txtProgramXJ1.Text = "";
            txtProgramYJ2.Text = "";
            txtProgramZJ3.Text = "";
            txtProgramWJ4.Text = "";
            txtProgramPJ5.Text = "";
            txtProgramRJ6.Text = "";
        }
        #endregion

        #region <NOgb>
        private void btnEsc_Click(object sender, EventArgs e)
        {
            if (fgConnectionState)
            {
                if (myController.Disconnect())
                {
                    Initialize();
                    Application.Exit();
                }
                else
                {
                    richTextBox1.Text += $"手臂離線失敗\r\n{RobotAdapter.apierrtext}";
                    MessageBox.Show($"手臂離線失敗\r\n{RobotAdapter.apierrtext}");
                    RobotAdapter.apierrtext = "";
                }
            }
            else
            {
                Application.Exit();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (myController.Robot)
            {
                case Controller.Robotnum.Fanuc:
                    if (!myController.Refresh())
                    {
                        ShowMessage("刷新失敗", "取得刷新狀態");
                        return;
                    }

                    short StartIndex = 1;
                    short Count = 10;
                    lblGetRegister.Text = "";

                    for (int i = StartIndex; i <= Count; i++)
                    {
                        RobotAdapter.getregister.SetValue(i, 1);
                        if (!myController.GetRegister())
                        {
                            ShowMessage("讀取暫存器值失敗", "讀取暫存器狀態");
                            return;
                        }
                        lblGetRegister.Text += $"R{i} = {Convert.ToSingle(RobotAdapter.getregister.GetValue(0))}\r\n";
                    }

                    break;
                case Controller.Robotnum.Nexcom:
                    break;
                case Controller.Robotnum.Ourarm:
                    break;
            }

            if (!myController.Alarm())
            {
                ShowMessage("讀取警示失敗", "讀取警示狀態");
                return;
            }
            else
            {
                if (RobotAdapter.alarmtext != "")
                {
                    ShowMessage($"{RobotAdapter.alarmtext}", "讀取警示狀態");
                    return;
                }
            }

            if (!myController.GetOverride())
            {
                ShowMessage("讀取速度百分比失敗", "讀取速度百分比狀態");
                lblOverride.Text = "Error";
                return;
            }
            else
            {
                lblOverride.Text = RobotAdapter.getoverride + "%";
            }

            if (!myController.GetState())
            {
                ShowMessage("讀取程式狀態失敗", "讀取程式狀態狀態");
                lblState.Text = "Error";
                return;
            }
            else
            {
                lblState.Text = $"State : {RobotAdapter.getstate}";
            }

            if (!myController.GetTool())
            {
                ShowMessage("讀取工具座標失敗", "讀取工具座標狀態");
                lblTool.Text = "Error";
                return;
            }
            else
            {
                lblTool.Text = $"Tool : {RobotAdapter.gettool}";
            }

            if (!myController.GetUFrame())
            {
                ShowMessage("讀取用戶座標失敗", "讀取用戶座標狀態");
                lblUFrame.Text = "Error";
                return;
            }
            else
            {
                lblUFrame.Text = $"UFrame : {RobotAdapter.getuframe}";
            }

            //if (RobotAdapter.preuframe != RobotAdapter.getuframe)
            //{
            //    if (!myController.SafeRangeChangeXYZ())
            //    {
            //        ShowMessage("更新安全範圍失敗", "更新安全範圍狀態");
            //        txtSafeRangeXJ1min.Text = "Error";
            //        txtSafeRangeXJ1max.Text = "Error";
            //        txtSafeRangeYJ2min.Text = "Error";
            //        txtSafeRangeYJ2max.Text = "Error";
            //        txtSafeRangeZJ3min.Text = "Error";
            //        txtSafeRangeZJ3max.Text = "Error";
            //        txtSafeRangeWJ4min.Text = "Error";
            //        txtSafeRangeWJ4max.Text = "Error";
            //        txtSafeRangePJ5min.Text = "Error";
            //        txtSafeRangePJ5max.Text = "Error";
            //        txtSafeRangeRJ6min.Text = "Error"; ;
            //        txtSafeRangeRJ6max.Text = "Error";
            //        txtSafeRangeVelocitymin.Text = "Error";
            //        txtSafeRangeVelocitymax.Text = "Error";
            //        return;
            //    }
            //    else
            //    {
            //        txtSafeRangeXJ1min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(0)).ToString("###0.000"))}";
            //        txtSafeRangeXJ1max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(1)).ToString("###0.000"))}";
            //        txtSafeRangeYJ2min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(2)).ToString("###0.000"))}";
            //        txtSafeRangeYJ2max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(3)).ToString("###0.000"))}";
            //        txtSafeRangeZJ3min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(4)).ToString("###0.000"))}";
            //        txtSafeRangeZJ3max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(5)).ToString("###0.000"))}";
            //        txtSafeRangeWJ4min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(6)).ToString("###0.000"))}";
            //        txtSafeRangeWJ4max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(7)).ToString("###0.000"))}";
            //        txtSafeRangePJ5min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(8)).ToString("###0.000"))}";
            //        txtSafeRangePJ5max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(9)).ToString("###0.000"))}";
            //        txtSafeRangeRJ6min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(10)).ToString("###0.000"))}";
            //        txtSafeRangeRJ6max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(11)).ToString("###0.000"))}";
            //        txtSafeRangeVelocitymin.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangevelocity.GetValue(0)).ToString("###0.000"))}";
            //        txtSafeRangeVelocitymax.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangevelocity.GetValue(1)).ToString("###0.000"))}";
            //        RobotAdapter.preuframe = RobotAdapter.getuframe;
            //    }
            //}

            if (!myController.GetCPosition())
            {
                ShowMessage("讀取卡氏座標失敗", "讀取卡氏座標狀態");
                lblXyzwpr.Text = "Cartesian\r\n";
                lblXyzwpr.Text += $"X : Error\r\n";
                lblXyzwpr.Text += $"Y : Error\r\n";
                lblXyzwpr.Text += $"Z : Error\r\n";
                lblXyzwpr.Text += $"W: Error\r\n";
                lblXyzwpr.Text += $"P : Error\r\n";
                lblXyzwpr.Text += $"R : Error";
                return;
            }
            else
            {
                lblXyzwpr.Text = "Cartesian\r\n";
                lblXyzwpr.Text += $"X : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(0)).ToString("###0.000"))}\r\n";
                lblXyzwpr.Text += $"Y : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(1)).ToString("###0.000"))}\r\n";
                lblXyzwpr.Text += $"Z : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(2)).ToString("###0.000"))}\r\n";
                lblXyzwpr.Text += $"W: {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(3)).ToString("###0.000"))}\r\n";
                lblXyzwpr.Text += $"P : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(4)).ToString("###0.000"))}\r\n";
                lblXyzwpr.Text += $"R : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(5)).ToString("###0.000"))}";
            }

            if (!myController.GetJPosition())
            {
                ShowMessage("讀取軸座標失敗", "讀取軸座標狀態");
                lblJoint.Text = "Joint\r\n";
                lblJoint.Text += $"J1 : Error\r\n";
                lblJoint.Text += $"J2 : Error\r\n";
                lblJoint.Text += $"J3 : Error\r\n";
                lblJoint.Text += $"J4 : Error\r\n";
                lblJoint.Text += $"J5 : Error\r\n";
                lblJoint.Text += $"J6 : Error";
                return;
            }
            else
            {
                lblJoint.Text = "Joint\r\n";
                lblJoint.Text += $"J1 : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(0)).ToString("###0.000"))}\r\n";
                lblJoint.Text += $"J2 : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(1)).ToString("###0.000"))}\r\n";
                lblJoint.Text += $"J3 : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(2)).ToString("###0.000"))}\r\n";
                lblJoint.Text += $"J4 : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(3)).ToString("###0.000"))}\r\n";
                lblJoint.Text += $"J5 : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(4)).ToString("###0.000"))}\r\n";
                lblJoint.Text += $"J6 : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(5)).ToString("###0.000"))}";
            }

            if (!myController.GetInformation1())
            {
                ShowMessage("取得資料1失敗", "取得資料狀態");
                return;
            }
            gbInformation1.Text = RobotAdapter.information1name;
            lblInformation1.Text = RobotAdapter.information1text;
            if (!myController.GetInformation2())
            {
                ShowMessage("取得資料2失敗", "取得資料狀態");
                return;
            }
            gbInformation2.Text = RobotAdapter.information2name;
            lblInformation2.Text = RobotAdapter.information2text;
            if (!myController.GetInformation3())
            {
                ShowMessage("取得資料3失敗", "取得資料狀態");
                return;
            }
            gbInformation3.Text = RobotAdapter.information3name;
            lblInformation3.Text = RobotAdapter.information3text;
        }
        private void ShowMessage(string content, string title)
        {
            DialogResult result;
            timer1.Enabled = false;
            richTextBox1.Text += $"{content}\r\n{RobotAdapter.apierrtext}\r\n";
            result = MessageBox.Show($"{content}\r\n{RobotAdapter.apierrtext}", $"{title}", MessageBoxButtons.AbortRetryIgnore);
            RobotAdapter.apierrtext = "";
            if (result == DialogResult.Abort)
            {
                if (myController.Disconnect())
                {
                    Initialize();
                }
                else
                {
                    richTextBox1.Text += $"手臂離線失敗\r\n{RobotAdapter.apierrtext}";
                    MessageBox.Show($"手臂離線失敗\r\n{RobotAdapter.apierrtext}");
                    RobotAdapter.apierrtext = "";
                }
            }
            else if (result == DialogResult.Retry)
            {
                if (!myController.Reset())
                {
                    ShowMessage("Reset失敗", "Reset狀態");
                    return;
                }
            }
        }
        #endregion

        #region <gbConnection>
        private void cboRobot_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboRobot.Text)
            {
                case nameof(Controller.Robotnum.Fanuc):
                    myController.Robot = Controller.Robotnum.Fanuc;
                    txtIP.Enabled = true;
                    txtProgramName.Enabled = true;
                    lblLineVelocityUnit.Text = "mm/sec";
                    break;
                case nameof(Controller.Robotnum.Nexcom):
                    myController.Robot = Controller.Robotnum.Nexcom;
                    txtIP.Enabled = false;
                    txtProgramName.Enabled = false;
                    lblLineVelocityUnit.Text = "unit/sec";
                    break;
                case nameof(Controller.Robotnum.Ourarm):
                    myController.Robot = Controller.Robotnum.Ourarm;
                    txtIP.Enabled = false;
                    txtProgramName.Enabled = false;
                    lblLineVelocityUnit.Text = "unit/sec";
                    break;
                default:
                    myController.Robot = Controller.Robotnum.None;
                    txtIP.Enabled = false;
                    txtProgramName.Enabled = true;
                    lblLineVelocityUnit.Text = "unit/sec";
                    break;
            }
        }
        private void btnConnection_Click(object sender, EventArgs e)
        {
            if (!fgConnectionState)
            {
                switch (myController.Robot)
                {
                    case Controller.Robotnum.Fanuc:
                        RobotAdapter.ip = txtIP.Text;
                        break;
                    case Controller.Robotnum.Nexcom:
                        break;
                    case Controller.Robotnum.Ourarm:
                        break;
                    default:
                        richTextBox1.Text += "請選擇手臂型號\r\n";
                        MessageBox.Show("請選擇手臂型號");
                        return;
                }
                if (myController.Connect())
                {
                    fgConnectionState = true;
                    lblConnectionStatus.Text = "Connection Status : Connected";
                    btnConnection.Text = "Disconnect";
                    cboRobot.Enabled = false;
                    timer1.Enabled = true;
                    txtIP.Enabled = false;
                    gbEnbleControl(true);
                    richTextBox1.Clear();

                    switch (myController.Robot)
                    {
                        case Controller.Robotnum.Fanuc:
                            RobotAdapter.saferangexyz = new float[12] { 0, 650, -450, 450, -270, 400, -180, 180, -180, 180, -180, 180 };
                            RobotAdapter.saferangexyzorginal = new float[12] { 0, 650, -450, 450, -270, 400, -180, 180, -180, 180, -180, 180 };
                            RobotAdapter.preuframe = 0;
                            RobotAdapter.saferangejoint = new float[12] { -170, 150, -100, 140, -70, 50, -180, 180, -125, -40, -180, 180 };
                            RobotAdapter.saferangevelocity = new float[2] { 0, 500 };
                            RobotAdapter.saferangeoverride = new float[2] { 1, 100 };
                            btnGrap.Enabled = false;
                            btnOpen.Enabled = false;
                            RobotAdapter.setoverride = 20;
                            if (!myController.SetOverride())
                            {
                                ShowMessage("設定速度百分比失敗", "設定速度百分比狀態");
                                return;
                            }
                            RobotAdapter.setvelocity = 100;
                            if (!myController.SetVelocity())
                            {
                                ShowMessage("設定速度失敗", "設定速度狀態");
                                return;
                            }
                            if (!myController.Refresh())
                            {
                                ShowMessage("刷新失敗", "取得刷新狀態");
                                return;
                            }
                            if (!myController.GetCPosition())
                            {
                                ShowMessage("讀取卡氏座標失敗", "讀取卡氏座標狀態");
                                return;
                            }
                            RobotAdapter.setcposition = RobotAdapter.getcposition;
                            if (!myController.PointMoveC())
                            {
                                ShowMessage("設定座標失敗", "點到點移動狀態");
                                return;
                            }
                            break;
                        case Controller.Robotnum.Nexcom:
                            RobotAdapter.saferangexyz = new float[12] { 0, 500, -450, 450, 50, 600, -180, 180, -180, 180, -180, 180 };
                            RobotAdapter.saferangexyzorginal = new float[12] { 0, 650, -450, 450, -270, 400, -180, 180, -180, 180, -180, 180 };
                            RobotAdapter.preuframe = 0;
                            RobotAdapter.saferangejoint = new float[12] { -170, 150, 0, 200, -60, 145, -120, 170, -105, 105, -180, 180 };
                            RobotAdapter.saferangevelocity = new float[2] { 0, 100 };
                            RobotAdapter.saferangeoverride = new float[2] { 1, 100 };
                            gbRegister.Enabled = false;
                            RobotAdapter.setoverride = 50;
                            if (!myController.SetOverride())
                            {
                                ShowMessage("設定速度百分比失敗", "設定速度百分比狀態");
                                return;
                            }
                            RobotAdapter.setvelocity = 20;
                            if (!myController.SetVelocity())
                            {
                                ShowMessage("設定速度失敗", "設定速度狀態");
                            }
                            break;
                        case Controller.Robotnum.Ourarm:
                            break;
                    }
                    cboJogStep.SelectedIndex = 0;
                    cboProgramInstruction.SelectedIndex = 0;
                }
                else
                {
                    richTextBox1.Text += $"手臂連線失敗\r\n{RobotAdapter.apierrtext}\r\n";
                    MessageBox.Show($"手臂連線失敗\r\n{RobotAdapter.apierrtext}");
                    RobotAdapter.apierrtext = "";
                }
            }
            else
            {
                if (myController.Disconnect())
                {
                    Initialize();
                }
                else
                {
                    richTextBox1.Text += $"手臂離線失敗\r\n{RobotAdapter.apierrtext}\r\n";
                    MessageBox.Show($"手臂離線失敗\r\n{RobotAdapter.apierrtext}");
                    RobotAdapter.apierrtext = "";
                }
            }
        }
        #endregion

        #region <gbOverride>
        private void btnPercentup_Click(object sender, EventArgs e)
        {
            if (!myController.GetOverride())
            {
                ShowMessage("讀取速度百分比失敗", "讀取速度百分比狀態");
                lblOverride.Text = "Error";
                return;
            }

            RobotAdapter.safeoverride = RobotAdapter.getoverride + 5;
            if (RobotAdapter.safeoverride > Convert.ToInt32(RobotAdapter.saferangeoverride.GetValue(1)))
            {
                RobotAdapter.safeoverride = 100;
            }
            RobotAdapter.setoverride = RobotAdapter.safeoverride;

            if (!myController.SetOverride())
            {
                ShowMessage("設定速度百分比失敗", "設定速度百分比狀態");
                return;
            }
        }
        private void btnPercentdown_Click(object sender, EventArgs e)
        {
            if (!myController.GetOverride())
            {
                ShowMessage("讀取速度百分比失敗", "讀取速度百分比狀態");
                lblOverride.Text = "Error";
                return;
            }

            RobotAdapter.safeoverride = RobotAdapter.getoverride - 5;
            if (RobotAdapter.safeoverride < Convert.ToInt32(RobotAdapter.saferangeoverride.GetValue(0)))
            {
                RobotAdapter.safeoverride = 1;
            }
            RobotAdapter.setoverride = RobotAdapter.safeoverride;

            if (!myController.SetOverride())
            {
                ShowMessage("設定速度百分比失敗", "設定速度百分比狀態");
                return;
            }
        }
        #endregion

        #region <gbPointMove>
        private void btnPTPGet_Click(object sender, EventArgs e)
        {
            switch (myController.Coordinate)
            {
                case Controller.Coordinatenum.Cartesian:
                    txtPTPXJ1.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(0)).ToString("###0.000"))}";
                    txtPTPYJ2.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(1)).ToString("###0.000"))}";
                    txtPTPZJ3.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(2)).ToString("###0.000"))}";
                    txtPTPWJ4.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(3)).ToString("###0.000"))}";
                    txtPTPPJ5.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(4)).ToString("###0.000"))}";
                    txtPTPRJ6.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(5)).ToString("###0.000"))}";
                    break;
                case Controller.Coordinatenum.Joint:
                    txtPTPXJ1.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(0)).ToString("###0.000"))}";
                    txtPTPYJ2.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(1)).ToString("###0.000"))}";
                    txtPTPZJ3.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(2)).ToString("###0.000"))}";
                    txtPTPWJ4.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(3)).ToString("###0.000"))}";
                    txtPTPPJ5.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(4)).ToString("###0.000"))}";
                    txtPTPRJ6.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(5)).ToString("###0.000"))}";
                    break;
            }
        }
        private void btnPTPSet_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPTPXJ1.Text) || string.IsNullOrEmpty(txtPTPYJ2.Text) ||
                    string.IsNullOrEmpty(txtPTPZJ3.Text) || string.IsNullOrEmpty(txtPTPWJ4.Text) ||
                    string.IsNullOrEmpty(txtPTPPJ5.Text) || string.IsNullOrEmpty(txtPTPRJ6.Text))
                {
                    MessageBox.Show("座標值不可有空白");
                }
                else
                {
                    RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtPTPXJ1.Text), 0);
                    RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtPTPYJ2.Text), 1);
                    RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtPTPZJ3.Text), 2);
                    RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtPTPWJ4.Text), 3);
                    RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtPTPPJ5.Text), 4);
                    RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtPTPRJ6.Text), 5);

                    switch (myController.Coordinate)
                    {
                        case Controller.Coordinatenum.Cartesian:
                            if (!myController.SafeRangeCheckXYZ())
                            {
                                MessageBox.Show("超出安全範圍", "安全範圍狀態");
                                return;
                            }
                            RobotAdapter.setcposition = RobotAdapter.safecheck;
                            if (!myController.PointMoveC())
                            {
                                ShowMessage("設定座標失敗", "點到點移動狀態");
                            }
                            break;
                        case Controller.Coordinatenum.Joint:
                            if (!myController.SafeRangeCheckJoint())
                            {
                                MessageBox.Show("超出安全範圍", "安全範圍狀態");
                                return;
                            }
                            RobotAdapter.setjposition = RobotAdapter.safecheck;
                            if (!myController.PointMoveJ())
                            {
                                ShowMessage("設定座標失敗", "點到點移動狀態");
                            }
                            break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入有效數值");
            }
        }
        #endregion

        #region <gbLineMove>
        private void btnLineGet_Click(object sender, EventArgs e)
        {
            txtLineXJ1.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(0)).ToString("###0.000"))}";
            txtLineYJ2.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(1)).ToString("###0.000"))}";
            txtLineZJ3.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(2)).ToString("###0.000"))}";
            txtLineWJ4.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(3)).ToString("###0.000"))}";
            txtLinePJ5.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(4)).ToString("###0.000"))}";
            txtLineRJ6.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(5)).ToString("###0.000"))}";

            if (!myController.GetVelocity())
            {
                ShowMessage("讀取速度失敗", "讀取速度狀態");
                txtLineVelocity.Text = "Erorr";
                return;
            }
            else
            {
                txtLineVelocity.Text = $"{string.Format("{0,10}", RobotAdapter.getvelocity.ToString("###0.000"))}";
            }
        }
        private void btnLineSet_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtLineXJ1.Text) || string.IsNullOrEmpty(txtLineYJ2.Text) ||
                    string.IsNullOrEmpty(txtLineZJ3.Text) || string.IsNullOrEmpty(txtLineWJ4.Text) ||
                    string.IsNullOrEmpty(txtLinePJ5.Text) || string.IsNullOrEmpty(txtLineRJ6.Text) ||
                    string.IsNullOrEmpty(txtLineVelocity.Text))
                {
                    MessageBox.Show("座標值和速度值不可有空白");
                }
                else
                {
                    RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtLineXJ1.Text), 0);
                    RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtLineYJ2.Text), 1);
                    RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtLineZJ3.Text), 2);
                    RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtLineWJ4.Text), 3);
                    RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtLinePJ5.Text), 4);
                    RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtLineRJ6.Text), 5);
                    RobotAdapter.safevelocity = Convert.ToSingle(txtLineVelocity.Text);

                    if (!myController.SafeRangeCheckXYZ())
                    {
                        MessageBox.Show("超出安全範圍", "安全範圍狀態");
                        return;
                    }

                    if (!myController.SafeRangeCheckVelocity())
                    {
                        MessageBox.Show("速度超出安全範圍");
                        return;
                    }

                    RobotAdapter.setvelocity = RobotAdapter.safevelocity;
                    if (!myController.SetVelocity())
                    {
                        ShowMessage("設定速度失敗", "設定速度狀態");
                    }

                    RobotAdapter.setcposition = RobotAdapter.safecheck;
                    if (!myController.LineMove())
                    {
                        ShowMessage("設定座標失敗", "點到點移動狀態");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入有效數值");
            }
        }
        #endregion

        #region <gbRegister>
        private void btnRegisterSet_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtR1.Text))
                {
                    RobotAdapter.setregister.SetValue(1, 1);
                    RobotAdapter.setregister.SetValue(Convert.ToSingle(txtR1.Text), 0);
                    if (!myController.SetRegister())
                    {
                        ShowMessage("設定暫存器R1失敗", "設定暫存器狀態");
                        txtR1.Text = "";
                    }
                }
                if (!string.IsNullOrEmpty(txtR2.Text))
                {
                    RobotAdapter.setregister.SetValue(2, 1);
                    RobotAdapter.setregister.SetValue(Convert.ToSingle(txtR2.Text), 0);
                    if (!myController.SetRegister())
                    {
                        ShowMessage("設定暫存器R2失敗", "設定暫存器狀態");
                        txtR2.Text = "";
                    }
                }
                if (!string.IsNullOrEmpty(txtR3.Text))
                {
                    RobotAdapter.setregister.SetValue(3, 1);
                    RobotAdapter.setregister.SetValue(Convert.ToSingle(txtR3.Text), 0);
                    if (!myController.SetRegister())
                    {
                        ShowMessage("設定暫存器R3失敗", "設定暫存器狀態");
                        txtR3.Text = "";
                    }
                }
                if (!string.IsNullOrEmpty(txtR4.Text))
                {
                    RobotAdapter.setregister.SetValue(4, 1);
                    RobotAdapter.setregister.SetValue(Convert.ToSingle(txtR4.Text), 0);
                    if (!myController.SetRegister())
                    {
                        ShowMessage("設定暫存器R4失敗", "設定暫存器狀態");
                        txtR4.Text = "";
                    }
                }
                if (!string.IsNullOrEmpty(txtR5.Text))
                {
                    RobotAdapter.setregister.SetValue(5, 1);
                    RobotAdapter.setregister.SetValue(Convert.ToSingle(txtR5.Text), 0);
                    if (!myController.SetRegister())
                    {
                        ShowMessage("設定暫存器R5失敗", "設定暫存器狀態");
                        txtR5.Text = "";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入有效數值");
            }
        }
        #endregion

        #region <gbJogMove>
        private void cboStep_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboJogStep.Text)
            {
                case nameof(Controller.Stepnum.One):
                    myController.Step = Controller.Stepnum.One;
                    break;
                case nameof(Controller.Stepnum.Five):
                    myController.Step = Controller.Stepnum.Five;
                    break;
                case nameof(Controller.Stepnum.Ten):
                    myController.Step = Controller.Stepnum.Ten;
                    break;
            }
            RobotAdapter.jogmove.SetValue(myController.Step, 0);
        }
        private void btnJogXJ1Positive_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            RobotAdapter.jogmove.SetValue(Convert.ToInt32(btn.Tag), 1);
            switch (myController.Coordinate)
            {
                case Controller.Coordinatenum.Cartesian:
                    if (!myController.JogMoveC())
                    {
                        ShowMessage("寸動移動失敗", "單動移動狀態");
                    }
                    break;
                case Controller.Coordinatenum.Joint:
                    if (!myController.JogMoveJ())
                    {
                        ShowMessage("寸動移動失敗", "單動移動狀態");
                    }
                    break;
            }
        }
        #endregion

        #region <gbControl>
        private void cboCoordinate_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboCoordinate.Text)
            {
                case nameof(Controller.Coordinatenum.Cartesian):
                    myController.Coordinate = Controller.Coordinatenum.Cartesian;
                    lblPTPXJ1.Text = "X :";
                    lblPTPYJ2.Text = "Y :";
                    lblPTPZJ3.Text = "Z :";
                    lblPTPWJ4.Text = "W:";
                    lblPTPPJ5.Text = "P :";
                    lblPTPRJ6.Text = "R :";
                    lblPTPXJ1Unit.Text = "mm";
                    lblPTPYJ2Unit.Text = "mm";
                    lblPTPZJ3Unit.Text = "mm";
                    lblPTPWJ4Unit.Text = "deg";
                    lblPTPPJ5Unit.Text = "deg";
                    lblPTPRJ6Unit.Text = "deg";
                    btnJogXJ1Positive.Text = "+X";
                    btnJogXJ1Negative.Text = "-X";
                    btnJogYJ2Positive.Text = "+Y";
                    btnJogYJ2Negative.Text = "-Y";
                    btnJogZJ3Positive.Text = "+Z";
                    btnJogZJ3Negative.Text = "-Z";
                    btnJogWJ4Positive.Text = "+W";
                    btnJogWJ4Negative.Text = "-W";
                    btnJogPJ5Positive.Text = "+P";
                    btnJogPJ5Negative.Text = "-P";
                    btnJogRJ6Positive.Text = "+R";
                    btnJogRJ6Negative.Text = "-R";
                    lblSafeRangeXJ1.Text = "X :                 ~";
                    lblSafeRangeYJ2.Text = "Y :                 ~";
                    lblSafeRangeZJ3.Text = "Z :                 ~";
                    lblSafeRangeWJ4.Text = "W:                 ~";
                    lblSafeRangePJ5.Text = "P :                  ~";
                    lblSafeRangeRJ6.Text = "R :                 ~";
                    txtSafeRangeXJ1min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(0)).ToString("###0.000"))}";
                    txtSafeRangeXJ1max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(1)).ToString("###0.000"))}";
                    txtSafeRangeYJ2min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(2)).ToString("###0.000"))}";
                    txtSafeRangeYJ2max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(3)).ToString("###0.000"))}";
                    txtSafeRangeZJ3min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(4)).ToString("###0.000"))}";
                    txtSafeRangeZJ3max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(5)).ToString("###0.000"))}";
                    txtSafeRangeWJ4min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(6)).ToString("###0.000"))}";
                    txtSafeRangeWJ4max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(7)).ToString("###0.000"))}";
                    txtSafeRangePJ5min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(8)).ToString("###0.000"))}";
                    txtSafeRangePJ5max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(9)).ToString("###0.000"))}";
                    txtSafeRangeRJ6min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(10)).ToString("###0.000"))}";
                    txtSafeRangeRJ6max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(11)).ToString("###0.000"))}";
                    txtSafeRangeVelocitymin.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangevelocity.GetValue(0)).ToString("###0.000"))}";
                    txtSafeRangeVelocitymax.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangevelocity.GetValue(1)).ToString("###0.000"))}";
                    lblProgramXJ1.Text = "X :";
                    lblProgramYJ2.Text = "Y :";
                    lblProgramZJ3.Text = "Z :";
                    lblProgramWJ4.Text = "W:";
                    lblProgramPJ5.Text = "P :";
                    lblProgramRJ6.Text = "R :";
                    break;
                case nameof(Controller.Coordinatenum.Joint):
                    myController.Coordinate = Controller.Coordinatenum.Joint;
                    lblPTPXJ1.Text = "J1 :";
                    lblPTPYJ2.Text = "J2 :";
                    lblPTPZJ3.Text = "J3 :";
                    lblPTPWJ4.Text = "J4 :";
                    lblPTPPJ5.Text = "J5 :";
                    lblPTPRJ6.Text = "J6 :";
                    lblPTPXJ1Unit.Text = "deg";
                    lblPTPYJ2Unit.Text = "deg";
                    lblPTPZJ3Unit.Text = "deg";
                    lblPTPWJ4Unit.Text = "deg";
                    lblPTPPJ5Unit.Text = "deg";
                    lblPTPRJ6Unit.Text = "deg";
                    btnJogXJ1Positive.Text = "+J1";
                    btnJogXJ1Negative.Text = "-J1";
                    btnJogYJ2Positive.Text = "+J2";
                    btnJogYJ2Negative.Text = "-J2";
                    btnJogZJ3Positive.Text = "+J3";
                    btnJogZJ3Negative.Text = "-J3";
                    btnJogWJ4Positive.Text = "+J4";
                    btnJogWJ4Negative.Text = "-J4";
                    btnJogPJ5Positive.Text = "+J5";
                    btnJogPJ5Negative.Text = "-J5";
                    btnJogRJ6Positive.Text = "+J6";
                    btnJogRJ6Negative.Text = "-J6";
                    lblSafeRangeXJ1.Text = "J1:                 ~";
                    lblSafeRangeYJ2.Text = "J2:                 ~";
                    lblSafeRangeZJ3.Text = "J3:                 ~";
                    lblSafeRangeWJ4.Text = "J4:                 ~";
                    lblSafeRangePJ5.Text = "J5:                 ~";
                    lblSafeRangeRJ6.Text = "J6:                 ~";
                    txtSafeRangeXJ1min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(0)).ToString("###0.000"))}";
                    txtSafeRangeXJ1max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(1)).ToString("###0.000"))}";
                    txtSafeRangeYJ2min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(2)).ToString("###0.000"))}";
                    txtSafeRangeYJ2max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(3)).ToString("###0.000"))}";
                    txtSafeRangeZJ3min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(4)).ToString("###0.000"))}";
                    txtSafeRangeZJ3max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(5)).ToString("###0.000"))}";
                    txtSafeRangeWJ4min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(6)).ToString("###0.000"))}";
                    txtSafeRangeWJ4max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(7)).ToString("###0.000"))}";
                    txtSafeRangePJ5min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(8)).ToString("###0.000"))}";
                    txtSafeRangePJ5max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(9)).ToString("###0.000"))}";
                    txtSafeRangeRJ6min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(10)).ToString("###0.000"))}";
                    txtSafeRangeRJ6max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(11)).ToString("###0.000"))}";
                    txtSafeRangeVelocitymin.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangevelocity.GetValue(0)).ToString("###0.000"))}";
                    txtSafeRangeVelocitymax.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangevelocity.GetValue(1)).ToString("###0.000"))}";
                    lblProgramXJ1.Text = "J1 :";
                    lblProgramYJ2.Text = "J2 :";
                    lblProgramZJ3.Text = "J3 :";
                    lblProgramWJ4.Text = "J4 :";
                    lblProgramPJ5.Text = "J5 :";
                    lblProgramRJ6.Text = "J6 :";
                    break;
            }
        }
        private void btnEnable_Click(object sender, EventArgs e)
        {
            if (!myController.Enable())
            {
                ShowMessage("Enable失敗", "Enable狀態");
            }
        }
        private void btnDisable_Click(object sender, EventArgs e)
        {
            if (!myController.Disable())
            {
                ShowMessage("Disable失敗", "Disable狀態");
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (!myController.Reset())
            {
                ShowMessage("Reset失敗", "Reset狀態");
            }
            timer1.Enabled = true;
            richTextBox1.Text = "";
        }
        private void btnHold_Click(object sender, EventArgs e)
        {
            if (!myController.Hold())
            {
                ShowMessage("Hold失敗", "Hold狀態");
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (!myController.Stop())
            {
                ShowMessage("Stop失敗", "Stop狀態");
            }
        }
        private void btnPositionHome_Click(object sender, EventArgs e)
        {
            RobotAdapter.homeposition.SetValue(0, 0);
            RobotAdapter.homeposition.SetValue(0, 1);
            RobotAdapter.homeposition.SetValue(0, 2);
            RobotAdapter.homeposition.SetValue(0, 3);
            RobotAdapter.homeposition.SetValue(-90, 4);
            RobotAdapter.homeposition.SetValue(0, 5);
            if (!myController.Home())
            {
                ShowMessage("回到自訂原點失敗", "回到自訂原點狀態");
            }
        }
        #endregion

        #region <gbSafeRange>
        private void btnSafeRangeSet_Click(object sender, EventArgs e)
        {
            if (!txtSafeRangeXJ1min.Enabled)
            {
                tbSafeRangeEnbleControl(true);
                return;
            }

            try
            {
                switch (myController.Coordinate)
                {
                    case Controller.Coordinatenum.Cartesian:
                        RobotAdapter.saferangexyz.SetValue(Convert.ToSingle(txtSafeRangeXJ1min.Text), 0);
                        RobotAdapter.saferangexyz.SetValue(Convert.ToSingle(txtSafeRangeXJ1max.Text), 1);
                        RobotAdapter.saferangexyz.SetValue(Convert.ToSingle(txtSafeRangeYJ2min.Text), 2);
                        RobotAdapter.saferangexyz.SetValue(Convert.ToSingle(txtSafeRangeYJ2max.Text), 3);
                        RobotAdapter.saferangexyz.SetValue(Convert.ToSingle(txtSafeRangeZJ3min.Text), 4);
                        RobotAdapter.saferangexyz.SetValue(Convert.ToSingle(txtSafeRangeZJ3max.Text), 5);
                        RobotAdapter.saferangexyz.SetValue(Convert.ToSingle(txtSafeRangeWJ4min.Text), 6);
                        RobotAdapter.saferangexyz.SetValue(Convert.ToSingle(txtSafeRangeWJ4max.Text), 7);
                        RobotAdapter.saferangexyz.SetValue(Convert.ToSingle(txtSafeRangePJ5min.Text), 8);
                        RobotAdapter.saferangexyz.SetValue(Convert.ToSingle(txtSafeRangePJ5max.Text), 9);
                        RobotAdapter.saferangexyz.SetValue(Convert.ToSingle(txtSafeRangeRJ6min.Text), 10);
                        RobotAdapter.saferangexyz.SetValue(Convert.ToSingle(txtSafeRangeRJ6max.Text), 11);
                        RobotAdapter.saferangevelocity.SetValue(Convert.ToSingle(txtSafeRangeVelocitymin.Text), 0);
                        RobotAdapter.saferangevelocity.SetValue(Convert.ToSingle(txtSafeRangeVelocitymax.Text), 1);
                        break;
                    case Controller.Coordinatenum.Joint:
                        RobotAdapter.saferangejoint.SetValue(Convert.ToSingle(txtSafeRangeXJ1min.Text), 0);
                        RobotAdapter.saferangejoint.SetValue(Convert.ToSingle(txtSafeRangeXJ1max.Text), 1);
                        RobotAdapter.saferangejoint.SetValue(Convert.ToSingle(txtSafeRangeYJ2min.Text), 2);
                        RobotAdapter.saferangejoint.SetValue(Convert.ToSingle(txtSafeRangeYJ2max.Text), 3);
                        RobotAdapter.saferangejoint.SetValue(Convert.ToSingle(txtSafeRangeZJ3min.Text), 4);
                        RobotAdapter.saferangejoint.SetValue(Convert.ToSingle(txtSafeRangeZJ3max.Text), 5);
                        RobotAdapter.saferangejoint.SetValue(Convert.ToSingle(txtSafeRangeWJ4min.Text), 6);
                        RobotAdapter.saferangejoint.SetValue(Convert.ToSingle(txtSafeRangeWJ4max.Text), 7);
                        RobotAdapter.saferangejoint.SetValue(Convert.ToSingle(txtSafeRangePJ5min.Text), 8);
                        RobotAdapter.saferangejoint.SetValue(Convert.ToSingle(txtSafeRangePJ5max.Text), 9);
                        RobotAdapter.saferangejoint.SetValue(Convert.ToSingle(txtSafeRangeRJ6min.Text), 10);
                        RobotAdapter.saferangejoint.SetValue(Convert.ToSingle(txtSafeRangeRJ6max.Text), 11);
                        RobotAdapter.saferangevelocity.SetValue(Convert.ToSingle(txtSafeRangeVelocitymin.Text), 0);
                        RobotAdapter.saferangevelocity.SetValue(Convert.ToSingle(txtSafeRangeVelocitymax.Text), 1);
                        break;
                }
                tbSafeRangeEnbleControl(false);
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入有效數值");
            }
        }

        #endregion

        #region <gbPoints>
        private void btnPointsLoad_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtFilePath.Text))
            {
                dataTable.Clear();
                sr = new StreamReader(txtFilePath.Text);
                string line = "";
                string[] str1;
                string[] str2;
                line = sr.ReadLine();
                while ((line = sr.ReadLine()) != null)
                {
                    DataRow row = dataTable.NewRow();
                    str1 = line.Split(new string[] { "Num:", ",Mov:", "," }, StringSplitOptions.RemoveEmptyEntries);
                    switch (str1[1].ToString())
                    {
                        case "C":
                            str2 = line.Split(new string[] { "Num:", ",Mov:", ",X:", ",Y:", ",Z:", ",W:", ",P:", ",R:" },
                                StringSplitOptions.RemoveEmptyEntries);
                            row[0] = str2[0].ToString();
                            row[1] = str2[1].ToString();
                            row[2] = $"{string.Format("{0,10}", Convert.ToSingle(str2[2]).ToString("###0.000"))}";
                            row[3] = $"{string.Format("{0,10}", Convert.ToSingle(str2[3]).ToString("###0.000"))}";
                            row[4] = $"{string.Format("{0,10}", Convert.ToSingle(str2[4]).ToString("###0.000"))}";
                            row[5] = $"{string.Format("{0,10}", Convert.ToSingle(str2[5]).ToString("###0.000"))}";
                            row[6] = $"{string.Format("{0,10}", Convert.ToSingle(str2[6]).ToString("###0.000"))}";
                            row[7] = $"{string.Format("{0,10}", Convert.ToSingle(str2[7]).ToString("###0.000"))}";
                            break;
                        case "J":
                            str2 = line.Split(new string[] { "Num:", ",Mov:", ",J1:", ",J2:", ",J3:", ",J4:", ",J5:", ",J6:" },
                                StringSplitOptions.RemoveEmptyEntries);
                            row[0] = str2[0].ToString();
                            row[1] = str2[1].ToString();
                            row[2] = $"{string.Format("{0,10}", Convert.ToSingle(str2[2]).ToString("###0.000"))}";
                            row[3] = $"{string.Format("{0,10}", Convert.ToSingle(str2[3]).ToString("###0.000"))}";
                            row[4] = $"{string.Format("{0,10}", Convert.ToSingle(str2[4]).ToString("###0.000"))}";
                            row[5] = $"{string.Format("{0,10}", Convert.ToSingle(str2[5]).ToString("###0.000"))}";
                            row[6] = $"{string.Format("{0,10}", Convert.ToSingle(str2[6]).ToString("###0.000"))}";
                            row[7] = $"{string.Format("{0,10}", Convert.ToSingle(str2[7]).ToString("###0.000"))}";
                            break;
                        case "L":
                            str2 = line.Split(new string[] { "Num:", ",Mov:", ",X:", ",Y:", ",Z:", ",W:", ",P:", ",R:", ",V:" },
                                StringSplitOptions.RemoveEmptyEntries);
                            row[0] = str2[0].ToString();
                            row[1] = str2[1].ToString();
                            row[2] = $"{string.Format("{0,10}", Convert.ToSingle(str2[2]).ToString("###0.000"))}";
                            row[3] = $"{string.Format("{0,10}", Convert.ToSingle(str2[3]).ToString("###0.000"))}";
                            row[4] = $"{string.Format("{0,10}", Convert.ToSingle(str2[4]).ToString("###0.000"))}";
                            row[5] = $"{string.Format("{0,10}", Convert.ToSingle(str2[5]).ToString("###0.000"))}";
                            row[6] = $"{string.Format("{0,10}", Convert.ToSingle(str2[6]).ToString("###0.000"))}";
                            row[7] = $"{string.Format("{0,10}", Convert.ToSingle(str2[7]).ToString("###0.000"))}";
                            row[8] = $"{string.Format("{0,10}", Convert.ToSingle(str2[8]).ToString("###0.000"))}";
                            break;
                        default:
                            MessageBox.Show($"請輸入有效Mov值");
                            return;
                    }
                    dataTable.Rows.Add(row);
                }
                sr.Close();
            }
            else
            {
                MessageBox.Show("此路徑不存在");
                return;
            }
        }
        private void btnPointsSave_Click(object sender, EventArgs e)
        {
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("表格無資料");
                return;
            }

            if (txtFilePath.Text == "")
            {
                MessageBox.Show("檔案路徑不可空白");
                return;
            }

            sw = new StreamWriter(txtFilePath.Text, false);
            sw.WriteLine($"{myController.Robot.ToString()}");
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                switch (dataTable.Rows[i].ItemArray[1])
                {
                    case "C":
                        sw.WriteLine($"Num:{dataTable.Rows[i].ItemArray[0]},Mov:{dataTable.Rows[i].ItemArray[1]},X:{dataTable.Rows[i].ItemArray[2]}," +
                             $"Y:{dataTable.Rows[i].ItemArray[3]},Z:{dataTable.Rows[i].ItemArray[4]},W:{dataTable.Rows[i].ItemArray[5]}," +
                             $"P:{dataTable.Rows[i].ItemArray[6]},R:{dataTable.Rows[i].ItemArray[7]}");
                        break;
                    case "J":
                        sw.WriteLine($"Num:{dataTable.Rows[i].ItemArray[0]},Mov:{dataTable.Rows[i].ItemArray[1]},J1:{dataTable.Rows[i].ItemArray[2]}," +
                             $"J2:{dataTable.Rows[i].ItemArray[3]},J3:{dataTable.Rows[i].ItemArray[4]},J4:{dataTable.Rows[i].ItemArray[5]}," +
                             $"J5:{dataTable.Rows[i].ItemArray[6]},J6:{dataTable.Rows[i].ItemArray[7]}");
                        break;
                    case "L":
                        sw.WriteLine($"Num:{dataTable.Rows[i].ItemArray[0]},Mov:{dataTable.Rows[i].ItemArray[1]},X:{dataTable.Rows[i].ItemArray[2]}," +
                             $"Y:{dataTable.Rows[i].ItemArray[3]},Z:{dataTable.Rows[i].ItemArray[4]},W:{dataTable.Rows[i].ItemArray[5]}," +
                             $"P:{dataTable.Rows[i].ItemArray[6]},R:{dataTable.Rows[i].ItemArray[7]},V:{dataTable.Rows[i].ItemArray[8]}");
                        break;
                    default:
                        MessageBox.Show("請輸入有效Mov值");
                        return;
                }
            }
            sw.Close();
        }
        private void btnPointsSet_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Cells[1].Value.ToString() == "C")
                {
                    myController.Coordinate = Controller.Coordinatenum.Cartesian;
                    cboCoordinate.SelectedIndex = (int)myController.Coordinate;
                    cboProgramInstruction.SelectedIndex = (int)Controller.Instructionnum.MOVEC;
                    txtProgramXJ1.Text = $"{string.Format("{0,10}", Convert.ToSingle(dataGridView1.CurrentRow.Cells[2].Value).ToString("###0.000"))}";
                    txtProgramYJ2.Text = $"{string.Format("{0,10}", Convert.ToSingle(dataGridView1.CurrentRow.Cells[3].Value).ToString("###0.000"))}";
                    txtProgramZJ3.Text = $"{string.Format("{0,10}", Convert.ToSingle(dataGridView1.CurrentRow.Cells[4].Value).ToString("###0.000"))}";
                    txtProgramWJ4.Text = $"{string.Format("{0,10}", Convert.ToSingle(dataGridView1.CurrentRow.Cells[5].Value).ToString("###0.000"))}";
                    txtProgramPJ5.Text = $"{string.Format("{0,10}", Convert.ToSingle(dataGridView1.CurrentRow.Cells[6].Value).ToString("###0.000"))}";
                    txtProgramRJ6.Text = $"{string.Format("{0,10}", Convert.ToSingle(dataGridView1.CurrentRow.Cells[7].Value).ToString("###0.000"))}";
                }
                else if (dataGridView1.CurrentRow.Cells[1].Value.ToString() == "L")
                {
                    myController.Coordinate = Controller.Coordinatenum.Cartesian;
                    cboCoordinate.SelectedIndex = (int)myController.Coordinate;
                    cboProgramInstruction.SelectedIndex = (int)Controller.Instructionnum.MOVEL;
                    txtProgramXJ1.Text = $"{string.Format("{0,10}", Convert.ToSingle(dataGridView1.CurrentRow.Cells[2].Value).ToString("###0.000"))}";
                    txtProgramYJ2.Text = $"{string.Format("{0,10}", Convert.ToSingle(dataGridView1.CurrentRow.Cells[3].Value).ToString("###0.000"))}";
                    txtProgramZJ3.Text = $"{string.Format("{0,10}", Convert.ToSingle(dataGridView1.CurrentRow.Cells[4].Value).ToString("###0.000"))}";
                    txtProgramWJ4.Text = $"{string.Format("{0,10}", Convert.ToSingle(dataGridView1.CurrentRow.Cells[5].Value).ToString("###0.000"))}";
                    txtProgramPJ5.Text = $"{string.Format("{0,10}", Convert.ToSingle(dataGridView1.CurrentRow.Cells[6].Value).ToString("###0.000"))}";
                    txtProgramRJ6.Text = $"{string.Format("{0,10}", Convert.ToSingle(dataGridView1.CurrentRow.Cells[7].Value).ToString("###0.000"))}";
                    txtProgramValue.Text = $"{string.Format("{0,10}", Convert.ToSingle(dataGridView1.CurrentRow.Cells[8].Value).ToString("###0.000"))}";
                }
                else if (dataGridView1.CurrentRow.Cells[1].Value.ToString() == "J")
                {
                    myController.Coordinate = Controller.Coordinatenum.Joint;
                    cboCoordinate.SelectedIndex = (int)myController.Coordinate;
                    cboProgramInstruction.SelectedIndex = (int)Controller.Instructionnum.MOVEJ;
                    txtProgramXJ1.Text = $"{string.Format("{0,10}", Convert.ToSingle(dataGridView1.CurrentRow.Cells[2].Value).ToString("###0.000"))}";
                    txtProgramYJ2.Text = $"{string.Format("{0,10}", Convert.ToSingle(dataGridView1.CurrentRow.Cells[3].Value).ToString("###0.000"))}";
                    txtProgramZJ3.Text = $"{string.Format("{0,10}", Convert.ToSingle(dataGridView1.CurrentRow.Cells[4].Value).ToString("###0.000"))}";
                    txtProgramWJ4.Text = $"{string.Format("{0,10}", Convert.ToSingle(dataGridView1.CurrentRow.Cells[5].Value).ToString("###0.000"))}";
                    txtProgramPJ5.Text = $"{string.Format("{0,10}", Convert.ToSingle(dataGridView1.CurrentRow.Cells[6].Value).ToString("###0.000"))}";
                    txtProgramRJ6.Text = $"{string.Format("{0,10}", Convert.ToSingle(dataGridView1.CurrentRow.Cells[7].Value).ToString("###0.000"))}";
                }
                else
                {
                    MessageBox.Show($"請輸入有效值");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入有效數值");
            }
        }
        private void btnPointsGet_Click(object sender, EventArgs e)
        {
            DataRow row = dataTable.NewRow();
            row[0] = dataTable.Rows.Count + 1;
            switch (myController.Coordinate)
            {
                case Controller.Coordinatenum.Cartesian:
                    row[1] = 'L';
                    row[2] = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(0)).ToString("###0.000"))}";
                    row[3] = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(1)).ToString("###0.000"))}";
                    row[4] = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(2)).ToString("###0.000"))}";
                    row[5] = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(3)).ToString("###0.000"))}";
                    row[6] = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(4)).ToString("###0.000"))}";
                    row[7] = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(5)).ToString("###0.000"))}";

                    if (!myController.GetVelocity())
                    {
                        ShowMessage("讀取速度失敗", "讀取速度狀態");
                        txtProgramValue.Text = "Erorr";
                        return;
                    }
                    else
                    {
                        row[8] = $"{string.Format("{0,10}", RobotAdapter.getvelocity.ToString("###0.000"))}";
                    }
                    break;
                case Controller.Coordinatenum.Joint:
                    row[1] = 'J';
                    row[2] = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(0)).ToString("###0.000"))}";
                    row[3] = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(1)).ToString("###0.000"))}";
                    row[4] = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(2)).ToString("###0.000"))}";
                    row[5] = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(3)).ToString("###0.000"))}";
                    row[6] = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(4)).ToString("###0.000"))}";
                    row[7] = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(5)).ToString("###0.000"))}";
                    break;
            }
            dataTable.Rows.Add(row);
        }
        #endregion

        #region <gbProgram>
        private void cboProgramInstruction_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboProgramInstruction.SelectedIndex)
            {
                case (int)Controller.Instructionnum.OVERRIDE:
                    myController.Instruction = Controller.Instructionnum.OVERRIDE;
                    lblProgramUnit.Text = "(%)";
                    txtProgramValue.Enabled = true;
                    txtProgramXJ1.Enabled = false;
                    txtProgramYJ2.Enabled = false;
                    txtProgramZJ3.Enabled = false;
                    txtProgramWJ4.Enabled = false;
                    txtProgramPJ5.Enabled = false;
                    txtProgramRJ6.Enabled = false;
                    btnProgramGet.Enabled = false;
                    break;
                case (int)Controller.Instructionnum.MOVEC:
                    myController.Instruction = Controller.Instructionnum.MOVEC;
                    myController.Coordinate = Controller.Coordinatenum.Cartesian;
                    lblProgramUnit.Text = "";
                    txtProgramValue.Enabled = false;
                    txtProgramXJ1.Enabled = true;
                    txtProgramYJ2.Enabled = true;
                    txtProgramZJ3.Enabled = true;
                    txtProgramWJ4.Enabled = true;
                    txtProgramPJ5.Enabled = true;
                    txtProgramRJ6.Enabled = true;
                    btnProgramGet.Enabled = true;
                    break;
                case (int)Controller.Instructionnum.MOVEJ:
                    myController.Instruction = Controller.Instructionnum.MOVEJ;
                    myController.Coordinate = Controller.Coordinatenum.Joint;
                    lblProgramUnit.Text = "";
                    txtProgramValue.Enabled = false;
                    txtProgramXJ1.Enabled = true;
                    txtProgramYJ2.Enabled = true;
                    txtProgramZJ3.Enabled = true;
                    txtProgramWJ4.Enabled = true;
                    txtProgramPJ5.Enabled = true;
                    txtProgramRJ6.Enabled = true;
                    btnProgramGet.Enabled = true;
                    break;
                case (int)Controller.Instructionnum.MOVEL:
                    myController.Instruction = Controller.Instructionnum.MOVEL;
                    myController.Coordinate = Controller.Coordinatenum.Cartesian;
                    lblProgramUnit.Text = "(unit/s)";
                    txtProgramValue.Enabled = true;
                    txtProgramXJ1.Enabled = true;
                    txtProgramYJ2.Enabled = true;
                    txtProgramZJ3.Enabled = true;
                    txtProgramWJ4.Enabled = true;
                    txtProgramPJ5.Enabled = true;
                    txtProgramRJ6.Enabled = true;
                    btnProgramGet.Enabled = true;
                    break;
                case (int)Controller.Instructionnum.WAIT:
                    myController.Instruction = Controller.Instructionnum.WAIT;
                    lblProgramUnit.Text = "(sec)";
                    txtProgramValue.Enabled = true;
                    txtProgramXJ1.Enabled = false;
                    txtProgramYJ2.Enabled = false;
                    txtProgramZJ3.Enabled = false;
                    txtProgramWJ4.Enabled = false;
                    txtProgramPJ5.Enabled = false;
                    txtProgramRJ6.Enabled = false;
                    btnProgramGet.Enabled = false;
                    break;
                case (int)Controller.Instructionnum.TOOL:
                    myController.Instruction = Controller.Instructionnum.TOOL;
                    lblProgramUnit.Text = "";
                    txtProgramValue.Enabled = true;
                    txtProgramXJ1.Enabled = false;
                    txtProgramYJ2.Enabled = false;
                    txtProgramZJ3.Enabled = false;
                    txtProgramWJ4.Enabled = false;
                    txtProgramPJ5.Enabled = false;
                    txtProgramRJ6.Enabled = false;
                    btnProgramGet.Enabled = false;
                    break;
                case (int)Controller.Instructionnum.FRAME:
                    myController.Instruction = Controller.Instructionnum.FRAME;
                    lblProgramUnit.Text = "";
                    txtProgramValue.Enabled = true;
                    txtProgramXJ1.Enabled = false;
                    txtProgramYJ2.Enabled = false;
                    txtProgramZJ3.Enabled = false;
                    txtProgramWJ4.Enabled = false;
                    txtProgramPJ5.Enabled = false;
                    txtProgramRJ6.Enabled = false;
                    btnProgramGet.Enabled = false;
                    break;
            }
            cboCoordinate.SelectedIndex = (int)myController.Coordinate;
        }
        private void btnProgramAdd_Click(object sender, EventArgs e)
        {
            string instruction = "";
            if (!ProgramInstruction(ref instruction))
            {
                return;
            }
            instruction = $"{lstProgram.Items.Count + 1}. {instruction}";
            lstProgram.Items.Add(instruction);
        }
        private void btnProgramInsert_Click(object sender, EventArgs e)
        {
            string instruction = "";
            int index = lstProgram.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("請選擇插入位置");
                return;
            }
            if (!ProgramInstruction(ref instruction))
            {
                return;
            }
            instruction = $"{index + 1}. {instruction}";
            lstProgram.Items.Insert(index, instruction);
            for (int i = index + 1; i < lstProgram.Items.Count; i++)
            {
                string str = lstProgram.Items[i].ToString();
                string str1 = str.Substring(str.IndexOf(' ') + 1);
                lstProgram.Items[i] = $"{i + 1}. {str1}";
            }
        }
        private void btnProgramEdit_Click(object sender, EventArgs e)
        {
            string instruction = "";
            int index = lstProgram.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("請選擇編譯位置");
                return;
            }
            if (!ProgramInstruction(ref instruction))
            {
                return;
            }
            instruction = $"{index + 1}. {instruction}";
            lstProgram.Items[index] = instruction;
        }
        private void btnProgramCopy_Click(object sender, EventArgs e)
        {
            int index = lstProgram.SelectedIndex;
            if (index < 0)
            {
                return;
            }

            string ins = lstProgram.Items[index].ToString();
            string[] str1 = ins.Split(new string[] { ". ", " " }, StringSplitOptions.RemoveEmptyEntries);
            string[] str2;

            switch (str1[1])
            {
                case nameof(Controller.Instructionnum.OVERRIDE):
                    cboProgramInstruction.SelectedIndex = (int)Controller.Instructionnum.OVERRIDE;
                    str2 = ins.Split(new string[] { ". ", Controller.Instructionnum.OVERRIDE.ToString(), " = ", "%" },
                        StringSplitOptions.RemoveEmptyEntries);
                    txtProgramValue.Text = $"{string.Format("{0,10}", Convert.ToSingle(str2[1]).ToString("###0.000"))}";
                    break;
                case nameof(Controller.Instructionnum.MOVEC):
                    cboProgramInstruction.SelectedIndex = (int)Controller.Instructionnum.MOVEC;
                    str2 = ins.Split(new string[] { ". ", Controller.Instructionnum.MOVEC.ToString(), " (", ", ", ")" },
                        StringSplitOptions.RemoveEmptyEntries);
                    txtProgramXJ1.Text = $"{string.Format("{0,10}", Convert.ToSingle(str2[1]).ToString("###0.000"))}";
                    txtProgramYJ2.Text = $"{string.Format("{0,10}", Convert.ToSingle(str2[2]).ToString("###0.000"))}";
                    txtProgramZJ3.Text = $"{string.Format("{0,10}", Convert.ToSingle(str2[3]).ToString("###0.000"))}";
                    txtProgramWJ4.Text = $"{string.Format("{0,10}", Convert.ToSingle(str2[4]).ToString("###0.000"))}";
                    txtProgramPJ5.Text = $"{string.Format("{0,10}", Convert.ToSingle(str2[5]).ToString("###0.000"))}";
                    txtProgramRJ6.Text = $"{string.Format("{0,10}", Convert.ToSingle(str2[6]).ToString("###0.000"))}";
                    break;
                case nameof(Controller.Instructionnum.MOVEJ):
                    cboProgramInstruction.SelectedIndex = (int)Controller.Instructionnum.MOVEJ;
                    str2 = ins.Split(new string[] { ". ", Controller.Instructionnum.MOVEJ.ToString(), " (", ", ", ")" },
                        StringSplitOptions.RemoveEmptyEntries);
                    txtProgramXJ1.Text = $"{string.Format("{0,10}", Convert.ToSingle(str2[1]).ToString("###0.000"))}";
                    txtProgramYJ2.Text = $"{string.Format("{0,10}", Convert.ToSingle(str2[2]).ToString("###0.000"))}";
                    txtProgramZJ3.Text = $"{string.Format("{0,10}", Convert.ToSingle(str2[3]).ToString("###0.000"))}";
                    txtProgramWJ4.Text = $"{string.Format("{0,10}", Convert.ToSingle(str2[4]).ToString("###0.000"))}";
                    txtProgramPJ5.Text = $"{string.Format("{0,10}", Convert.ToSingle(str2[5]).ToString("###0.000"))}";
                    txtProgramRJ6.Text = $"{string.Format("{0,10}", Convert.ToSingle(str2[6]).ToString("###0.000"))}";
                    break;
                case nameof(Controller.Instructionnum.MOVEL):
                    cboProgramInstruction.SelectedIndex = (int)Controller.Instructionnum.MOVEL;
                    str2 = ins.Split(new string[] { ". ", Controller.Instructionnum.MOVEL.ToString(), " (", ", ", ")" },
                        StringSplitOptions.RemoveEmptyEntries);
                    txtProgramXJ1.Text = $"{string.Format("{0,10}", Convert.ToSingle(str2[1]).ToString("###0.000"))}";
                    txtProgramYJ2.Text = $"{string.Format("{0,10}", Convert.ToSingle(str2[2]).ToString("###0.000"))}";
                    txtProgramZJ3.Text = $"{string.Format("{0,10}", Convert.ToSingle(str2[3]).ToString("###0.000"))}";
                    txtProgramWJ4.Text = $"{string.Format("{0,10}", Convert.ToSingle(str2[4]).ToString("###0.000"))}";
                    txtProgramPJ5.Text = $"{string.Format("{0,10}", Convert.ToSingle(str2[5]).ToString("###0.000"))}";
                    txtProgramRJ6.Text = $"{string.Format("{0,10}", Convert.ToSingle(str2[6]).ToString("###0.000"))}";
                    txtProgramValue.Text = $"{string.Format("{0,10}", Convert.ToSingle(str2[7]).ToString("###0.000"))}";
                    break;
                case nameof(Controller.Instructionnum.WAIT):
                    cboProgramInstruction.SelectedIndex = (int)Controller.Instructionnum.WAIT;
                    str2 = ins.Split(new string[] { ". ", Controller.Instructionnum.WAIT.ToString(), " ", " sec" },
                        StringSplitOptions.RemoveEmptyEntries);
                    txtProgramValue.Text = $"{string.Format("{0,10}", Convert.ToSingle(str2[1]).ToString("###0.000"))}";
                    break;
            }

        }
        private void btnProgramDelete_Click(object sender, EventArgs e)
        {
            int index = lstProgram.SelectedIndex;
            if (index < 0)
            {
                return;
            }
            lstProgram.Items.RemoveAt(index);
            lstProgram.SelectedIndex = index - 1;
            for (int i = index; i < lstProgram.Items.Count; i++)
            {
                string str = lstProgram.Items[i].ToString();
                string str1 = str.Substring(str.IndexOf(' ') + 1);
                lstProgram.Items[i] = $"{i + 1}. {str1}";
            }
        }
        private void btnProgramClear_Click(object sender, EventArgs e)
        {
            lstProgram.Items.Clear();
        }
        private bool ProgramInstruction(ref string ins)
        {
            try
            {
                switch (myController.Instruction)
                {
                    case Controller.Instructionnum.OVERRIDE:
                        if (string.IsNullOrEmpty(txtProgramValue.Text))
                        {
                            MessageBox.Show("Override值不可空白");
                            return false;
                        }

                        RobotAdapter.safeoverride = Convert.ToInt32(txtProgramValue.Text);
                        if (!myController.SafeRangeCheckOverride())
                        {
                            MessageBox.Show("速度百分比超出安全範圍", "速度百分比安全範圍狀態");
                            return false;
                        }

                        ins = $"{myController.Instruction.ToString()} = {RobotAdapter.safeoverride}%";
                        return true;
                    case Controller.Instructionnum.MOVEC:
                        if (string.IsNullOrEmpty(txtProgramXJ1.Text) || string.IsNullOrEmpty(txtProgramYJ2.Text) ||
                            string.IsNullOrEmpty(txtProgramZJ3.Text) || string.IsNullOrEmpty(txtProgramWJ4.Text) ||
                            string.IsNullOrEmpty(txtProgramPJ5.Text) || string.IsNullOrEmpty(txtProgramRJ6.Text))
                        {
                            MessageBox.Show("座標值不可有空白");
                            return false;
                        }

                        RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtProgramXJ1.Text), 0);
                        RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtProgramYJ2.Text), 1);
                        RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtProgramZJ3.Text), 2);
                        RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtProgramWJ4.Text), 3);
                        RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtProgramPJ5.Text), 4);
                        RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtProgramRJ6.Text), 5);
                        if (!myController.SafeRangeCheckXYZ())
                        {
                            MessageBox.Show("超出安全範圍", "安全範圍狀態");
                            return false;
                        }

                        ins = $"{myController.Instruction.ToString()}" +
                              $" ({Convert.ToSingle(RobotAdapter.safecheck.GetValue(0))}," +
                              $" {Convert.ToSingle(RobotAdapter.safecheck.GetValue(1))}," +
                              $" {Convert.ToSingle(RobotAdapter.safecheck.GetValue(2))}," +
                              $" {Convert.ToSingle(RobotAdapter.safecheck.GetValue(3))}," +
                              $" {Convert.ToSingle(RobotAdapter.safecheck.GetValue(4))}," +
                              $" {Convert.ToSingle(RobotAdapter.safecheck.GetValue(5))})";
                        return true;
                    case Controller.Instructionnum.MOVEJ:
                        if (string.IsNullOrEmpty(txtProgramXJ1.Text) || string.IsNullOrEmpty(txtProgramYJ2.Text) ||
                            string.IsNullOrEmpty(txtProgramZJ3.Text) || string.IsNullOrEmpty(txtProgramWJ4.Text) ||
                            string.IsNullOrEmpty(txtProgramPJ5.Text) || string.IsNullOrEmpty(txtProgramRJ6.Text))
                        {
                            MessageBox.Show("座標值不可有空白");
                            return false;
                        }

                        RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtProgramXJ1.Text), 0);
                        RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtProgramYJ2.Text), 1);
                        RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtProgramZJ3.Text), 2);
                        RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtProgramWJ4.Text), 3);
                        RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtProgramPJ5.Text), 4);
                        RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtProgramRJ6.Text), 5);
                        if (!myController.SafeRangeCheckJoint())
                        {
                            MessageBox.Show("超出安全範圍", "安全範圍狀態");
                            return false;
                        }

                        ins = $"{myController.Instruction.ToString()}" +
                              $" ({Convert.ToSingle(RobotAdapter.safecheck.GetValue(0))}," +
                              $" {Convert.ToSingle(RobotAdapter.safecheck.GetValue(1))}," +
                              $" {Convert.ToSingle(RobotAdapter.safecheck.GetValue(2))}," +
                              $" {Convert.ToSingle(RobotAdapter.safecheck.GetValue(3))}," +
                              $" {Convert.ToSingle(RobotAdapter.safecheck.GetValue(4))}," +
                              $" {Convert.ToSingle(RobotAdapter.safecheck.GetValue(5))})";
                        return true;
                    case Controller.Instructionnum.MOVEL:
                        if (string.IsNullOrEmpty(txtProgramXJ1.Text) || string.IsNullOrEmpty(txtProgramYJ2.Text) ||
                            string.IsNullOrEmpty(txtProgramZJ3.Text) || string.IsNullOrEmpty(txtProgramWJ4.Text) ||
                            string.IsNullOrEmpty(txtProgramPJ5.Text) || string.IsNullOrEmpty(txtProgramRJ6.Text) ||
                            string.IsNullOrEmpty(txtProgramValue.Text))
                        {
                            MessageBox.Show("座標值和速度值不可有空白");
                            return false;
                        }

                        RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtProgramXJ1.Text), 0);
                        RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtProgramYJ2.Text), 1);
                        RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtProgramZJ3.Text), 2);
                        RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtProgramWJ4.Text), 3);
                        RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtProgramPJ5.Text), 4);
                        RobotAdapter.safecheck.SetValue(Convert.ToSingle(txtProgramRJ6.Text), 5);
                        RobotAdapter.safevelocity = Convert.ToSingle(txtProgramValue.Text);

                        if (!myController.SafeRangeCheckXYZ())
                        {
                            MessageBox.Show("超出安全範圍", "安全範圍狀態");
                            return false;
                        }

                        if (!myController.SafeRangeCheckVelocity())
                        {
                            MessageBox.Show("速度超出安全範圍");
                            return false;
                        }

                        ins = $"{myController.Instruction.ToString()}" +
                              $" ({Convert.ToSingle(RobotAdapter.safecheck.GetValue(0))}," +
                              $" {Convert.ToSingle(RobotAdapter.safecheck.GetValue(1))}," +
                              $" {Convert.ToSingle(RobotAdapter.safecheck.GetValue(2))}," +
                              $" {Convert.ToSingle(RobotAdapter.safecheck.GetValue(3))}," +
                              $" {Convert.ToSingle(RobotAdapter.safecheck.GetValue(4))}," +
                              $" {Convert.ToSingle(RobotAdapter.safecheck.GetValue(5))}," +
                              $" {RobotAdapter.safevelocity})";
                        return true;
                    case Controller.Instructionnum.WAIT:
                        if (string.IsNullOrEmpty(txtProgramValue.Text))
                        {
                            MessageBox.Show("Wait值不可空白");
                            return false;
                        }

                        int sec = Convert.ToInt32(txtProgramValue.Text);
                        if (sec < 0 || sec > 30)
                        {
                            MessageBox.Show("等待時間超出範圍", "等待時間範圍狀態");
                            return false;
                        }

                        ins = $"{myController.Instruction.ToString()} {sec} sec";
                        return true;
                    case Controller.Instructionnum.TOOL:
                        if (string.IsNullOrEmpty(txtProgramValue.Text))
                        {
                            MessageBox.Show("工具中心點值不可空白");
                            return false;
                        }

                        int tool = Convert.ToInt32(txtProgramValue.Text);
                        if (tool < 0 || tool > 10)
                        {
                            MessageBox.Show("工具中心點值超出範圍", "工具中心點值範圍狀態");
                            return false;
                        }

                        ins = $"{myController.Instruction.ToString()} = {tool}";
                        return true;
                    case Controller.Instructionnum.FRAME:
                        if (string.IsNullOrEmpty(txtProgramValue.Text))
                        {
                            MessageBox.Show("座標系值不可空白");
                            return false;
                        }

                        int frame = Convert.ToInt32(txtProgramValue.Text);
                        if (frame < 0 || frame > 10)
                        {
                            MessageBox.Show("座標系超出範圍", "座標系範圍狀態");
                            return false;
                        }

                        ins = $"{myController.Instruction.ToString()} = {frame}";
                        return true;
                    default:
                        return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入有效數值");
                return false;
            }
        }
        private void btnProgramCompile_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(ProgramCompile);
            thread.Start();
        }
        private void btnProgramGet_Click(object sender, EventArgs e)
        {
            switch (myController.Coordinate)
            {
                case Controller.Coordinatenum.Cartesian:
                    txtProgramXJ1.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(0)).ToString("###0.000"))}";
                    txtProgramYJ2.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(1)).ToString("###0.000"))}";
                    txtProgramZJ3.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(2)).ToString("###0.000"))}";
                    txtProgramWJ4.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(3)).ToString("###0.000"))}";
                    txtProgramPJ5.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(4)).ToString("###0.000"))}";
                    txtProgramRJ6.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(5)).ToString("###0.000"))}";

                    if (!myController.GetVelocity())
                    {
                        ShowMessage("讀取速度失敗", "讀取速度狀態");
                        txtProgramValue.Text = "Erorr";
                        return;
                    }
                    else
                    {
                        txtProgramValue.Text = $"{string.Format("{0,10}", RobotAdapter.getvelocity.ToString("###0.000"))}";
                    }
                    break;
                case Controller.Coordinatenum.Joint:
                    txtProgramXJ1.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(0)).ToString("###0.000"))}";
                    txtProgramYJ2.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(1)).ToString("###0.000"))}";
                    txtProgramZJ3.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(2)).ToString("###0.000"))}";
                    txtProgramWJ4.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(3)).ToString("###0.000"))}";
                    txtProgramPJ5.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(4)).ToString("###0.000"))}";
                    txtProgramRJ6.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(5)).ToString("###0.000"))}";
                    break;
            }
        }
        private void ProgramCompile()
        {
            if (lstProgram.Items.Count == 0)
                return;
            if (myController.Robot == Controller.Robotnum.Fanuc)
            {
                if (string.IsNullOrEmpty(txtProgramName.Text))
                {
                    MessageBox.Show("程式名稱不可空白");
                    return;
                }
                RobotAdapter.programname = txtProgramName.Text;
            }
            for (int i = 0; i <= lstProgram.Items.Count; i++)
            {
                if (i == lstProgram.Items.Count)
                {
                    RobotAdapter.compile.SetValue(-1, 0);
                    if (!myController.Compile())
                    {
                        ShowMessage("編譯失敗", "編譯狀態");
                        return;
                    }
                    MessageBox.Show("編譯完成");
                    return;
                }

                string ins = lstProgram.Items[i].ToString();
                string[] str1 = ins.Split(new string[] { ". ", " " }, StringSplitOptions.RemoveEmptyEntries);
                string[] str2;

                switch (str1[1])
                {
                    case nameof(Controller.Instructionnum.OVERRIDE):
                        RobotAdapter.compile.SetValue((int)Controller.Instructionnum.OVERRIDE, 1);
                        str2 = ins.Split(new string[] { ". ", Controller.Instructionnum.OVERRIDE.ToString(), " = ", "%" },
                            StringSplitOptions.RemoveEmptyEntries);
                        RobotAdapter.compile.SetValue(Convert.ToSingle(str2[0]), 0);
                        RobotAdapter.compile.SetValue(Convert.ToSingle(str2[1]), 2);
                        if (!myController.Compile())
                        {
                            ShowMessage("編譯失敗", "編譯狀態");
                            return;
                        }
                        break;
                    case nameof(Controller.Instructionnum.MOVEC):
                        RobotAdapter.compile.SetValue((int)Controller.Instructionnum.MOVEC, 1);
                        str2 = ins.Split(new string[] { ". ", Controller.Instructionnum.MOVEC.ToString(), " (", ", ", ")" },
                            StringSplitOptions.RemoveEmptyEntries);
                        RobotAdapter.compile.SetValue(Convert.ToSingle(str2[0]), 0);
                        for (int j = 1; j < str2.Length; j++)
                        {
                            RobotAdapter.compile.SetValue(Convert.ToSingle(str2[j]), j + 1);
                        }
                        if (!myController.Compile())
                        {
                            ShowMessage("編譯失敗", "編譯狀態");
                            return;
                        }
                        break;
                    case nameof(Controller.Instructionnum.MOVEJ):
                        RobotAdapter.compile.SetValue((int)Controller.Instructionnum.MOVEJ, 1);
                        str2 = ins.Split(new string[] { ". ", Controller.Instructionnum.MOVEJ.ToString(), " (", ", ", ")" },
                            StringSplitOptions.RemoveEmptyEntries);
                        RobotAdapter.compile.SetValue(Convert.ToSingle(str2[0]), 0);
                        for (int j = 1; j < str2.Length; j++)
                        {
                            RobotAdapter.compile.SetValue(Convert.ToSingle(str2[j]), j + 1);
                        }
                        if (!myController.Compile())
                        {
                            ShowMessage("編譯失敗", "編譯狀態");
                            return;
                        }
                        break;
                    case nameof(Controller.Instructionnum.MOVEL):
                        RobotAdapter.compile.SetValue((int)Controller.Instructionnum.MOVEL, 1);
                        str2 = ins.Split(new string[] { ". ", Controller.Instructionnum.MOVEL.ToString(), " (", ", ", ")" },
                            StringSplitOptions.RemoveEmptyEntries);
                        RobotAdapter.compile.SetValue(Convert.ToSingle(str2[0]), 0);
                        for (int j = 1; j < str2.Length; j++)
                        {
                            RobotAdapter.compile.SetValue(Convert.ToSingle(str2[j]), j + 1);
                        }
                        if (!myController.Compile())
                        {
                            ShowMessage("編譯失敗", "編譯狀態");
                            return;
                        }
                        break;
                    case nameof(Controller.Instructionnum.WAIT):
                        RobotAdapter.compile.SetValue((int)Controller.Instructionnum.WAIT, 1);
                        str2 = ins.Split(new string[] { ". ", Controller.Instructionnum.WAIT.ToString(), " ", " sec" },
                            StringSplitOptions.RemoveEmptyEntries);
                        RobotAdapter.compile.SetValue(Convert.ToSingle(str2[0]), 0);
                        RobotAdapter.compile.SetValue(Convert.ToSingle(str2[1]), 2);
                        if (!myController.Compile())
                        {
                            ShowMessage("編譯失敗", "編譯狀態");
                            return;
                        }
                        break;
                    case nameof(Controller.Instructionnum.TOOL):
                        RobotAdapter.compile.SetValue((int)Controller.Instructionnum.TOOL, 1);
                        str2 = ins.Split(new string[] { ". ", Controller.Instructionnum.TOOL.ToString(), " = " },
                            StringSplitOptions.RemoveEmptyEntries);
                        RobotAdapter.compile.SetValue(Convert.ToSingle(str2[0]), 0);
                        RobotAdapter.compile.SetValue(Convert.ToSingle(str2[1]), 2);
                        if (!myController.Compile())
                        {
                            ShowMessage("編譯失敗", "編譯狀態");
                            return;
                        }
                        break;
                    case nameof(Controller.Instructionnum.FRAME):
                        RobotAdapter.compile.SetValue((int)Controller.Instructionnum.FRAME, 1);
                        str2 = ins.Split(new string[] { ". ", Controller.Instructionnum.FRAME.ToString(), " = " },
                            StringSplitOptions.RemoveEmptyEntries);
                        RobotAdapter.compile.SetValue(Convert.ToSingle(str2[0]), 0);
                        RobotAdapter.compile.SetValue(Convert.ToSingle(str2[1]), 2);
                        if (!myController.Compile())
                        {
                            ShowMessage("編譯失敗", "編譯狀態");
                            return;
                        }
                        break;
                }
            }
        }
        #endregion

        #region <gbGripper>
        private void btnGripperConnect_Click(object sender, EventArgs e)
        {
            if (fgGripperConnectionState == false)
            {
                if (!myController.GripperConnect())
                {
                    MessageBox.Show("夾爪連線失敗");
                    return;
                }
                fgGripperConnectionState = true;
                btnGripperConnect.Text = "Disconnect";
                btnGrap.Enabled = true;
                btnOpen.Enabled = true;
            }
            else
            {
                if (!myController.GripperDisconnect())
                {
                    MessageBox.Show("夾爪離線失敗");
                    return;
                }
                fgGripperConnectionState = false;
                btnGripperConnect.Text = "Connect";
                btnGrap.Enabled = false;
                btnOpen.Enabled = false;
            }
        }
        private void btnGrap_Click(object sender, EventArgs e)
        {
            if (fgGripperState == false)
            {
                if (!myController.GripperGrap())
                {
                    MessageBox.Show("夾爪抓取失敗");
                    return;
                }
                btnGrap.Text = "Stop";
                btnOpen.Text = "Stop";
                fgGripperState = true;
            }
            else
            {
                if (!myController.GripperStop())
                {
                    MessageBox.Show("夾爪抓取失敗");
                    return;
                }
                btnGrap.Text = "Grap";
                btnOpen.Text = "Open";
                fgGripperState = false;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (fgGripperState == false)
            {
                if (!myController.GripperOpen())
                {
                    MessageBox.Show("夾爪打開失敗");
                    return;
                }
                btnGrap.Text = "Stop";
                btnOpen.Text = "Stop";
                fgGripperState = true;
            }
            else
            {
                if (!myController.GripperStop())
                {
                    MessageBox.Show("夾爪抓取失敗");
                    return;
                }
                btnGrap.Text = "Grap";
                btnOpen.Text = "Open";
                fgGripperState = false;
            }
        }
        #endregion

    }
}
