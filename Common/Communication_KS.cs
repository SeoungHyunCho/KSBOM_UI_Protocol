using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Data;

namespace Common
{
    public class Communication_KS
    {
        #region Define
        #endregion

        #region Field
        private int m_ComPortNum;
        private string m_PortName;
        private List<string> m_ComPortList;
        private int m_Baudrate;
        private bool m_IsConnected;
        private int m_RepeatCount;
        private SerialPort serialPort_KS;
        private string m_SendData;
        private string m_ReceiveData;
        private bool m_IsReceivedData;
        #endregion

        #region Constructor
        public Communication_KS()
        {
            this.ComPortNum = 0;
            this.PortName = string.Empty;
            this.ComPortList = new List<string>();
            this.Baudrate = 9600;
            this.IsConnected = false;
            this.RepeatCount = 0;
            this.SendData = string.Empty;
            this.ReceiveData = string.Empty;
            this.IsReceivedData = false;
        }
        #endregion

        #region Property
        public int ComPortNum
        {
            get { return this.m_ComPortNum; }
            set { this.m_ComPortNum = value; }
        }

        public List<string> ComPortList
        {
            get { return this.m_ComPortList; }
            set { this.m_ComPortList = value; }
        }
        public string PortName
        {
            get { return this.m_PortName; }
            set { this.m_PortName = value; }
        }
        public int Baudrate
        {
            get { return this.m_Baudrate; }
            set { this.m_Baudrate = value; }
        }
        public bool IsConnected
        {
            get { return this.m_IsConnected; }
            set { this.m_IsConnected = value; }
        }
        public int RepeatCount
        {
            get { return this.m_RepeatCount; }
            set { this.m_RepeatCount = value; }
        }
        public string SendData
        {
            get { return this.m_SendData; }
            set { this.m_SendData = value; }
        }
        public string ReceiveData
        {
            get { return this.m_ReceiveData; }
            set { this.m_ReceiveData = value; }
        }
        public bool IsReceivedData
        {
            get { return this.m_IsReceivedData; }
            set { this.m_IsReceivedData = value; }
        }
        #endregion

        #region Event Handler
        #endregion

        #region Method
        public bool GetSerialPorts()
        {
            bool ret = false;

            string[] serialPortList = System.IO.Ports.SerialPort.GetPortNames();

            this.ComPortList.Clear();
            foreach (string portName in serialPortList)
            {
                this.ComPortList.Add(portName);
            }

            this.ComPortList.Sort();

            ret = true;

            return ret;
        }

        public bool SetSelectedSerialPortConnect(string portName, int baudrate)
        {
            bool ret = false;

            if (this.serialPort_KS != null && this.serialPort_KS.IsOpen)
            {
                this.serialPort_KS.Close();
                this.IsConnected = serialPort_KS.IsOpen;
            }
            else
            {
                this.serialPort_KS = new SerialPort
                {
                    PortName = portName,
                    BaudRate = baudrate,
                    DataBits = 8,
                    Parity = Parity.None,
                    StopBits = StopBits.One
                };

                this.serialPort_KS.DataReceived += OnDataReceived;

                this.serialPort_KS.Open();
                this.IsConnected = this.serialPort_KS.IsOpen;
            }

            ret = true;

            return ret;
        }

        public bool OnOpen()
        {
            bool ret = false;

            if (this.serialPort_KS != null && !this.serialPort_KS.IsOpen)
            {
                this.serialPort_KS.Open();
                this.IsConnected = serialPort_KS.IsOpen;
                ret = true;
            }

            return ret;
        }

        public bool OnClose()
        {
            bool ret = false;

            if (this.serialPort_KS != null && this.serialPort_KS.IsOpen)
            {
                this.serialPort_KS.Close();
                this.IsConnected = serialPort_KS.IsOpen;
                ret = true;
            }

            return ret;
        }

        public bool OnDataSend(string data, bool hex)
        {
            bool ret = false;

            if (this.serialPort_KS.IsOpen)
            {
                this.SendData = data;
                if (hex)
                {
                    string hexData = data.Replace(" ", "");
                    byte[] writeBuffer = new byte[hexData.Length / 2];

                    for (int i = 0; i < writeBuffer.Length; i++)
                    {
                        writeBuffer[i] = Convert.ToByte(hexData.Substring(i * 2, 2), 16);
                    }

                    this.serialPort_KS.Write(writeBuffer, 0, writeBuffer.Length);
                }
                else
                {
                    //byte[] writeBuffer = System.Text.Encoding.ASCII.GetBytes(this.SendData);
                    //this.serialPort_KS.Write(writeBuffer, 0, writeBuffer.Length);

                    this.serialPort_KS.Write(this.SendData);
                }

                ret = true;
            }

            return ret;
        }

        private void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int bytesToRead = this.serialPort_KS.BytesToRead;
                byte[] readBuffer = new byte[bytesToRead];
                this.serialPort_KS.Read(readBuffer, 0, bytesToRead);

                foreach (byte subBuffer in readBuffer)
                {
                    this.ReceiveData += subBuffer.ToString("X2") + " ";
                }

                this.IsReceivedData = true;

                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"데이터 수신 중 오류: {ex.Message}");
            }
        }
        #endregion

        #region Members
        #endregion
    }
}
