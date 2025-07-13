using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#if false
<PROTOCOL - KS : AI 인공지능>
* DEVICE ID : 0x40

* CMD
- 특성요구 : 0x0F   
- 상태요구 : 0x01
- 조명 자동설정 제어 : 0x41
- 콘센트 자동설정 제어 : 0x42
- AI 인공지능 설정 제어 : 0x43
- 재실센서 제어 : 0x44

* 데이터 프레임
(1-1) 특성요구 / length 0
(1-2) 특성요구 응답 / length 3
  - DATA0 : error byte
  - DATA1 : AI 지원기능
    - bit7 :reserved
    - bit6 :reserved
    - bit5 : 조명 자동설정 (0:미지원 / 1:지원)
    - bit4 : 콘센트 자동설정 (0:미지원 / 1:지원)
    - bit3 :reserved
    - bit2 : 환기 AI 설정 (0:미지원 / 1:지원)
    - bit1 : 냉방 AI 설정 (0:미지원 / 1:지원)
    - bit0 : 난방 AI 설정 (0:미지원 / 1:지원)
  - DATA2 : 재실센서 지원 (0x00 지원안함 / 0x01 지원함)
(2-1) 상태요구 / length 4
  - DATA0 : error byte
  - DATA1 : 재실 여부 (0x00 해당 없음 / 0x01 : 재실 / 0x02 : 비재실)
  - DATA2 : AI 기능 사용 요구 (0x00 평상시 / 0x01 AI 사용 요구)
    --> 인공지능사용하세요 표시
  - DATA3 : 회원가입 여부 (0x00 회원가입정보없음 / 0x01 회원가입 / 0x02 미가입)
(2-2) 상태응답 / length 0x0B(11)
  - DATA0 : error byte
  - DATA1 : 재실감지 sensor DATA1 (sensor TIME sum)
  - DATA2 : 재실감지 sensor DATA2 (sensor falling 횟수)
  - DATA3 : 조명 자동 설정 상태 (0x00 자동해제 / 0x01 자동설정)
  - DATA4 : 콘센트 자동 설정 상태
    - bit4~7 : reserved
    - bit3 : 콘센트4 자동설정 (0:해제 / 1:설정)
    - bit2 : 콘센트3 자동설정 (0:해제 / 1:설정)
    - bit1 : 콘센트2 자동설정 (0:해제 / 1:설정)
    - bit0 : 콘센트1 자동설정 (0:해제 / 1:설정)
  - DATA5 : AI 인공지능 설정 상태 (난방/냉방/환기)
    - bit3~7 : reserved
    - bit2 : 환기 AI 설정 상태 (0:해제 / 1:설정) 
    - bit1 : 냉방 AI 설정 상태 (0:해제 / 1:설정) 
    - bit0 : 난방 AI 설정 상태 (0:해제 / 1:설정)
  - DATA6 : 재실센서 상태
    - bit4~7 : 스위치 보정 적용 단계 (0:해당없음 / 1~5:민감하게 / 6:보정없음 / 7~15 둔감하게)
    - bit3 : 재실학습 초기화 요청 (0: 요청없음 / 1:요청)
    - bit0~2 :캘리브레이션 상태 (0: 대기 / 1: 진행 중 / 2: 완료)
  - DATA7 : 센서 감지 기준값 min (threshold min)
  - DATA8 : 센서 감지 기준값 max (threshold max)
  - DATA9 : 센서 감지 1분 MIN
  - DATA10: 센서 감지 1분 MAX
#endif

namespace Common
{
    public partial class Protocols  /* Protocols Partial Protocol_KS */
    {
        #region Define
        #endregion
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
        static int Button_BypassStat = 0x11;
        static int Button_BypassCtrl = 0x12;

        static int BATCH_ON = 0x01;
        static int BATCH_OFF = 0x00;
        static int GAS_OPEN = 0x01;
        static int GAS_CLOSE = 0x00;
        #region Field
        #endregion

        #region Constructor
        /* Protocols Partial Protocol_KS */
        #endregion

        #region Property
        #endregion

        #region Event Handler
        #endregion

