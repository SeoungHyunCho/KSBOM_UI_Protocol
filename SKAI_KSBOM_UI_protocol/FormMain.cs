using Common.UI;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using System.Collections.Specialized;
using System.Reflection.PortableExecutable;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.CodeDom;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Reflection.Emit;

namespace SKAI_KSBOM_UI_protocol
{
    public partial class FormMain : Form
    {

        #region Define
        static int Button_Status_Req = 0x01;
        static int Button_Batch_On = 0x02;
        static int Button_Batch_Off = 0x03;
        static int Button_Gas_Open = 0x04;
        static int Button_Gas_Close = 0x05;
        static int Button_Gas_Done = 0x06;
        static int Button_Gas_Fail = 0x07;
        static int Button_ELV_Done = 0x08;
        static int Button_ELV_Fail = 0x09;
        static int Button_ELV_Arrived = 0x0A;
        static int Button_Send_Weather = 0x0D;
        static int Button_Send_Time = 0x0E;
        static int Button_Send_Parking = 0x0F;
        static int Button_Send_Notice = 0x10;
        static int Button_BypassStat = 0x11;
        static int Button_BypassCtrl = 0x12;
        
        static int BATCH_ON = 0x01;
        static int BATCH_OFF = 0x00;
        static int GAS_OPEN = 0x01;
        static int GAS_CLOSE = 0x00;
        #endregion

        #region Field
        private Communication_KS m_Communication_KS;
        private Protocols m_Protocols;
        private TestVectorSystem m_TestVectorSystem;
        private Thread m_SubThread;
        private bool m_SubThread_IsRunning;

        //private int m_DataState_room_index;
        //private int m_DataState_use_index;
        //private int m_DataState_mem_index;
        //private int m_DataLight_index;
        //private int m_DataStnadby1_index;
        //private int m_DataStnadby2_index;
        //private int m_DataAircon_index;
        //private int m_DataHeat_index;

        //private int m_DataSensor1_index;
        //private int m_DataSensor2_index;
        //private int m_DataSensor3_index;
        //private int m_DataSensor4_index;

        //private int m_DataVent_index;





        #endregion
   
        #region Constructor
        public FormMain()
        {
            try
            {
                InitializeComponent();

                this.comboBoxProtocols.SelectedIndex = 0;
                this.comboBoxCommunicationBaudrate.SelectedIndex = 3;

                this.comboBox_WeatherCode.SelectedIndex = 0;
                this.comboBox_Finedust.SelectedIndex = 0;


                this.m_Protocols = new Protocols();
                this.m_TestVectorSystem = new TestVectorSystem();
                this.m_Communication_KS = new Communication_KS();

                this.GetTestVector();
                this.GetProtocol();
                this.GetSerialPorts();

                this.StartFormMainSubThread();
            }
            catch (Exception ex)
            {
                var mb = new MessageBoxOk();
                mb.ShowDialog("FormMain", ex.Message);
            }
        }
        #endregion

        #region Property
        #endregion

        #region Event Handler
        private void Communication_KS_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender == this.buttonCommunicationSearch)
                {
                    if (this.m_Communication_KS.IsConnected)
                    {
                        if (this.m_Communication_KS.OnClose())
                        {
                            this.GetSerialPorts();
                        }
                    }
                    else
                    {
                        this.GetSerialPorts();
                    }
                }
                else if (sender == this.buttonCommunicationConnection)
                {
                    if (this.comboBoxCommunicationComPort.Items.Count > 0)
                    {
                        this.m_Communication_KS.PortName = this.comboBoxCommunicationComPort.Text;
                        this.m_Communication_KS.Baudrate = Convert.ToInt32(this.comboBoxCommunicationBaudrate.Text);
                        if (!this.m_Communication_KS.SetSelectedSerialPortConnect(this.m_Communication_KS.PortName, this.m_Communication_KS.Baudrate))
                        {
                            var mb = new MessageBoxOk();
                            mb.ShowDialog("Communication", "Check To SerialPortConnect");
                        }
                    }
                    else
                    {
                        var mb = new MessageBoxOk();
                        mb.ShowDialog("Communication", "Check To ComPort", 3);

                        return;
                    }
                    timer1.Interval = 1000; // 타이머 간격을 1초로 설정
                    timer1.Start();
                }
                else if (sender == this.buttonCommunicationSend && this.m_Communication_KS.IsConnected)
                {
                    this.Execution_Click(this.buttonMake, e);
                    for (int i = 0; i < this.m_Communication_KS.RepeatCount; i++)
                    {
                        this.OnDataSend(this.textBoxCommunication.Text);
                    }
                }
                else if (sender == this.button_Clear)
                {
                    this.richTextBoxLog.Clear();

                    //this.m_TestVectorSystem.GroupLists.Clear();
                    //this.m_TestVectorSystem.VerLists.Clear();
                }

                this.GetTestVector();
                this.GetProtocol();
            }
            catch (Exception ex)
            {
                var mb = new MessageBoxOk();
                mb.ShowDialog("Communication", ex.Message);
            }
        }
#if false
       static int Button_Status_Req = 0x01;
        static int Button_Batch_On = 0x02;
        static int Button_Batch_Off = 0x03;
        static int Button_Gas_Open = 0x04;
        static int Button_Gas_Close = 0x05;
        static int Button_Gas_Done = 0x06;
        static int Button_Gas_Fail = 0x07;
        static int Button_ELV_Done = 0x08;
        static int Button_ELV_Fail = 0x09;
        static int Button_ELV_Arrived = 0x0A;
        static int Button_Out_Done = 0x0B;
        static int Button_Out_Fail = 0x0C;
        static int Button_Send_Weather = 0x0D;
        static int Button_Send_Time = 0x0E;
        static int Button_Send_Parking = 0x0F;
        static int Button_Send_Notice = 0x10;
