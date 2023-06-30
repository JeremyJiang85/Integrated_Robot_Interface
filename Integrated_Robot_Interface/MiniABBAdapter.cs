using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using System.IO;
using System.IO.Ports;

namespace Integrated_Robot_Interface
{
    public class MiniABBAdapter : RobotAdapter, IGripper
    {
        int port = 8000;
        string message; //Message to send
        string receivedData;
        string receivedData1;
        int byteCount; //Raw bytes to send
        int bytesRead;
        byte[] buffer;
        NetworkStream stream; //Link stream
        byte[] sendData; //Raw data to send
        TcpClient client;

        bool Inverse_kinematics_flag = false;
        bool forward_kinematics_flag = false;
        double[] joint_point_array = new double[6];
        double[] x_y_z_point_array = new double[6];
        String joint_point_string;
        String x_y_z_point_string;

        #region <RobotAdapter>
        public override bool Connect()
        {
            if (port == 8000)
            {
                client = new TcpClient("", port);
            }
            try
            {
                message = "init_point";
                byteCount = Encoding.UTF8.GetByteCount(message);
                sendData = new byte[byteCount]; //Prepares variable size for required data
                sendData = Encoding.UTF8.GetBytes(message);
                stream = client.GetStream(); //Opens up the network stream
                stream.Write(sendData, 0, sendData.Length); //Transmits data onto the stream
                buffer = new byte[4096]; // Adjust the buffer size according to your data
                bytesRead = stream.Read(buffer, 0, buffer.Length);
                receivedData = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                buffer = new byte[4096]; // Adjust the buffer size according to your data
                bytesRead = stream.Read(buffer, 0, buffer.Length);
                receivedData1 = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                //listBox1.Items.Add("receive Data : " + receivedData);
                joint_point_array = ExtractDoubleArray(receivedData); //字串轉陣列
                x_y_z_point_array = ExtractDoubleArray(receivedData1); //字串轉陣列
                getcposition = x_y_z_point_array;
                getjposition = joint_point_array;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public override bool Disconnect()
        {
            message = "close"; //Set message variable to input
                               //byteCount = Encoding.ASCII.GetByteCount(message); //Measures bytes required to send ASCII data
            byteCount = Encoding.UTF8.GetByteCount(message);
            sendData = new byte[byteCount]; //Prepares variable size for required data
                                            // sendData = Encoding.ASCII.GetBytes(message);sendData = Encoding.UTF8.GetBytes(message); //Sets the sendData variable to the actual binary data (from the ASCII)
            sendData = Encoding.UTF8.GetBytes(message);
            stream = client.GetStream(); //Opens up the network stream
            stream.Write(sendData, 0, sendData.Length); //Transmits data onto the stream
            stream.Close(); //Closes data stream
            client.Close(); //Closes socket
            return true;
        }
        public override bool GetCPosition()
        {
            getcposition.SetValue(Convert.ToSingle(x_y_z_point_array[0]), 0);
            getcposition.SetValue(Convert.ToSingle(x_y_z_point_array[1]), 1);
            getcposition.SetValue(Convert.ToSingle(x_y_z_point_array[2]), 2);
            getcposition.SetValue(Convert.ToSingle(x_y_z_point_array[3]), 3);
            getcposition.SetValue(Convert.ToSingle(x_y_z_point_array[4]), 4);
            getcposition.SetValue(Convert.ToSingle(x_y_z_point_array[5]), 5);
            return true;
        }
        public override bool GetJPosition()
        {
            getjposition.SetValue(Convert.ToSingle(joint_point_array[0]), 0);
            getjposition.SetValue(Convert.ToSingle(joint_point_array[1]), 1);
            getjposition.SetValue(Convert.ToSingle(joint_point_array[2]), 2);
            getjposition.SetValue(Convert.ToSingle(joint_point_array[3]), 3);
            getjposition.SetValue(Convert.ToSingle(joint_point_array[4]), 4);
            getjposition.SetValue(Convert.ToSingle(joint_point_array[5]), 5);
            return true;
        }
        public override bool PointMoveC()
        {
            try
            {
                while (true)
                {
                    if (Inverse_kinematics_flag == false)
                    {
                        message = "Inverse_kinematics"; //Set message variable to input
                        //byteCount = Encoding.ASCII.GetByteCount(message); //Measures bytes required to send ASCII data
                        byteCount = Encoding.UTF8.GetByteCount(message);
                        sendData = new byte[byteCount]; //Prepares variable size for required data
                        sendData = Encoding.UTF8.GetBytes(message);

                        stream = client.GetStream(); //Opens up the network stream
                        stream.Write(sendData, 0, sendData.Length); //Transmits data onto the stream
                        Inverse_kinematics_flag = true;
                    }
                    else
                    {
                        //字串轉雙浮點數

                        x_y_z_point_array[0] = Convert.ToDouble(setcposition.GetValue(0));
                        x_y_z_point_array[1] = Convert.ToDouble(setcposition.GetValue(1));
                        x_y_z_point_array[2] = Convert.ToDouble(setcposition.GetValue(2));
                        x_y_z_point_array[3] = Convert.ToDouble(setcposition.GetValue(3));
                        x_y_z_point_array[4] = Convert.ToDouble(setcposition.GetValue(4));
                        x_y_z_point_array[5] = Convert.ToDouble(setcposition.GetValue(5));
                        x_y_z_point_string = string.Join(", ", x_y_z_point_array);
                        //發送訊息到server端
                        byteCount = Encoding.UTF8.GetByteCount(x_y_z_point_string);
                        sendData = new byte[byteCount];
                        sendData = Encoding.UTF8.GetBytes(x_y_z_point_string);
                        stream = client.GetStream(); //Opens up the network stream
                        stream.Write(sendData, 0, sendData.Length); //Transmits data onto the stream
                        //接收server訊息
                        buffer = new byte[4096]; // Adjust the buffer size according to your data
                        bytesRead = stream.Read(buffer, 0, buffer.Length);
                        receivedData = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        //listBox1.Items.Add("receive Data : " + receivedData);
                        joint_point_array = ExtractDoubleArray(receivedData); //字串轉陣列
                        getjposition.SetValue(Convert.ToSingle(joint_point_array[0]), 0);
                        getjposition.SetValue(Convert.ToSingle(joint_point_array[1]), 1);
                        getjposition.SetValue(Convert.ToSingle(joint_point_array[2]), 2);
                        getjposition.SetValue(Convert.ToSingle(joint_point_array[3]), 3);
                        getjposition.SetValue(Convert.ToSingle(joint_point_array[4]), 4);
                        getjposition.SetValue(Convert.ToSingle(joint_point_array[5]), 5);
                        //x_y_z_point_array = ExtractDoubleArray(receivedData1); //字串轉陣列
                        getcposition.SetValue(Convert.ToSingle(x_y_z_point_array[0]), 0);
                        getcposition.SetValue(Convert.ToSingle(x_y_z_point_array[1]), 1);
                        getcposition.SetValue(Convert.ToSingle(x_y_z_point_array[2]), 2);
                        getcposition.SetValue(Convert.ToSingle(x_y_z_point_array[3]), 3);
                        getcposition.SetValue(Convert.ToSingle(x_y_z_point_array[4]), 4);
                        getcposition.SetValue(Convert.ToSingle(x_y_z_point_array[5]), 5);

                        Inverse_kinematics_flag = false;
                        return true;
                    }
                }
            }
            catch (System.NullReferenceException)
            {
                return false;
            }
        }
        public override bool PointMoveJ()
        {
            try
            {
                while (true)
                {
                    if (forward_kinematics_flag == false)
                    {
                        message = "forward_kinematics"; //Set message variable to input
                        //byteCount = Encoding.ASCII.GetByteCount(message); //Measures bytes required to send ASCII data
                        byteCount = Encoding.UTF8.GetByteCount(message);
                        sendData = new byte[byteCount]; //Prepares variable size for required data
                        sendData = Encoding.UTF8.GetBytes(message);

                        stream = client.GetStream(); //Opens up the network stream
                        stream.Write(sendData, 0, sendData.Length); //Transmits data onto the stream
                        forward_kinematics_flag = true;
                    }
                    else
                    {
                        //字串轉雙浮點數
                        joint_point_array[0] = Convert.ToDouble(setjposition.GetValue(0));
                        joint_point_array[1] = Convert.ToDouble(setjposition.GetValue(1));
                        joint_point_array[2] = Convert.ToDouble(setjposition.GetValue(2));
                        joint_point_array[3] = Convert.ToDouble(setjposition.GetValue(3));
                        joint_point_array[4] = Convert.ToDouble(setjposition.GetValue(4));
                        joint_point_array[5] = Convert.ToDouble(setjposition.GetValue(5));
                        joint_point_string = string.Join(", ", joint_point_array);
                        //發送訊息到server端
                        byteCount = Encoding.UTF8.GetByteCount(joint_point_string);
                        sendData = new byte[byteCount];
                        sendData = Encoding.UTF8.GetBytes(joint_point_string);
                        stream = client.GetStream(); //Opens up the network stream
                        stream.Write(sendData, 0, sendData.Length); //Transmits data onto the stream
                        //接收server訊息
                        buffer = new byte[4096]; // Adjust the buffer size according to your data
                        bytesRead = stream.Read(buffer, 0, buffer.Length);
                        receivedData = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        //listBox1.Items.Add("receive Data : " + receivedData);
                        x_y_z_point_array = ExtractDoubleArray(receivedData); //字串轉陣列
                        getcposition.SetValue(Convert.ToSingle(x_y_z_point_array[0]), 0);
                        getcposition.SetValue(Convert.ToSingle(x_y_z_point_array[1]), 1);
                        getcposition.SetValue(Convert.ToSingle(x_y_z_point_array[2]), 2);
                        getcposition.SetValue(Convert.ToSingle(x_y_z_point_array[3]), 3);
                        getcposition.SetValue(Convert.ToSingle(x_y_z_point_array[4]), 4);
                        getcposition.SetValue(Convert.ToSingle(x_y_z_point_array[5]), 5);
                        //joint_point_array = ExtractDoubleArray(receivedData); //字串轉陣列
                        getjposition.SetValue(Convert.ToSingle(joint_point_array[0]), 0);
                        getjposition.SetValue(Convert.ToSingle(joint_point_array[1]), 1);
                        getjposition.SetValue(Convert.ToSingle(joint_point_array[2]), 2);
                        getjposition.SetValue(Convert.ToSingle(joint_point_array[3]), 3);
                        getjposition.SetValue(Convert.ToSingle(joint_point_array[4]), 4);
                        getjposition.SetValue(Convert.ToSingle(joint_point_array[5]), 5);
                        forward_kinematics_flag = false;
                        return true;
                    }
                }
            }
            catch (System.NullReferenceException)
            {
                return false;
            }
        }
        public override bool JogMoveC()
        {
            float Value = Convert.ToSingle(jogmove.GetValue(0));
            
            switch (Convert.ToInt32(jogmove.GetValue(1)))
            {
                case 0:
                    x_y_z_point_array[0] += Value;
                    break;
                case 1:
                    x_y_z_point_array[0] -= Value;
                    break;
                case 2:
                    x_y_z_point_array[1] += Value;
                    break;
                case 3:
                    x_y_z_point_array[1] -= Value;
                    break;
                case 4:
                    x_y_z_point_array[2] += Value;
                    break;
                case 5:
                    x_y_z_point_array[2] -= Value;
                    break;
                case 6:
                    x_y_z_point_array[3] += Value;
                    break;
                case 7:
                    x_y_z_point_array[3] -= Value;
                    break;
                case 8:
                    x_y_z_point_array[4] += Value;
                    break;
                case 9:
                    x_y_z_point_array[4] -= Value;
                    break;
                case 10:
                    x_y_z_point_array[5] += Value;
                    break;
                case 11:
                    x_y_z_point_array[5] -= Value;
                    break;
            }

            try
            {
                while (true)
                {
                    if (Inverse_kinematics_flag == false)
                    {
                        message = "Inverse_kinematics"; //Set message variable to input
                        //byteCount = Encoding.ASCII.GetByteCount(message); //Measures bytes required to send ASCII data
                        byteCount = Encoding.UTF8.GetByteCount(message);
                        sendData = new byte[byteCount]; //Prepares variable size for required data
                        sendData = Encoding.UTF8.GetBytes(message);

                        stream = client.GetStream(); //Opens up the network stream
                        stream.Write(sendData, 0, sendData.Length); //Transmits data onto the stream
                        Inverse_kinematics_flag = true;
                    }
                    else
                    {
                        //字串轉雙浮點數
                        x_y_z_point_string = string.Join(", ", x_y_z_point_array);
                        //發送訊息到server端
                        byteCount = Encoding.UTF8.GetByteCount(x_y_z_point_string);
                        sendData = new byte[byteCount];
                        sendData = Encoding.UTF8.GetBytes(x_y_z_point_string);
                        stream = client.GetStream(); //Opens up the network stream
                        stream.Write(sendData, 0, sendData.Length); //Transmits data onto the stream
                        //接收server訊息
                        buffer = new byte[4096]; // Adjust the buffer size according to your data
                        bytesRead = stream.Read(buffer, 0, buffer.Length);
                        receivedData = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        //listBox1.Items.Add("receive Data : " + receivedData);
                        joint_point_array = ExtractDoubleArray(receivedData); //字串轉陣列
                        getjposition.SetValue(Convert.ToSingle(joint_point_array[0]), 0);
                        getjposition.SetValue(Convert.ToSingle(joint_point_array[1]), 1);
                        getjposition.SetValue(Convert.ToSingle(joint_point_array[2]), 2);
                        getjposition.SetValue(Convert.ToSingle(joint_point_array[3]), 3);
                        getjposition.SetValue(Convert.ToSingle(joint_point_array[4]), 4);
                        getjposition.SetValue(Convert.ToSingle(joint_point_array[5]), 5);
                        Inverse_kinematics_flag = false;
                        return true;
                    }
                }
            }
            catch (System.NullReferenceException)
            {
                return false;
            }
        }
        public override bool JogMoveJ()
        {
            float Value = Convert.ToSingle(jogmove.GetValue(0));

            switch (Convert.ToInt32(jogmove.GetValue(1)))
            {
                case 0:
                    joint_point_array[0] += Value;
                    message = "j1";
                    break;
                case 1:
                    joint_point_array[0] -= Value;
                    message = "J1";
                    break;
                case 2:
                    joint_point_array[1] += Value;
                    message = "j2";
                    break;
                case 3:
                    joint_point_array[1] -= Value;
                    message = "J2";
                    break;
                case 4:
                    joint_point_array[2] += Value;
                    message = "j3";
                    break;
                case 5:
                    joint_point_array[2] -= Value;
                    message = "J3";
                    break;
                case 6:
                    joint_point_array[3] += Value;
                    message = "j4";
                    break;
                case 7:
                    joint_point_array[3] -= Value;
                    message = "J4";
                    break;
                case 8:
                    joint_point_array[4] += Value;
                    message = "j5";
                    break;
                case 9:
                    joint_point_array[4] -= Value;
                    message = "J5";
                    break;
                case 10:
                    joint_point_array[5] += Value;
                    message = "j6";
                    break;
                case 11:
                    joint_point_array[5] -= Value;
                    message = "J6";
                    break;
            }

            try
            {
                while (true)
                {
                    if (forward_kinematics_flag == false)
                    {
                        //byteCount = Encoding.ASCII.GetByteCount(message); //Measures bytes required to send ASCII data
                        byteCount = Encoding.UTF8.GetByteCount(message);
                        sendData = new byte[byteCount]; //Prepares variable size for required data
                        sendData = Encoding.UTF8.GetBytes(message);

                        stream = client.GetStream(); //Opens up the network stream
                        stream.Write(sendData, 0, sendData.Length); //Transmits data onto the stream
                        forward_kinematics_flag = true;
                    }
                    else
                    {
                        //字串轉雙浮點數
                        joint_point_string = string.Join(", ", joint_point_array);
                        //發送訊息到server端
                        byteCount = Encoding.UTF8.GetByteCount(joint_point_string);
                        sendData = new byte[byteCount];
                        sendData = Encoding.UTF8.GetBytes(joint_point_string);
                        stream = client.GetStream(); //Opens up the network stream
                        stream.Write(sendData, 0, sendData.Length); //Transmits data onto the stream
                        //接收server訊息
                        buffer = new byte[4096]; // Adjust the buffer size according to your data
                        bytesRead = stream.Read(buffer, 0, buffer.Length);
                        receivedData = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        //listBox1.Items.Add("receive Data : " + receivedData);
                        x_y_z_point_array = ExtractDoubleArray(receivedData); //字串轉陣列
                        getcposition.SetValue(Convert.ToSingle(x_y_z_point_array[0]), 0);
                        getcposition.SetValue(Convert.ToSingle(x_y_z_point_array[1]), 1);
                        getcposition.SetValue(Convert.ToSingle(x_y_z_point_array[2]), 2);
                        getcposition.SetValue(Convert.ToSingle(x_y_z_point_array[3]), 3);
                        getcposition.SetValue(Convert.ToSingle(x_y_z_point_array[4]), 4);
                        getcposition.SetValue(Convert.ToSingle(x_y_z_point_array[5]), 5);
                        forward_kinematics_flag = false;
                        return true;
                    }
                }
            }
            catch (System.NullReferenceException)
            {
                return false;
            }
        }
        #endregion

        #region <Gripper>
        public bool GripperConnect()
        {
            return false;
        }
        public bool GripperDisconnect()
        {
            return false;
        }
        public bool GripperGrap()
        {
            GripperDirState = 1;
            fgGripperState = true;
            Thread thread = new Thread(grab);
            thread.Start();
            return true;
        }
        public bool GripperOpen()
        {
            GripperDirState = 0;
            fgGripperState = true;
            Thread thread = new Thread(grab);
            thread.Start();
            return true;
        }
        public bool GripperStop()
        {
            fgGripperState = false;
            return true;
        }
        private void grab()
        {
            while (fgGripperState)
            {
                if (GripperDirState == 1)
                {
                    message = "catch"; //Set message variable to input

                    byteCount = Encoding.UTF8.GetByteCount(message);
                    sendData = new byte[byteCount]; //Prepares variable size for required data
                                                    // sendData = Encoding.ASCII.GetBytes(message);sendData = Encoding.UTF8.GetBytes(message); //Sets the sendData variable to the actual binary data (from the ASCII)
                    sendData = Encoding.UTF8.GetBytes(message);
                    stream = client.GetStream(); //Opens up the network stream
                    stream.Write(sendData, 0, sendData.Length); //Transmits data onto the stream
                    Task.Delay(100);
                }
                else
                {
                    message = "release"; //Set message variable to input
                                         //byteCount = Encoding.ASCII.GetByteCount(message); //Measures bytes required to send ASCII data
                    byteCount = Encoding.UTF8.GetByteCount(message);
                    sendData = new byte[byteCount]; //Prepares variable size for required data
                                                    // sendData = Encoding.ASCII.GetBytes(message);sendData = Encoding.UTF8.GetBytes(message); //Sets the sendData variable to the actual binary data (from the ASCII)
                    sendData = Encoding.UTF8.GetBytes(message);
                    stream = client.GetStream(); //Opens up the network stream
                    stream.Write(sendData, 0, sendData.Length); //Transmits data onto the stream
                    Task.Delay(100);
                }
            }
        }
        #endregion
        public static double[] ExtractDoubleArray(string str)
        {
            string[] values = str.Trim('[', ']').Split(',');
            double[] array = new double[values.Length];
            NumberFormatInfo format = new NumberFormatInfo();
            format.NumberDecimalSeparator = ".";

            for (int i = 0; i < values.Length; i++)
            {
                array[i] = double.Parse(values[i], format);
            }
            return array;
        }
    }
}
