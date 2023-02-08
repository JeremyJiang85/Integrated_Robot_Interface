﻿using System;
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
        public bool fgJogStatus { get; set; } = false;
        public bool fgJog { get; set; } = false;


        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer2.Interval = 200;
            string[] Robot = new string[] { Controller.Robotnum.None.ToString(), Controller.Robotnum.Fanuc.ToString(),
                                            Controller.Robotnum.Nexcom.ToString(), Controller.Robotnum.Ourarm.ToString()};
            cboRobot.Items.AddRange(Robot);
            string[] Coordinate = new string[] { Controller.Coordinatenum.Cartesian.ToString(), Controller.Coordinatenum.Joint.ToString() };
            cboCoordinate.Items.AddRange(Coordinate);
            string[] Step = new string[] { Controller.Stepnum.One.ToString(), Controller.Stepnum.Five.ToString(),
                                           Controller.Stepnum.Ten.ToString(), Controller.Stepnum.Cont.ToString() };
            cboStep.Items.AddRange(Step);
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
                }
            }
        }

        #region <object status>
        private void Initialize()
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            txtIP.Enabled = false;
            fgConnectionStatus = false;
            fgState = false;
            cboRobot.Enabled = true;
            cboRobot.SelectedIndex = 0;
            cboCoordinate.SelectedIndex = 0;
            cboStep.SelectedIndex = 0;
            gbEnbleControl(false);
            txtInitialize();
        }
        private void gbEnbleControl(bool tf)
        {
            gbOverride.Enabled = tf;
            gbCurrentState.Enabled = tf;
            gbPositionSet.Enabled = tf;
            gbRegister.Enabled = tf;
            gbPositionMove.Enabled = tf;
        }
        private void txtInitialize()
        {
            btnConnection.Text = "Connect";
            lblConnectionStatus.Text = "Connection Status : Disconnected";
            lblXyzwpr.Text = "Cartesian\r\nX : \r\nY : \r\nZ : \r\nW: \r\nP : \r\nR : ";
            lblJoint.Text = "Joint\r\nJ1 : \r\nJ2 : \r\nJ3 : \r\nJ4 : \r\nJ5 : \r\nJ6 : ";
            lblOverride.Text = "";
            tbXJ1Set.Text = "";
            tbYJ2Set.Text = "";
            tbZJ3Set.Text = "";
            tbWJ4Set.Text = "";
            tbPJ5Set.Text = "";
            tbRJ6Set.Text = "";
            tbVelocity.Text = "";
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
                    break;
                case nameof(Controller.Robotnum.Nexcom):
                    myController.Robot = Controller.Robotnum.Nexcom;
                    txtIP.Enabled = false;
                    break;
                case nameof(Controller.Robotnum.Ourarm):
                    myController.Robot = Controller.Robotnum.Ourarm;
                    txtIP.Enabled = false;
                    break;
                default:
                    myController.Robot = Controller.Robotnum.None;
                    txtIP.Enabled = false;
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
                    switch (myController.Robot)
                    {
                        case Controller.Robotnum.Fanuc:
                            lblRange.Text = "X : 0~650\r\nY : -450~450\r\nZ : -270~400\r\nVelocity : 100~500";
                            myController.GetCPosition();
                            RobotAdapter.SetCposition = RobotAdapter.GetCposition;
                            myController.SetCPosition();
                            break;
                        case Controller.Robotnum.Nexcom:
                            gbRegister.Enabled = false;
                            lblRange.Text = "X : 0~500\r\nY : -450~450\r\nZ : 50~600\r\nVelocity : 0~500";
                            myController.GetCPosition();
                            RobotAdapter.SetCposition = RobotAdapter.GetCposition;
                            myController.SetCPosition();
                            break;
                        case Controller.Robotnum.Ourarm:
                            break;
                    }
                }
                else
                {
                    richTextBox1.Text += $"手臂連線失敗\r\n{RobotAdapter.Apierrtext}";
                    MessageBox.Show($"手臂連線失敗\r\n{RobotAdapter.Apierrtext}");
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
                    richTextBox1.Text += $"手臂離線失敗\r\n{RobotAdapter.Apierrtext}";
                    MessageBox.Show($"手臂離線失敗\r\n{RobotAdapter.Apierrtext}");
                }
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

            if (!myController.Override())
            {
                ShowMessage("讀取速度百分比失敗", "讀取速度百分比狀態");
                lblOverride.Text = "Error";
                return;
            }
            else
            {
                lblOverride.Text = RobotAdapter.Overridetext;
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


        }
        private void ShowMessage(string content, string title)
        {
            DialogResult result;
            fgState = false;
            timer1.Enabled = false;
            richTextBox1.Text += $"{content}\r\n{RobotAdapter.Apierrtext}";
            result = MessageBox.Show($"{content}\r\n{RobotAdapter.Apierrtext}", $"{title}", MessageBoxButtons.AbortRetryIgnore);
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
                }
            }
            else if (result == DialogResult.Ignore)
            {
                fgState = true;
                timer1.Enabled = true;
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (!fgState)
            {
                if (!myController.Reset())
                {
                    ShowMessage("Reset失敗", "取得刷新狀態");
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

        #region <gbPositionSet>
        private void cboCoordinate_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboCoordinate.Text)
            {
                case nameof(Controller.Coordinatenum.Cartesian):
                    myController.Coordinate = Controller.Coordinatenum.Cartesian;
                    lblXJ1Set.Text = "X :";
                    lblYJ2Set.Text = "Y :";
                    lblZJ3Set.Text = "Z :";
                    lblWJ4Set.Text = "W:";
                    lblPJ5Set.Text = "P :";
                    lblRJ6Set.Text = "R :";
                    break;
                case nameof(Controller.Coordinatenum.Joint):
                    myController.Coordinate = Controller.Coordinatenum.Joint;
                    lblXJ1Set.Text = "J1 :";
                    lblYJ2Set.Text = "J2 :";
                    lblZJ3Set.Text = "J3 :";
                    lblWJ4Set.Text = "J4 :";
                    lblPJ5Set.Text = "J5 :";
                    lblRJ6Set.Text = "J6 :";
                    break;
            }
        }
        private void btnPositionCopy_Click(object sender, EventArgs e)
        {
            switch (myController.Coordinate)
            {
                case Controller.Coordinatenum.Cartesian:
                    tbXJ1Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetCposition.GetValue(0)).ToString("###0.000"))}";
                    tbYJ2Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetCposition.GetValue(1)).ToString("###0.000"))}";
                    tbZJ3Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetCposition.GetValue(2)).ToString("###0.000"))}";
                    tbWJ4Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetCposition.GetValue(3)).ToString("###0.000"))}";
                    tbPJ5Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetCposition.GetValue(4)).ToString("###0.000"))}";
                    tbRJ6Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetCposition.GetValue(5)).ToString("###0.000"))}";

                    if (!myController.GetVelocity())
                    {
                        ShowMessage("讀取速度失敗", "讀取速度狀態");
                        tbVelocity.Text = "Erorr";
                        return;
                    }
                    else
                    {
                        tbVelocity.Text = $"{string.Format("{0,10}", RobotAdapter.Getvelocity.ToString("###0.000"))}";
                    }
                    break;
                case Controller.Coordinatenum.Joint:
                    tbXJ1Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetJposition.GetValue(0)).ToString("###0.000"))}";
                    tbYJ2Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetJposition.GetValue(1)).ToString("###0.000"))}";
                    tbZJ3Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetJposition.GetValue(2)).ToString("###0.000"))}";
                    tbWJ4Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetJposition.GetValue(3)).ToString("###0.000"))}";
                    tbPJ5Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetJposition.GetValue(4)).ToString("###0.000"))}";
                    tbRJ6Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.GetJposition.GetValue(5)).ToString("###0.000"))}";

                    if (!myController.GetVelocity())
                    {
                        ShowMessage("讀取速度失敗", "讀取速度狀態");
                        tbVelocity.Text = "Erorr";
                        return;
                    }
                    else
                    {
                        tbVelocity.Text = $"{string.Format("{0,10}", RobotAdapter.Getvelocity.ToString("###0.000"))}";
                    }
                    break;
            }
        }
        private void btnPositionSet_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbXJ1Set.Text) || string.IsNullOrEmpty(tbYJ2Set.Text) || string.IsNullOrEmpty(tbZJ3Set.Text) ||
                    string.IsNullOrEmpty(tbWJ4Set.Text) || string.IsNullOrEmpty(tbPJ5Set.Text) || string.IsNullOrEmpty(tbRJ6Set.Text) ||
                    string.IsNullOrEmpty(tbVelocity.Text))
                {
                    MessageBox.Show("座標值和速度值不可有空白");
                }
                else
                {
                    switch (myController.Coordinate)
                    {
                        case Controller.Coordinatenum.Cartesian:
                            switch (myController.Robot)
                            {
                                case Controller.Robotnum.Fanuc:
                                    if (Convert.ToSingle(tbXJ1Set.Text) < 0 || Convert.ToSingle(tbXJ1Set.Text) > 650 ||
                                        Convert.ToSingle(tbYJ2Set.Text) < -450 || Convert.ToSingle(tbYJ2Set.Text) > 450 ||
                                        Convert.ToSingle(tbZJ3Set.Text) < -270 || Convert.ToSingle(tbZJ3Set.Text) > 400 ||
                                        Convert.ToSingle(tbVelocity.Text) < 100 || Convert.ToSingle(tbVelocity.Text) > 500)
                                    {
                                        MessageBox.Show("座標或速度超出安全範圍");
                                        return;
                                    }
                                    break;
                                case Controller.Robotnum.Nexcom:
                                    if (Convert.ToSingle(tbXJ1Set.Text) < 0 || Convert.ToSingle(tbXJ1Set.Text) > 500 ||
                                        Convert.ToSingle(tbYJ2Set.Text) < -450 || Convert.ToSingle(tbYJ2Set.Text) > 450 ||
                                        Convert.ToSingle(tbZJ3Set.Text) < 50 || Convert.ToSingle(tbZJ3Set.Text) > 600 ||
                                        Convert.ToSingle(tbVelocity.Text) < 0 || Convert.ToSingle(tbVelocity.Text) > 500)
                                    {
                                        MessageBox.Show("座標或速度超出安全範圍");
                                        return;
                                    }
                                    break;
                                case Controller.Robotnum.Ourarm:
                                    break;
                            }
                            RobotAdapter.Setvelocity = Convert.ToSingle(tbVelocity.Text);
                            if (!myController.SetVelocity())
                            {
                                ShowMessage("設定速度失敗", "設定速度狀態");
                            }

                            RobotAdapter.SetCposition.SetValue(Convert.ToSingle(tbXJ1Set.Text), 0);
                            RobotAdapter.SetCposition.SetValue(Convert.ToSingle(tbYJ2Set.Text), 1);
                            RobotAdapter.SetCposition.SetValue(Convert.ToSingle(tbZJ3Set.Text), 2);
                            RobotAdapter.SetCposition.SetValue(Convert.ToSingle(tbWJ4Set.Text), 3);
                            RobotAdapter.SetCposition.SetValue(Convert.ToSingle(tbPJ5Set.Text), 4);
                            RobotAdapter.SetCposition.SetValue(Convert.ToSingle(tbRJ6Set.Text), 5);
                            if (!myController.SetCPosition())
                            {
                                ShowMessage("設定座標失敗", "點到點移動狀態");
                            }
                            break;
                        case Controller.Coordinatenum.Joint:
                            switch (myController.Robot)
                            {
                                case Controller.Robotnum.Fanuc:
                                    if (Convert.ToSingle(tbXJ1Set.Text) < -180 || Convert.ToSingle(tbXJ1Set.Text) > 180 ||
                                        Convert.ToSingle(tbYJ2Set.Text) < -180 || Convert.ToSingle(tbYJ2Set.Text) > 180 ||
                                        Convert.ToSingle(tbZJ3Set.Text) < -180 || Convert.ToSingle(tbZJ3Set.Text) > 180 ||
                                        Convert.ToSingle(tbWJ4Set.Text) < -180 || Convert.ToSingle(tbWJ4Set.Text) > 180 ||
                                        Convert.ToSingle(tbPJ5Set.Text) < -180 || Convert.ToSingle(tbPJ5Set.Text) > 180 ||
                                        Convert.ToSingle(tbRJ6Set.Text) < -180 || Convert.ToSingle(tbRJ6Set.Text) > 180 ||
                                        Convert.ToSingle(tbVelocity.Text) < 100 || Convert.ToSingle(tbVelocity.Text) > 500)
                                    {
                                        MessageBox.Show("座標速度超出安全範圍");
                                        return;
                                    }
                                    break;
                                case Controller.Robotnum.Nexcom:
                                    if (Convert.ToSingle(tbXJ1Set.Text) < -180 || Convert.ToSingle(tbXJ1Set.Text) > 180 ||
                                        Convert.ToSingle(tbYJ2Set.Text) < -180 || Convert.ToSingle(tbYJ2Set.Text) > 180 ||
                                        Convert.ToSingle(tbZJ3Set.Text) < -180 || Convert.ToSingle(tbZJ3Set.Text) > 180 ||
                                        Convert.ToSingle(tbWJ4Set.Text) < -180 || Convert.ToSingle(tbWJ4Set.Text) > 180 ||
                                        Convert.ToSingle(tbPJ5Set.Text) < -180 || Convert.ToSingle(tbPJ5Set.Text) > 180 ||
                                        Convert.ToSingle(tbRJ6Set.Text) < -180 || Convert.ToSingle(tbRJ6Set.Text) > 180 ||
                                        Convert.ToSingle(tbVelocity.Text) < 0 || Convert.ToSingle(tbVelocity.Text) > 500)
                                    {
                                        MessageBox.Show("座標速度超出安全範圍");
                                        return;
                                    }
                                    break;
                                case Controller.Robotnum.Ourarm:
                                    break;
                            }
                            RobotAdapter.Setvelocity = Convert.ToSingle(tbVelocity.Text);
                            if (!myController.SetVelocity())
                            {
                                ShowMessage("設定速度失敗", "設定速度狀態");
                            }

                            RobotAdapter.SetJposition.SetValue(Convert.ToSingle(tbXJ1Set.Text), 0);
                            RobotAdapter.SetJposition.SetValue(Convert.ToSingle(tbYJ2Set.Text), 1);
                            RobotAdapter.SetJposition.SetValue(Convert.ToSingle(tbZJ3Set.Text), 2);
                            RobotAdapter.SetJposition.SetValue(Convert.ToSingle(tbWJ4Set.Text), 3);
                            RobotAdapter.SetJposition.SetValue(Convert.ToSingle(tbPJ5Set.Text), 4);
                            RobotAdapter.SetJposition.SetValue(Convert.ToSingle(tbRJ6Set.Text), 5);
                            if (!myController.SetJPosition())
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

        #region <gbPositionMove>
        private void cboStep_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboStep.Text)
            {
                case nameof(Controller.Stepnum.One):
                    myController.Step = Controller.Stepnum.One;
                    fgJogStatus = false;
                    timer2.Enabled = false;
                    break;
                case nameof(Controller.Stepnum.Five):
                    myController.Step = Controller.Stepnum.Five;
                    fgJogStatus = false;
                    timer2.Enabled = false;
                    break;
                case nameof(Controller.Stepnum.Ten):
                    myController.Step = Controller.Stepnum.Ten;
                    fgJogStatus = false;
                    timer2.Enabled = false;
                    break;
                case nameof(Controller.Stepnum.Cont):
                    myController.Step = Controller.Stepnum.Cont;
                    fgJogStatus = true;
                    break;
            }
            RobotAdapter.Axismove.SetValue(myController.Step, 0);
        }
        private void btnXJ1Positive_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (fgJogStatus)
            {
                if (!fgJog)
                {
                    fgJog = true;
                    RobotAdapter.Axismove.SetValue(Convert.ToInt32(btn.Tag), 1);
                    timer2.Enabled = true;
                }
                else
                {
                    fgJog = false;
                    timer2.Enabled = false;
                }
            }
            else
            {
                RobotAdapter.Axismove.SetValue(Convert.ToInt32(btn.Tag), 1);
                if (!myController.Inc())
                {
                    ShowMessage("單動移動失敗", "單動移動狀態");
                }

            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!myController.Inc())
            {
                ShowMessage("寸動移動失敗", "寸動移動狀態");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myController.Enable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myController.Disable();
        }
    }

    #endregion


}