#endif

        private void Homenet_Tx_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.m_Communication_KS.IsConnected)
                {
                    int button = 0;
                    if (sender == this.button_StatReq) button = Button_Status_Req;
                    else if (sender == this.button_BatchOn) button = Button_Batch_On;
                    else if (sender == this.button_BatchOff) button = Button_Batch_Off;
                    else if (sender == this.button_GasOpen) button = Button_Gas_Open;
                    else if (sender == this.button_GasClose) button = Button_Gas_Close;
                    else if (sender == this.button_GasDone) button = Button_Gas_Done;
                    else if (sender == this.button_GasFail) button = Button_Gas_Fail;
                    else if (sender == this.button_ElvDone) button = Button_ELV_Done;
                    else if (sender == this.button_ElvFail) button = Button_ELV_Fail;
                    else if (sender == this.button_ElvArrived) button = Button_ELV_Arrived;
                    else if (sender == this.button_SendWeather) button = Button_Send_Weather;
                    else if (sender == this.button_SendTime) button = Button_Send_Time;
                    else if (sender == this.button_SendParking)
                    {
                        button = Button_Send_Parking;

                        string car1_num = textBox_Car1Num.Text;
                        string car1_pos = textBox_Car1Pos.Text;
                        string car2_num = textBox_Car2Num.Text;
                        string car2_pos = textBox_Car2Pos.Text;
                        this.m_Protocols.car1_num_len = car1_num.Length;
                        this.m_Protocols.car1_pos_len = car1_pos.Length;
                        this.m_Protocols.car2_num_len = car2_num.Length;
                        this.m_Protocols.car2_pos_len = car2_pos.Length;

                        if ((car1_num.Length > 0) && (car1_pos.Length > 0) &&
                             (car2_num.Length > 0) && (car2_pos.Length > 0)
                            )
                        {
                            this.m_Protocols.Parking_Count = 2;
                        }
                        else if ((car1_num.Length > 0) && (car1_pos.Length > 0) ||
                                  (car2_num.Length > 0) && (car2_pos.Length > 0)
                                )
                        {
                            this.m_Protocols.Parking_Count = 1;
                        }
                        else
                            this.m_Protocols.Parking_Count = 0;

                        this.m_Protocols.car1_num = car1_num.Select(c => (int)c).ToArray();
                        this.m_Protocols.car1_pos = car1_pos.Select(c => (int)c).ToArray();
                        this.m_Protocols.car2_num = car2_num.Select(c => (int)c).ToArray();
                        this.m_Protocols.car2_pos = car2_pos.Select(c => (int)c).ToArray();

                        label_Parking_num.Text = this.m_Protocols.Parking_Count.ToString();
                    }
                    else if (sender == this.button_SendNotice)
                    {
                        button = Button_Send_Notice;

                        this.m_Protocols.Delivery = this.checkBox_Delivery.Checked;
                        this.m_Protocols.Guest = this.checkBox_Guest.Checked;
                        this.m_Protocols.Notice = this.checkBox_Notice.Checked;
                    }
                    
                    else if (sender == this.button_BypassCtrl)
                    {
                        button = Button_BypassCtrl;
                    }
                    else if (sender == this.button_BypassStat)
                    {
                        button = Button_BypassStat;
                    }

                        this.GetProtocol();

                    this.m_TestVectorSystem.Log = this.m_Protocols.MakeToProtocol(this.m_TestVectorSystem, button);
                    if (this.m_TestVectorSystem.Log == string.Empty || this.m_TestVectorSystem.Log == null || this.m_TestVectorSystem.Log == "")
                    {
                        var emb = new MessageBoxOk();
                        emb.ShowDialog("FormMain", "생성 Data Error", 5);
                        return;
                    }
                    else
                    {
                        this.textBoxCommunication.Text = this.m_Protocols.SendData;
                    }

                    for (int i = 0; i < this.m_Communication_KS.RepeatCount; i++)
                    {
                        this.OnDataSend(this.textBoxCommunication.Text);
                    }
                }
                this.GetTestVector();
            }
            catch (Exception ex)
            {
                var mb = new MessageBoxOk();
                mb.ShowDialog("Communication", ex.Message);
            }
        }
        private void Execution_Click(object sender, EventArgs e)
        {
            try
            {

                if (sender == this.buttonMake)
                {
                    int temp_button_input = 0x01;
                    this.m_TestVectorSystem.Log = this.m_Protocols.MakeToProtocol(this.m_TestVectorSystem, temp_button_input);

                    if (this.m_TestVectorSystem.Log == string.Empty || this.m_TestVectorSystem.Log == null || this.m_TestVectorSystem.Log == "")
                    {
                        var emb = new MessageBoxOk();
                        emb.ShowDialog("FormMain", "생성 Data Error", 5);
                        return;
                    }
                    else
                    {
                        this.textBoxCommunication.Text = this.m_Protocols.SendData;
                    }

                }
                else if (sender == this.buttonRemove)
                {
                    if (this.richTextBoxLog.Lines.Length > 0)
                    {
                        string copyLog = string.Empty;
                        for (int i = 0; i < this.richTextBoxLog.Lines.Length - 2; i++)
                        {
                            copyLog += this.richTextBoxLog.Lines[i] + "\r\n";
                        }
                        this.richTextBoxLog.Clear();
                        this.richTextBoxLog.Text = copyLog;
                        this.richTextBoxLog.SelectionStart = this.richTextBoxLog.Text.Length;
                        this.richTextBoxLog.ScrollToCaret();
                    }
                }
                else if (sender == this.buttonReset)
                {
                    var mb = new MessageBoxYesNo();
                    if (DialogResult.Yes == mb.ShowDialog("FormMain", "생성한 내용을 [초기화] 하시겠습니까?"))
                    {
                        this.richTextBoxLog.Clear();

                        this.m_TestVectorSystem.GroupLists.Clear();
                        this.m_TestVectorSystem.VerLists.Clear();
                    }
                }

                this.GetTestVector();
                this.GetProtocol();
            }
            catch (Exception ex)
            {
                var mb = new MessageBoxOk();
                mb.ShowDialog("FormMain", ex.Message);
            }
        }

        private void Execution_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    this.GetTestVector();
                    this.GetProtocol();
                    this.buttonMake.PerformClick();
                }
                else if (e.KeyData == Keys.Back)
                {
                    this.buttonRemove.PerformClick();
                }
                else if (e.KeyData == Keys.Delete)
                {
                    this.buttonReset.PerformClick();
                }
                else if (e.KeyData == Keys.Space)
                {
                   // this.textBoxTestVectorGroup.Focus();
                }
            }
            catch (Exception ex)
            {
                var mb = new MessageBoxOk();
                mb.ShowDialog("FormMain", ex.Message);
            }
        }
        
        private void TestVectorSystem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.GetTestVector();
                this.GetProtocol();
                //this.SetSwitchUIVisible();
            }
            catch (Exception ex)
            {
                var mb = new MessageBoxOk();
                mb.ShowDialog("FormMain", ex.Message);
            }
        }
        
        private void Protocols_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            try
            {
                //    this.groupBoxCommunication.Location = new Point(1021 + (this.Size.Width - 1170), 9);
                //    this.groupBoxExecution.Location = new Point(1021 + (this.Size.Width - 1170), 250);
            }
            catch (Exception ex)
            {
                var mb = new MessageBoxOk();
                mb.ShowDialog("FormMain", ex.Message);
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                this.StopFormMainSubThread();
            }
            catch (Exception ex)
            {
                var mb = new MessageBoxOk();
                mb.ShowDialog("FormMain", ex.Message, 3);
            }
        }
        #endregion

        #region Method
        private void GetTestVector()
        {
            
        }
      
        private void GetProtocol()
        {
            int result = 0;
            this.textBoxSwitchID.Text = this.ChangeGetProtocolStrToHex(this.textBoxSwitchID.Text, this.m_Protocols.SwitchID, out result);
            this.m_Protocols.SwitchID = result;

            try
            {
                this.m_Protocols.ProtocolName = this.comboBoxProtocols.SelectedItem.ToString();
                this.m_Protocols.ProtocolIndex = this.comboBoxProtocols.SelectedIndex;


                /* 25.06.28 */
                this.m_Protocols.GasOpen = this.checkBoxGasOpen.Checked;
                this.m_Protocols.GasClose = this.checkBoxGasClose.Checked; ;

                this.m_Protocols.WeatherCode = this.comboBox_WeatherCode.SelectedIndex + 1;
                this.m_Protocols.TempPlus = this.checkBox_TempPlus.Checked;
                this.m_Protocols.TempMinus = this.checkBox_TempMinus.Checked;
                this.m_Protocols.TempInt = int.Parse(this.textBox_WeatherTemp.Text);
                this.m_Protocols.Finedust = (int)((this.comboBox_Finedust.SelectedIndex + 1) << 4);

                /* bypass control */
                this.m_Protocols.GoWorkSet = this.checkBoxGoWork_Set.Checked;
                this.m_Protocols.GoWorkReset = this.checkBoxGoWork_Reset.Checked;

                this.m_Protocols.Out = this.checkBoxOut.Checked;
                this.m_Protocols.In = this.checkBoxIn.Checked;

                this.m_Protocols.HeatSet = this.checkBoxHeat_Set.Checked;
                this.m_Protocols.HeatReset = this.checkBoxHeat_Reset.Checked;

                this.m_Protocols.LightOff = this.checkBoxLight_Off.Checked;
                this.m_Protocols.LightOn = this.checkBoxLight_On.Checked;

                this.m_Protocols.Vol0 = this.checkBoxVol_0.Checked;
                this.m_Protocols.Vol1 = this.checkBoxVol_1.Checked;
                this.m_Protocols.Vol2 = this.checkBoxVol_2.Checked;
                this.m_Protocols.Vol3 = this.checkBoxVol_3.Checked;
                this.m_Protocols.Vol_NO = this.checkBoxVol_NO.Checked;
                /* bypass control */

               
                if (int.Parse(this.textBoxCommunicationRepeatCount.Text) < 1)
                {
                    this.textBoxCommunicationRepeatCount.Text = "1";
                }
                this.m_Communication_KS.RepeatCount = Convert.ToInt32(this.textBoxCommunicationRepeatCount.Text, 10);
            }
            catch (Exception ex)
            {

                var mb = new MessageBoxOk();
                mb.ShowDialog("FormMain", ex.Message, 3);
            }
        }
       
        private string ChangeGetProtocolStrToHex(string text, int value, out int result)
        {
            string ret = string.Empty;
            result = value;

            try
            {
                text = text.ToUpper();

                if (text.Length < 2)
                {
                    text = "0" + text;
                }
                else
                {
                    text = text.Substring(text.Length - 2, 2);
                }

                result = Convert.ToInt32(text, 16);
            }
            catch (Exception ex)
            {
                text = value.ToString("X");

                var mb = new MessageBoxOk();
                mb.ShowDialog("FormMain", ex.Message, 3);
            }

            return ret = text;
        }

        private void GetSerialPorts()
        {
            try
            {
                if (this.m_Communication_KS.GetSerialPorts())
                {
                    if (this.m_Communication_KS.ComPortList.Count > 0)
                    {
                        string[] comPortLists = new string[0];

                        for (int i = 0; i < this.m_Communication_KS.ComPortList.Count; i++)
                        {
                            comPortLists = comPortLists.Concat(new string[] { this.m_Communication_KS.ComPortList[i] }).ToArray();
                        }

                        this.comboBoxCommunicationComPort.Items.Clear();
                        this.comboBoxCommunicationComPort.Items.AddRange(comPortLists);
                        this.comboBoxCommunicationComPort.SelectedIndex = 0;
                    }
                    else
                    {
                        var mb = new MessageBoxOk();
                        mb.ShowDialog("Communication", "Check To ComPort", 3);
                    }
                }
                else
                {
                    var mb = new MessageBoxOk();
                    mb.ShowDialog("Communication", "Check To SerialPortConnect");
                }
            }
            catch (Exception ex)
            {
                var mb = new MessageBoxOk();
                mb.ShowDialog("Communication", ex.Message);
            }
        }

        private void StartFormMainSubThread()
        {
            this.m_SubThread_IsRunning = true;
            if (this.m_SubThread == null || !this.m_SubThread.IsAlive)
            {
                this.m_SubThread = new Thread(this.OnFormMainSubThread)
                {
                    IsBackground = true
                };

                this.m_SubThread.Start();
            }
        }
        private void StopFormMainSubThread()
        {
            this.m_SubThread_IsRunning = false;
            if (this.m_SubThread != null && this.m_SubThread.IsAlive)
            {
                this.m_SubThread.Join();
            }
        }
        //added 25.07.13
        private void ParsingReceivedData_UI_Protocol(string data)
        {
            string msg_direction = "()";
            string msg_cmd = "[]";
            string message = "  ";

            int[] packet_buf = data
                .Split(' ')
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .Select(s => Convert.ToInt32(s, 16))
                //.Select(s =>
                //{
                //    bool ok = int.TryParse(s, System.Globalization.NumberStyles.HexNumber, null, out int val);
                //    return ok ? val : -1;  // 실패 시 -1로 처리하거나 예외 던질 수도 있음
                //})
                .ToArray();
            if ((packet_buf[0] == 0xF7) && (packet_buf[1] == 0x33) && (packet_buf[2] == 0x01))
            {
                int cmd = (int)(packet_buf[3] & 0x7F);
                int direction = (int)(packet_buf[3] & 0x80);

                if (direction == 0x80) { msg_direction = "(UI>Main)"; }
                else                   { msg_direction = "(Main>UI)"; }

                //switch (packet_buf[3])
                switch (cmd)
                {
                    case 0x00:  // 
                        msg_cmd = "[사양정보]";

                        message += "/ D0(화면):";
                        if (packet_buf[5] == 0x01) { message += "가스"; }
                        else if (packet_buf[5] == 0x02) { message += "쿡탑"; }
                        break;

                    case 0x71:  // 
                        {
                            msg_cmd = "[UI Input]";
                            int long_touch = packet_buf[6] & 0x10;
                            int touch_input = packet_buf[6] & 0x0F;
                            int voice_input = packet_buf[7];

                            message += "   D0(제어):";
                            if (packet_buf[5] == 0x00) { message += "없음"; }
                            else if (packet_buf[5] == 0x01) { message += "버튼"; }
                            else if (packet_buf[5] == 0x02) { message += "음성"; }

                            message += " / D1(버튼):";
                            if (long_touch == 0x10) { message += "롱터치|"; }
                            else { message += "숏터치|"; }
                            if (touch_input == 0x00) { message += "없음"; }
                            else if (touch_input == 0x02) { message += "일괄"; }
                            else if (touch_input == 0x05) { message += "가스"; }
                            else if (touch_input == 0x06) { message += "엘콜"; }
                            else if (touch_input == 0x07) { message += "외출귀가"; }
                            else if (touch_input == 0x0A) { message += "정보"; }

                            message += " / D2(음성):";
                            if (voice_input == 0x00) { message += "없음"; }
                            else if (voice_input == 0x01) { message += "트리거"; }
                            else if (voice_input == 0x03) { message += "일괄소등"; }
                            else if (voice_input == 0x04) { message += "일괄점등"; }
                            else if (voice_input == 0x05) { message += "가스"; }
                            else if (voice_input == 0x06) { message += "엘콜"; }
                            else if (voice_input == 0x08) { message += "외출"; }
                            else if (voice_input == 0x09) { message += "귀가"; }
                            else if (voice_input == 0x0A) { message += "정보"; }

                            message += " / D3(음량):";
                            if (packet_buf[8] == 0x00) { message += "변경없음"; }
                            else if (packet_buf[8] == 0x01) { message += "음소거"; }
                            else if (packet_buf[8] == 0x02) { message += "소"; }
                            else if (packet_buf[8] == 0x03) { message += "중"; }
                            else if (packet_buf[8] == 0x04) { message += "대"; }

                            message += " / D4(음성인식):";
                            if (packet_buf[9] == 0x00) { message += "변경없음"; }
                            else if (packet_buf[9] == 0x01) { message += "사용"; }
                            else if (packet_buf[9] == 0x02) { message += "미사용"; }

                            message += " / D5(주차삭제):";
                            if (packet_buf[10] == 0x00) { message += "요청없음"; }
                            else if (packet_buf[10] == 0x01) { message += "요청있음"; }
                        }
                        break;
                    case 0x01:  // 
                        {
                            msg_cmd = "[상태전달]";
                            int status_gas = packet_buf[6] & 0x01;
                            int status_light = packet_buf[6] & 0x02;
                            int status_out = packet_buf[6] & 0x04;
                            int status_delivery = packet_buf[6] & 0x08;
                            int volume = packet_buf[7];
                            int voice_mix = packet_buf[8];
                            int voice_code = packet_buf[9];

                            message += "   D0(rsv)";

                            message += " / D1(상태):";
                            if (status_gas == 0x01)     { message += "가스열림"; }
                            else                        { message += "가스차단"; }
                            if (status_light == 0x02)   { message += ",일괄점등"; }
                            else                        { message += ",일괄소등"; }
                            if (status_out == 0x04)     { message += ",귀가"; }
                            else                        { message += ",외출"; }
                            if (status_delivery == 0x08)    { message += ",택배있음"; }
                            else                            { message += ",택배없음"; }

                            message += " / D2(음량):";
                            if(volume==0x00)            { message += "정보없음"; }
                            else if (volume == 0x01)    { message += "음소거"; }
                            else if (volume == 0x02)    { message += "소"; }
                            else if (volume == 0x03)    { message += "중"; }
                            else if (volume == 0x04)    { message += "대"; }

                            message += " / D3(음성모드):";
                            if (voice_mix == 0x00) { message += "없음"; }
                            else if (voice_mix == 0x01) { message += "외출모드"; }
                            else if (voice_mix == 0x02) { message += "귀가모드"; }
                            else if (voice_mix == 0x03) { message += "출근모드"; }
                            else if (voice_mix == 0x04) { message += "정보화면"; }

                            message += " / D4(음성코드):";
                            message += voice_code.ToString();
                        }
                        break;
                    

                    case 0x11:  // 
                        {
                            msg_cmd = "[전체화면]";
                            int voice_mix = packet_buf[6];
                            int voice_code = packet_buf[7];
                            
                            message += "   D0(화면):";
                            if (packet_buf[5] == 0x00) { message += "없음"; }
                            else if (packet_buf[5] == 0x01) { message += "메인화면"; }
                            else if (packet_buf[5] == 0x02) { message += "음성대기화면"; }
                            else if (packet_buf[5] == 0x03) { message += "음량설정화면"; }

                            message += " / D1(음성모드):";
                            if (voice_mix == 0x00) { message += "없음"; }
                            else if (voice_mix == 0x01) { message += "외출모드"; }
                            else if (voice_mix == 0x02) { message += "귀가모드"; }
                            else if (voice_mix == 0x03) { message += "출근모드"; }
                            else if (voice_mix == 0x04) { message += "정보화면"; }

                            message += " / D2(음성코드):";
                            message += voice_code.ToString();
                        }
                        break;
                    case 0x12:  // 
                        {
                            msg_cmd = "[일괄소등화면]";
                            int status_light = packet_buf[5];
                            int voice_mix = packet_buf[6];
                            int voice_code = packet_buf[7];
                            
                            message += "   D0(일괄):";
                            if (status_light == 0x00) { message += "소등"; }
                            else if (status_light == 0x01) { message += "점등"; }
                            else if (status_light == 0x02) { message += "지연소등"; }

                            message += " / D1(음성모드):";
                            if (voice_mix == 0x00) { message += "없음"; }
                            else if (voice_mix == 0x01) { message += "외출모드"; }
                            else if (voice_mix == 0x02) { message += "귀가모드"; }
                            else if (voice_mix == 0x03) { message += "출근모드"; }
                            else if (voice_mix == 0x04) { message += "정보화면"; }

                            message += " / D2(음성코드):";
                            message += voice_code.ToString();
                        }
                        break;
                    case 0x13:  // 
                        {
                            msg_cmd = "[가스차단화면]";
                            int status_gas = packet_buf[5];
                            int voice_mix = packet_buf[6];
                            int voice_code = packet_buf[7];

                            message += "   D0(가스):";
                            if (status_gas == 0x00) { message += "설정중"; }
                            else if (status_gas == 0x01) { message += "설정완료"; }
                            else if (status_gas == 0x02) { message += "설정실패"; }
                            else if (status_gas == 0x03) { message += "차단"; }
                            else if (status_gas == 0x04) { message += "열림"; }

                            message += " / D1(음성모드):";
                            if (voice_mix == 0x00) { message += "없음"; }
                            else if (voice_mix == 0x01) { message += "외출모드"; }
                            else if (voice_mix == 0x02) { message += "귀가모드"; }
                            else if (voice_mix == 0x03) { message += "출근모드"; }
                            else if (voice_mix == 0x04) { message += "정보화면"; }

                            message += " / D2(음성코드):";
                            message += voice_code.ToString();
                        }
                        break;
                    case 0x14:  // 
                        {
                            msg_cmd = "[엘콜화면]";

                            int status_elv = packet_buf[5];
                            int voice_mix = packet_buf[6];
                            int voice_code = packet_buf[7];

                            message += "   D0(엘콜):";
                            if (status_elv == 0x00) { message += "호출중"; }
                            else if (status_elv == 0x01) { message += "완료"; }
                            else if (status_elv == 0x02) { message += "실패"; }
                            else if (status_elv == 0x03) { message += "도착"; }

                            message += " / D1(음성모드):";
                            if (voice_mix == 0x00) { message += "없음"; }
                            else if (voice_mix == 0x01) { message += "외출모드"; }
                            else if (voice_mix == 0x02) { message += "귀가모드"; }
                            else if (voice_mix == 0x03) { message += "출근모드"; }
                            else if (voice_mix == 0x04) { message += "정보화면"; }

                            message += " / D2(음성코드):";
                            message += voice_code.ToString();
                        }
                        break;
                    case 0x15:  // 
                        msg_cmd = "[복도등화면 - 사용안함]";
                        break;
                    case 0x16:  // 
                        msg_cmd = "[방범화면 - 사용안함]";
                        break;
                    case 0x17:  // 
                        {
                            msg_cmd = "[외출화면]";

                            int status_out = packet_buf[5];
                            int icon_delivery = packet_buf[6] & 0x01;
                            int icon_parking = packet_buf[6] & 0x02;
                            int icon_elv = packet_buf[6] & 0x04;
                            int icon_gas = packet_buf[6] & 0x08;
                            int icon_light = packet_buf[6] & 0x10;

                            int status_AI_Heat = packet_buf[7];
                            int status_gas = packet_buf[8];
                            int status_parking = packet_buf[9];
                            int status_elv = packet_buf[10];
                            int voice_mix = packet_buf[11];
                            int voice_code = packet_buf[12];

                            message += "   D0(외출):";
                            if(status_out == 0x00) { message += "설정중"; }
                            else if (status_out == 0x01) { message += "설정성공"; }
                            else if (status_out == 0x02) { message += "설정실패"; }

                            message += " / D1(아이콘):";
                            if (icon_delivery == 0x01)  { message += "택배있음"; }
                            else                        { message += "택배없음"; }
                            if (icon_parking == 0x02)   { message += ",주차있음"; }
                            else                        { message += ",주차없음"; }
                            if (icon_elv == 0x04)       { message += ",엘콜있음"; }
                            else                        { message += ",엘콜없음"; }
                            if (icon_gas == 0x08)       { message += ",가스차단 활성"; }
                            else                        { message += ",가스차단 비활성"; }
                            if (icon_light == 0x10)     { message += ",일괄 활성"; }
                            else                        { message += ",일괄 비활성"; }


                            message += " / D2(인공지능난방):";
                            if (status_AI_Heat == 0x00) { message += "해당없음"; }
                            else if (status_AI_Heat == 0x01) { message += "사용"; }
                            
                            message += " / D3(가스):";
                            if (status_gas == 0x00) { message += "설정중"; }
                            else if (status_gas == 0x01) { message += "설정완료"; }
                            else if (status_gas == 0x02) { message += "설정실패"; }
                            else if (status_gas == 0x03) { message += "차단"; }
                            else if (status_gas == 0x04) { message += "열림"; }

                            message += " / D4(주차):";
                            if (status_parking == 0x00) { message += "정보없음"; }
                            else if (status_parking == 0x01) { message += "정보있음"; }

                            message += " / D5(엘콜):";
                            if (status_elv == 0x00) { message += "호출중"; }
                            else if (status_elv == 0x01) { message += "호출완료"; }
                            else if (status_elv == 0x02) { message += "호출실패"; }
                            else if (status_elv == 0x03) { message += "도착"; }

                            message += " / D6(음성모드):";
                            if (voice_mix == 0x00) { message += "없음"; }
                            else if (voice_mix == 0x01) { message += "외출모드"; }
                            else if (voice_mix == 0x02) { message += "귀가모드"; }
                            else if (voice_mix == 0x03) { message += "출근모드"; }
                            else if (voice_mix == 0x04) { message += "정보화면"; }

                            message += " / D7(음성코드):";
                            message += voice_code.ToString();
                        }
                        break;
                    case 0x18:  // 
                        {
                            msg_cmd = "[귀가화면]";

                            int icon_notice = packet_buf[5] & 0x01;
                            int icon_parking = packet_buf[5] & 0x02;
                            int icon_delivery = packet_buf[5] & 0x04;
                            int icon_guest = packet_buf[5] & 0x08;
                            int icon_light = packet_buf[5] & 0x10;
                            int status_AI_Heat = packet_buf[6];
                            int number_notice = packet_buf[7];
                            int status_delivery = packet_buf[8];
                            int number_guest = packet_buf[9];

                            int voice_mix = packet_buf[10];
                            int voice_code = packet_buf[11];

                            message += "   D0(아이콘):";
                            if (icon_notice == 0x01)    { message += "공지있음"; }
                            else                        { message += "공지없음"; }
                            if (icon_parking == 0x02)   { message += ",주차있음"; }
                            else                        { message += ",주차없음"; }
                            if (icon_delivery == 0x04)  { message += ",택배있음"; }
                            else                        { message += ",택베없음"; }
                            if (icon_guest == 0x08)     { message += ",방문자 있음"; }
                            else                        { message += ",방문자 없음"; }
                            if (icon_light == 0x10)     { message += ",일괄 활성"; }
                            else                        { message += ",일괄 비활성"; }

                            message += " / D1(인공지능난방):";
                            if (status_AI_Heat == 0x00) { message += "해당없음"; }
                            else if (status_AI_Heat == 0x01) { message += "사용"; }

                            message += " / D2(공지사항):";
                            message += number_notice.ToString();
                            message += "건";

                            message += " / D3(택배):";
                            if(status_delivery==0x00)   { message += "없음"; }
                            else                        { message += "있음"; }

                            message += " / D4(방문자):";
                            message += number_guest.ToString();
                            message += "명";

                            message += " / D5(음성모드):";
                            if (voice_mix == 0x00) { message += "없음"; }
                            else if (voice_mix == 0x01) { message += "외출모드"; }
                            else if (voice_mix == 0x02) { message += "귀가모드"; }
                            else if (voice_mix == 0x03) { message += "출근모드"; }
                            else if (voice_mix == 0x04) { message += "정보화면"; }

                            message += " / D6(음성코드):";
                            message += voice_code.ToString();
                        }
                        break;
                    case 0x19:  // 
                        {
                            msg_cmd = "[출근/정보화면]";
                            int status_delivery = packet_buf[5];
                            int status_parking = packet_buf[6];
                            int voice_mix = packet_buf[7];
                            int voice_code = packet_buf[8];

                            message += "   D0(택배):";
                            if (status_delivery == 0x00) { message += "없음"; }
                            else if (status_delivery == 0x01) { message += "있음"; }

                            message += " / D1(주차):";
                            if (status_parking == 0x00) { message += "없음"; }
                            else if (status_parking == 0x01) { message += "있음"; }

                            message += " / D2(음성모드):";
                            if (voice_mix == 0x00) { message += "없음"; }
                            else if (voice_mix == 0x01) { message += "외출모드"; }
                            else if (voice_mix == 0x02) { message += "귀가모드"; }
                            else if (voice_mix == 0x03) { message += "출근모드"; }
                            else if (voice_mix == 0x04) { message += "정보화면"; }

                            message += " / D3(음성코드):";
                            message += voice_code.ToString();
                        }
                        break;
                    case 0x1A:  // 출근/정보화면으로 합침
                        msg_cmd = "[정보화면 - 사용안함]";
                        break;
                    case 0x1B:  // 
                        msg_cmd = "[LCD백라이트]";

                        message += "   D0(백라이트):";
                        if (packet_buf[5] == 0x00) { message += "꺼짐"; }
                        else if (packet_buf[5] == 0x01) { message += "FADE_OUT"; }
                        else if (packet_buf[5] == 0x02) { message += "어두움"; }
                        else if (packet_buf[5] == 0x03) { message += "켜짐"; }
                        break;

                    case 0x44:  // 
                        msg_cmd = "[날씨정보]";
                        break;
                    case 0x45:  // 
                        msg_cmd = "[시간정보]";
                        break;
                    case 0x47:  // 
                        msg_cmd = "[주차정보]";
                        break;
                    case 0x50:  // 
                        {
                            msg_cmd = "[택배/방문자/공지사항]";

                            int status_delivery = packet_buf[5] & 0x01;
                            int number_guest = packet_buf[6];
                            int number_notice = packet_buf[7];                            
                            
                            message += "   D0(택배):";
                            if (status_delivery == 0x00) { message += "없음"; }
                            else { message += "있음"; }

                            message += " / D1(방문자):";
                            message += number_guest.ToString();
                            message += "명";

                            message += " / D2(공지사항):";
                            message += number_notice.ToString();
                            message += "건";
                        }
                        break;
                    default:
                        msg_cmd = "[CMD 오류]";
                        break;
                }
                this.richTextBoxLog.Invoke(new Action(() => this.richTextBoxLog.AppendText(msg_direction )));
                this.richTextBoxLog.Invoke(new Action(() => this.richTextBoxLog.SelectionColor = Color.Red));
                this.richTextBoxLog.Invoke(new Action(() => this.richTextBoxLog.AppendText(msg_cmd)));
                this.richTextBoxLog.Invoke(new Action(() => this.richTextBoxLog.SelectionColor = Color.White));
                this.richTextBoxLog.Invoke(new Action(() => this.richTextBoxLog.AppendText(message + "\r\n\n")));
                this.richTextBoxLog.Invoke(new Action(() => this.richTextBoxLog.ScrollToCaret()));
            }
        }
        // added 25.04.24 
        private void ParsingReceivedData(string data)
        {
            int[] packet_buf = data
                .Split(' ')
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .Select(s => Convert.ToInt32(s, 16))
                //.Select(s =>
                //{
                //    bool ok = int.TryParse(s, System.Globalization.NumberStyles.HexNumber, null, out int val);
                //    return ok ? val : -1;  // 실패 시 -1로 처리하거나 예외 던질 수도 있음
                //})
                .ToArray();

            /* Message Box Show */
            //string str = packet_buf[0].ToString("X2") + packet_buf[1].ToString("X2") + packet_buf[2].ToString("X2");
            //MessageBox.Show(str);

            /* parsing */
            //if ((packet_buf[0] == 0xF7) && (packet_buf[1] == 0x40) && (packet_buf[2] == 0x11))
            if ((packet_buf[0] == 0xF7) && (packet_buf[1] == 0x33) && (packet_buf[2] == 0x01))
            {
                // command
                switch (packet_buf[3])
                {
                    case 0x8F:// Char
                        if (packet_buf[4] == 0x03)
                        {
                            if ((packet_buf[6] & 0x01) == 0x01)
                            {
                                //checkBoxChar_Heat.Checked = true;
                                //checkBoxChar_Heat.Invoke(new Action(() => { checkBoxChar_Heat.Checked = true; }));
                            }
                            else
                            {
                                //checkBoxChar_Heat.Checked = false;
                                //checkBoxChar_Heat.Invoke(new Action(() => { checkBoxChar_Heat.Checked = false; }));
                            }

                            if ((packet_buf[6] & 0x02) == 0x02)
                            {
                                //checkBoxChar_Aircon.Checked = true; 
                                //checkBoxChar_Aircon.Invoke(new Action(() => { checkBoxChar_Aircon.Checked = true; }));
                            }
                            else
                            {
                                //checkBoxChar_Aircon.Checked = false; 
                                //checkBoxChar_Aircon.Invoke(new Action(() => { checkBoxChar_Aircon.Checked = false; }));
                            }

                            if ((packet_buf[6] & 0x04) == 0x04)
                            {
                                //checkBoxChar_Vent.Checked = true; 
                                // checkBoxChar_Vent.Invoke(new Action(() => { checkBoxChar_Vent.Checked = true; }));
                            }

                            else
                            {
                                //checkBoxChar_Vent.Checked = false; 
                                //checkBoxChar_Vent.Invoke(new Action(() => { checkBoxChar_Vent.Checked = false; }));
                            }

                            if ((packet_buf[6] & 0x10) == 0x10)
                            {
                                //checkBoxChar_Standby.Checked = true; 
                                //checkBoxChar_Standby.Invoke(new Action(() => { checkBoxChar_Standby.Checked = true; }));
                            }
                            else
                            {
                                //checkBoxChar_Standby.Checked = false; 
                                //checkBoxChar_Standby.Invoke(new Action(() => { checkBoxChar_Standby.Checked = false; }));
                            }

                            if ((packet_buf[6] & 0x20) == 0x20)
                            {
                                //checkBoxChar_Light.Checked = true; 
                                //checkBoxChar_Light.Invoke(new Action(() => { checkBoxChar_Light.Checked = true; }));
                            }
                            else
                            {
                                //checkBoxChar_Light.Checked = false; 
                                //checkBoxChar_Light.Invoke(new Action(() => { checkBoxChar_Light.Checked = false; }));
                            }

                            if ((packet_buf[7]) == 0x01)
                            {
                                //textBoxChar_Sensor.Invoke(new Action(() => { textBoxChar_Sensor.Text = "지원함"; }));
                            }
                            else if ((packet_buf[7]) == 0x00)
                            {
                                //textBoxChar_Sensor.Invoke(new Action(() => { textBoxChar_Sensor.Text = "지원안함"; }));
                            }
                        }
                        break;
                    case 0x81:// status
                    case 0xC1:// Control
                    case 0xD1:// Bypass Control
                              //case 0xC2:// Standby AI SET
                              //case 0xC3:// heat,aircon AI SET
                              //case 0xC4:// sensor SET
                              //case 0xC5:// vent AI SET
                        if (packet_buf[4] == 0x03)
                        {
                            if ((packet_buf[5] & 0x80) == 0x80)
                            {
                                checkBox_BypassON.Invoke(new Action(() => { checkBox_BypassON.Text = "있음"; }));
                                checkBox_BypassON.Invoke(new Action(() => { checkBox_BypassON.BackColor = SystemColors.MenuHighlight; }));
                                button_BypassStat.Invoke(new Action(() => { button_BypassStat.BackColor = SystemColors.MenuHighlight; }));
                            }
                            else
                            {
                                checkBox_BypassON.Invoke(new Action(() => { checkBox_BypassON.Text = "없음"; }));
                                checkBox_BypassON.Invoke(new Action(() => { checkBox_BypassON.BackColor = SystemColors.Control; }));
                                button_BypassStat.Invoke(new Action(() => { button_BypassStat.BackColor = SystemColors.Control; }));
                            }

                            if ((packet_buf[6] & 0x01) == 0x01)
                            {
                                checkBox_GasCloseReq.Invoke(new Action(() => { checkBox_GasCloseReq.Text = "있음"; }));
                                checkBox_GasCloseReq.Invoke(new Action(() => { checkBox_GasCloseReq.BackColor = SystemColors.MenuHighlight; }));
                            }
                            else
                            {
                                checkBox_GasCloseReq.Invoke(new Action(() => { checkBox_GasCloseReq.Text = "없음"; }));
                                checkBox_GasCloseReq.Invoke(new Action(() => { checkBox_GasCloseReq.BackColor = SystemColors.Control; }));
                            }

                            if ((packet_buf[6] & 0x04) == 0x04)
                            {
                                checkBox_BatchStatus.Invoke(new Action(() => { checkBox_BatchStatus.Text = "점등"; }));
                            }
                            else
                            {
                                checkBox_BatchStatus.Invoke(new Action(() => { checkBox_BatchStatus.Text = "소등"; }));
                            }

                            if ((packet_buf[6] & 0x20) == 0x20)
                            {
                                checkBox_ElvCallReq.Invoke(new Action(() => { checkBox_ElvCallReq.Text = "있음"; }));
                                checkBox_ElvCallReq.Invoke(new Action(() => { checkBox_ElvCallReq.BackColor = SystemColors.MenuHighlight; }));
                            }
                            else
                            {
                                checkBox_ElvCallReq.Invoke(new Action(() => { checkBox_ElvCallReq.Text = "없음"; }));
                                checkBox_ElvCallReq.Invoke(new Action(() => { checkBox_ElvCallReq.BackColor = SystemColors.Control; }));
                            }
                        }

                        break;
                    case 0xC9:// Bypass Status
                        if (packet_buf[4] == 0x09)  // length
                        {
                            // packet_buf[5] // reserved
                            int data_type = packet_buf[6] & 0x03;
                            // packet_buf[7], [8] // reserved
                            label_DataType.Invoke(new Action(() => { label_DataType.Text = data_type.ToString(); }));

                            if ((packet_buf[9] & 0x01) == 0x01)
                            {
                                // out mode
                                label_InOut.Invoke(new Action(() => { label_InOut.Text = "외출"; }));
                                checkBoxOut.Invoke(new Action(() => { checkBoxOut.Checked = true; ; }));
                                checkBoxIn.Invoke(new Action(() => { checkBoxIn.Checked = false; ; }));
                            }
                            else
                            {
                                // in mode
                                label_InOut.Invoke(new Action(() => { label_InOut.Text = "귀가"; }));
                                checkBoxOut.Invoke(new Action(() => { checkBoxOut.Checked = false; ; }));
                                checkBoxIn.Invoke(new Action(() => { checkBoxIn.Checked = true; ; }));
                            }

                            if ((packet_buf[9] & 0x02) == 0x02)
                            {
                                // ai_heat_operation
                                label_AiHeat.Invoke(new Action(() => { label_AiHeat.Text = "동작중"; }));
                                checkBoxHeat_Set.Invoke(new Action(() => { checkBoxHeat_Set.Checked = true; }));
                                checkBoxHeat_Reset.Invoke(new Action(() => { checkBoxHeat_Reset.Checked = false; }));
                            }
                            else
                            {
                                // ai_heat_Not_operation
                                label_AiHeat.Invoke(new Action(() => { label_AiHeat.Text = "동작안함"; }));
                                checkBoxHeat_Set.Invoke(new Action(() => { checkBoxHeat_Set.Checked = false; }));
                                checkBoxHeat_Reset.Invoke(new Action(() => { checkBoxHeat_Reset.Checked = true; }));
                            }

                            //if (packet_buf[10] == 0x01)
                            if (packet_buf[10] == BATCH_OFF)
                            {
                                // batch off
                                label_batch.Invoke(new Action(() => { label_batch.Text = "소등"; }));
                                checkBoxLight_Off.Invoke(new Action(() => { checkBoxLight_Off.Checked = true; }));
                                checkBoxLight_On.Invoke(new Action(() => { checkBoxLight_On.Checked = false; }));
                            }
                            //else if (packet_buf[10] == 0x00) 
                            else if (packet_buf[10] == BATCH_ON)
                            {
                                // batch on
                                label_batch.Invoke(new Action(() => { label_batch.Text = "점등"; }));
                                checkBoxLight_Off.Invoke(new Action(() => { checkBoxLight_Off.Checked = false; }));
                                checkBoxLight_On.Invoke(new Action(() => { checkBoxLight_On.Checked = true; }));
                            }

                            //if (packet_buf[11] == 0x01)
                            if (packet_buf[11] == GAS_CLOSE)
                            {
                                // gas close
                                label_gas.Invoke(new Action(() => { label_gas.Text = "차단"; }));
                            }
                            //else if (packet_buf[11] == 0x00)
                            else if (packet_buf[11] == GAS_OPEN)
                            {
                                // gas open
                                label_gas.Invoke(new Action(() => { label_gas.Text = "열림"; }));
                            }

                            if (packet_buf[12] == 0x01)
                            {
                                // elevator call
                                label_elv.Invoke(new Action(() => { label_elv.Text = "호출중"; }));
                                //label_elv.Text = "호출중";
                            }
                            else if (packet_buf[12] == 0x00)
                            {
                                // elevator Not call
                                label_elv.Invoke(new Action(() => { label_elv.Text = "호출없음"; }));
                                //label_elv.Text = "호출없음";
                            }

                            if ( (packet_buf[13] & 0x01) == 0x01)
                            {
                                // volume off
                                label_volume.Invoke(new Action(() => { label_volume.Text = "음소거"; }));
                                //label_volume.Text = "음소거";
                                checkBoxVol_0.Invoke(new Action(() => { checkBoxVol_0.Checked = true; }));
                                checkBoxVol_1.Invoke(new Action(() => { checkBoxVol_1.Checked = false; }));
                                checkBoxVol_2.Invoke(new Action(() => { checkBoxVol_2.Checked = false; }));
                                checkBoxVol_3.Invoke(new Action(() => { checkBoxVol_3.Checked = false; }));
                                checkBoxVol_NO.Invoke(new Action(() => { checkBoxVol_NO.Checked = false; }));
                            }
                            else if ((packet_buf[13] & 0x02) == 0x02)
                            {
                                // volume 1
                                label_volume.Invoke(new Action(() => { label_volume.Text = "소"; }));
                                //label_volume.Text = "소";
                                checkBoxVol_0.Invoke(new Action(() => { checkBoxVol_0.Checked = false; }));
                                checkBoxVol_1.Invoke(new Action(() => { checkBoxVol_1.Checked = true; }));
                                checkBoxVol_2.Invoke(new Action(() => { checkBoxVol_2.Checked = false; }));
                                checkBoxVol_3.Invoke(new Action(() => { checkBoxVol_3.Checked = false; }));
                                checkBoxVol_NO.Invoke(new Action(() => { checkBoxVol_NO.Checked = false; }));
                            }
                            else if ((packet_buf[13] & 0x04) == 0x04)
                            {
                                // volume 2
                                label_volume.Invoke(new Action(() => { label_volume.Text = "중"; }));
                                //label_volume.Text = "중";
                                checkBoxVol_0.Invoke(new Action(() => { checkBoxVol_0.Checked = false; }));
                                checkBoxVol_1.Invoke(new Action(() => { checkBoxVol_1.Checked = false; }));
                                checkBoxVol_2.Invoke(new Action(() => { checkBoxVol_2.Checked = true; }));
                                checkBoxVol_3.Invoke(new Action(() => { checkBoxVol_3.Checked = false; }));
                                checkBoxVol_NO.Invoke(new Action(() => { checkBoxVol_NO.Checked = false; }));
                            }
                            else if ((packet_buf[13] & 0x08) == 0x08)
                            {
                                // volume 3
                                label_volume.Invoke(new Action(() => { label_volume.Text = "대"; }));
                                //label_volume.Text = "대";
                                checkBoxVol_0.Invoke(new Action(() => { checkBoxVol_0.Checked = false; }));
                                checkBoxVol_1.Invoke(new Action(() => { checkBoxVol_1.Checked = false; }));
                                checkBoxVol_2.Invoke(new Action(() => { checkBoxVol_2.Checked = false; }));
                                checkBoxVol_3.Invoke(new Action(() => { checkBoxVol_3.Checked = true; }));
                                checkBoxVol_NO.Invoke(new Action(() => { checkBoxVol_NO.Checked = false; }));
                            }
                            else if ((packet_buf[13] & 0x10) == 0x10)
                            {
                                // No function
                                label_volume.Invoke(new Action(() => { label_volume.Text = "기능없음"; }));
                                //label_volume.Text = "기능없음";
                                checkBoxVol_0.Invoke(new Action(() => { checkBoxVol_0.Checked = false; }));
                                checkBoxVol_1.Invoke(new Action(() => { checkBoxVol_1.Checked = false; }));
                                checkBoxVol_2.Invoke(new Action(() => { checkBoxVol_2.Checked = false; }));
                                checkBoxVol_3.Invoke(new Action(() => { checkBoxVol_3.Checked = false; }));
                                checkBoxVol_NO.Invoke(new Action(() => { checkBoxVol_NO.Checked = true; }));
                            }
                        }
                        break;


                    default: break;
                }


                // length
                // data
                // xor
                // add
            }

        }
        private void OnFormMainSubThread()
        {
            try
            {
                while (this.m_SubThread_IsRunning)
                {
                    #region UI
                    if (this.m_Communication_KS.IsConnected)
                    {
                        this.buttonCommunicationConnection.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        this.buttonCommunicationConnection.BackColor = Color.Red;
                    }
                    #endregion

                    if (this.m_Communication_KS.IsReceivedData)
                    {
                        if (this.richTextBoxLog.InvokeRequired)
                        {
                            Task.Delay(30).Wait();

                            this.richTextBoxLog.Invoke(new Action(() => this.richTextBoxLog.AppendText(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff") + " R< : " + this.m_Communication_KS.ReceiveData + "\r\n")));
                            this.richTextBoxLog.Invoke(new Action(() => this.richTextBoxLog.ScrollToCaret()));

                            //ParsingReceivedData(m_Communication_KS.ReceiveData);    // added 25.04.24
                            ParsingReceivedData_UI_Protocol(m_Communication_KS.ReceiveData);    // added 25.07.13
                            this.m_Communication_KS.ReceiveData = string.Empty;

                        }

                        this.m_Communication_KS.IsReceivedData = false;
                    }
                }
            }
            catch (Exception ex)
            {
                var mb = new MessageBoxOk();
                mb.ShowDialog("FormMain", ex.Message, 3);
            }
        }



        private void OnDataSend(string data)
        {
            try
            {
                if (this.m_Communication_KS.OnDataSend(data, this.checkBoxCommunicationHex.Checked))
                {
                    this.richTextBoxLog.AppendText(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff") + " S> : " + data + "\r\n");
                    this.richTextBoxLog.ScrollToCaret();
                }
                else
                {
                    this.richTextBoxLog.AppendText(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff") + " S(FAIL)> : " + data + "\r\n");
                    this.richTextBoxLog.ScrollToCaret();
                }
            }
            catch (Exception ex)
            {
                var mb = new MessageBoxOk();
                mb.ShowDialog("FormMain", ex.Message, 3);
            }
        }
        /*
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        */
        private void Gas_Status_Click(object sender, EventArgs e)
        {
            if (sender == this.checkBoxGasOpen)
            {
                this.checkBoxGasClose.Checked = false;
                this.checkBoxGasOpen.Checked = true;
            }
            else if (sender == this.checkBoxGasClose)
            {
                this.checkBoxGasOpen.Checked = false;
                this.checkBoxGasClose.Checked = true;
            }
        }
        private void Temp_Sign_Click(object sender, EventArgs e)
        {
            if (sender == this.checkBox_TempPlus)
            {
                this.checkBox_TempMinus.Checked = false;
                this.checkBox_TempPlus.Checked = true;
            }
            else if (sender == this.checkBox_TempMinus)
            {
                this.checkBox_TempPlus.Checked = false;
                this.checkBox_TempMinus.Checked = true;
            }
        }
        private void checkBoxGasOpen_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void Timer1_1s_Tick(object sender, EventArgs e)
        {
            //test_timer_second++;
            //if (test_timer_second >= 60) test_timer_second = 0;

            this.m_Protocols.TimeYear = (DateTime.Now.Year % 100);
            this.m_Protocols.TimeMonth = DateTime.Now.Month;
            this.m_Protocols.TimeDay = DateTime.Now.Day;
            this.m_Protocols.TimeHour = DateTime.Now.Hour;
            this.m_Protocols.TimeMunite = DateTime.Now.Minute;
            this.m_Protocols.TimeSecond = DateTime.Now.Second;

            textBox_Year.Text = this.m_Protocols.TimeYear.ToString();
            textBox_Month.Text = this.m_Protocols.TimeMonth.ToString();
            textBox_Day.Text = this.m_Protocols.TimeDay.ToString();
            textBox_Hour.Text = this.m_Protocols.TimeHour.ToString();
            textBox_Minute.Text = this.m_Protocols.TimeMunite.ToString();
            textBox_Second.Text = this.m_Protocols.TimeSecond.ToString();
            //textBox_Second.Text = test_timer_second.ToString();

        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void GoWork_Status_Click(object sender, EventArgs e)
        {

        }
        /*
        private void InOut_Status_Click(object sender, EventArgs e)
        {

        }

        private void Heat_Status_Click(object sender, EventArgs e)
        {

        }
        */
        private void Bypass_CheckBox_Click(object sender, EventArgs e)
        {
            /* example */
            if (sender == this.checkBox_TempPlus)
            {
                this.checkBox_TempMinus.Checked = false;
                this.checkBox_TempPlus.Checked = true;
            }
            else if (sender == this.checkBox_TempMinus)
            {
                this.checkBox_TempPlus.Checked = false;
                this.checkBox_TempMinus.Checked = true;
            }
            /* example */


            if (sender == this.checkBoxGoWork_Set)
            {
                this.checkBoxGoWork_Reset.Checked = false;
                this.checkBoxGoWork_Set.Checked = true;
            }
            else if (sender == this.checkBoxGoWork_Reset)
            {
                this.checkBoxGoWork_Set.Checked = false;
                this.checkBoxGoWork_Reset.Checked = true;
            }

            if (sender == this.checkBoxOut)
            {
                this.checkBoxIn.Checked = false;
                this.checkBoxOut.Checked = true;
            }
            else if (sender == this.checkBoxIn)
            {
                this.checkBoxOut.Checked = false;
                this.checkBoxIn.Checked = true;
            }

            if (sender == this.checkBoxHeat_Set)
            {
                this.checkBoxHeat_Reset.Checked = false;
                this.checkBoxHeat_Set.Checked = true;
            }
            else if (sender == this.checkBoxHeat_Reset)
            {
                this.checkBoxHeat_Set.Checked = false;
                this.checkBoxHeat_Reset.Checked = true;
            }

            if (sender == this.checkBoxLight_Off)
            {
                this.checkBoxLight_On.Checked = false;
                this.checkBoxLight_Off.Checked = true;
            }
            else if (sender == this.checkBoxLight_On)
            {
                this.checkBoxLight_Off.Checked = false;
                this.checkBoxLight_On.Checked = true;
            }

            //this.checkBoxVol_0.Checked = false;
            //this.checkBoxVol_1.Checked = false;
            //this.checkBoxVol_2.Checked = false;
            //this.checkBoxVol_3.Checked = false;
            if (sender == this.checkBoxVol_0)
            {
                this.checkBoxVol_1.Checked = false;
                this.checkBoxVol_2.Checked = false;
                this.checkBoxVol_3.Checked = false;
                this.checkBoxVol_NO.Checked = false;

                this.checkBoxVol_0.Checked = true;
            }
            else if (sender == this.checkBoxVol_1)
            {
                this.checkBoxVol_0.Checked = false;
                this.checkBoxVol_2.Checked = false;
                this.checkBoxVol_3.Checked = false;
                this.checkBoxVol_NO.Checked = false;

                this.checkBoxVol_1.Checked = true;
            }
            else if (sender == this.checkBoxVol_2)
            {
                this.checkBoxVol_0.Checked = false;
                this.checkBoxVol_1.Checked = false;
                this.checkBoxVol_3.Checked = false;
                this.checkBoxVol_NO.Checked = false;

                this.checkBoxVol_2.Checked = true;
            }
            else if (sender == this.checkBoxVol_3)
            {
                this.checkBoxVol_0.Checked = false;
                this.checkBoxVol_1.Checked = false;
                this.checkBoxVol_2.Checked = false;
                this.checkBoxVol_NO.Checked = false;

                this.checkBoxVol_3.Checked = true;
            }
            else if (sender == this.checkBoxVol_NO)
            {
                this.checkBoxVol_0.Checked = false;
                this.checkBoxVol_1.Checked = false;
                this.checkBoxVol_2.Checked = false;
                this.checkBoxVol_3.Checked = false;

                this.checkBoxVol_NO.Checked = true;
            }
        }



        #endregion

        #region Members
        #endregion

    }
}
