using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Integrated_Robot_Interface
{
    public partial class FrmMain : Form
    {
        //變數宣告
        private Controller myController;
        private FrmInformation f;
        private DataTable dataTable;
        private bool fgConnectionState { get; set; } = false;
        private bool fgRobotState { get; set; } = false;
        

        public FrmMain()
        {
            InitializeComponent();
            myController = new Controller();
            f = new FrmInformation();
            dataTable = new DataTable();
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
            cboSafeRangeCoordinate.Items.Clear();
            cboSafeRangeCoordinate.Items.AddRange(Coordinate);
            cboPTPCoordinate.Items.Clear();
            cboPTPCoordinate.Items.AddRange(Coordinate);
            cboLineCoordinate.Items.Clear();
            cboLineCoordinate.Items.AddRange(Coordinate);
            string[] Step = new string[] { Controller.Stepnum.One.ToString(), Controller.Stepnum.Five.ToString(),
                                           Controller.Stepnum.Ten.ToString(), Controller.Stepnum.Cont.ToString() };
            cboJogStep.Items.Clear();
            cboJogStep.Items.AddRange(Step);
            txtInitialize();
            cboRobot.SelectedIndex = 0;
            timer1.Interval = 500;
            timer1.Enabled = false;
            txtIP.Enabled = false;
            fgConnectionState = false;
            fgRobotState = false;
            cboRobot.Enabled = true;
            gbEnbleControl(false);
            tbSafeRangeEnbleControl(false);
            f.Hide();
        }
        private void gbEnbleControl(bool tf)
        {
            gbOverride.Enabled = tf;
            gbCurrentPosition.Enabled = tf;
            gbPTP.Enabled = tf;
            gbRegister.Enabled = tf;
            gbJog.Enabled = tf;
            gbControl.Enabled = tf;
            gbLine.Enabled = tf;
            gbSafeRange.Enabled = tf;
            gbPointsMove.Enabled = tf;
        }
        private void tbSafeRangeEnbleControl(bool tf)
        {
            tbSafeRangeXJ1min.Enabled = tf;
            tbSafeRangeXJ1max.Enabled = tf;
            tbSafeRangeYJ2min.Enabled = tf;
            tbSafeRangeYJ2max.Enabled = tf;
            tbSafeRangeZJ3min.Enabled = tf;
            tbSafeRangeZJ3max.Enabled = tf;
            tbSafeRangeWJ4min.Enabled = tf;
            tbSafeRangeWJ4max.Enabled = tf;
            tbSafeRangePJ5min.Enabled = tf;
            tbSafeRangePJ5max.Enabled = tf;
            tbSafeRangeRJ6min.Enabled = tf;
            tbSafeRangeRJ6max.Enabled = tf;
        }
        private void txtInitialize()
        {
            btnConnection.Text = "Connect";
            lblConnectionStatus.Text = "Connection Status : Disconnected";
            lblXyzwpr.Text = "Cartesian\r\nX : \r\nY : \r\nZ : \r\nW: \r\nP : \r\nR : ";
            lblJoint.Text = "Joint\r\nJ1 : \r\nJ2 : \r\nJ3 : \r\nJ4 : \r\nJ5 : \r\nJ6 : ";
            lblOverride.Text = "";
            tbPTPXJ1Set.Text = "";
            tbPTPYJ2Set.Text = "";
            tbPTPZJ3Set.Text = "";
            tbPTPWJ4Set.Text = "";
            tbPTPPJ5Set.Text = "";
            tbPTPRJ6Set.Text = "";
            tbLineXJ1Set.Text = "";
            tbLineYJ2Set.Text = "";
            tbLineZJ3Set.Text = "";
            tbLineWJ4Set.Text = "";
            tbLinePJ5Set.Text = "";
            tbLineRJ6Set.Text = "";
            tbLineVelocitySet.Text = "";
            lblOverride.Text = "";
            tbR1Set.Text = "";
            tbR2Set.Text = "";
            tbR3Set.Text = "";
            tbR4Set.Text = "";
            tbR5Set.Text = "";
            tbSafeRangeXJ1max.Text = "";
            tbSafeRangeXJ1min.Text = "";
            tbSafeRangeYJ2max.Text = "";
            tbSafeRangeYJ2min.Text = "";
            tbSafeRangeZJ3max.Text = "";
            tbSafeRangeZJ3min.Text = "";
            tbSafeRangeWJ4max.Text = "";
            tbSafeRangeWJ4min.Text = "";
            tbSafeRangePJ5max.Text = "";
            tbSafeRangePJ5min.Text = "";
            tbSafeRangeRJ6max.Text = "";
            tbSafeRangeRJ6min.Text = "";
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
        private void btnInformation_Click(object sender, EventArgs e)
        {
            if (f.Visible)
            {
                f.Hide();
            }
            else
            {
                f.Show();
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
            if (!myController.GetInformation2())
            {
                ShowMessage("取得資料2失敗", "取得資料狀態");
                return;
            }
            if (!myController.GetInformation3())
            {
                ShowMessage("取得資料3失敗", "取得資料狀態");
                return;
            }
            if (!myController.GetInformation4())
            {
                ShowMessage("取得資料4失敗", "取得資料狀態");
                return;
            }
        }
        private void ShowMessage(string content, string title)
        {
            DialogResult result;
            fgRobotState = false;
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
            else if (result == DialogResult.Ignore)
            {
                fgRobotState = true;
                timer1.Enabled = true;
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
                    lblLineVelocityUnit.Text = "mm/sec";
                    lblLineVelocityRange.Text = "V : 0 ~ 500(預設為100)";
                    RobotAdapter.saferangexyz = new float[12] { 0, 650, -450, 450, -270, 400, -180, 180, -180, 180, -180, 180 };
                    RobotAdapter.saferangejoint = new float[12] { -180, 180, -180, 180, -180, 180, -180, 180, -180, 180, -180, 180 };
                    break;
                case nameof(Controller.Robotnum.Nexcom):
                    myController.Robot = Controller.Robotnum.Nexcom;
                    txtIP.Enabled = false;
                    lblLineVelocityUnit.Text = "unit/sec";
                    lblLineVelocityRange.Text = "V : 0 ~ 100 (預設為10)";
                    RobotAdapter.saferangexyz = new float[12] { 0, 500, -450, 450, 50, 600, -180, 180, -180, 180, -180, 180 };
                    RobotAdapter.saferangejoint = new float[12] { -180, 180, -180, 180, -180, 180, -180, 180, -180, 180, -180, 180 };
                    break;
                case nameof(Controller.Robotnum.Ourarm):
                    myController.Robot = Controller.Robotnum.Ourarm;
                    txtIP.Enabled = false;
                    lblLineVelocityUnit.Text = "unit/sec";
                    lblLineVelocityRange.Text = "V :";
                    break;
                default:
                    myController.Robot = Controller.Robotnum.None;
                    txtIP.Enabled = false;
                    lblLineVelocityUnit.Text = "unit/sec";
                    lblLineVelocityRange.Text = "V :";
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
                    fgRobotState = true;
                    lblConnectionStatus.Text = "Connection Status : Connected";
                    btnConnection.Text = "Disconnect";
                    cboRobot.Enabled = false;
                    timer1.Enabled = true;
                    txtIP.Enabled = false;
                    gbEnbleControl(true);
                    richTextBox1.Clear();
                    cboJogStep.SelectedIndex = 0;
                    cboSafeRangeCoordinate.SelectedIndex = 0;

                    switch (myController.Robot)
                    {
                        case Controller.Robotnum.Fanuc:
                            cboJogStep.Items.Remove(Controller.Stepnum.Cont.ToString());
                            RobotAdapter.setoverride = 20;
                            myController.SetOverride();
                            myController.GetCPosition();
                            RobotAdapter.setcposition = RobotAdapter.getcposition;
                            myController.PTPC();
                            break;
                        case Controller.Robotnum.Nexcom:
                            gbRegister.Enabled = false;
                            myController.GetCPosition();
                            RobotAdapter.setcposition = RobotAdapter.getcposition;
                            myController.PTPC();
                            break;
                        case Controller.Robotnum.Ourarm:
                            break;
                    }
                }
                else
                {
                    richTextBox1.Text += $"手臂連線失敗\r\n{RobotAdapter.apierrtext}\r\n";
                    MessageBox.Show($"手臂連線失敗\r\n{RobotAdapter.apierrtext}");
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

            RobotAdapter.setoverride = RobotAdapter.getoverride + 5;

            if (RobotAdapter.setoverride > 100)
            {
                RobotAdapter.setoverride = 100;
            }

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

            RobotAdapter.setoverride = RobotAdapter.getoverride - 5;

            if (RobotAdapter.setoverride < 0)
            {
                RobotAdapter.setoverride = 0;
            }

            if (!myController.SetOverride())
            {
                ShowMessage("設定速度百分比失敗", "設定速度百分比狀態");
                return;
            }
        }
        #endregion
        
        #region <gbPTP>
        private void cboCoordinate_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboPTPCoordinate.Text)
            {
                case nameof(Controller.Coordinatenum.Cartesian):
                    myController.Coordinate = Controller.Coordinatenum.Cartesian;
                    lblPTPXJ1Set.Text = "X :";
                    lblPTPYJ2Set.Text = "Y :";
                    lblPTPZJ3Set.Text = "Z :";
                    lblPTPWJ4Set.Text = "W:";
                    lblPTPPJ5Set.Text = "P :";
                    lblPTPRJ6Set.Text = "R :";
                    lblPTPXJ1Unit.Text = "mm";
                    lblPTPYJ2Unit.Text = "mm";
                    lblPTPZJ3Unit.Text = "mm";
                    lblPTPWJ4Unit.Text = "deg";
                    lblPTPPJ5Unit.Text = "deg";
                    lblPTPRJ6Unit.Text = "deg";
                    break;
                case nameof(Controller.Coordinatenum.Joint):
                    myController.Coordinate = Controller.Coordinatenum.Joint;
                    lblPTPXJ1Set.Text = "J1 :";
                    lblPTPYJ2Set.Text = "J2 :";
                    lblPTPZJ3Set.Text = "J3 :";
                    lblPTPWJ4Set.Text = "J4 :";
                    lblPTPPJ5Set.Text = "J5 :";
                    lblPTPRJ6Set.Text = "J6 :";
                    lblPTPXJ1Unit.Text = "deg";
                    lblPTPYJ2Unit.Text = "deg";
                    lblPTPZJ3Unit.Text = "deg";
                    lblPTPWJ4Unit.Text = "deg";
                    lblPTPPJ5Unit.Text = "deg";
                    lblPTPRJ6Unit.Text = "deg";
                    break;
            }
            cboLineCoordinate.SelectedIndex = (int)myController.Coordinate;
            cboSafeRangeCoordinate.SelectedIndex = (int)myController.Coordinate;
        }
        private void btnPTPCopy_Click(object sender, EventArgs e)
        {
            switch (myController.Coordinate)
            {
                case Controller.Coordinatenum.Cartesian:
                    tbPTPXJ1Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(0)).ToString("###0.000"))}";
                    tbPTPYJ2Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(1)).ToString("###0.000"))}";
                    tbPTPZJ3Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(2)).ToString("###0.000"))}";
                    tbPTPWJ4Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(3)).ToString("###0.000"))}";
                    tbPTPPJ5Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(4)).ToString("###0.000"))}";
                    tbPTPRJ6Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(5)).ToString("###0.000"))}";
                    break;
                case Controller.Coordinatenum.Joint:
                    tbPTPXJ1Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(0)).ToString("###0.000"))}";
                    tbPTPYJ2Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(1)).ToString("###0.000"))}";
                    tbPTPZJ3Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(2)).ToString("###0.000"))}";
                    tbPTPWJ4Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(3)).ToString("###0.000"))}";
                    tbPTPPJ5Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(4)).ToString("###0.000"))}";
                    tbPTPRJ6Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getjposition.GetValue(5)).ToString("###0.000"))}";
                    break;
            }
        }
        private void btnPTPSet_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbPTPXJ1Set.Text) || string.IsNullOrEmpty(tbPTPYJ2Set.Text) ||
                    string.IsNullOrEmpty(tbPTPZJ3Set.Text) || string.IsNullOrEmpty(tbPTPWJ4Set.Text) ||
                    string.IsNullOrEmpty(tbPTPPJ5Set.Text) || string.IsNullOrEmpty(tbPTPRJ6Set.Text))
                {
                    MessageBox.Show("座標值不可有空白");
                }
                else
                {
                    RobotAdapter.saferangecheck.SetValue(Convert.ToSingle(tbPTPXJ1Set.Text), 0);
                    RobotAdapter.saferangecheck.SetValue(Convert.ToSingle(tbPTPYJ2Set.Text), 1);
                    RobotAdapter.saferangecheck.SetValue(Convert.ToSingle(tbPTPZJ3Set.Text), 2);
                    RobotAdapter.saferangecheck.SetValue(Convert.ToSingle(tbPTPWJ4Set.Text), 3);
                    RobotAdapter.saferangecheck.SetValue(Convert.ToSingle(tbPTPPJ5Set.Text), 4);
                    RobotAdapter.saferangecheck.SetValue(Convert.ToSingle(tbPTPRJ6Set.Text), 5);
                    
                    switch (myController.Coordinate)
                    {
                        case Controller.Coordinatenum.Cartesian:
                            if (!myController.SafeRangeCheckXYZ())
                            {
                                MessageBox.Show("超出安全範圍", "安全範圍狀態");
                                return;
                            }
                            RobotAdapter.setcposition = RobotAdapter.saferangecheck;
                            if (!myController.PTPC())
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
                            RobotAdapter.setjposition = RobotAdapter.saferangecheck;
                            if (!myController.PTPJ())
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
        private void btnPositionHome_Click(object sender, EventArgs e)
        {
            switch (myController.Robot)
            {
                case Controller.Robotnum.Fanuc:
                    RobotAdapter.setvelocity = 100;
                    if (!myController.SetVelocity())
                    {
                        ShowMessage("設定速度失敗", "設定速度狀態");
                    }

                    RobotAdapter.homeposition.SetValue(180, 0);
                    RobotAdapter.homeposition.SetValue(0, 1);
                    RobotAdapter.homeposition.SetValue(280, 2);
                    RobotAdapter.homeposition.SetValue(180, 3);
                    RobotAdapter.homeposition.SetValue(0, 4);
                    RobotAdapter.homeposition.SetValue(0, 5);
                    if (!myController.Home())
                    {
                        ShowMessage("回到原點失敗", "回到原點狀態");
                    }
                    break;
                case Controller.Robotnum.Nexcom:
                    break;
                case Controller.Robotnum.Ourarm:
                    break;
            }
        }
        #endregion

        #region <gbLine>
        private void btnLineCopy_Click(object sender, EventArgs e)
        {
            tbLineXJ1Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(0)).ToString("###0.000"))}";
            tbLineYJ2Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(1)).ToString("###0.000"))}";
            tbLineZJ3Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(2)).ToString("###0.000"))}";
            tbLineWJ4Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(3)).ToString("###0.000"))}";
            tbLinePJ5Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(4)).ToString("###0.000"))}";
            tbLineRJ6Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.getcposition.GetValue(5)).ToString("###0.000"))}";

            if (!myController.GetVelocity())
            {
                ShowMessage("讀取速度失敗", "讀取速度狀態");
                tbLineVelocitySet.Text = "Erorr";
                return;
            }
            else
            {
                tbLineVelocitySet.Text = $"{string.Format("{0,10}", RobotAdapter.getvelocity.ToString("###0.000"))}";
            }
        }
        private void btnLineSet_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbLineXJ1Set.Text) || string.IsNullOrEmpty(tbLineYJ2Set.Text) ||
                    string.IsNullOrEmpty(tbLineZJ3Set.Text) || string.IsNullOrEmpty(tbLineWJ4Set.Text) ||
                    string.IsNullOrEmpty(tbLinePJ5Set.Text) || string.IsNullOrEmpty(tbLineRJ6Set.Text) ||
                    string.IsNullOrEmpty(tbLineVelocitySet.Text))
                {
                    MessageBox.Show("座標值和速度值不可有空白");
                }
                else
                {
                    RobotAdapter.saferangecheck.SetValue(Convert.ToSingle(tbLineXJ1Set.Text), 0);
                    RobotAdapter.saferangecheck.SetValue(Convert.ToSingle(tbLineYJ2Set.Text), 1);
                    RobotAdapter.saferangecheck.SetValue(Convert.ToSingle(tbLineZJ3Set.Text), 2);
                    RobotAdapter.saferangecheck.SetValue(Convert.ToSingle(tbLineWJ4Set.Text), 3);
                    RobotAdapter.saferangecheck.SetValue(Convert.ToSingle(tbLinePJ5Set.Text), 4);
                    RobotAdapter.saferangecheck.SetValue(Convert.ToSingle(tbLineRJ6Set.Text), 5);
                    float V = Convert.ToSingle(tbLineVelocitySet.Text);

                    if (!myController.SafeRangeCheckXYZ())
                    {
                        MessageBox.Show("超出安全範圍", "安全範圍狀態");
                        return;
                    }

                    switch (myController.Robot)
                    {
                        case Controller.Robotnum.Fanuc:
                            if (V < 0 || V > 500)
                            {
                                MessageBox.Show("速度超出安全範圍");
                                return;
                            }
                            break;
                        case Controller.Robotnum.Nexcom:
                            if (V < 0 || V > 100)
                            {
                                MessageBox.Show("速度超出安全範圍");
                                return;
                            }
                            break;
                    }
                    RobotAdapter.setvelocity = V;
                    if (!myController.SetVelocity())
                    {
                        ShowMessage("設定速度失敗", "設定速度狀態");
                    }

                    RobotAdapter.setcposition = RobotAdapter.saferangecheck;
                    if (!myController.Line())
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
                if (!string.IsNullOrEmpty(tbR1Set.Text))
                {
                    RobotAdapter.setregister.SetValue(1, 1);
                    RobotAdapter.setregister.SetValue(Convert.ToSingle(tbR1Set.Text), 0);
                    if (!myController.SetRegister())
                    {
                        ShowMessage("設定暫存器R1失敗", "設定暫存器狀態");
                        tbR1Set.Text = "";
                    }
                }
                if (!string.IsNullOrEmpty(tbR2Set.Text))
                {
                    RobotAdapter.setregister.SetValue(2, 1);
                    RobotAdapter.setregister.SetValue(Convert.ToSingle(tbR2Set.Text), 0);
                    if (!myController.SetRegister())
                    {
                        ShowMessage("設定暫存器R2失敗", "設定暫存器狀態");
                        tbR2Set.Text = "";
                    }
                }
                if (!string.IsNullOrEmpty(tbR3Set.Text))
                {
                    RobotAdapter.setregister.SetValue(3, 1);
                    RobotAdapter.setregister.SetValue(Convert.ToSingle(tbR3Set.Text), 0);
                    if (!myController.SetRegister())
                    {
                        ShowMessage("設定暫存器R3失敗", "設定暫存器狀態");
                        tbR3Set.Text = "";
                    }
                }
                if (!string.IsNullOrEmpty(tbR4Set.Text))
                {
                    RobotAdapter.setregister.SetValue(4, 1);
                    RobotAdapter.setregister.SetValue(Convert.ToSingle(tbR4Set.Text), 0);
                    if (!myController.SetRegister())
                    {
                        ShowMessage("設定暫存器R4失敗", "設定暫存器狀態");
                        tbR4Set.Text = "";
                    }
                }
                if (!string.IsNullOrEmpty(tbR5Set.Text))
                {
                    RobotAdapter.setregister.SetValue(5, 1);
                    RobotAdapter.setregister.SetValue(Convert.ToSingle(tbR5Set.Text), 0);
                    if (!myController.SetRegister())
                    {
                        ShowMessage("設定暫存器R5失敗", "設定暫存器狀態");
                        tbR5Set.Text = "";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入有效數值");
            }
        }
        #endregion

        #region <gbJog>
        private void cboLineCoordinate_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboLineCoordinate.Text)
            {
                case nameof(Controller.Coordinatenum.Cartesian):
                    myController.Coordinate = Controller.Coordinatenum.Cartesian;
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
                    break;
                case nameof(Controller.Coordinatenum.Joint):
                    myController.Coordinate = Controller.Coordinatenum.Joint;
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
                    break;
            }
            cboPTPCoordinate.SelectedIndex = (int)myController.Coordinate;
            cboSafeRangeCoordinate.SelectedIndex = (int)myController.Coordinate;
        }
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
                case nameof(Controller.Stepnum.Cont):
                    myController.Step = Controller.Stepnum.Cont;
                    break;
            }
            RobotAdapter.incmove.SetValue(myController.Step, 0);
        }
        private void btnJogXJ1Positive_Click(object sender, EventArgs e)
        {
            if (myController.Step == Controller.Stepnum.Cont)
            {
                return;
            }

            Button btn = (Button)sender;

            RobotAdapter.incmove.SetValue(Convert.ToInt32(btn.Tag), 1);
            switch (myController.Coordinate)
            {
                case Controller.Coordinatenum.Cartesian:
                    if (!myController.IncC())
                    {
                        ShowMessage("單動移動失敗", "單動移動狀態");
                    }
                    break;
                case Controller.Coordinatenum.Joint:
                    if (!myController.IncJ())
                    {
                        ShowMessage("單動移動失敗", "單動移動狀態");
                    }
                    break;
            }
        }
        private void btnJogXJ1Positive_MouseDown(object sender, MouseEventArgs e)
        {
            if (myController.Step == Controller.Stepnum.Cont)
            {
                Button btn = (Button)sender;

                RobotAdapter.jogmove = Convert.ToInt32(btn.Tag);
                switch (myController.Coordinate)
                {
                    case Controller.Coordinatenum.Cartesian:
                        if (!myController.JogC())
                        {
                            ShowMessage("寸動移動失敗", "寸動移動狀態");
                        }
                        break;
                    case Controller.Coordinatenum.Joint:
                        if (!myController.JogJ())
                        {
                            ShowMessage("寸動移動失敗", "寸動移動狀態");
                        }
                        break;
                }
            }
        }
        private void btnJogXJ1Positive_MouseUp(object sender, MouseEventArgs e)
        {
            if (myController.Step == Controller.Stepnum.Cont)
            {
                if (!myController.Hold())
                {
                    ShowMessage("Hold失敗", "Hold狀態");
                }
            }
        }
        #endregion

        #region <gbEnable>

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
            if (!fgRobotState)
            {
                if (!myController.Reset())
                {
                    ShowMessage("Reset失敗", "Reset狀態");
                    return;
                }
                else
                {
                    fgRobotState = true;
                    timer1.Enabled = true;
                    richTextBox1.Text = "";
                }
            }
        }

        #endregion

        #region <gbSafeRange>
        private void cboSafeRangeCoordinate_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboSafeRangeCoordinate.Text)
            {
                case nameof(Controller.Coordinatenum.Cartesian):
                    myController.Coordinate = Controller.Coordinatenum.Cartesian;
                    lblSafeRangeXJ1.Text = "X :                 ~";
                    lblSafeRangeYJ2.Text = "Y :                 ~";
                    lblSafeRangeZJ3.Text = "Z :                 ~";
                    lblSafeRangeWJ4.Text = "W:                 ~";
                    lblSafeRangePJ5.Text = "P :                  ~";
                    lblSafeRangeRJ6.Text = "R :                 ~";
                    tbSafeRangeXJ1min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(0)).ToString("###0.000"))}";
                    tbSafeRangeXJ1max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(1)).ToString("###0.000"))}";
                    tbSafeRangeYJ2min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(2)).ToString("###0.000"))}";
                    tbSafeRangeYJ2max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(3)).ToString("###0.000"))}";
                    tbSafeRangeZJ3min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(4)).ToString("###0.000"))}";
                    tbSafeRangeZJ3max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(5)).ToString("###0.000"))}";
                    tbSafeRangeWJ4min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(6)).ToString("###0.000"))}";
                    tbSafeRangeWJ4max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(7)).ToString("###0.000"))}";
                    tbSafeRangePJ5min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(8)).ToString("###0.000"))}";
                    tbSafeRangePJ5max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(9)).ToString("###0.000"))}";
                    tbSafeRangeRJ6min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(10)).ToString("###0.000"))}";
                    tbSafeRangeRJ6max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(11)).ToString("###0.000"))}";
                    break;
                case nameof(Controller.Coordinatenum.Joint):
                    myController.Coordinate = Controller.Coordinatenum.Joint;
                    lblSafeRangeXJ1.Text = "J1:                 ~";
                    lblSafeRangeYJ2.Text = "J2:                 ~";
                    lblSafeRangeZJ3.Text = "J3:                 ~";
                    lblSafeRangeWJ4.Text = "J4:                 ~";
                    lblSafeRangePJ5.Text = "J5:                 ~";
                    lblSafeRangeRJ6.Text = "J6:                 ~";
                    tbSafeRangeXJ1min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(0)).ToString("###0.000"))}";
                    tbSafeRangeXJ1max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(1)).ToString("###0.000"))}";
                    tbSafeRangeYJ2min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(2)).ToString("###0.000"))}";
                    tbSafeRangeYJ2max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(3)).ToString("###0.000"))}";
                    tbSafeRangeZJ3min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(4)).ToString("###0.000"))}";
                    tbSafeRangeZJ3max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(5)).ToString("###0.000"))}";
                    tbSafeRangeWJ4min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(6)).ToString("###0.000"))}";
                    tbSafeRangeWJ4max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(7)).ToString("###0.000"))}";
                    tbSafeRangePJ5min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(8)).ToString("###0.000"))}";
                    tbSafeRangePJ5max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(9)).ToString("###0.000"))}";
                    tbSafeRangeRJ6min.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(10)).ToString("###0.000"))}";
                    tbSafeRangeRJ6max.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(11)).ToString("###0.000"))}";
                    break;
            }
            cboLineCoordinate.SelectedIndex = (int)myController.Coordinate;
            cboPTPCoordinate.SelectedIndex = (int)myController.Coordinate;
        }
        private void btnSafeRangeSet_Click(object sender, EventArgs e)
        {
            if (!tbSafeRangeXJ1min.Enabled)
            {
                tbSafeRangeEnbleControl(true);
                return;
            }

            try
            {
                switch (myController.Coordinate)
                {
                    case Controller.Coordinatenum.Cartesian:
                        RobotAdapter.saferangexyz.SetValue(Convert.ToSingle(tbSafeRangeXJ1min.Text), 0);
                        RobotAdapter.saferangexyz.SetValue(Convert.ToSingle(tbSafeRangeXJ1max.Text), 1);
                        RobotAdapter.saferangexyz.SetValue(Convert.ToSingle(tbSafeRangeYJ2min.Text), 2);
                        RobotAdapter.saferangexyz.SetValue(Convert.ToSingle(tbSafeRangeYJ2max.Text), 3);
                        RobotAdapter.saferangexyz.SetValue(Convert.ToSingle(tbSafeRangeZJ3min.Text), 4);
                        RobotAdapter.saferangexyz.SetValue(Convert.ToSingle(tbSafeRangeZJ3max.Text), 5);
                        RobotAdapter.saferangexyz.SetValue(Convert.ToSingle(tbSafeRangeWJ4min.Text), 6);
                        RobotAdapter.saferangexyz.SetValue(Convert.ToSingle(tbSafeRangeWJ4max.Text), 7);
                        RobotAdapter.saferangexyz.SetValue(Convert.ToSingle(tbSafeRangePJ5min.Text), 8);
                        RobotAdapter.saferangexyz.SetValue(Convert.ToSingle(tbSafeRangePJ5max.Text), 9);
                        RobotAdapter.saferangexyz.SetValue(Convert.ToSingle(tbSafeRangeRJ6min.Text), 10);
                        RobotAdapter.saferangexyz.SetValue(Convert.ToSingle(tbSafeRangeRJ6max.Text), 11);
                        break;
                    case Controller.Coordinatenum.Joint:
                        RobotAdapter.saferangejoint.SetValue(Convert.ToSingle(tbSafeRangeXJ1min.Text), 0);
                        RobotAdapter.saferangejoint.SetValue(Convert.ToSingle(tbSafeRangeXJ1max.Text), 1);
                        RobotAdapter.saferangejoint.SetValue(Convert.ToSingle(tbSafeRangeYJ2min.Text), 2);
                        RobotAdapter.saferangejoint.SetValue(Convert.ToSingle(tbSafeRangeYJ2max.Text), 3);
                        RobotAdapter.saferangejoint.SetValue(Convert.ToSingle(tbSafeRangeZJ3min.Text), 4);
                        RobotAdapter.saferangejoint.SetValue(Convert.ToSingle(tbSafeRangeZJ3max.Text), 5);
                        RobotAdapter.saferangejoint.SetValue(Convert.ToSingle(tbSafeRangeWJ4min.Text), 6);
                        RobotAdapter.saferangejoint.SetValue(Convert.ToSingle(tbSafeRangeWJ4max.Text), 7);
                        RobotAdapter.saferangejoint.SetValue(Convert.ToSingle(tbSafeRangePJ5min.Text), 8);
                        RobotAdapter.saferangejoint.SetValue(Convert.ToSingle(tbSafeRangePJ5max.Text), 9);
                        RobotAdapter.saferangejoint.SetValue(Convert.ToSingle(tbSafeRangeRJ6min.Text), 10);
                        RobotAdapter.saferangejoint.SetValue(Convert.ToSingle(tbSafeRangeRJ6max.Text), 11);
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

        #region <gbPointsMove>
        private void btnPointsMoveCopy_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["ColumnNumber"].Value = dataGridView1.RowCount;
            dataGridView1.Rows.Add();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("C:/Users/shanbingchi/Documents/My Workcells/shibingchi/SavePoints/2023_03_24/Robot_1/JJJ.LS", false);
            sw.WriteLine("/PROG  JJJ");
            sw.WriteLine("/ATTR");
            sw.WriteLine("OWNER		= MNEDITOR;");
            sw.WriteLine("COMMENT		= \"\";");
            sw.WriteLine("PROG_SIZE	= 0;");
            sw.WriteLine("CREATE		= DATE 23-03-19  TIME 20:28:08;");
            sw.WriteLine("MODIFIED	= DATE 23-03-19  TIME 20:28:08;");
            sw.WriteLine("FILE_NAME	= ;");
            sw.WriteLine("VERSION		= 0;");
            sw.WriteLine("LINE_COUNT	= 0;");
            sw.WriteLine("MEMORY_SIZE	= 0;");
            sw.WriteLine("PROTECT		= READ_WRITE;");
            sw.WriteLine("TCD:  STACK_SIZE	= 0,");
            sw.WriteLine("      TASK_PRIORITY	= 50,");
            sw.WriteLine("      TIME_SLICE	= 0,");
            sw.WriteLine("      BUSY_LAMP_OFF	= 0,");
            sw.WriteLine("      ABORT_REQUEST	= 0,");
            sw.WriteLine("      PAUSE_REQUEST	= 0;");
            sw.WriteLine("DEFAULT_GROUP	= 1,*,*,*,*;");
            sw.WriteLine("CONTROL_CODE	= 00000000 00000000;");
            sw.WriteLine("/MN");
            sw.WriteLine("   1:  LBL[2] ;");
            sw.WriteLine("/POS");
            sw.WriteLine("/END");
            sw.Close();
        }

        
    }
}