        #region Method
        //private string SendData_KS()
        public string SendData_StatusReq()
        {
            string ret = string.Empty;

            #region HEADER
            this.Send.Add(0xF7);
            #endregion

            #region DEVICE ID
                this.Send.Add(0x33);    // batch protocol
            #endregion

            #region DEVICE SUB ID
                this.Send.Add(0x01);
            #endregion




            #region COMMAND TYPE
            this.Send.Add(0x01);
            #endregion

            #region LENGTH
            this.Send.Add(0x01);
            #endregion

            #region DATA
            if (this.GasOpen)
                this.Send.Add(0x01);
            else if (this.GasClose)
                this.Send.Add(0x00);
            #endregion





            #region XOR SUM : HEADER ~ DATA
            int sumXOR = 0;
            for (int i = 0; i < this.Send.Count; i++)
            {
                sumXOR ^= this.Send[i];
            }
            if (sumXOR > 0xff)
            {
                sumXOR = int.Parse(sumXOR.ToString("X").Substring(sumXOR.ToString("X").Length - 2, 2), System.Globalization.NumberStyles.HexNumber);
            }
            this.Send.Add(sumXOR);
            #endregion

            #region ADD SUM : HEADER ~ XOR SUM
            int sumADD = 0;
            for (int i = 0; i < this.Send.Count; i++)
            {
                sumADD += this.Send[i];
            }
            if (sumADD > 0xff)
            {
                sumADD = int.Parse(sumADD.ToString("X").Substring(sumADD.ToString("X").Length - 2, 2), System.Globalization.NumberStyles.HexNumber);
            }
            this.Send.Add(sumADD);

            for (int i = 0; i < this.Send.Count; i++)
            {
                if (this.Send[i] < 16)
                {
                    ret += "0";
                }

                if (i == this.Send.Count - 1)
                {
                    ret += this.Send[i].ToString("X");
                }
                else
                {
                    ret += (this.Send[i].ToString("X") + " ");
                }
            }
            #endregion

            return ret;
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

        private string SendData_KS(int button_input)
        {
            string ret = string.Empty;
            this.Send.Add(0xF7);        // HEADER
            this.Send.Add(0x33);        //DEVICE ID            
            this.Send.Add(0x01);        // DEVICE SUB ID


            if (button_input == Button_Status_Req)
            {
                this.Send.Add(0x01);        // COMMAND TYPE
                this.Send.Add(0x01);        // LENGTH
                if (this.GasOpen) this.Send.Add(0x01);    // DATA
                else if (this.GasClose) this.Send.Add(0x00);
            }
            else if ((button_input == Button_Gas_Open) || (button_input == Button_Gas_Close))
            {
                this.Send.Add(0x01);        // COMMAND TYPE
                this.Send.Add(0x01);        // LENGTH
                if (button_input == Button_Gas_Open) this.Send.Add(0x01);    // DATA
                else if (button_input == Button_Gas_Close) this.Send.Add(0x00);
            }
            else if ((button_input == Button_Batch_On) || (button_input == Button_Batch_Off))
            {
                this.Send.Add(0x41);        // COMMAND TYPE
                this.Send.Add(0x01);        // LENGTH
                if (button_input == Button_Batch_On) this.Send.Add(0x01);    // DATA
                else if (button_input == Button_Batch_Off) this.Send.Add(0x00);
            }
            else if ((button_input == Button_Gas_Done) || (button_input == Button_Gas_Fail) ||
                     (button_input == Button_ELV_Done) || (button_input == Button_ELV_Fail))
            {
                this.Send.Add(0x43);        // COMMAND TYPE
                this.Send.Add(0x01);        // LENGTH
                if (button_input == Button_Gas_Done) this.Send.Add(0x01);    // DATA
                else if (button_input == Button_Gas_Fail) this.Send.Add(0x02);
                else if (button_input == Button_ELV_Done) this.Send.Add(0x10);
                else if (button_input == Button_ELV_Fail) this.Send.Add(0x20);
            }
            else if (button_input == Button_ELV_Arrived)
            {
                this.Send.Add(0x46);        // COMMAND TYPE
                this.Send.Add(0x04);        // LENGTH
                this.Send.Add(0x01);        // DATA0
                this.Send.Add(0x00);        // DATA1
                this.Send.Add(0x00);        // DATA2
                this.Send.Add(0x00);        // DATA3
            }
            else if (button_input == Button_Send_Weather)
            {
                int temperature_sign = 0;
                int temperature = 0;

                if (this.TempPlus) temperature_sign = 0x00;
                else if (this.TempMinus) temperature_sign = 0x80;

                temperature = temperature_sign | this.TempInt;

                this.Send.Add(0x44);        // COMMAND TYPE
                this.Send.Add(0x06);        // LENGTH
                this.Send.Add(this.WeatherCode);    // DATA0
                this.Send.Add(temperature);         // DATA1 temperature
                this.Send.Add(0x00);                // DATA2 temperature
                this.Send.Add(0x00);                // DATA3 humidity
                this.Send.Add(0x00);                // DATA4 humidity
                this.Send.Add(this.Finedust);                // DATA5 fine-dust, ultra fine-dust
            }
            else if (button_input == Button_Send_Time)
            {
                this.Send.Add(0x45);        // COMMAND TYPE
                this.Send.Add(0x06);        // LENGTH
                this.Send.Add(TimeYear);    // DATA0
                this.Send.Add(TimeMonth);   // DATA1
                this.Send.Add(TimeDay);     // DATA2
                this.Send.Add(TimeHour);    // DATA3
                this.Send.Add(TimeMunite);  // DATA4
                this.Send.Add(TimeSecond);  // DATA5
            }
            else if (button_input == Button_Send_Parking)
            {
                int data_len = 0;

                if (this.Parking_Count == 0)
                { 
                    data_len = 6;
                }
                else if (this.Parking_Count == 1)
                {
                    data_len = 3 + this.car1_num_len + this.car1_pos_len;
                }
                else if (this.Parking_Count == 2)
                {
                    
                    data_len = 5 + this.car1_num_len + this.car1_pos_len + this.car2_num_len + this.car2_pos_len;
                }

                this.Send.Add(0x47);        // COMMAND TYPE
                this.Send.Add(data_len);    // LENGTH
                this.Send.Add(this.Parking_Count);   // DATA0

                if (this.Parking_Count == 0)
                {
                    this.Send.Add(0x00);    // DATA1
                    this.Send.Add(0x00);    // DATA2
                    this.Send.Add(0x00);    // DATA3
                    this.Send.Add(0x00);    // DATA4
                    this.Send.Add(0x00);    // DATA5
                }
                else if (this.Parking_Count > 0)
                {
                    this.Send.Add(this.car1_num_len);    // DATA
                    for (int i = 0; i < this.car1_num_len; i++)
                    {
                        this.Send.Add(this.car1_num[i]);
                    }
                    this.Send.Add(this.car1_pos_len);    // DATA
                    for (int i = 0; i < this.car1_pos_len; i++)
                    {
                        this.Send.Add(this.car1_pos[i]);
                    }

                    if (this.Parking_Count == 2)
                    {
                        this.Send.Add(this.car2_num_len);    // DATA
                        for (int i = 0; i < this.car2_num_len; i++)
                        {
                            this.Send.Add(this.car2_num[i]);
                        }
                        this.Send.Add(this.car2_pos_len);    // DATA
                        for (int i = 0; i < this.car2_pos_len; i++)
                        {
                            this.Send.Add(this.car2_pos[i]);
                        }
                    }
                } 
            }
            else if (button_input == Button_Send_Notice)
            {
                int info_delivery = 0;
                int info_guest = 0;
                int info_notice = 0;
                int information = 0;
                if (this.Delivery) info_delivery = 0x02;
                if (this.Guest) info_guest = 0x04;
                if (this.Notice) info_notice = 0x01;
                information = (info_delivery | info_guest | info_notice);

                this.Send.Add(0x48);        // COMMAND TYPE
                this.Send.Add(0x02);        // LENGTH
                this.Send.Add(0x00);        // DATA0
                this.Send.Add(information); // DATA1
            }
            else if (button_input == Button_BypassStat)
            {
                this.Send.Add(0x49);        // COMMAND TYPE
                this.Send.Add(0x00);        // LENGTH
            }
            else if (button_input == Button_BypassCtrl)
            {
                int out_data = 0;
                int out_out = 0;
                int out_heat = 0;
                if (this.Out) out_out = 0x01;
                else if (this.In) out_out = 0x00;
                if (this.HeatSet) out_heat = 0x02;
                else if (this.HeatReset) out_heat = 0x00;
                out_data = out_heat | out_out;

                this.Send.Add(0x51);        // COMMAND TYPE
                this.Send.Add(0x07);        // LENGTH
                this.Send.Add(0x03);        // DATA0 (Data Type : Control)
                this.Send.Add(0x00);        // DATA1 (Reserved)
                this.Send.Add(0x00);        // DATA2 (Reserved)

                if (this.GoWorkSet) this.Send.Add(0x01);    // DATA3
                else if (this.GoWorkReset) this.Send.Add(0x00);

                this.Send.Add(out_data);        // DATA4

                if (this.LightOff) this.Send.Add(BATCH_OFF); // DATA5
                else if (this.LightOn) this.Send.Add(BATCH_ON);

                if (this.Vol0) this.Send.Add(0x01); // DATA6
                else if (this.Vol1) this.Send.Add(0x02);
                else if (this.Vol2) this.Send.Add(0x04);
                else if (this.Vol3) this.Send.Add(0x08);
                else if (this.m_Vol_NO) this.Send.Add(0x10);
            }

            #region XOR SUM : HEADER ~ DATA
            int sumXOR = 0;
            for (int i = 0; i < this.Send.Count; i++)
            {
                sumXOR ^= this.Send[i];
            }
            if (sumXOR > 0xff)
            {
                sumXOR = int.Parse(sumXOR.ToString("X").Substring(sumXOR.ToString("X").Length - 2, 2), System.Globalization.NumberStyles.HexNumber);
            }
            this.Send.Add(sumXOR);
            #endregion

            #region ADD SUM : HEADER ~ XOR SUM
            int sumADD = 0;
            for (int i = 0; i < this.Send.Count; i++)
            {
                sumADD += this.Send[i];
            }
            if (sumADD > 0xff)
            {
                sumADD = int.Parse(sumADD.ToString("X").Substring(sumADD.ToString("X").Length - 2, 2), System.Globalization.NumberStyles.HexNumber);
            }
            this.Send.Add(sumADD);

            for (int i = 0; i < this.Send.Count; i++)
            {
                if (this.Send[i] < 16)
                {
                    ret += "0";
                }

                if (i == this.Send.Count - 1)
                {
                    ret += this.Send[i].ToString("X");
                }
                else
                {
                    ret += (this.Send[i].ToString("X") + " ");
                }
            }
            #endregion

            return ret;
#if false
            string ret = string.Empty;

            #region HEADER
            this.Send.Add(0xF7);
            #endregion

            #region DEVICE ID
            if (this.Light || this.Dimming || this.Scene)
            {
                //this.Send.Add(0x0E);
                this.Send.Add(0x40);    // AI protocol
            }
            else
            {
                this.Send.Clear();
                return ret;
            }
            #endregion

            #region DEVICE SUB ID
            if (this.Light && !this.Dimming && !this.Scene)
            {
                this.Send.Add(0x11);
            }
            else
            {
                this.Send.Clear();
                return ret;
            }
            #endregion

            #region COMMAND TYPE
            if (this.CmdState)
            {
                this.Send.Add(0x01);
            }
            else if (this.CmdSpec)
            {
                this.Send.Add(0x0F);
            }

            else if (this.CmdLight)
            {
                this.Send.Add(0x41);
            }
            else if (this.CmdStandby)
            {
                this.Send.Add(0x42);
            }
            else if (this.CmdHeat)
            {
                this.Send.Add(0x43);
            }
            else if (this.CmdSensor)
            {
                this.Send.Add(0x44);
            }
            else if (this.CmdVent)
            {
                this.Send.Add(0x45);
            }
            else
            {
                this.Send.Clear();
                return ret;
            }
            #endregion

            #region LENGTH : DATA Byte Count
            if (this.Light && !this.Dimming && !this.Scene)
            {
                if (this.CmdSpec)
                {
                    this.Send.Add(0x00);
                }
                else if (this.CmdState)
                {
                    // length
                    this.Send.Add(0x04);
                    // data0 : error code
                    this.Send.Add(0x00);
                    // data1 : 재실여부
                    this.Send.Add(m_DataState_room_index);

                    // data2 : 인공지능사용하세요6
                    this.Send.Add(m_DataState_use_index);

                    // data3 : 회원가입
                    this.Send.Add(m_DataState_mem_index);
                }
                else if (this.CmdLight)
                {
                    // length
                    this.Send.Add(0x02);
                    // data0 : error code
                    this.Send.Add(0x00);

                    // data1 : 조명 AI 설정
                    this.Send.Add(m_DataLight_index);
                }
                else if ( this.CmdHeat)
                {
                    // length
                    this.Send.Add(0x02);
                    // data0 : error code
                    this.Send.Add(0x00);
                    // data1 : 냉난방 AI 설정
                    if ((m_DataHeat_index != 0x01) && (m_DataAircon_index != 0x01))
                        this.Send.Add(0x00);
                    else if ((m_DataHeat_index == 0x01) && (m_DataAircon_index != 0x01))
                        this.Send.Add(0x11);
                    else if ((m_DataHeat_index != 0x01) && (m_DataAircon_index == 0x01))
                        this.Send.Add(0x22);
                    else if ((m_DataHeat_index == 0x01) && (m_DataAircon_index == 0x01))
                        this.Send.Add(0x33);
                }
                else if (this.CmdStandby)
                {
                    // length
                    this.Send.Add(0x02);
                    // data0 : error code
                    this.Send.Add(0x00);
                    // data1 : 콘센트 AI 설정
                    if( (m_DataStnadby1_index!=0x01) && (m_DataStnadby2_index != 0x01))
                        this.Send.Add(0x00);
                    else if ((m_DataStnadby1_index == 0x01) && (m_DataStnadby2_index != 0x01))
                        this.Send.Add(0x11);
                    else if ((m_DataStnadby1_index != 0x01) && (m_DataStnadby2_index == 0x01))
                        this.Send.Add(0x22);
                    else if ((m_DataStnadby1_index == 0x01) && (m_DataStnadby2_index == 0x01))
                        this.Send.Add(0x33);


                }
                else if (this.CmdSensor)
                {
                    // length
                    this.Send.Add(0x05);
                    // data0 : error code
                    this.Send.Add(0x00);

                    this.Send.Add(0x01);
                    this.Send.Add(0x02);
                    this.Send.Add(0x03);
                    this.Send.Add(0x04);

                }
                else if (this.CmdVent)
                {
                    // length
                    this.Send.Add(0x02);
                    // data0 : error code
                    this.Send.Add(0x00);

                    // data1 : 환기 AI 설정
                    this.Send.Add(m_DataVent_index);
                }
                else
                {
                    this.Send.Clear();
                    return ret;
                }
            }
            else
            {
                this.Send.Clear();
                return ret;
            }
            #endregion

            #region DATA
#if false
            int length = this.Send[4];
            for (int i = 0; i < length; i++)
            {
                this.Send.Add(0x00);
            }
#endif
            #endregion

            #region XOR SUM : HEADER ~ DATA
            int sumXOR = 0;
            for (int i = 0; i < this.Send.Count; i++)
            {
                sumXOR ^= this.Send[i];
            }
            if (sumXOR > 0xff)
            {
                sumXOR = int.Parse(sumXOR.ToString("X").Substring(sumXOR.ToString("X").Length - 2, 2), System.Globalization.NumberStyles.HexNumber);
            }
            this.Send.Add(sumXOR);
            #endregion

            #region ADD SUM : HEADER ~ XOR SUM
            int sumADD = 0;
            for (int i = 0; i < this.Send.Count; i++)
            {
                sumADD += this.Send[i];
            }
            if (sumADD > 0xff)
            {
                sumADD = int.Parse(sumADD.ToString("X").Substring(sumADD.ToString("X").Length - 2, 2), System.Globalization.NumberStyles.HexNumber);
            }
            this.Send.Add(sumADD);

            for (int i = 0; i < this.Send.Count; i++)
            {
                if (this.Send[i] < 16)
                {
                    ret += "0";
                }

                if (i == this.Send.Count - 1)
                {
                    ret += this.Send[i].ToString("X");
                }
                else
                {
                    ret += (this.Send[i].ToString("X") + " ");
                }
            }
            #endregion

            return ret;
#endif
        }

        private string ResponseData_KS()
        {
            string ret = string.Empty;

            #region HEADER
            this.Response.Add(0xF7);
            #endregion

            #region DEVICE ID
            if (this.Light || this.Dimming || this.Scene)
            {
                this.Response.Add(0x0E);
            }
            else if (this.StandBy)
            {
                this.Response.Add(0x39);
            }
            else if (this.Heating)
            {
                this.Response.Add(0x36);
            }
            else if (this.Ventilation)
            {
                this.Response.Add(0x32);
            }
            else if (this.Batch)
            {
                this.Response.Add(0x33);
            }
            else
            {
                this.Response.Clear();
                return ret;
            }
            #endregion

            #region DEVICE SUB ID
            if (this.Light && !this.Dimming && !this.Scene)
            {
                if (this.CmdState || this.CmdSpec || this.CmdCtrlAll)
                {
                    this.Response.Add((this.SwitchID << 4) | 0x0F);
                }
                else if (this.CmdCtrlGroup)
                {
                    if (this.SwitchLight6_On)
                    {
                        this.Response.Add((this.SwitchID << 4) | 0x06);
                    }
                    else if (this.SwitchLight5_On)
                    {
                        this.Response.Add((this.SwitchID << 4) | 0x05);
                    }
                    else if (this.SwitchLight4_On)
                    {
                        this.Response.Add((this.SwitchID << 4) | 0x04);
                    }
                    else if (this.SwitchLight3_On)
                    {
                        this.Response.Add((this.SwitchID << 4) | 0x03);
                    }
                    else if (this.SwitchLight2_On)
                    {
                        this.Response.Add((this.SwitchID << 4) | 0x02);
                    }
                    else if (this.SwitchLight1_On)
                    {
                        this.Response.Add((this.SwitchID << 4) | 0x01);
                    }

                    if (!this.SwitchLight1_On && !this.SwitchLight2_On && !this.SwitchLight3_On && !this.SwitchLight4_On && !this.SwitchLight5_On && !this.SwitchLight6_On)
                    {
                        this.Response.Clear();
                        return ret;
                    }
                }
                else
                {
                    this.Response.Clear();
                    return ret;
                }
            }
            else if (this.Dimming && !this.Scene)
            {
                if (this.CmdState)
                {

                }
                else if (this.CmdSpec)
                {

                }
                else if (this.CmdCtrlGroup)
                {

                }
                else if (this.CmdCtrlAll)
                {

                }
                else
                {
                    this.Response.Clear();
                    return ret;
                }
            }
            else if (this.Scene)
            {
                if (this.CmdState)
                {

                }
                else if (this.CmdSpec)
                {

                }
                else if (this.CmdCtrlGroup)
                {

                }
                else if (this.CmdCtrlAll)
                {

                }
                else
                {
                    this.Response.Clear();
                    return ret;
                }
            }
            else if (this.StandBy)
            {
                if (this.CmdState)
                {

                }
                else if (this.CmdSpec)
                {
                    this.Response.Add((this.SwitchID << 4) | 0x0F);
                }
                else if (this.CmdCtrlGroup || this.CmdSetSBPV || this.CmdGetSBPV)
                {
                    if (this.SwitchStandby4_On)
                    {
                        this.Response.Add((this.SwitchID << 4) | 0x04);
                    }
                    else if (this.SwitchStandby3_On)
                    {
                        this.Response.Add((this.SwitchID << 4) | 0x03);
                    }
                    else if (this.SwitchStandby2_On)
                    {
                        this.Response.Add((this.SwitchID << 4) | 0x02);
                    }
                    else if (this.SwitchStandby1_On)
                    {
                        this.Response.Add((this.SwitchID << 4) | 0x01);
                    }
                    else
                    {
                        this.Response.Clear();
                        return ret;
                    }
                }
                else if (this.CmdCtrlAll)
                {
                    this.Response.Clear();
                    return ret;
                }
                else
                {
                    this.Response.Clear();
                    return ret;
                }
            }
            else if (this.Heating)
            {
                if (this.CmdState || this.CmdSpec || this.CmdCtrlAll)
                {
                    this.Response.Add((this.SwitchID << 4) | 0x0F);
                }
                else if (this.CmdCtrlGroup)
                {
                    this.Response.Add((this.SwitchID << 4) | 0x01);
                }
                else
                {
                    this.Response.Clear();
                    return ret;
                }
            }
            else if (this.Ventilation)
            {
                if (this.CmdState || this.CmdSpec || this.CmdCtrlAll)
                {
                    this.Response.Add((this.SwitchID << 4) | 0x0F);
                }
                else if (this.CmdCtrlGroup)
                {
                    this.Response.Add(this.SwitchID);
                }
                else
                {
                    this.Response.Clear();
                    return ret;
                }
            }
            else if (this.Batch)
            {
                if (this.CmdState || this.CmdSpec || this.CmdCtrlAll)
                {
                    this.Response.Add((this.SwitchID << 4) | 0x0F);
                }
                else if (this.CmdCtrlGroup)
                {
                    this.Response.Add(this.SwitchID);
                }
                else
                {
                    this.Response.Clear();
                    return ret;
                }
            }
            else
            {
                this.Response.Clear();
                return ret;
            }
            #endregion

            #region COMMAND TYPE
            if (this.CmdState)
            {
                this.Response.Add(0x81);
            }
            else if (this.CmdSpec)
            {
                this.Response.Add(0x8F);
            }
            else if (this.CmdCtrlGroup || this.CmdSetSBPV)
            {
                this.Response.Add(0xC1);
            }
            else if (this.CmdCtrlAll)
            {
                this.Response.Clear();
                return ret;
            }
            else if (this.CmdGetSBPV)
            {
                this.Response.Add(0xB1);
            }
            else
            {
                this.Response.Clear();
                return ret;
            }
            #endregion

            #region LENGTH : DATA Byte Count
            if (this.Light && !this.Dimming && !this.Scene)
            {
                if (this.CmdState)
                {
                    this.Response.Add(this.SwitchLightCount + 1);
                }
                else if (this.CmdSpec)
                {
                    this.Response.Add(0x05);
                }
                else if (this.CmdCtrlGroup || this.CmdCtrlAll)
                {
                    this.Response.Add(0x02);
                }
                else
                {
                    this.Response.Clear();
                    return ret;
                }
            }
            else if (this.Dimming && !this.Scene)
            {
                if (this.CmdState)
                {

                }
                else if (this.CmdSpec)
                {

                }
                else if (this.CmdCtrlGroup)
                {

                }
                else if (this.CmdCtrlAll)
                {

                }
                else
                {
                    this.Response.Clear();
                    return ret;
                }
            }
            else if (this.Scene)
            {
                if (this.CmdState)
                {

                }
                else if (this.CmdSpec)
                {

                }
                else if (this.CmdCtrlGroup)
                {

                }
                else if (this.CmdCtrlAll)
                {

                }
                else
                {
                    this.Response.Clear();
                    return ret;
                }
            }
            else if (this.StandBy)
            {
                if (this.CmdState)
                {

                }
                else if (this.CmdSpec)
                {
                    this.Response.Add(this.SwitchStandbyCount + 2);
                }
                else if (this.CmdCtrlGroup)
                {
                    this.Response.Add(0x02);
                }
                else if (this.CmdCtrlAll)
                {
                    this.Response.Clear();
                    return ret;
                }
                else if (this.CmdSetSBPV || this.CmdGetSBPV)
                {
                    this.Response.Add(0x03);
                }
                else
                {
                    this.Response.Clear();
                    return ret;
                }
            }
            else if (this.Heating)
            {
                if (this.CmdState)
                {

                }
                else if (this.CmdSpec)
                {

                }
                else if (this.CmdCtrlGroup)
                {

                }
                else if (this.CmdCtrlAll)
                {

                }
                else
                {
                    this.Response.Clear();
                    return ret;
                }
            }
            else if (this.Ventilation)
            {
                if (this.CmdState)
                {

                }
                else if (this.CmdSpec)
                {

                }
                else if (this.CmdCtrlGroup)
                {

                }
                else if (this.CmdCtrlAll)
                {

                }
                else
                {
                    this.Response.Clear();
                    return ret;
                }
            }
            else if (this.Batch)
            {
                if (this.CmdState)
                {

                }
                else if (this.CmdSpec)
                {

                }
                else if (this.CmdCtrlGroup)
                {

                }
                else if (this.CmdCtrlAll)
                {

                }
                else
                {
                    this.Response.Clear();
                    return ret;
                }
            }
            else
            {
                this.Response.Clear();
                return ret;
            }
            #endregion

            #region DATA
            if (this.Response[4] != 0x00)
            {
                if (this.Light && !this.Dimming && !this.Scene)
                {
                    if (this.CmdState)
                    {
                        if (this.SwitchLightCount >= 1)
                        {
                            if (this.SwitchLight1_On)
                            {
                                this.Response.Add(0x01);
                            }
                            else
                            {
                                this.Response.Add(0x00);
                            }
                        }

                        if (this.SwitchLightCount >= 2)
                        {
                            if (this.SwitchLight2_On)
                            {
                                this.Response.Add(0x01);
                            }
                            else
                            {
                                this.Response.Add(0x00);
                            }
                        }

                        if (this.SwitchLightCount >= 3)
                        {
                            if (this.SwitchLight3_On)
                            {
                                this.Response.Add(0x01);
                            }
                            else
                            {
                                this.Response.Add(0x00);
                            }
                        }

                        if (this.SwitchLightCount >= 4)
                        {
                            if (this.SwitchLight4_On)
                            {
                                this.Response.Add(0x01);
                            }
                            else
                            {
                                this.Response.Add(0x00);
                            }
                        }

                        if (this.SwitchLightCount >= 5)
                        {
                            if (this.SwitchLight5_On)
                            {
                                this.Response.Add(0x01);
                            }
                            else
                            {
                                this.Response.Add(0x00);
                            }
                        }

                        if (this.SwitchLightCount >= 6)
                        {
                            if (this.SwitchLight6_On)
                            {
                                this.Response.Add(0x01);
                            }
                            else
                            {
                                this.Response.Add(0x00);
                            }
                        }
                    }
                    else if (this.CmdSpec)
                    {
                        this.Response.Add(0x00); // Error Bit0~7

                        this.Response.Add(this.SwitchLightCount - this.UseLightDimmingCount()); // Not Dimming Function Light Count

                        this.Response.Add(this.UseLightDimmingCount()); // Dimming Function Light Count

                        this.Response.Add(this.UseLightDimmingBit1()); // Dimming Function Light Position Bit0~7, bit0:1 / bit7:8

                        this.Response.Add(this.UseLightDimmingBit2()); // Dimming Function Light Position Bit0~7, bit0:9 / bit5:14(E)
                    }
                    else if (this.CmdCtrlGroup)
                    {
                        this.Response.Add(0x00);
                        if (this.CmdOff)
                        {
                            this.Response.Add(0x00);
                        }
                        else
                        {
                            this.Response.Add(0x01);
                        }
                    }
                    else if (this.CmdCtrlAll) // Not Response
                    {
                        this.Response.Clear();
                        return ret;
                    }
                    else
                    {
                        this.Response.Clear();
                        return ret;
                    }
                }
                else if (this.Dimming && !this.Scene)
                {
                    if (this.CmdState)
                    {

                    }
                    else if (this.CmdSpec)
                    {
                        this.Response.Add(0x00); // Error Bit0~7

                        this.Response.Add(this.SwitchLightCount); // Not Dimming Function Light Count
                    }
                    else if (this.CmdCtrlGroup)
                    {

                    }
                    else if (this.CmdCtrlAll)
                    {

                    }
                    else
                    {
                        this.Response.Clear();
                        return ret;
                    }
                }
                else if (this.Scene)
                {
                    if (this.CmdState)
                    {

                    }
                    else if (this.CmdSpec)
                    {

                    }
                    else if (this.CmdCtrlGroup)
                    {

                    }
                    else if (this.CmdCtrlAll)
                    {

                    }
                    else
                    {
                        this.Response.Clear();
                        return ret;
                    }
                }
                else if (this.StandBy)
                {
                    if (this.CmdState)
                    {

                    }
                    else if (this.CmdSpec)
                    {
                        this.Response.Add(0x00);//Error
                        this.Response.Add(this.SwitchStandbyCount);//SwitchStandbyCount
                        for (int i = 0; i < this.SwitchStandbyCount; i++)
                        {
                            this.Response.Add(0xE0);//Function : Bit7_Auto, Bit6_Watt, Bit5_Overload, Bit_4,3,2,1,0_Reserved
                        }
                    }
                    else if (this.CmdCtrlGroup)
                    {
                        this.Response.Add(0x00);//Error

                        if (this.SwitchStandby4_On)
                        {
                            if (this.m_SwitchStandby4_Auto)
                            {
                                if (this.CmdOff)
                                {
                                    this.Response.Add(0x02);
                                }
                                else
                                {
                                    this.Response.Add(0x03);
                                }
                            }
                            else
                            {
                                if (this.CmdOff)
                                {
                                    this.Response.Add(0x00);
                                }
                                else
                                {
                                    this.Response.Add(0x01);
                                }
                            }
                        }
                        else if (this.SwitchStandby3_On)
                        {
                            if (this.m_SwitchStandby3_Auto)
                            {
                                if (this.CmdOff)
                                {
                                    this.Response.Add(0x02);
                                }
                                else
                                {
                                    this.Response.Add(0x03);
                                }
                            }
                            else
                            {
                                if (this.CmdOff)
                                {
                                    this.Response.Add(0x00);
                                }
                                else
                                {
                                    this.Response.Add(0x01);
                                }
                            }
                        }
                        else if (this.SwitchStandby2_On)
                        {
                            if (this.m_SwitchStandby2_Auto)
                            {
                                if (this.CmdOff)
                                {
                                    this.Response.Add(0x02);
                                }
                                else
                                {
                                    this.Response.Add(0x03);
                                }
                            }
                            else
                            {
                                if (this.CmdOff)
                                {
                                    this.Response.Add(0x00);
                                }
                                else
                                {
                                    this.Response.Add(0x01);
                                }
                            }
                        }
                        else if (this.SwitchStandby1_On)
                        {
                            if (this.m_SwitchStandby1_Auto)
                            {
                                if (this.CmdOff)
                                {
                                    this.Response.Add(0x02);
                                }
                                else
                                {
                                    this.Response.Add(0x03);
                                }
                            }
                            else
                            {
                                if (this.CmdOff)
                                {
                                    this.Response.Add(0x00);
                                }
                                else
                                {
                                    this.Response.Add(0x01);
                                }
                            }
                        }
                        else
                        {
                            this.Response.Clear();
                            return ret;
                        }
                    }
                    else if (this.CmdCtrlAll)
                    {
                        this.Response.Clear();
                        return ret;
                    }
                    else if (this.CmdSetSBPV || this.CmdGetSBPV)
                    {
                        this.Response.Add(0x00);//Error
                        string subValue = string.Empty;
                        if (this.StandByPowerValue / 100 >= 1)
                        {
                            subValue = this.StandByPowerValue.ToString("F1");
                        }
                        else if (this.StandByPowerValue / 10 >= 1)
                        {
                            subValue = "0" + this.StandByPowerValue.ToString("F1");
                        }
                        else if (this.StandByPowerValue / 1 >= 1)
                        {
                            subValue = "00" + this.StandByPowerValue.ToString("F1");
                        }

                        int hundreds = Convert.ToInt32(subValue.Substring(0, 1));
                        int tens = Convert.ToInt32(subValue.Substring(1, 1));
                        int units = Convert.ToInt32(subValue.Substring(2, 1));
                        int tenths = Convert.ToInt32(subValue.Substring(4, 1));

                        this.Response.Add(hundreds * 10 + tens);// BCD : 0x(100w + 10w)
                        this.Response.Add(units * 10 + tenths);// BCD : 0x(1w + 0.1w)
                    }
                    else
                    {
                        this.Response.Clear();
                        return ret;
                    }
                }
                else if (this.Heating)
                {
                    if (this.CmdState)
                    {

                    }
                    else if (this.CmdSpec)
                    {

                    }
                    else if (this.CmdCtrlGroup)
                    {

                    }
                    else if (this.CmdCtrlAll)
                    {

                    }
                    else
                    {
                        this.Response.Clear();
                        return ret;
                    }
                }
                else if (this.Ventilation)
                {
                    if (this.CmdState)
                    {

                    }
                    else if (this.CmdSpec)
                    {

                    }
                    else if (this.CmdCtrlGroup)
                    {

                    }
                    else if (this.CmdCtrlAll)
                    {

                    }
                    else
                    {
                        this.Response.Clear();
                        return ret;
                    }
                }
                else if (this.Batch)
                {
                    if (this.CmdState)
                    {

                    }
                    else if (this.CmdSpec)
                    {

                    }
                    else if (this.CmdCtrlGroup)
                    {

                    }
                    else if (this.CmdCtrlAll)
                    {

                    }
                    else
                    {
                        this.Response.Clear();
                        return ret;
                    }
                }
                else
                {
                    this.Response.Clear();
                    return ret;
                }
            }
            #endregion

            #region XOR SUM : HEADER ~ DATA
            int sumXOR = 0;
            for (int i = 0; i < this.Response.Count; i++)
            {
                sumXOR ^= this.Response[i];
            }
            if (sumXOR > 0xff)
            {
                sumXOR = int.Parse(sumXOR.ToString("X").Substring(sumXOR.ToString("X").Length - 2, 2), System.Globalization.NumberStyles.HexNumber);
            }
            this.Response.Add(sumXOR);
            #endregion

            #region ADD SUM : HEADER ~ XOR SUM
            int sumADD = 0;
            for (int i = 0; i < this.Response.Count; i++)
            {
                sumADD += this.Response[i];
            }
            if (sumADD > 0xff)
            {
                sumADD = int.Parse(sumADD.ToString("X").Substring(sumADD.ToString("X").Length - 2, 2), System.Globalization.NumberStyles.HexNumber);
            }
            this.Response.Add(sumADD);

            for (int i = 0; i < this.Response.Count; i++)
            {
                if (this.Response[i] < 16)
                {
                    if (this.StandBy && this.CmdSetSBPV)
                    {
                        if ((i == 6 || i == 7) && (this.Response[i] < 10))
                        {
                            ret += "0";
                        }
                    }
                    else
                    {
                        ret += "0";
                    }
                }

                if (i == this.Response.Count - 1)
                {
                    ret += this.Response[i].ToString("X");
                }
                else
                {
                    if ((this.StandBy && this.CmdSetSBPV) && (i == 6 || i == 7))
                    {
                        ret += (this.Response[i].ToString() + " ");
                    }
                    else
                    {
                        ret += (this.Response[i].ToString("X") + " ");
                    }
                }
            }
            #endregion

            return ret;
        }
#endregion

        #region Members
        #endregion
    }
}
