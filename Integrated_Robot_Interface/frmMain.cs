using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrated_Robot_Interface
{
    public partial class FrmMain : Form
    {
        //變數宣告
        Controller myController = new Controller();
        public bool fgConnectionStatus { get; set; } = false;
        public bool fgState { get; set; } = false;

        FrmFanuc f = new FrmFanuc();
        


        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            Initialize();
        }
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fgConnectionStatus)
            {
                if (myController.Disconnect())
                {
                    Initialize();
                }
                else
                {
                    richTextBox1.Text += $"手臂離線失敗\r\n{RobotAdapter.Apierrtext}";
                    MessageBox.Show($"手臂離線失敗\r\n{RobotAdapter.Apierrtext}");
                    RobotAdapter.Apierrtext = "";
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
            cboPTPCoordinate.Items.Clear();
            cboPTPCoordinate.Items.AddRange(Coordinate);
            cboLineCoordinate.Items.Clear();
            cboLineCoordinate.Items.AddRange(Coordinate);
            string[] Step = new string[] { Controller.Stepnum.One.ToString(), Controller.Stepnum.Five.ToString(),
                                           Controller.Stepnum.Ten.ToString(), Controller.Stepnum.Cont.ToString() };
            cboJogStep.Items.Clear();
            cboJogStep.Items.AddRange(Step);
            cboRobot.SelectedIndex = 0;
            cboPTPCoordinate.SelectedIndex = 0;
            cboLineCoordinate.SelectedIndex = 0;
            cboJogStep.SelectedIndex = 0;
            timer1.Interval = 500;
            timer1.Enabled = false;
            txtIP.Enabled = false;
            fgConnectionStatus = false;
            fgState = false;
            cboRobot.Enabled = true;
            gbEnbleControl(false);
            txtInitialize();
        }
        private void gbEnbleControl(bool tf)
        {
            gbOverride.Enabled = tf;
            gbCurrentState.Enabled = tf;
            gbPTP.Enabled = tf;
            gbRegister.Enabled = tf;
            gbJog.Enabled = tf;
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
            lblRange.Text = "X :\r\nY :\r\nZ :\r\nVelocity :";
            lblRegister.Text = "R1 = \r\nR2 = \r\nR3 = \r\nR4 = \r\nR5 = ";
            lblOverride.Text = "";
            tbR1Set.Text = "";
            tbR2Set.Text = "";
            tbR3Set.Text = "";
            tbR4Set.Text = "";
            tbR5Set.Text = "";
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
                    break;
                case nameof(Controller.Robotnum.Nexcom):
                    myController.Robot = Controller.Robotnum.Nexcom;
                    txtIP.Enabled = false;
                    lblLineVelocityUnit.Text = "unit/sec";
                    lblLineVelocityRange.Text = "V : 0 ~ 100 (預設為10)";
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
            if (!fgConnectionStatus)
            {
                switch (myController.Robot)
                {
                    case Controller.Robotnum.Fanuc:
                        RobotAdapter.IP = txtIP.Text;
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
                    fgConnectionStatus = true;
                    fgState = true;
                    lblConnectionStatus.Text = "Connection Status : Connected";
                    btnConnection.Text = "Disconnect";
                    cboRobot.Enabled = false;
                    timer1.Enabled = true;
                    txtIP.Enabled = false;
                    gbEnbleControl(true);
                    richTextBox1.Clear();
                    f.Show();
                    switch (myController.Robot)
                    {
                        case Controller.Robotnum.Fanuc:
                            lblRange.Text = "X : 0~650\r\nY : -450~450\r\nZ : -270~400\r\nVelocity : 0~500";
                            cboJogStep.Items.Remove(Controller.Stepnum.Cont.ToString());
                            RobotAdapter.Setoverride = 20;
                            myController.SetOverride();
                            myController.GetCPosition();
                            RobotAdapter.SetCposition = RobotAdapter.GetCposition;
                            myController.PTPC();
                            break;
                        case Controller.Robotnum.Nexcom:
                            gbRegister.Enabled = false;
                            lblRange.Text = "X : 0~500\r\nY : -450~450\r\nZ : 50~600\r\nVelocity : 0~100";
                            myController.GetCPosition();
                            RobotAdapter.SetCposition = RobotAdapter.GetCposition;
                            myController.PTPC();
                            break;
                        case Controller.Robotnum.Ourarm:
                            break;
                    }
                }
                else
                {
                    richTextBox1.Text += $"手臂連線失敗\r\n{RobotAdapter.Apierrtext}\r\n";
                    MessageBox.Show($"手臂連線失敗\r\n{RobotAdapter.Apierrtext}");
                    RobotAdapter.Apierrtext = "";
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
                    richTextBox1.Text += $"手臂離線失敗\r\n{RobotAdapter.Apierrtext}\r\n";
                    MessageBox.Show($"手臂離線失敗\r\n{RobotAdapter.Apierrtext}");
                    RobotAdapter.Apierrtext = "";
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

            RobotAdapter.Setoverride = RobotAdapter.Getoverride + 5;

            if (RobotAdapter.Setoverride > 100)
            {
                RobotAdapter.Setoverride = 100;
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

            RobotAdapter.Setoverride = RobotAdapter.Getoverride - 5;

            if (RobotAdapter.Setoverride < 0)
            {
                RobotAdapter.Setoverride = 0;
            }

            if (!myController.SetOverride())
            {
                ShowMessage("設定速度百分比失敗", "設定速度百分比狀態");
                return;
            }
        }
        #endregion

        #region <NOgb>
        private void btnEsc_Click(object sender, EventArgs e)
        {
            if (fgConnectionStatus)
            {
                if (myController.Disconnect())
                {
                    Initialize();
                    Application.Exit();
                }
                else
                {
                    richTextBox1.Text += $"手臂離線失敗\r\n{RobotAdapter.Apierrtext}";
                    MessageBox.Show($"手臂離線失敗\r\n{RobotAdapter.Apierrtext}");
                    RobotAdapter.Apierrtext = "";
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

                    for (int Index = 1; Index <= 5; Index++)
                    {
                        RobotAdapter.Getregister.SetValue(Index, 1);
                        if (!myController.GetRegister())
                        {
                            ShowMessage("讀取暫存器失敗", "讀取暫存器狀態");
                            lblRegister.Text = "R1 = Erorr\r\n";
                            lblRegister.Text += "R2 = Erorr\r\n";
                            lblRegister.Text += "R3 = Erorr\r\n";
                            lblRegister.Text += "R4 = Erorr\r\n";
                            lblRegister.Text += "R5 = Erorr";
                            return;
                        }
                        else
                        {
                            if (Index == 1)
                            {
                                lblRegister.Text = $"R{Index} = {Convert.ToSingle(RobotAdapter.Getregister.GetValue(0)).ToString()}\r\n";
                            }
                            else
                            {
                                lblRegister.Text += $"R{Index} = {Convert.ToSingle(RobotAdapter.Getregister.GetValue(0)).ToString()}\r\n";
                            }
                        }
                    }

                    
                    
                    break;
                case Controller.Robotnum.Nexcom:
                    if (!myController.GetState())
                    {
                        ShowMessage("取得State失敗", "取得State狀態");
                        return;
                    }
                    else
                    {
                        lblState.Text = RobotAdapter.Statetext;
                    }
                    if (!myController.GetStatus())
                    {
                        ShowMessage("取得Status失敗", "取得Status狀態");
                        return;
                    }
                    else
                    {
                        lblState.Text += RobotAdapter.Statustext;
                    }
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
                if (RobotAdapter.Alarmtext != "")
                {
                    ShowMessage($"{RobotAdapter.Alarmtext}", "讀取警示狀態");
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
                lblOverride.Text = RobotAdapter.Getoverride + "%";
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
                lblXyzwpr.Text += $"X : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetCposition.GetValue(0)).ToString("###0.000"))}\r\n";
                lblXyzwpr.Text += $"Y : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetCposition.GetValue(1)).ToString("###0.000"))}\r\n";
                lblXyzwpr.Text += $"Z : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetCposition.GetValue(2)).ToString("###0.000"))}\r\n";
                lblXyzwpr.Text += $"W: {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetCposition.GetValue(3)).ToString("###0.000"))}\r\n";
                lblXyzwpr.Text += $"P : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetCposition.GetValue(4)).ToString("###0.000"))}\r\n";
                lblXyzwpr.Text += $"R : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetCposition.GetValue(5)).ToString("###0.000"))}";
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
                lblJoint.Text += $"J1 : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetJposition.GetValue(0)).ToString("###0.000"))}\r\n";
                lblJoint.Text += $"J2 : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetJposition.GetValue(1)).ToString("###0.000"))}\r\n";
                lblJoint.Text += $"J3 : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetJposition.GetValue(2)).ToString("###0.000"))}\r\n";
                lblJoint.Text += $"J4 : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetJposition.GetValue(3)).ToString("###0.000"))}\r\n";
                lblJoint.Text += $"J5 : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetJposition.GetValue(4)).ToString("###0.000"))}\r\n";
                lblJoint.Text += $"J6 : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetJposition.GetValue(5)).ToString("###0.000"))}";
            }

            if (!myController.GetInformation())
            {
                ShowMessage("取得資料失敗", "取得資料狀態");
                return;
            }
        }
        private void ShowMessage(string content, string title)
        {
            DialogResult result;
            fgState = false;
            timer1.Enabled = false;
            richTextBox1.Text += $"{content}\r\n{RobotAdapter.Apierrtext}\r\n";
            result = MessageBox.Show($"{content}\r\n{RobotAdapter.Apierrtext}", $"{title}", MessageBoxButtons.AbortRetryIgnore);
            RobotAdapter.Apierrtext = "";
            if (result == DialogResult.Abort)
            {
                if (myController.Disconnect())
                {
                    Initialize();
                }
                else
                {
                    richTextBox1.Text += $"手臂離線失敗\r\n{RobotAdapter.Apierrtext}";
                    MessageBox.Show($"手臂離線失敗\r\n{RobotAdapter.Apierrtext}");
                    RobotAdapter.Apierrtext = "";
                }
            }
            else if (result == DialogResult.Ignore)
            {
                fgState = true;
                timer1.Enabled = true;
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
        }
        private void btnPTPCopy_Click(object sender, EventArgs e)
        {
            switch (myController.Coordinate)
            {
                case Controller.Coordinatenum.Cartesian:
                    tbPTPXJ1Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetCposition.GetValue(0)).ToString("###0.000"))}";
                    tbPTPYJ2Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetCposition.GetValue(1)).ToString("###0.000"))}";
                    tbPTPZJ3Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetCposition.GetValue(2)).ToString("###0.000"))}";
                    tbPTPWJ4Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetCposition.GetValue(3)).ToString("###0.000"))}";
                    tbPTPPJ5Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetCposition.GetValue(4)).ToString("###0.000"))}";
                    tbPTPRJ6Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetCposition.GetValue(5)).ToString("###0.000"))}";
                    break;
                case Controller.Coordinatenum.Joint:
                    tbPTPXJ1Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetJposition.GetValue(0)).ToString("###0.000"))}";
                    tbPTPYJ2Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetJposition.GetValue(1)).ToString("###0.000"))}";
                    tbPTPZJ3Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetJposition.GetValue(2)).ToString("###0.000"))}";
                    tbPTPWJ4Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetJposition.GetValue(3)).ToString("###0.000"))}";
                    tbPTPPJ5Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetJposition.GetValue(4)).ToString("###0.000"))}";
                    tbPTPRJ6Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetJposition.GetValue(5)).ToString("###0.000"))}";
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
                    switch (myController.Coordinate)
                    {
                        case Controller.Coordinatenum.Cartesian:
                            switch (myController.Robot)
                            {
                                case Controller.Robotnum.Fanuc:
                                    if (Convert.ToSingle(tbPTPXJ1Set.Text) < 0 || Convert.ToSingle(tbPTPXJ1Set.Text) > 650 ||
                                        Convert.ToSingle(tbPTPYJ2Set.Text) < -450 || Convert.ToSingle(tbPTPYJ2Set.Text) > 450 ||
                                        Convert.ToSingle(tbPTPZJ3Set.Text) < -270 || Convert.ToSingle(tbPTPZJ3Set.Text) > 400 ||
                                        Convert.ToSingle(tbPTPWJ4Set.Text) < -180 || Convert.ToSingle(tbPTPWJ4Set.Text) > 180 ||
                                        Convert.ToSingle(tbPTPPJ5Set.Text) < -180 || Convert.ToSingle(tbPTPPJ5Set.Text) > 180 ||
                                        Convert.ToSingle(tbPTPRJ6Set.Text) < -180 || Convert.ToSingle(tbPTPRJ6Set.Text) > 180)
                                    {
                                        MessageBox.Show("座標超出安全範圍");
                                        return;
                                    }
                                    break;
                                case Controller.Robotnum.Nexcom:
                                    if (Convert.ToSingle(tbPTPXJ1Set.Text) < 0 || Convert.ToSingle(tbPTPXJ1Set.Text) > 500 ||
                                        Convert.ToSingle(tbPTPYJ2Set.Text) < -450 || Convert.ToSingle(tbPTPYJ2Set.Text) > 450 ||
                                        Convert.ToSingle(tbPTPZJ3Set.Text) < 50 || Convert.ToSingle(tbPTPZJ3Set.Text) > 600 ||
                                        Convert.ToSingle(tbPTPWJ4Set.Text) < -180 || Convert.ToSingle(tbPTPWJ4Set.Text) > 180 ||
                                        Convert.ToSingle(tbPTPPJ5Set.Text) < -180 || Convert.ToSingle(tbPTPPJ5Set.Text) > 180 ||
                                        Convert.ToSingle(tbPTPRJ6Set.Text) < -180 || Convert.ToSingle(tbPTPRJ6Set.Text) > 180)
                                    {
                                        MessageBox.Show("座標超出安全範圍");
                                        return;
                                    }
                                    break;
                                case Controller.Robotnum.Ourarm:
                                    break;
                            }
                            RobotAdapter.SetCposition.SetValue(Convert.ToSingle(tbPTPXJ1Set.Text), 0);
                            RobotAdapter.SetCposition.SetValue(Convert.ToSingle(tbPTPYJ2Set.Text), 1);
                            RobotAdapter.SetCposition.SetValue(Convert.ToSingle(tbPTPZJ3Set.Text), 2);
                            RobotAdapter.SetCposition.SetValue(Convert.ToSingle(tbPTPWJ4Set.Text), 3);
                            RobotAdapter.SetCposition.SetValue(Convert.ToSingle(tbPTPPJ5Set.Text), 4);
                            RobotAdapter.SetCposition.SetValue(Convert.ToSingle(tbPTPRJ6Set.Text), 5);
                            if (!myController.PTPC())
                            {
                                ShowMessage("設定座標失敗", "點到點移動狀態");
                            }
                            break;
                        case Controller.Coordinatenum.Joint:
                            switch (myController.Robot)
                            {
                                case Controller.Robotnum.Fanuc:
                                    if (Convert.ToSingle(tbPTPXJ1Set.Text) < -180 || Convert.ToSingle(tbPTPXJ1Set.Text) > 180 ||
                                        Convert.ToSingle(tbPTPYJ2Set.Text) < -180 || Convert.ToSingle(tbPTPYJ2Set.Text) > 180 ||
                                        Convert.ToSingle(tbPTPZJ3Set.Text) < -180 || Convert.ToSingle(tbPTPZJ3Set.Text) > 180 ||
                                        Convert.ToSingle(tbPTPWJ4Set.Text) < -180 || Convert.ToSingle(tbPTPWJ4Set.Text) > 180 ||
                                        Convert.ToSingle(tbPTPPJ5Set.Text) < -180 || Convert.ToSingle(tbPTPPJ5Set.Text) > 180 ||
                                        Convert.ToSingle(tbPTPRJ6Set.Text) < -180 || Convert.ToSingle(tbPTPRJ6Set.Text) > 180)
                                    {
                                        MessageBox.Show("座標超出安全範圍");
                                        return;
                                    }
                                    break;
                                case Controller.Robotnum.Nexcom:
                                    if (Convert.ToSingle(tbPTPXJ1Set.Text) < -180 || Convert.ToSingle(tbPTPXJ1Set.Text) > 180 ||
                                        Convert.ToSingle(tbPTPYJ2Set.Text) < -180 || Convert.ToSingle(tbPTPYJ2Set.Text) > 180 ||
                                        Convert.ToSingle(tbPTPZJ3Set.Text) < -180 || Convert.ToSingle(tbPTPZJ3Set.Text) > 180 ||
                                        Convert.ToSingle(tbPTPWJ4Set.Text) < -180 || Convert.ToSingle(tbPTPWJ4Set.Text) > 180 ||
                                        Convert.ToSingle(tbPTPPJ5Set.Text) < -180 || Convert.ToSingle(tbPTPPJ5Set.Text) > 180 ||
                                        Convert.ToSingle(tbPTPRJ6Set.Text) < -180 || Convert.ToSingle(tbPTPRJ6Set.Text) > 180)
                                    {
                                        MessageBox.Show("座標超出安全範圍");
                                        return;
                                    }
                                    break;
                                case Controller.Robotnum.Ourarm:
                                    break;
                            }
                            RobotAdapter.SetJposition.SetValue(Convert.ToSingle(tbPTPXJ1Set.Text), 0);
                            RobotAdapter.SetJposition.SetValue(Convert.ToSingle(tbPTPYJ2Set.Text), 1);
                            RobotAdapter.SetJposition.SetValue(Convert.ToSingle(tbPTPZJ3Set.Text), 2);
                            RobotAdapter.SetJposition.SetValue(Convert.ToSingle(tbPTPWJ4Set.Text), 3);
                            RobotAdapter.SetJposition.SetValue(Convert.ToSingle(tbPTPPJ5Set.Text), 4);
                            RobotAdapter.SetJposition.SetValue(Convert.ToSingle(tbPTPRJ6Set.Text), 5);
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
                    RobotAdapter.Setvelocity = 100;
                    if (!myController.SetVelocity())
                    {
                        ShowMessage("設定速度失敗", "設定速度狀態");
                    }

                    RobotAdapter.Homeposition.SetValue(180, 0);
                    RobotAdapter.Homeposition.SetValue(0, 1);
                    RobotAdapter.Homeposition.SetValue(280, 2);
                    RobotAdapter.Homeposition.SetValue(180, 3);
                    RobotAdapter.Homeposition.SetValue(0, 4);
                    RobotAdapter.Homeposition.SetValue(0, 5);
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
            tbLineXJ1Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetCposition.GetValue(0)).ToString("###0.000"))}";
            tbLineYJ2Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetCposition.GetValue(1)).ToString("###0.000"))}";
            tbLineZJ3Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetCposition.GetValue(2)).ToString("###0.000"))}";
            tbLineWJ4Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetCposition.GetValue(3)).ToString("###0.000"))}";
            tbLinePJ5Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetCposition.GetValue(4)).ToString("###0.000"))}";
            tbLineRJ6Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetCposition.GetValue(5)).ToString("###0.000"))}";

            if (!myController.GetVelocity())
            {
                ShowMessage("讀取速度失敗", "讀取速度狀態");
                tbLineVelocitySet.Text = "Erorr";
                return;
            }
            else
            {
                tbLineVelocitySet.Text = $"{string.Format("{0,10}", RobotAdapter.Getvelocity.ToString("###0.000"))}";
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
                    switch (myController.Robot)
                    {
                        case Controller.Robotnum.Fanuc:
                            if (Convert.ToSingle(tbLineXJ1Set.Text) < 0 || Convert.ToSingle(tbLineXJ1Set.Text) > 650 ||
                                Convert.ToSingle(tbLineYJ2Set.Text) < -450 || Convert.ToSingle(tbLineYJ2Set.Text) > 450 ||
                                Convert.ToSingle(tbLineZJ3Set.Text) < -270 || Convert.ToSingle(tbLineZJ3Set.Text) > 400 ||
                                Convert.ToSingle(tbLineWJ4Set.Text) < -180 || Convert.ToSingle(tbLineWJ4Set.Text) > 180 ||
                                Convert.ToSingle(tbLinePJ5Set.Text) < -180 || Convert.ToSingle(tbLinePJ5Set.Text) > 180 ||
                                Convert.ToSingle(tbLineRJ6Set.Text) < -180 || Convert.ToSingle(tbLineRJ6Set.Text) > 180 ||
                                Convert.ToSingle(tbLineVelocitySet.Text) < 0 || Convert.ToSingle(tbLineVelocitySet.Text) > 500)
                            {
                                MessageBox.Show("座標或速度超出安全範圍");
                                return;
                            }
                            break;
                        case Controller.Robotnum.Nexcom:
                            if (Convert.ToSingle(tbLineXJ1Set.Text) < 0 || Convert.ToSingle(tbLineXJ1Set.Text) > 500 ||
                                Convert.ToSingle(tbLineYJ2Set.Text) < -450 || Convert.ToSingle(tbLineYJ2Set.Text) > 450 ||
                                Convert.ToSingle(tbLineZJ3Set.Text) < 50 || Convert.ToSingle(tbLineZJ3Set.Text) > 600 ||
                                Convert.ToSingle(tbLineWJ4Set.Text) < -180 || Convert.ToSingle(tbLineWJ4Set.Text) > 180 ||
                                Convert.ToSingle(tbLinePJ5Set.Text) < -180 || Convert.ToSingle(tbLinePJ5Set.Text) > 180 ||
                                Convert.ToSingle(tbLineRJ6Set.Text) < -180 || Convert.ToSingle(tbLineRJ6Set.Text) > 180 ||
                                Convert.ToSingle(tbLineVelocitySet.Text) < 0 || Convert.ToSingle(tbLineVelocitySet.Text) > 100)
                            {
                                MessageBox.Show("座標或速度超出安全範圍");
                                return;
                            }
                            break;
                        case Controller.Robotnum.Ourarm:
                            break;
                    }
                    RobotAdapter.Setvelocity = Convert.ToSingle(tbLineVelocitySet.Text);
                    if (!myController.SetVelocity())
                    {
                        ShowMessage("設定速度失敗", "設定速度狀態");
                    }

                    RobotAdapter.SetCposition.SetValue(Convert.ToSingle(tbLineXJ1Set.Text), 0);
                    RobotAdapter.SetCposition.SetValue(Convert.ToSingle(tbLineYJ2Set.Text), 1);
                    RobotAdapter.SetCposition.SetValue(Convert.ToSingle(tbLineZJ3Set.Text), 2);
                    RobotAdapter.SetCposition.SetValue(Convert.ToSingle(tbLineWJ4Set.Text), 3);
                    RobotAdapter.SetCposition.SetValue(Convert.ToSingle(tbLinePJ5Set.Text), 4);
                    RobotAdapter.SetCposition.SetValue(Convert.ToSingle(tbLineRJ6Set.Text), 5);
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
                    RobotAdapter.Setregister.SetValue(1, 1);
                    RobotAdapter.Setregister.SetValue(Convert.ToSingle(tbR1Set.Text), 0);
                    if (!myController.SetRegister())
                    {
                        ShowMessage("設定暫存器R1失敗", "設定暫存器狀態");
                        tbR1Set.Text = "";
                    }
                }
                if (!string.IsNullOrEmpty(tbR2Set.Text))
                {
                    RobotAdapter.Setregister.SetValue(2, 1);
                    RobotAdapter.Setregister.SetValue(Convert.ToSingle(tbR2Set.Text), 0);
                    if (!myController.SetRegister())
                    {
                        ShowMessage("設定暫存器R2失敗", "設定暫存器狀態");
                        tbR2Set.Text = "";
                    }
                }
                if (!string.IsNullOrEmpty(tbR3Set.Text))
                {
                    RobotAdapter.Setregister.SetValue(3, 1);
                    RobotAdapter.Setregister.SetValue(Convert.ToSingle(tbR3Set.Text), 0);
                    if (!myController.SetRegister())
                    {
                        ShowMessage("設定暫存器R3失敗", "設定暫存器狀態");
                        tbR3Set.Text = "";
                    }
                }
                if (!string.IsNullOrEmpty(tbR4Set.Text))
                {
                    RobotAdapter.Setregister.SetValue(4, 1);
                    RobotAdapter.Setregister.SetValue(Convert.ToSingle(tbR4Set.Text), 0);
                    if (!myController.SetRegister())
                    {
                        ShowMessage("設定暫存器R4失敗", "設定暫存器狀態");
                        tbR4Set.Text = "";
                    }
                }
                if (!string.IsNullOrEmpty(tbR5Set.Text))
                {
                    RobotAdapter.Setregister.SetValue(5, 1);
                    RobotAdapter.Setregister.SetValue(Convert.ToSingle(tbR5Set.Text), 0);
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
            RobotAdapter.Incmove.SetValue(myController.Step, 0);
        }
        private void btnJogXJ1Positive_Click(object sender, EventArgs e)
        {
            if (myController.Step == Controller.Stepnum.Cont)
            {
                return;
            }

            Button btn = (Button)sender;

            RobotAdapter.Incmove.SetValue(Convert.ToInt32(btn.Tag), 1);
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

                RobotAdapter.Jogmove = Convert.ToInt32(btn.Tag);
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
            if (!fgState)
            {
                if (!myController.Reset())
                {
                    ShowMessage("Reset失敗", "Reset狀態");
                    return;
                }
                else
                {
                    fgState = true;
                    timer1.Enabled = true;
                    richTextBox1.Text = "";
                }
            }
        }

        #endregion

    }
}
