using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public partial class Protocols /* Protocols Partial Protocol_Main */
    {
        #region Define
        [Serializable]
        private enum ProtocolKeys
        {
            KS,
            COMMAX,
            CVnet,
            HyundaiHT,
        }
        #endregion

        #region Field
        private int m_SwitchID;
        private int m_SwitchLightCount;
        private int m_SwitchStandbyCount;

        private string m_ProtocolName;
        private int m_ProtocolIndex;

        /* 25.06.28 */
        private bool m_GasOpen;
        private bool m_GasClose;

        private int m_WeatherCode;
        private bool m_TempPlus;
        private bool m_TempMinus;
        private int m_TempInt;
        private int m_Finedust;

        private int m_TimeYear;
        private int m_TimeMonth;
        private int m_TimeDay;
        private int m_TimeHour;
        private int m_TimeMunite;
        private int m_TimeSecond;

        private bool m_Delivery;
        private bool m_Guest;
        private bool m_Notice;

        private int[] m_car1_num = new int[10];
        private int[] m_car1_pos = new int[10];
        private int[] m_car2_num = new int[10];
        private int[] m_car2_pos = new int[10];

        //private int[] m_car1_num;
        //private int[] m_car1_pos;
        //private int[] m_car2_num;
        //private int[] m_car2_pos;

        private int m_car1_num_len;
        private int m_car2_num_len;
        private int m_car1_pos_len;
        private int m_car2_pos_len;

        private int m_Parking_Count;

        /* bypass control */
        private bool m_GoWorkSet;
        private bool m_GoWorkReset;

        private bool m_Out;
        private bool m_In;

        private bool m_HeatSet;
        private bool m_HeatReset;

        private bool m_LightOff;
        private bool m_LightOn;

        private bool m_Vol0;
        private bool m_Vol1;
        private bool m_Vol2;
        private bool m_Vol3;
        private bool m_Vol_NO;
        /* bypass control */


        /* 25.06.28 */

        private bool m_Light;
        private bool m_Dimming;
        private bool m_Scene;
        private bool m_StandBy;
        private bool m_Heating;
        private bool m_Ventilation;
        private bool m_Batch;

        private bool m_CmdState;
        private bool m_CmdSpec;

        private bool m_CmdLight;
        private bool m_CmdStandby;
        private bool m_CmdHeat;
        private bool m_CmdSensor;
        private bool m_CmdVent;

        private bool m_CmdCtrlGroup;
        private bool m_CmdCtrlAll;
        private bool m_CmdSetSBPV;
        private bool m_CmdGetSBPV;
        private bool m_CmdOff;

        private string m_SendData;
        private List<int> m_Send;
        private string m_ResponseData;
        private List<int> m_Response;

        private bool m_SwitchLight1_On;
        private bool m_SwitchLight2_On;
        private bool m_SwitchLight3_On;
        private bool m_SwitchLight4_On;
        private bool m_SwitchLight5_On;
        private bool m_SwitchLight6_On;
        private bool m_SwitchStandby1_On;
        private bool m_SwitchStandby2_On;
        private bool m_SwitchStandby3_On;
        private bool m_SwitchStandby4_On;
        private bool m_SwitchStandby1_Auto;
        private bool m_SwitchStandby2_Auto;
        private bool m_SwitchStandby3_Auto;
        private bool m_SwitchStandby4_Auto;

        private bool m_UseLightDimming1;
        private bool m_UseLightDimming2;
        private bool m_UseLightDimming3;
        private bool m_UseLightDimming4;
        private bool m_UseLightDimming5;
        private bool m_UseLightDimming6;

        private int m_DimmingStep;
        private int m_SceneStep;

        private double m_StandByPowerValue;

        // DATA FRAME
        public int m_DataState_room_index;
        public int m_DataState_use_index;
        public int m_DataState_mem_index;
        public int m_DataLight_index;
        public int m_DataStnadby1_index;
        public int m_DataStnadby2_index;
        public int m_DataAircon_index;
        public int m_DataHeat_index;

        public int m_DataSensor1_index;
        public int m_DataSensor2_index;
        public int m_DataSensor3_index;
        public int m_DataSensor4_index;

        public int m_DataVent_index;
        #endregion

        #region Constructor
        /* Protocols Partial Protocol_Main */
        public Protocols()
        {
            this.SwitchID = 0;
            this.SwitchLightCount = 0;
            this.SwitchStandbyCount = 0;

            this.ProtocolName = string.Empty;
            this.ProtocolIndex = 0;



            this.Light = false;
            this.Dimming = false;
            this.Scene = false;
            this.StandBy = false;
            this.Heating = false;
            this.Ventilation = false;
            this.Batch = false;

            this.CmdState = false;
            this.CmdSpec = false;
            this.CmdCtrlGroup = false;
            this.CmdCtrlAll = false;
            this.CmdSetSBPV = false;
            this.CmdGetSBPV = false;
            this.CmdOff = false;

            /* 25.06.28 */
            this.GasOpen = false;
            this.GasClose = false;

            this.WeatherCode = 0;
            //this.TempSign = 0;
            this.TempPlus = false;
            this.TempMinus = false;
            this.TempInt = 0;
            this.Finedust = 0;

            this.TimeYear = 0;
            this.TimeMonth = 0;
            this.TimeDay = 0;
            this.TimeHour = 0;
            this.TimeMunite = 0;
            this.TimeSecond = 0;

            this.Delivery = false;
            this.Guest = false;
            this.Notice = false;

            for (int i = 0; i < 10; i++)
            {
                car1_num[i] = 0;
                car1_pos[i] = 0;
                car2_num[i] = 0;
                car2_pos[i] = 0;
            }
            
            this.car1_num_len = 0;
            this.car1_pos_len = 0;
            this.car2_num_len = 0;
            this.car2_pos_len = 0;

            this.Parking_Count = 0;
            /* 25.06.28 */

            this.SendData = string.Empty;
            this.Send = new List<int>();
            this.SendData = string.Empty;
            this.Response = new List<int>();

            this.SwitchLight1_On = false;
            this.SwitchLight2_On = false;
            this.SwitchLight3_On = false;
            this.SwitchLight4_On = false;
            this.SwitchLight5_On = false;
            this.SwitchLight6_On = false;
            this.SwitchStandby1_On = false;
            this.SwitchStandby2_On = false;
            this.SwitchStandby3_On = false;
            this.SwitchStandby4_On = false;

            this.m_SwitchStandby1_Auto = false;
            this.m_SwitchStandby2_Auto = false;
            this.m_SwitchStandby3_Auto = false;
            this.m_SwitchStandby4_Auto = false;

            this.UseLightDimming1 = false;
            this.UseLightDimming2 = false;
            this.UseLightDimming3 = false;
            this.UseLightDimming4 = false;
            this.UseLightDimming5 = false;
            this.UseLightDimming6 = false;

            this.DimmingStep = 0;
            this.SceneStep = 0;

            this.StandByPowerValue = 0.0;
        }
        #endregion

        #region Property
        public int SwitchID
        {
            get { return this.m_SwitchID; }
            set { this.m_SwitchID = value; }
        }
        public int SwitchLightCount
        {
            get { return this.m_SwitchLightCount; }
            set { this.m_SwitchLightCount = value; }
        }
        public int SwitchStandbyCount
        {
            get { return this.m_SwitchStandbyCount; }
            set { this.m_SwitchStandbyCount = value; }
        }

        public string ProtocolName
        {
            get { return this.m_ProtocolName; }
            set { this.m_ProtocolName = value; }
        }
        public int ProtocolIndex
        {
            get { return this.m_ProtocolIndex; }
            set { this.m_ProtocolIndex = value; }
        }

        /* 25.06.28 */
        public bool GasOpen
        {
            get { return this.m_GasOpen; }
            set { this.m_GasOpen = value; }
        }
        public bool GasClose
        {
            get { return this.m_GasClose; }
            set { this.m_GasClose = value; }
        }

        public int WeatherCode
        {
            get { return this.m_WeatherCode; }
            set { this.m_WeatherCode = value; }
        }

        public bool TempPlus
        {
            get { return this.m_TempPlus; }
            set { this.m_TempPlus = value; }
        }
        public bool TempMinus
        {
            get { return this.m_TempMinus; }
            set { this.m_TempMinus = value; }
        }
        public int TempInt
        {
            get { return this.m_TempInt; }
            set { this.m_TempInt = value; }
        }
        public int Finedust
        {
            get { return this.m_Finedust; }
            set { this.m_Finedust = value; }
        }

        public int TimeYear
        {
            get { return this.m_TimeYear; }
            set { this.m_TimeYear = value; }
        }
        public int TimeMonth
        {
            get { return this.m_TimeMonth; }
            set { this.m_TimeMonth = value; }
        }
        public int TimeDay
        {
            get { return this.m_TimeDay; }
            set { this.m_TimeDay = value; }
        }
        public int TimeHour
        {
            get { return this.m_TimeHour; }
            set { this.m_TimeHour = value; }
        }
        public int TimeMunite
        {
            get { return this.m_TimeMunite; }
            set { this.m_TimeMunite = value; }
        }
        public int TimeSecond
        {
            get { return this.m_TimeSecond; }
            set { this.m_TimeSecond = value; }
        }

        public bool Delivery
        {
            get { return this.m_Delivery; }
            set { this.m_Delivery = value; }
        }
        public bool Guest
        {
            get { return this.m_Guest; }
            set { this.m_Guest = value; }
        }
        public bool Notice
        {
            get { return this.m_Notice; }
            set { this.m_Notice = value; }
        }


        public int[] car1_num
        {
            get { return this.m_car1_num; }
            set { this.m_car1_num = value; }
        }

        public int[] car1_pos
        {
            get { return this.m_car1_pos; }
            set { this.m_car1_pos = value; }
        }

        public int[] car2_num
        {
            get { return this.m_car2_num; }
            set { this.m_car2_num = value; }
        }

        public int[] car2_pos
        {
            get { return this.m_car2_pos; }
            set { this.m_car2_pos = value; }
        }

        public int car1_num_len
        {
            get { return this.m_car1_num_len; }
            set { this.m_car1_num_len = value; }
        }

        public int car1_pos_len
        {
            get { return this.m_car1_pos_len; }
            set { this.m_car1_pos_len = value; }
        }

        public int car2_num_len
        {
            get { return this.m_car2_num_len; }
            set { this.m_car2_num_len = value; }
        }

        public int car2_pos_len
        {
            get { return this.m_car2_pos_len; }
            set { this.m_car2_pos_len = value; }
        }

        public int Parking_Count
        {
            get { return this.m_Parking_Count; }
            set { this.m_Parking_Count = value; }
        }




        /* bypass control */
        public bool GoWorkSet
        {
            get { return this.m_GoWorkSet; }
            set { this.m_GoWorkSet = value; }
        }
        public bool GoWorkReset
        {
            get { return this.m_GoWorkReset; }
            set { this.m_GoWorkReset = value; }
        }
        public bool Out
        {
            get { return this.m_Out; }
            set { this.m_Out = value; }
        }
        public bool In
        {
            get { return this.m_In; }
            set { this.m_In = value; }
        }
        public bool HeatSet
        {
            get { return this.m_HeatSet; }
            set { this.m_HeatSet = value; }
        }
        public bool HeatReset
        {
            get { return this.m_HeatReset; }
            set { this.m_HeatReset = value; }
        }

        public bool LightOff
        {
            get { return this.m_LightOff; }
            set { this.m_LightOff = value; }
        }
        public bool LightOn
        {
            get { return this.m_LightOn; }
            set { this.m_LightOn = value; }
        }

        public bool Vol0
        {
            get { return this.m_Vol0; }
            set { this.m_Vol0 = value; }
        }
        public bool Vol1
        {
            get { return this.m_Vol1; }
            set { this.m_Vol1 = value; }
        }
        public bool Vol2
        {
            get { return this.m_Vol2; }
            set { this.m_Vol2 = value; }
        }
        public bool Vol3
        {
            get { return this.m_Vol3; }
            set { this.m_Vol3 = value; }
        }
        public bool Vol_NO
        {
            get { return this.m_Vol_NO; }
            set { this.m_Vol_NO = value; }
        }

        /* bypass control */

        /* 25.06.28 */


        public bool Light
        {
            get { return this.m_Light; }
            set { this.m_Light = value; }
        }
        public bool Dimming
        {
            get { return this.m_Dimming; }
            set { this.m_Dimming = value; }
        }
        public bool Scene
        {
            get { return this.m_Scene; }
            set { this.m_Scene = value; }
        }
        public bool StandBy
        {
            get { return this.m_StandBy; }
            set { this.m_StandBy = value; }
        }
        public bool Heating
        {
            get { return this.m_Heating; }
            set { this.m_Heating = value; }
        }
        public bool Ventilation
        {
            get { return this.m_Ventilation; }
            set { this.m_Ventilation = value; }
        }
        public bool Batch
        {
            get { return this.m_Batch; }
            set { this.m_Batch = value; }
        }
        public bool CmdState
        {
            get { return this.m_CmdState; }
            set { this.m_CmdState = value; }
        }
        public bool CmdSpec
        {
            get { return this.m_CmdSpec; }
            set { this.m_CmdSpec = value; }
        }

        public bool CmdLight
        {
            get { return this.m_CmdLight; }
            set { this.m_CmdLight = value; }
        }
        public bool CmdStandby
        {
            get { return this.m_CmdStandby; }
            set { this.m_CmdStandby = value; }
        }
        public bool CmdHeat
        {
            get { return this.m_CmdHeat; }
            set { this.m_CmdHeat = value; }
        }
        public bool CmdSensor
        {
            get { return this.m_CmdSensor; }
            set { this.m_CmdSensor = value; }
        }
        public bool CmdVent
        {
            get { return this.m_CmdVent; }
            set { this.m_CmdVent = value; }
        }

        /*
         *  
        private bool m_CmdLight;
        private bool m_CmdStandby;
        private bool m_CmdHeat;
        private bool m_CmdSensor;
         */





        public bool CmdCtrlGroup
        {
            get { return this.m_CmdCtrlGroup; }
            set { this.m_CmdCtrlGroup = value; }
        }
        public bool CmdCtrlAll
        {
            get { return this.m_CmdCtrlAll; }
            set { this.m_CmdCtrlAll = value; }
        }
        public bool CmdSetSBPV
        {
            get { return this.m_CmdSetSBPV; }
            set { this.m_CmdSetSBPV = value; }
        }
        public bool CmdGetSBPV
        {
            get { return this.m_CmdGetSBPV; }
            set { this.m_CmdGetSBPV = value; }
        }

        public bool CmdOff
        {
            get { return this.m_CmdOff; }
            set { this.m_CmdOff = value; }
        }

        public string SendData
        {
            get { return this.m_SendData; }
            set { this.m_SendData = value; }
        }
        public List<int> Send
        {
            get { return this.m_Send; }
            set { this.m_Send = value; }
        }
        public string ResponseData
        {
            get { return this.m_ResponseData; }
            set { this.m_ResponseData = value; }
        }
        public List<int> Response
        {
            get { return this.m_Response; }
            set { this.m_Response = value; }
        }

        public bool SwitchLight1_On
        {
            get { return this.m_SwitchLight1_On; }
            set { this.m_SwitchLight1_On = value; }
        }
        public bool SwitchLight2_On
        {
            get { return this.m_SwitchLight2_On; }
            set { this.m_SwitchLight2_On = value; }
        }
        public bool SwitchLight3_On
        {
            get { return this.m_SwitchLight3_On; }
            set { this.m_SwitchLight3_On = value; }
        }
        public bool SwitchLight4_On
        {
            get { return this.m_SwitchLight4_On; }
            set { this.m_SwitchLight4_On = value; }
        }
        public bool SwitchLight5_On
        {
            get { return this.m_SwitchLight5_On; }
            set { this.m_SwitchLight5_On = value; }
        }
        public bool SwitchLight6_On
        {
            get { return this.m_SwitchLight6_On; }
            set { this.m_SwitchLight6_On = value; }
        }
        public bool SwitchStandby1_On
        {
            get { return this.m_SwitchStandby1_On; }
            set { this.m_SwitchStandby1_On = value; }
        }
        public bool SwitchStandby2_On
        {
            get { return this.m_SwitchStandby2_On; }
            set { this.m_SwitchStandby2_On = value; }
        }
        public bool SwitchStandby3_On
        {
            get { return this.m_SwitchStandby3_On; }
            set { this.m_SwitchStandby3_On = value; }
        }
        public bool SwitchStandby4_On
        {
            get { return this.m_SwitchStandby4_On; }
            set { this.m_SwitchStandby4_On = value; }
        }
        public bool SwitchStandby1_Auto
        {
            get { return this.m_SwitchStandby1_Auto; }
            set { this.m_SwitchStandby1_Auto = value; }
        }
        public bool SwitchStandby2_Auto
        {
            get { return this.m_SwitchStandby2_Auto; }
            set { this.m_SwitchStandby2_Auto = value; }
        }
        public bool SwitchStandby3_Auto
        {
            get { return this.m_SwitchStandby3_Auto; }
            set { this.m_SwitchStandby3_Auto = value; }
        }
        public bool SwitchStandby4_Auto
        {
            get { return this.m_SwitchStandby4_Auto; }
            set { this.m_SwitchStandby4_Auto = value; }
        }

        public bool UseLightDimming1
        {
            get { return this.m_UseLightDimming1; }
            set { this.m_UseLightDimming1 = value; }
        }

        public bool UseLightDimming2
        {
            get { return this.m_UseLightDimming2; }
            set { this.m_UseLightDimming2 = value; }
        }

        public bool UseLightDimming3
        {
            get { return this.m_UseLightDimming3; }
            set { this.m_UseLightDimming3 = value; }
        }

        public bool UseLightDimming4
        {
            get { return this.m_UseLightDimming4; }
            set { this.m_UseLightDimming4 = value; }
        }

        public bool UseLightDimming5
        {
            get { return this.m_UseLightDimming5; }
            set { this.m_UseLightDimming5 = value; }
        }

        public bool UseLightDimming6
        {
            get { return this.m_UseLightDimming6; }
            set { this.m_UseLightDimming6 = value; }
        }

        public int DimmingStep
        {
            get { return this.m_DimmingStep; }
            set { this.m_DimmingStep = value; }
        }

        public int SceneStep
        {
            get { return this.m_SceneStep; }
            set { this.m_SceneStep = value; }
        }

        public double StandByPowerValue
        {
            get { return this.m_StandByPowerValue; }
            set { this.m_StandByPowerValue = value; }
        }
        #endregion

        #region Event Handler
        #endregion

        #region Method
        //public string MakeToProtocol(TestVectorSystem testVectorForm, int parkingTestIndex_01, int parkingTestIndex_02, int parkingTestIndex_03, int parkingTestIndex_04)
        //public string MakeToProtocol(TestVectorSystem testVectorForm)
        public string MakeToProtocol(TestVectorSystem testVectorForm, int button_input)
        {
            string ret = string.Empty;

            string dataSend = string.Empty;
            string dataResponse = string.Empty;

            this.Send.Clear();
            this.Response.Clear();
#if true
            switch (this.m_ProtocolIndex)
            {
                case (int)ProtocolKeys.KS:
                    {
                        dataSend = this.SendData_KS(button_input);
                        dataResponse = this.ResponseData_KS();
                    }
                    break;

                case (int)ProtocolKeys.COMMAX:
                    {
                        dataSend = this.SendData_COMMAX();
                        dataResponse = this.ResponseData_COMMAX();
                    }
                    break;

                case (int)ProtocolKeys.CVnet:
                    {
                        dataSend = this.SendData_CVnet();
                        dataResponse = this.ResponseData_CVnet();
                    }
                    break;

                case (int)ProtocolKeys.HyundaiHT://TestVector_Parking
                    {
                        List<int> tempSendList = new List<int>();

                        /* 0A293E421B_B2-C12
                        
                        */

                        //Fix(STX, LEN, VEN, DEV, TYPE, SRV, LOC, CMD)
                        tempSendList.Add(0xF7); //STX
                        tempSendList.Add(0x19); //LEN
                        tempSendList.Add(0x01); //VEN
                        tempSendList.Add(0x44); //DEV
                        tempSendList.Add(0x0C); //TYPE
                        tempSendList.Add(0x63); //SRV
                        tempSendList.Add(0x11); //LOC
                        tempSendList.Add(0x00); //CMD
                        //ARGUMENT_Parking_Time(Year, Month, Day, Hour, Minute, Second)
                        tempSendList.Add(0x19); //Year
                        tempSendList.Add(0x03); //Month
                        tempSendList.Add(0x0B); //Day
                        tempSendList.Add(0x08); //Hour
                        tempSendList.Add(0x3B); //Minute(0x1E : 30min, 0x37 : 55min, 0x3B : 59min)
                        tempSendList.Add(0x00); //Second
                        //ARGUMENT_Parking_CardID
                        tempSendList.Add(0x0A);
                        tempSendList.Add(0x29);
                        tempSendList.Add(0x3E);
                        tempSendList.Add(0x42);
                        tempSendList.Add(0x1B);
                        //ARGUMENT_Parking_ParkingLocation
                        //parkingTestIndex
                        //tempSendList.Add(parkingTestIndex_01); //Floor : ASCII(0x41~0x5A/65~90, 0x61~0x7A/97~122)
                        //tempSendList.Add(parkingTestIndex_02); //Floor
                        //tempSendList.Add(parkingTestIndex_03); //Area : ASCII(0x41~0x5A/65~90, 0x61~0x7A/97~122)
                        //tempSendList.Add(parkingTestIndex_04); //Area
                        tempSendList.Add(0x42); //Floor : ASCII(0x41~0x5A/65~90, 0x61~0x7A/97~122)
                        tempSendList.Add(0x09); //Floor
                        tempSendList.Add(0x7A); //Area : ASCII(0x41~0x5A/65~90, 0x61~0x7A/97~122)
                        tempSendList.Add(0xFF); //Area
                        //CRC
                        int crc = 0;
                        for (int i = 0; i < tempSendList.Count; i++)
                        {
                            crc ^= tempSendList[i];
                        }
                        tempSendList.Add(crc); //CRC
                        //Fix(ETX)
                        tempSendList.Add(0xEE); //ETX(FiX)

                        dataSend = string.Empty;
                        for (int i = 0; i < tempSendList.Count; i++)
                        {
                            if(i != 0)
                            {
                                dataSend += " ";
                            }

                            if(tempSendList[i] < 0x10)
                            {
                                dataSend += "0";
                            }

                            dataSend += tempSendList[i].ToString("X");
                        }

                        //dataResponse += "F7 19 01 44 0C 63 10 00 ";  //Fix(STX, LEN, VEN, DEV, TYPE, SRV, LOC, CMD)
                        //dataResponse += "FF FF FF FF FF FF ";  //ARGUMENT_Parking_Time(Year, Month, Day, Hour, Minute, Second)
                        //dataResponse += "FF FF FF FF FF FF ";  //ARGUMENT_Parking_CardID
                        //dataResponse += "FF FF FF FF FF FF ";  //ARGUMENT_Parking_ParkingLocation
                        //dataResponse += "FF EE";  //CRC, ETX

                        for (int i = 0; i < 5; i++)
                        {
                            if (tempSendList[i+14] < 0x10)
                            {
                                testVectorForm.Test += "0";
                            }

                            testVectorForm.Test += tempSendList[i+14].ToString("X");;
                        }
                        testVectorForm.Test += "_";
                        string subParkingLocation1 = string.Empty;
                        if (tempSendList[19] != 0x00)
                        {
                            if (tempSendList[19] > 0x5A)
                            {
                                testVectorForm.Test += (char)(tempSendList[19]-0x20);
                                subParkingLocation1 += (char)(tempSendList[19] - 0x20);
                            }
                            else
                            {
                                testVectorForm.Test += (char)tempSendList[19];
                                subParkingLocation1 += (char)tempSendList[19];
                            }
                        }
                        else
                        {
                            subParkingLocation1 = "00";
                        }
                        testVectorForm.Test += tempSendList[20].ToString();
                        testVectorForm.Test += "-";
                        string subParkingLocation2 = string.Empty;
                        if (tempSendList[21] != 0x00)
                        {
                            if (tempSendList[21] > 0x5A)
                            {
                                testVectorForm.Test += (char)(tempSendList[21] - 0x20);
                                subParkingLocation2 += (char)(tempSendList[21] - 0x20);
                            }
                            else
                            {
                                testVectorForm.Test += (char)tempSendList[21];
                                subParkingLocation2 += (char)tempSendList[21];
                            }
                        }
                        else
                        {
                            subParkingLocation2 = "00";
                        }
                        if (tempSendList[22] < 100)
                        {
                            testVectorForm.Test += "0";
                        }
                        if (tempSendList[22] < 10)
                        {
                            testVectorForm.Test += "0";
                        }
                        testVectorForm.Test += tempSendList[22].ToString();

                        testVectorForm.Group = "Event_주차";
                        testVectorForm.Ver = subParkingLocation1+"_"+subParkingLocation2;
                    }
                    break;

                default:
                    {
                        ret = string.Empty;
                    }
                    break;
            }
#endif
            if (testVectorForm.IsTestVectorFormUse)
            {
                if (!testVectorForm.GroupLists.Contains(testVectorForm.Group))
                {
                    if (testVectorForm.GroupLists.Count != 0)
                    {
                        ret += "\r\n";
                    }
                    testVectorForm.GroupLists.Add(testVectorForm.Group);
                    string sub_Group = "device_group: " + testVectorForm.Group;
                    ret += sub_Group + "\r\n";

                    testVectorForm.VerLists.Clear();
                }

                if (!testVectorForm.VerLists.Contains(testVectorForm.Ver))
                {
                    testVectorForm.VerLists.Add(testVectorForm.Ver);
                    string sub_Ver = "device_ver: " + testVectorForm.Ver;

                    ret += sub_Ver + "\r\n";
                }

                ret += "test: " + testVectorForm.Test + "\t";

                //Send Data
                testVectorForm.In = dataSend;

                ret += testVectorForm.In + "\tin_end:\t";

                //Response Data
                testVectorForm.Ok = dataResponse;

                ret += testVectorForm.Ok + "\tok_end:\t";

                testVectorForm.Mask = string.Empty;

                ret += testVectorForm.Mask + "mask_end:";
            }
            else
            {
                //Send Data
                ret += DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff") + " S> : ";
                ret += dataSend;

                //ret += "\t";
                ret += "\r\n";

                //Response Data
                ret += DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff") + " R< : ";
                ret += dataResponse;
            }

            this.SendData = dataSend;
            this.ResponseData = dataResponse;

            return ret;
        }

        private int UseLightDimmingCount()
        {
            int ret = 0;

            if (this.UseLightDimming1)
            {
                ret++;
            }

            if (this.UseLightDimming2)
            {
                ret++;
            }

            if (this.UseLightDimming3)
            {
                ret++;
            }

            if (this.UseLightDimming4)
            {
                ret++;
            }

            if (this.UseLightDimming5)
            {
                ret++;
            }

            if (this.UseLightDimming6)
            {
                ret++;
            }

            return ret;
        }

        private int UseLightDimmingBit1()
        {
            int ret = 0;

            if (this.UseLightDimming1)
            {
                ret |= (1 << 0);
            }

            if (this.UseLightDimming2)
            {
                ret |= (1 << 1);
            }

            if (this.UseLightDimming3)
            {
                ret |= (1 << 2);
            }

            if (this.UseLightDimming4)
            {
                ret |= (1 << 3);
            }

            if (this.UseLightDimming5)
            {
                ret |= (1 << 4);
            }

            if (this.UseLightDimming6)
            {
                ret |= (1 << 5);
            }

            if (false)
            {
                ret |= (1 << 6);
            }

            if (false)
            {
                ret |= (1 << 7);
            }

            return ret;
        }

        private int UseLightDimmingBit2()
        {
            int ret = 0;

            if (false)
            {
                ret |= (1 << 0);
            }

            if (false)
            {
                ret |= (1 << 1);
            }

            if (false)
            {
                ret |= (1 << 2);
            }

            if (false)
            {
                ret |= (1 << 3);
            }

            if (false)
            {
                ret |= (1 << 4);
            }

            if (false)
            {
                ret |= (1 << 5);
            }

            if (false)
            {
                ret |= (1 << 6);
            }

            if (false)
            {
                ret |= (1 << 7);
            }

            return ret;
        }
        #endregion

        #region Members
        #endregion
    }
}
