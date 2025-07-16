namespace SKAI_KSBOM_UI_protocol
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            richTextBoxLog = new RichTextBox();
            groupBoxConfiguration = new GroupBox();
            groupBoxCommunication = new GroupBox();
            labelCommunicationRepeatCount = new Label();
            checkBoxCommunicationHex = new CheckBox();
            textBoxCommunicationRepeatCount = new TextBox();
            buttonCommunicationSearch = new Button();
            buttonCommunicationConnection = new Button();
            labelCommunicationBaudrate = new Label();
            labelCommunicationComPort = new Label();
            comboBoxCommunicationBaudrate = new ComboBox();
            comboBoxCommunicationComPort = new ComboBox();
            buttonCommunicationSend = new Button();
            groupBox10 = new GroupBox();
            checkBox_Notice = new CheckBox();
            checkBox_Guest = new CheckBox();
            checkBox_Delivery = new CheckBox();
            button_SendNotice = new Button();
            groupBox3 = new GroupBox();
            checkBoxGasClose = new CheckBox();
            checkBoxGasOpen = new CheckBox();
            button_StatReq = new Button();
            checkBox_ElvCallReq = new CheckBox();
            checkBox_BypassON = new CheckBox();
            checkBox_BatchStatus = new CheckBox();
            checkBox_GasCloseReq = new CheckBox();
            groupBox9 = new GroupBox();
            label_Parking_num = new Label();
            label21 = new Label();
            label16 = new Label();
            textBox_Car2Pos = new TextBox();
            textBox_Car1Pos = new TextBox();
            textBox_Car2Num = new TextBox();
            textBox_Car1Num = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            button_SendParking = new Button();
            label3 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label14 = new Label();
            label13 = new Label();
            groupBox1 = new GroupBox();
            comboBoxProtocols = new ComboBox();
            checkBoxLight = new CheckBox();
            groupBoxExecution = new GroupBox();
            buttonReset = new Button();
            buttonRemove = new Button();
            buttonMake = new Button();
            groupBoxSwitch = new GroupBox();
            textBoxSwitchID = new TextBox();
            labelSwitchID = new Label();
            groupBox4 = new GroupBox();
            button_BatchOn = new Button();
            button_BatchOff = new Button();
            textBoxCommunication = new TextBox();
            groupBox5 = new GroupBox();
            button_GasFail = new Button();
            button_GasDone = new Button();
            button_GasClose = new Button();
            button_GasOpen = new Button();
            groupBox6 = new GroupBox();
            button_ElvArrived = new Button();
            button_ElvFail = new Button();
            button_ElvDone = new Button();
            groupBox2 = new GroupBox();
            button_SendWeather = new Button();
            textBox_WeatherTemp = new TextBox();
            label7 = new Label();
            label6 = new Label();
            checkBox_TempMinus = new CheckBox();
            checkBox_TempPlus = new CheckBox();
            label5 = new Label();
            comboBox_Finedust = new ComboBox();
            comboBox_WeatherCode = new ComboBox();
            groupBox8 = new GroupBox();
            textBox_Second = new TextBox();
            label11 = new Label();
            textBox_Minute = new TextBox();
            label12 = new Label();
            textBox_Hour = new TextBox();
            label15 = new Label();
            textBox_Day = new TextBox();
            label10 = new Label();
            textBox_Month = new TextBox();
            label9 = new Label();
            button_SendTime = new Button();
            textBox_Year = new TextBox();
            label8 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox11 = new GroupBox();
            button_BypassCtrl = new Button();
            checkBoxVol_3 = new CheckBox();
            checkBoxVol_NO = new CheckBox();
            checkBoxVol_2 = new CheckBox();
            checkBoxVol_1 = new CheckBox();
            checkBoxLight_On = new CheckBox();
            checkBoxHeat_Reset = new CheckBox();
            checkBoxIn = new CheckBox();
            label25 = new Label();
            label24 = new Label();
            checkBoxVol_0 = new CheckBox();
            label23 = new Label();
            checkBoxLight_Off = new CheckBox();
            label22 = new Label();
            checkBoxHeat_Set = new CheckBox();
            label20 = new Label();
            checkBoxOut = new CheckBox();
            checkBoxGoWork_Reset = new CheckBox();
            checkBoxGoWork_Set = new CheckBox();
            groupBox12 = new GroupBox();
            button_BypassStat = new Button();
            label_volume = new Label();
            label_elv = new Label();
            label_gas = new Label();
            label_batch = new Label();
            label_AiHeat = new Label();
            label_InOut = new Label();
            label_DataType = new Label();
            label32 = new Label();
            label31 = new Label();
            label30 = new Label();
            label28 = new Label();
            label29 = new Label();
            label27 = new Label();
            label26 = new Label();
            button_Clear = new Button();
            groupBoxConfiguration.SuspendLayout();
            groupBoxCommunication.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxExecution.SuspendLayout();
            groupBoxSwitch.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox11.SuspendLayout();
            groupBox12.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBoxLog
            // 
            richTextBoxLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxLog.BackColor = Color.Black;
            richTextBoxLog.ForeColor = Color.White;
            richTextBoxLog.Location = new Point(153, 3);
            richTextBoxLog.Margin = new Padding(2);
            richTextBoxLog.MinimumSize = new Size(481, 464);
            richTextBoxLog.Name = "richTextBoxLog";
            richTextBoxLog.ReadOnly = true;
            richTextBoxLog.Size = new Size(960, 554);
            richTextBoxLog.TabIndex = 0;
            richTextBoxLog.Text = "";
            richTextBoxLog.KeyDown += Execution_KeyDown;
            // 
            // groupBoxConfiguration
            // 
            groupBoxConfiguration.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxConfiguration.Controls.Add(groupBoxCommunication);
            groupBoxConfiguration.Controls.Add(button_Clear);
            groupBoxConfiguration.Location = new Point(9, 9);
            groupBoxConfiguration.Margin = new Padding(2);
            groupBoxConfiguration.MinimumSize = new Size(100, 485);
            groupBoxConfiguration.Name = "groupBoxConfiguration";
            groupBoxConfiguration.Padding = new Padding(2);
            groupBoxConfiguration.Size = new Size(134, 592);
            groupBoxConfiguration.TabIndex = 100;
            groupBoxConfiguration.TabStop = false;
            groupBoxConfiguration.Text = "Configuration";
            // 
            // groupBoxCommunication
            // 
            groupBoxCommunication.Controls.Add(labelCommunicationRepeatCount);
            groupBoxCommunication.Controls.Add(checkBoxCommunicationHex);
            groupBoxCommunication.Controls.Add(textBoxCommunicationRepeatCount);
            groupBoxCommunication.Controls.Add(buttonCommunicationSearch);
            groupBoxCommunication.Controls.Add(buttonCommunicationConnection);
            groupBoxCommunication.Controls.Add(labelCommunicationBaudrate);
            groupBoxCommunication.Controls.Add(labelCommunicationComPort);
            groupBoxCommunication.Controls.Add(comboBoxCommunicationBaudrate);
            groupBoxCommunication.Controls.Add(comboBoxCommunicationComPort);
            groupBoxCommunication.Controls.Add(buttonCommunicationSend);
            groupBoxCommunication.Location = new Point(5, 15);
            groupBoxCommunication.Name = "groupBoxCommunication";
            groupBoxCommunication.Size = new Size(122, 260);
            groupBoxCommunication.TabIndex = 202;
            groupBoxCommunication.TabStop = false;
            groupBoxCommunication.Text = "Communication";
            // 
            // labelCommunicationRepeatCount
            // 
            labelCommunicationRepeatCount.AutoSize = true;
            labelCommunicationRepeatCount.Location = new Point(8, 166);
            labelCommunicationRepeatCount.MinimumSize = new Size(51, 15);
            labelCommunicationRepeatCount.Name = "labelCommunicationRepeatCount";
            labelCommunicationRepeatCount.Size = new Size(54, 15);
            labelCommunicationRepeatCount.TabIndex = 210;
            labelCommunicationRepeatCount.Text = "Repeat  :";
            // 
            // checkBoxCommunicationHex
            // 
            checkBoxCommunicationHex.AutoSize = true;
            checkBoxCommunicationHex.Checked = true;
            checkBoxCommunicationHex.CheckState = CheckState.Checked;
            checkBoxCommunicationHex.Location = new Point(5, 142);
            checkBoxCommunicationHex.Margin = new Padding(2);
            checkBoxCommunicationHex.Name = "checkBoxCommunicationHex";
            checkBoxCommunicationHex.Size = new Size(48, 19);
            checkBoxCommunicationHex.TabIndex = 205;
            checkBoxCommunicationHex.Text = "HEX";
            checkBoxCommunicationHex.UseVisualStyleBackColor = true;
            checkBoxCommunicationHex.Click += Communication_KS_Click;
            // 
            // textBoxCommunicationRepeatCount
            // 
            textBoxCommunicationRepeatCount.Location = new Point(71, 162);
            textBoxCommunicationRepeatCount.Margin = new Padding(2);
            textBoxCommunicationRepeatCount.Name = "textBoxCommunicationRepeatCount";
            textBoxCommunicationRepeatCount.Size = new Size(42, 23);
            textBoxCommunicationRepeatCount.TabIndex = 207;
            textBoxCommunicationRepeatCount.Text = "1";
            textBoxCommunicationRepeatCount.TextAlign = HorizontalAlignment.Center;
            textBoxCommunicationRepeatCount.TextChanged += TestVectorSystem_TextChanged;
            // 
            // buttonCommunicationSearch
            // 
            buttonCommunicationSearch.Location = new Point(5, 20);
            buttonCommunicationSearch.Margin = new Padding(2);
            buttonCommunicationSearch.Name = "buttonCommunicationSearch";
            buttonCommunicationSearch.Size = new Size(108, 30);
            buttonCommunicationSearch.TabIndex = 209;
            buttonCommunicationSearch.Text = "Search";
            buttonCommunicationSearch.UseVisualStyleBackColor = true;
            buttonCommunicationSearch.Click += Communication_KS_Click;
            // 
            // buttonCommunicationConnection
            // 
            buttonCommunicationConnection.BackColor = Color.Red;
            buttonCommunicationConnection.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            buttonCommunicationConnection.Location = new Point(5, 189);
            buttonCommunicationConnection.Margin = new Padding(2);
            buttonCommunicationConnection.Name = "buttonCommunicationConnection";
            buttonCommunicationConnection.Size = new Size(108, 30);
            buttonCommunicationConnection.TabIndex = 208;
            buttonCommunicationConnection.Text = "Connection";
            buttonCommunicationConnection.UseVisualStyleBackColor = false;
            buttonCommunicationConnection.Click += Communication_KS_Click;
            // 
            // labelCommunicationBaudrate
            // 
            labelCommunicationBaudrate.AutoSize = true;
            labelCommunicationBaudrate.Location = new Point(5, 96);
            labelCommunicationBaudrate.MinimumSize = new Size(51, 15);
            labelCommunicationBaudrate.Name = "labelCommunicationBaudrate";
            labelCommunicationBaudrate.Size = new Size(54, 15);
            labelCommunicationBaudrate.TabIndex = 207;
            labelCommunicationBaudrate.Text = "Baudrate";
            // 
            // labelCommunicationComPort
            // 
            labelCommunicationComPort.AutoSize = true;
            labelCommunicationComPort.Location = new Point(5, 52);
            labelCommunicationComPort.MinimumSize = new Size(51, 15);
            labelCommunicationComPort.Name = "labelCommunicationComPort";
            labelCommunicationComPort.Size = new Size(61, 15);
            labelCommunicationComPort.TabIndex = 206;
            labelCommunicationComPort.Text = "COM Port";
            // 
            // comboBoxCommunicationBaudrate
            // 
            comboBoxCommunicationBaudrate.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCommunicationBaudrate.FormattingEnabled = true;
            comboBoxCommunicationBaudrate.Items.AddRange(new object[] { "1200", "2400", "4800", "9600", "14400", "19200", "28800", "38400", "57600", "115200", "250000", "500000", "1000000" });
            comboBoxCommunicationBaudrate.Location = new Point(5, 114);
            comboBoxCommunicationBaudrate.Name = "comboBoxCommunicationBaudrate";
            comboBoxCommunicationBaudrate.Size = new Size(108, 23);
            comboBoxCommunicationBaudrate.TabIndex = 204;
            // 
            // comboBoxCommunicationComPort
            // 
            comboBoxCommunicationComPort.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCommunicationComPort.FormattingEnabled = true;
            comboBoxCommunicationComPort.Location = new Point(5, 70);
            comboBoxCommunicationComPort.Name = "comboBoxCommunicationComPort";
            comboBoxCommunicationComPort.Size = new Size(108, 23);
            comboBoxCommunicationComPort.TabIndex = 203;
            // 
            // buttonCommunicationSend
            // 
            buttonCommunicationSend.Location = new Point(5, 223);
            buttonCommunicationSend.Margin = new Padding(2);
            buttonCommunicationSend.Name = "buttonCommunicationSend";
            buttonCommunicationSend.Size = new Size(108, 30);
            buttonCommunicationSend.TabIndex = 209;
            buttonCommunicationSend.Text = "Send";
            buttonCommunicationSend.UseVisualStyleBackColor = true;
            buttonCommunicationSend.Click += Communication_KS_Click;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(checkBox_Notice);
            groupBox10.Controls.Add(checkBox_Guest);
            groupBox10.Controls.Add(checkBox_Delivery);
            groupBox10.Controls.Add(button_SendNotice);
            groupBox10.Location = new Point(848, 450);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(181, 86);
            groupBox10.TabIndex = 224;
            groupBox10.TabStop = false;
            groupBox10.Text = "택배/방문자/공지사항 전달";
            groupBox10.Visible = false;
            // 
            // checkBox_Notice
            // 
            checkBox_Notice.AutoSize = true;
            checkBox_Notice.Location = new Point(110, 26);
            checkBox_Notice.Name = "checkBox_Notice";
            checkBox_Notice.Size = new Size(74, 19);
            checkBox_Notice.TabIndex = 0;
            checkBox_Notice.Text = "공지사항";
            checkBox_Notice.UseVisualStyleBackColor = true;
            // 
            // checkBox_Guest
            // 
            checkBox_Guest.AutoSize = true;
            checkBox_Guest.Location = new Point(50, 26);
            checkBox_Guest.Name = "checkBox_Guest";
            checkBox_Guest.Size = new Size(62, 19);
            checkBox_Guest.TabIndex = 0;
            checkBox_Guest.Text = "방문자";
            checkBox_Guest.UseVisualStyleBackColor = true;
            // 
            // checkBox_Delivery
            // 
            checkBox_Delivery.AutoSize = true;
            checkBox_Delivery.Location = new Point(3, 26);
            checkBox_Delivery.Name = "checkBox_Delivery";
            checkBox_Delivery.Size = new Size(50, 19);
            checkBox_Delivery.TabIndex = 0;
            checkBox_Delivery.Text = "택배";
            checkBox_Delivery.UseVisualStyleBackColor = true;
            // 
            // button_SendNotice
            // 
            button_SendNotice.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            button_SendNotice.Location = new Point(8, 51);
            button_SendNotice.Name = "button_SendNotice";
            button_SendNotice.Size = new Size(167, 26);
            button_SendNotice.TabIndex = 1;
            button_SendNotice.Text = "보내기";
            button_SendNotice.UseVisualStyleBackColor = true;
            button_SendNotice.Click += Homenet_Tx_Button_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBoxGasClose);
            groupBox3.Controls.Add(checkBoxGasOpen);
            groupBox3.Controls.Add(button_StatReq);
            groupBox3.Controls.Add(checkBox_ElvCallReq);
            groupBox3.Controls.Add(checkBox_BypassON);
            groupBox3.Controls.Add(checkBox_BatchStatus);
            groupBox3.Controls.Add(checkBox_GasCloseReq);
            groupBox3.Controls.Add(groupBox9);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Font = new Font("맑은 고딕", 9F);
            groupBox3.Location = new Point(853, 293);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(262, 175);
            groupBox3.TabIndex = 220;
            groupBox3.TabStop = false;
            groupBox3.Text = "상태 모니터링";
            groupBox3.Visible = false;
            // 
            // checkBoxGasClose
            // 
            checkBoxGasClose.AutoSize = true;
            checkBoxGasClose.Font = new Font("맑은 고딕", 8F);
            checkBoxGasClose.Location = new Point(120, 22);
            checkBoxGasClose.Margin = new Padding(2);
            checkBoxGasClose.Name = "checkBoxGasClose";
            checkBoxGasClose.Size = new Size(74, 17);
            checkBoxGasClose.TabIndex = 220;
            checkBoxGasClose.Text = "가스 차단";
            checkBoxGasClose.UseVisualStyleBackColor = true;
            checkBoxGasClose.Click += Gas_Status_Click;
            // 
            // checkBoxGasOpen
            // 
            checkBoxGasOpen.AutoSize = true;
            checkBoxGasOpen.Checked = true;
            checkBoxGasOpen.CheckState = CheckState.Checked;
            checkBoxGasOpen.Font = new Font("맑은 고딕", 8F);
            checkBoxGasOpen.Location = new Point(9, 22);
            checkBoxGasOpen.Margin = new Padding(2);
            checkBoxGasOpen.Name = "checkBoxGasOpen";
            checkBoxGasOpen.Size = new Size(74, 17);
            checkBoxGasOpen.TabIndex = 220;
            checkBoxGasOpen.Text = "가스 열림";
            checkBoxGasOpen.UseVisualStyleBackColor = true;
            checkBoxGasOpen.CheckedChanged += checkBoxGasOpen_CheckedChanged;
            checkBoxGasOpen.Click += Gas_Status_Click;
            // 
            // button_StatReq
            // 
            button_StatReq.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            button_StatReq.Location = new Point(5, 47);
            button_StatReq.Margin = new Padding(2);
            button_StatReq.Name = "button_StatReq";
            button_StatReq.Size = new Size(210, 26);
            button_StatReq.TabIndex = 33;
            button_StatReq.Text = "상태요청";
            button_StatReq.UseVisualStyleBackColor = true;
            button_StatReq.Click += Homenet_Tx_Button_Click;
            // 
            // checkBox_ElvCallReq
            // 
            checkBox_ElvCallReq.Appearance = Appearance.Button;
            checkBox_ElvCallReq.AutoSize = true;
            checkBox_ElvCallReq.Location = new Point(73, 144);
            checkBox_ElvCallReq.MinimumSize = new Size(50, 10);
            checkBox_ElvCallReq.Name = "checkBox_ElvCallReq";
            checkBox_ElvCallReq.Size = new Size(50, 25);
            checkBox_ElvCallReq.TabIndex = 32;
            checkBox_ElvCallReq.Text = "--";
            checkBox_ElvCallReq.UseVisualStyleBackColor = true;
            // 
            // checkBox_BypassON
            // 
            checkBox_BypassON.Appearance = Appearance.Button;
            checkBox_BypassON.AutoSize = true;
            checkBox_BypassON.Location = new Point(171, 141);
            checkBox_BypassON.MinimumSize = new Size(50, 10);
            checkBox_BypassON.Name = "checkBox_BypassON";
            checkBox_BypassON.Size = new Size(50, 25);
            checkBox_BypassON.TabIndex = 31;
            checkBox_BypassON.Text = "--";
            checkBox_BypassON.UseVisualStyleBackColor = true;
            // 
            // checkBox_BatchStatus
            // 
            checkBox_BatchStatus.Appearance = Appearance.Button;
            checkBox_BatchStatus.AutoSize = true;
            checkBox_BatchStatus.Location = new Point(171, 116);
            checkBox_BatchStatus.MinimumSize = new Size(50, 10);
            checkBox_BatchStatus.Name = "checkBox_BatchStatus";
            checkBox_BatchStatus.Size = new Size(50, 25);
            checkBox_BatchStatus.TabIndex = 30;
            checkBox_BatchStatus.Text = "--";
            checkBox_BatchStatus.UseVisualStyleBackColor = true;
            // 
            // checkBox_GasCloseReq
            // 
            checkBox_GasCloseReq.Appearance = Appearance.Button;
            checkBox_GasCloseReq.AutoSize = true;
            checkBox_GasCloseReq.BackColor = SystemColors.Control;
            checkBox_GasCloseReq.Location = new Point(73, 117);
            checkBox_GasCloseReq.MinimumSize = new Size(50, 10);
            checkBox_GasCloseReq.Name = "checkBox_GasCloseReq";
            checkBox_GasCloseReq.Size = new Size(50, 25);
            checkBox_GasCloseReq.TabIndex = 29;
            checkBox_GasCloseReq.Text = "--";
            checkBox_GasCloseReq.UseVisualStyleBackColor = false;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(label_Parking_num);
            groupBox9.Controls.Add(label21);
            groupBox9.Controls.Add(label16);
            groupBox9.Controls.Add(textBox_Car2Pos);
            groupBox9.Controls.Add(textBox_Car1Pos);
            groupBox9.Controls.Add(textBox_Car2Num);
            groupBox9.Controls.Add(textBox_Car1Num);
            groupBox9.Controls.Add(label2);
            groupBox9.Controls.Add(label4);
            groupBox9.Controls.Add(label1);
            groupBox9.Controls.Add(button_SendParking);
            groupBox9.Controls.Add(label3);
            groupBox9.Location = new Point(184, 39);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(184, 214);
            groupBox9.TabIndex = 223;
            groupBox9.TabStop = false;
            groupBox9.Text = "주차정보 전달";
            groupBox9.Visible = false;
            groupBox9.Enter += groupBox9_Enter;
            // 
            // label_Parking_num
            // 
            label_Parking_num.AutoSize = true;
            label_Parking_num.Location = new Point(75, 153);
            label_Parking_num.Name = "label_Parking_num";
            label_Parking_num.Size = new Size(17, 15);
            label_Parking_num.TabIndex = 2;
            label_Parking_num.Text = "--";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(98, 153);
            label21.Name = "label21";
            label21.Size = new Size(19, 15);
            label21.TabIndex = 2;
            label21.Text = "대";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(10, 153);
            label16.Name = "label16";
            label16.Size = new Size(59, 15);
            label16.TabIndex = 2;
            label16.Text = "주차 대수";
            // 
            // textBox_Car2Pos
            // 
            textBox_Car2Pos.Location = new Point(71, 110);
            textBox_Car2Pos.Name = "textBox_Car2Pos";
            textBox_Car2Pos.Size = new Size(108, 23);
            textBox_Car2Pos.TabIndex = 1;
            // 
            // textBox_Car1Pos
            // 
            textBox_Car1Pos.Location = new Point(71, 47);
            textBox_Car1Pos.Name = "textBox_Car1Pos";
            textBox_Car1Pos.Size = new Size(108, 23);
            textBox_Car1Pos.TabIndex = 1;
            // 
            // textBox_Car2Num
            // 
            textBox_Car2Num.Location = new Point(71, 83);
            textBox_Car2Num.Name = "textBox_Car2Num";
            textBox_Car2Num.Size = new Size(108, 23);
            textBox_Car2Num.TabIndex = 1;
            // 
            // textBox_Car1Num
            // 
            textBox_Car1Num.Location = new Point(71, 20);
            textBox_Car1Num.Name = "textBox_Car1Num";
            textBox_Car1Num.Size = new Size(108, 23);
            textBox_Car1Num.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 114);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 0;
            label2.Text = "주차위치";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 51);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 0;
            label4.Text = "주차위치";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 87);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "차량번호2";
            // 
            // button_SendParking
            // 
            button_SendParking.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            button_SendParking.Location = new Point(14, 178);
            button_SendParking.Name = "button_SendParking";
            button_SendParking.Size = new Size(164, 26);
            button_SendParking.TabIndex = 1;
            button_SendParking.Text = "보내기";
            button_SendParking.UseVisualStyleBackColor = true;
            button_SendParking.Click += Homenet_Tx_Button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 24);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 0;
            label3.Text = "차량번호1";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("맑은 고딕", 8F);
            label19.Location = new Point(1, 146);
            label19.Name = "label19";
            label19.Size = new Size(73, 13);
            label19.TabIndex = 26;
            label19.Text = "엘콜하강호출";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("맑은 고딕", 8F);
            label18.Location = new Point(125, 146);
            label18.Name = "label18";
            label18.Size = new Size(51, 13);
            label18.TabIndex = 25;
            label18.Text = "바이패스";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("맑은 고딕", 8F);
            label17.Location = new Point(126, 121);
            label17.Name = "label17";
            label17.Size = new Size(29, 13);
            label17.TabIndex = 24;
            label17.Text = "일괄";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("맑은 고딕", 8F);
            label14.Location = new Point(1, 121);
            label14.Name = "label14";
            label14.Size = new Size(73, 13);
            label14.TabIndex = 21;
            label14.Text = "가스잠금요구";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            label13.Location = new Point(9, 96);
            label13.Name = "label13";
            label13.Size = new Size(59, 15);
            label13.TabIndex = 20;
            label13.Text = "상태 응답";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxProtocols);
            groupBox1.Controls.Add(checkBoxLight);
            groupBox1.Location = new Point(914, 209);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(134, 77);
            groupBox1.TabIndex = 203;
            groupBox1.TabStop = false;
            groupBox1.Text = "Protocol";
            groupBox1.Visible = false;
            // 
            // comboBoxProtocols
            // 
            comboBoxProtocols.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProtocols.FormattingEnabled = true;
            comboBoxProtocols.Items.AddRange(new object[] { "KS", "COMMAX", "CVnet", "현대HT" });
            comboBoxProtocols.Location = new Point(6, 22);
            comboBoxProtocols.MinimumSize = new Size(100, 0);
            comboBoxProtocols.Name = "comboBoxProtocols";
            comboBoxProtocols.Size = new Size(100, 23);
            comboBoxProtocols.TabIndex = 132;
            comboBoxProtocols.KeyDown += Protocols_KeyDown;
            // 
            // checkBoxLight
            // 
            checkBoxLight.AutoSize = true;
            checkBoxLight.Checked = true;
            checkBoxLight.CheckState = CheckState.Checked;
            checkBoxLight.Location = new Point(4, 50);
            checkBoxLight.Margin = new Padding(2);
            checkBoxLight.Name = "checkBoxLight";
            checkBoxLight.Size = new Size(86, 19);
            checkBoxLight.TabIndex = 133;
            checkBoxLight.Text = "생활정보기";
            checkBoxLight.UseVisualStyleBackColor = true;
            // 
            // groupBoxExecution
            // 
            groupBoxExecution.Controls.Add(buttonReset);
            groupBoxExecution.Controls.Add(buttonRemove);
            groupBoxExecution.Controls.Add(buttonMake);
            groupBoxExecution.Location = new Point(913, 82);
            groupBoxExecution.Margin = new Padding(2);
            groupBoxExecution.MinimumSize = new Size(122, 122);
            groupBoxExecution.Name = "groupBoxExecution";
            groupBoxExecution.Padding = new Padding(2);
            groupBoxExecution.Size = new Size(128, 122);
            groupBoxExecution.TabIndex = 200;
            groupBoxExecution.TabStop = false;
            groupBoxExecution.Text = "Execution";
            groupBoxExecution.Visible = false;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(5, 87);
            buttonReset.Margin = new Padding(2);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(108, 30);
            buttonReset.TabIndex = 203;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += Execution_Click;
            buttonReset.KeyDown += Execution_KeyDown;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(5, 52);
            buttonRemove.Margin = new Padding(2);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(108, 30);
            buttonRemove.TabIndex = 202;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += Execution_Click;
            buttonRemove.KeyDown += Execution_KeyDown;
            // 
            // buttonMake
            // 
            buttonMake.Location = new Point(5, 18);
            buttonMake.Margin = new Padding(2);
            buttonMake.Name = "buttonMake";
            buttonMake.Size = new Size(108, 30);
            buttonMake.TabIndex = 201;
            buttonMake.Text = "Make";
            buttonMake.UseVisualStyleBackColor = true;
            buttonMake.Visible = false;
            buttonMake.Click += Execution_Click;
            buttonMake.KeyDown += Execution_KeyDown;
            // 
            // groupBoxSwitch
            // 
            groupBoxSwitch.Controls.Add(textBoxSwitchID);
            groupBoxSwitch.Controls.Add(labelSwitchID);
            groupBoxSwitch.Location = new Point(913, 24);
            groupBoxSwitch.Margin = new Padding(2);
            groupBoxSwitch.MinimumSize = new Size(128, 56);
            groupBoxSwitch.Name = "groupBoxSwitch";
            groupBoxSwitch.Padding = new Padding(2);
            groupBoxSwitch.Size = new Size(128, 56);
            groupBoxSwitch.TabIndex = 110;
            groupBoxSwitch.TabStop = false;
            groupBoxSwitch.Text = "Switch";
            groupBoxSwitch.Visible = false;
            // 
            // textBoxSwitchID
            // 
            textBoxSwitchID.Location = new Point(67, 23);
            textBoxSwitchID.Margin = new Padding(2);
            textBoxSwitchID.Name = "textBoxSwitchID";
            textBoxSwitchID.Size = new Size(55, 23);
            textBoxSwitchID.TabIndex = 112;
            textBoxSwitchID.Text = "01";
            textBoxSwitchID.TextAlign = HorizontalAlignment.Center;
            textBoxSwitchID.Leave += TestVectorSystem_TextChanged;
            // 
            // labelSwitchID
            // 
            labelSwitchID.AutoSize = true;
            labelSwitchID.Location = new Point(5, 26);
            labelSwitchID.MinimumSize = new Size(51, 15);
            labelSwitchID.Name = "labelSwitchID";
            labelSwitchID.Size = new Size(58, 15);
            labelSwitchID.TabIndex = 111;
            labelSwitchID.Text = "        ID :";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button_BatchOn);
            groupBox4.Controls.Add(button_BatchOff);
            groupBox4.Location = new Point(1046, 9);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(181, 58);
            groupBox4.TabIndex = 220;
            groupBox4.TabStop = false;
            groupBox4.Text = "일괄제어";
            groupBox4.Visible = false;
            // 
            // button_BatchOn
            // 
            button_BatchOn.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            button_BatchOn.Location = new Point(91, 17);
            button_BatchOn.Name = "button_BatchOn";
            button_BatchOn.Size = new Size(75, 26);
            button_BatchOn.TabIndex = 0;
            button_BatchOn.Text = "일괄점등";
            button_BatchOn.UseVisualStyleBackColor = true;
            button_BatchOn.Click += Homenet_Tx_Button_Click;
            // 
            // button_BatchOff
            // 
            button_BatchOff.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            button_BatchOff.Location = new Point(11, 17);
            button_BatchOff.Name = "button_BatchOff";
            button_BatchOff.Size = new Size(75, 26);
            button_BatchOff.TabIndex = 0;
            button_BatchOff.Text = "일괄소등";
            button_BatchOff.UseVisualStyleBackColor = true;
            button_BatchOff.Click += Homenet_Tx_Button_Click;
            // 
            // textBoxCommunication
            // 
            textBoxCommunication.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCommunication.Location = new Point(708, 13);
            textBoxCommunication.Margin = new Padding(2);
            textBoxCommunication.MinimumSize = new Size(400, 23);
            textBoxCommunication.Name = "textBoxCommunication";
            textBoxCommunication.Size = new Size(400, 23);
            textBoxCommunication.TabIndex = 201;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button_GasFail);
            groupBox5.Controls.Add(button_GasDone);
            groupBox5.Controls.Add(button_GasClose);
            groupBox5.Controls.Add(button_GasOpen);
            groupBox5.Location = new Point(1046, 70);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(181, 91);
            groupBox5.TabIndex = 220;
            groupBox5.TabStop = false;
            groupBox5.Text = "가스 제어";
            groupBox5.Visible = false;
            // 
            // button_GasFail
            // 
            button_GasFail.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            button_GasFail.Location = new Point(95, 54);
            button_GasFail.Name = "button_GasFail";
            button_GasFail.Size = new Size(75, 26);
            button_GasFail.TabIndex = 1;
            button_GasFail.Text = "차단실패";
            button_GasFail.UseVisualStyleBackColor = true;
            button_GasFail.Click += Homenet_Tx_Button_Click;
            // 
            // button_GasDone
            // 
            button_GasDone.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            button_GasDone.Location = new Point(11, 52);
            button_GasDone.Name = "button_GasDone";
            button_GasDone.Size = new Size(75, 26);
            button_GasDone.TabIndex = 1;
            button_GasDone.Text = "차단성공";
            button_GasDone.UseVisualStyleBackColor = true;
            button_GasDone.Click += Homenet_Tx_Button_Click;
            // 
            // button_GasClose
            // 
            button_GasClose.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            button_GasClose.Location = new Point(95, 17);
            button_GasClose.Name = "button_GasClose";
            button_GasClose.Size = new Size(75, 26);
            button_GasClose.TabIndex = 0;
            button_GasClose.Text = "가스닫힘";
            button_GasClose.UseVisualStyleBackColor = true;
            button_GasClose.Click += Homenet_Tx_Button_Click;
            // 
            // button_GasOpen
            // 
            button_GasOpen.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            button_GasOpen.Location = new Point(11, 17);
            button_GasOpen.Name = "button_GasOpen";
            button_GasOpen.Size = new Size(75, 26);
            button_GasOpen.TabIndex = 0;
            button_GasOpen.Text = "가스열림";
            button_GasOpen.UseVisualStyleBackColor = true;
            button_GasOpen.Click += Homenet_Tx_Button_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(button_ElvArrived);
            groupBox6.Controls.Add(button_ElvFail);
            groupBox6.Controls.Add(button_ElvDone);
            groupBox6.Location = new Point(1046, 166);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(181, 85);
            groupBox6.TabIndex = 220;
            groupBox6.TabStop = false;
            groupBox6.Text = "엘콜 제어";
            groupBox6.Visible = false;
            // 
            // button_ElvArrived
            // 
            button_ElvArrived.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            button_ElvArrived.Location = new Point(11, 52);
            button_ElvArrived.Name = "button_ElvArrived";
            button_ElvArrived.Size = new Size(75, 26);
            button_ElvArrived.TabIndex = 1;
            button_ElvArrived.Text = "도착";
            button_ElvArrived.UseVisualStyleBackColor = true;
            button_ElvArrived.Click += Homenet_Tx_Button_Click;
            // 
            // button_ElvFail
            // 
            button_ElvFail.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            button_ElvFail.Location = new Point(95, 17);
            button_ElvFail.Name = "button_ElvFail";
            button_ElvFail.Size = new Size(75, 26);
            button_ElvFail.TabIndex = 0;
            button_ElvFail.Text = "호출실패";
            button_ElvFail.UseVisualStyleBackColor = true;
            button_ElvFail.Click += Homenet_Tx_Button_Click;
            // 
            // button_ElvDone
            // 
            button_ElvDone.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            button_ElvDone.Location = new Point(11, 17);
            button_ElvDone.Name = "button_ElvDone";
            button_ElvDone.Size = new Size(75, 26);
            button_ElvDone.TabIndex = 0;
            button_ElvDone.Text = "호출성공";
            button_ElvDone.UseVisualStyleBackColor = true;
            button_ElvDone.Click += Homenet_Tx_Button_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button_SendWeather);
            groupBox2.Controls.Add(textBox_WeatherTemp);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(checkBox_TempMinus);
            groupBox2.Controls.Add(checkBox_TempPlus);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(comboBox_Finedust);
            groupBox2.Controls.Add(comboBox_WeatherCode);
            groupBox2.Location = new Point(1233, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(215, 181);
            groupBox2.TabIndex = 221;
            groupBox2.TabStop = false;
            groupBox2.Text = "날씨정보 전달";
            groupBox2.Visible = false;
            // 
            // button_SendWeather
            // 
            button_SendWeather.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            button_SendWeather.Location = new Point(10, 149);
            button_SendWeather.Name = "button_SendWeather";
            button_SendWeather.Size = new Size(194, 26);
            button_SendWeather.TabIndex = 1;
            button_SendWeather.Text = "보내기";
            button_SendWeather.UseVisualStyleBackColor = true;
            button_SendWeather.Click += Homenet_Tx_Button_Click;
            // 
            // textBox_WeatherTemp
            // 
            textBox_WeatherTemp.Location = new Point(135, 63);
            textBox_WeatherTemp.Name = "textBox_WeatherTemp";
            textBox_WeatherTemp.Size = new Size(60, 23);
            textBox_WeatherTemp.TabIndex = 4;
            textBox_WeatherTemp.Text = "25";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 117);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 3;
            label7.Text = "미세먼지";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 65);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 3;
            label6.Text = "온도";
            // 
            // checkBox_TempMinus
            // 
            checkBox_TempMinus.AutoSize = true;
            checkBox_TempMinus.Location = new Point(79, 81);
            checkBox_TempMinus.Name = "checkBox_TempMinus";
            checkBox_TempMinus.Size = new Size(50, 19);
            checkBox_TempMinus.TabIndex = 2;
            checkBox_TempMinus.Text = "영하";
            checkBox_TempMinus.UseVisualStyleBackColor = true;
            checkBox_TempMinus.Click += Temp_Sign_Click;
            // 
            // checkBox_TempPlus
            // 
            checkBox_TempPlus.AutoSize = true;
            checkBox_TempPlus.Checked = true;
            checkBox_TempPlus.CheckState = CheckState.Checked;
            checkBox_TempPlus.Location = new Point(79, 63);
            checkBox_TempPlus.Name = "checkBox_TempPlus";
            checkBox_TempPlus.Size = new Size(50, 19);
            checkBox_TempPlus.TabIndex = 2;
            checkBox_TempPlus.Text = "영상";
            checkBox_TempPlus.UseVisualStyleBackColor = true;
            checkBox_TempPlus.Click += Temp_Sign_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 20);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 1;
            label5.Text = "날씨 코드";
            // 
            // comboBox_Finedust
            // 
            comboBox_Finedust.FormattingEnabled = true;
            comboBox_Finedust.Items.AddRange(new object[] { "0x10: 좋음", "0x20: 보통", "0x40: 나쁨", "0x80: 매우나쁨", "0xF0: 지원안함" });
            comboBox_Finedust.Location = new Point(77, 114);
            comboBox_Finedust.Name = "comboBox_Finedust";
            comboBox_Finedust.Size = new Size(121, 23);
            comboBox_Finedust.TabIndex = 0;
            // 
            // comboBox_WeatherCode
            // 
            comboBox_WeatherCode.FormattingEnabled = true;
            comboBox_WeatherCode.Items.AddRange(new object[] { "0x01: 맑음", "0x02: 구름조금", "0x03: 구름많음", "0x04: 흐림", "0x05: 흐리고 비", "0x06: 흐리고 눈", "0x07: 비온후 갬", "0x08: 소나기", "0x09: 비 또는 눈", "0x0A: 눈 또는 비", "0x0B: 천둥번개", "0x0C: 안개" });
            comboBox_WeatherCode.Location = new Point(77, 16);
            comboBox_WeatherCode.Name = "comboBox_WeatherCode";
            comboBox_WeatherCode.Size = new Size(121, 23);
            comboBox_WeatherCode.TabIndex = 0;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(textBox_Second);
            groupBox8.Controls.Add(label11);
            groupBox8.Controls.Add(textBox_Minute);
            groupBox8.Controls.Add(label12);
            groupBox8.Controls.Add(textBox_Hour);
            groupBox8.Controls.Add(label15);
            groupBox8.Controls.Add(textBox_Day);
            groupBox8.Controls.Add(label10);
            groupBox8.Controls.Add(textBox_Month);
            groupBox8.Controls.Add(label9);
            groupBox8.Controls.Add(button_SendTime);
            groupBox8.Controls.Add(textBox_Year);
            groupBox8.Controls.Add(label8);
            groupBox8.Location = new Point(1046, 259);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(181, 121);
            groupBox8.TabIndex = 222;
            groupBox8.TabStop = false;
            groupBox8.Text = "시간정보 전달";
            groupBox8.Visible = false;
            // 
            // textBox_Second
            // 
            textBox_Second.Location = new Point(122, 51);
            textBox_Second.Name = "textBox_Second";
            textBox_Second.Size = new Size(28, 23);
            textBox_Second.TabIndex = 14;
            textBox_Second.Text = "--";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(151, 55);
            label11.Name = "label11";
            label11.Size = new Size(19, 15);
            label11.TabIndex = 13;
            label11.Text = "초";
            // 
            // textBox_Minute
            // 
            textBox_Minute.Location = new Point(66, 51);
            textBox_Minute.Name = "textBox_Minute";
            textBox_Minute.Size = new Size(28, 23);
            textBox_Minute.TabIndex = 12;
            textBox_Minute.Text = "--";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(93, 55);
            label12.Name = "label12";
            label12.Size = new Size(19, 15);
            label12.TabIndex = 11;
            label12.Text = "분";
            // 
            // textBox_Hour
            // 
            textBox_Hour.Location = new Point(12, 51);
            textBox_Hour.Name = "textBox_Hour";
            textBox_Hour.Size = new Size(28, 23);
            textBox_Hour.TabIndex = 10;
            textBox_Hour.Text = "--";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(37, 55);
            label15.Name = "label15";
            label15.Size = new Size(19, 15);
            label15.TabIndex = 9;
            label15.Text = "시";
            // 
            // textBox_Day
            // 
            textBox_Day.Location = new Point(122, 24);
            textBox_Day.Name = "textBox_Day";
            textBox_Day.Size = new Size(28, 23);
            textBox_Day.TabIndex = 8;
            textBox_Day.Text = "--";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(151, 28);
            label10.Name = "label10";
            label10.Size = new Size(19, 15);
            label10.TabIndex = 7;
            label10.Text = "일";
            // 
            // textBox_Month
            // 
            textBox_Month.Location = new Point(66, 24);
            textBox_Month.Name = "textBox_Month";
            textBox_Month.Size = new Size(28, 23);
            textBox_Month.TabIndex = 6;
            textBox_Month.Text = "--";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(93, 28);
            label9.Name = "label9";
            label9.Size = new Size(19, 15);
            label9.TabIndex = 5;
            label9.Text = "월";
            // 
            // button_SendTime
            // 
            button_SendTime.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            button_SendTime.Location = new Point(12, 83);
            button_SendTime.Name = "button_SendTime";
            button_SendTime.Size = new Size(164, 26);
            button_SendTime.TabIndex = 1;
            button_SendTime.Text = "보내기";
            button_SendTime.UseVisualStyleBackColor = true;
            button_SendTime.Click += Homenet_Tx_Button_Click;
            // 
            // textBox_Year
            // 
            textBox_Year.Location = new Point(12, 24);
            textBox_Year.Name = "textBox_Year";
            textBox_Year.Size = new Size(28, 23);
            textBox_Year.TabIndex = 4;
            textBox_Year.Text = "--";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(37, 28);
            label8.Name = "label8";
            label8.Size = new Size(19, 15);
            label8.TabIndex = 3;
            label8.Text = "년";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += Timer1_1s_Tick;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(button_BypassCtrl);
            groupBox11.Controls.Add(checkBoxVol_3);
            groupBox11.Controls.Add(checkBoxVol_NO);
            groupBox11.Controls.Add(checkBoxVol_2);
            groupBox11.Controls.Add(checkBoxVol_1);
            groupBox11.Controls.Add(checkBoxLight_On);
            groupBox11.Controls.Add(checkBoxHeat_Reset);
            groupBox11.Controls.Add(checkBoxIn);
            groupBox11.Controls.Add(label25);
            groupBox11.Controls.Add(label24);
            groupBox11.Controls.Add(checkBoxVol_0);
            groupBox11.Controls.Add(label23);
            groupBox11.Controls.Add(checkBoxLight_Off);
            groupBox11.Controls.Add(label22);
            groupBox11.Controls.Add(checkBoxHeat_Set);
            groupBox11.Controls.Add(label20);
            groupBox11.Controls.Add(checkBoxOut);
            groupBox11.Controls.Add(checkBoxGoWork_Reset);
            groupBox11.Controls.Add(checkBoxGoWork_Set);
            groupBox11.Location = new Point(1233, 369);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(213, 225);
            groupBox11.TabIndex = 224;
            groupBox11.TabStop = false;
            groupBox11.Text = "Bypass 제어";
            groupBox11.Visible = false;
            // 
            // button_BypassCtrl
            // 
            button_BypassCtrl.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            button_BypassCtrl.Location = new Point(12, 187);
            button_BypassCtrl.Name = "button_BypassCtrl";
            button_BypassCtrl.Size = new Size(194, 26);
            button_BypassCtrl.TabIndex = 1;
            button_BypassCtrl.Text = "보내기";
            button_BypassCtrl.UseVisualStyleBackColor = true;
            button_BypassCtrl.Click += Homenet_Tx_Button_Click;
            // 
            // checkBoxVol_3
            // 
            checkBoxVol_3.AutoSize = true;
            checkBoxVol_3.Checked = true;
            checkBoxVol_3.CheckState = CheckState.Checked;
            checkBoxVol_3.Font = new Font("맑은 고딕", 8F);
            checkBoxVol_3.Location = new Point(128, 150);
            checkBoxVol_3.Margin = new Padding(2);
            checkBoxVol_3.Name = "checkBoxVol_3";
            checkBoxVol_3.RightToLeft = RightToLeft.No;
            checkBoxVol_3.Size = new Size(63, 17);
            checkBoxVol_3.TabIndex = 221;
            checkBoxVol_3.Text = "음량 대";
            checkBoxVol_3.UseVisualStyleBackColor = true;
            checkBoxVol_3.Click += Bypass_CheckBox_Click;
            // 
            // checkBoxVol_NO
            // 
            checkBoxVol_NO.AutoSize = true;
            checkBoxVol_NO.Font = new Font("맑은 고딕", 8F);
            checkBoxVol_NO.Location = new Point(68, 171);
            checkBoxVol_NO.Margin = new Padding(2);
            checkBoxVol_NO.Name = "checkBoxVol_NO";
            checkBoxVol_NO.Size = new Size(70, 17);
            checkBoxVol_NO.TabIndex = 222;
            checkBoxVol_NO.Text = "기능없음";
            checkBoxVol_NO.UseVisualStyleBackColor = true;
            checkBoxVol_NO.Click += Bypass_CheckBox_Click;
            // 
            // checkBoxVol_2
            // 
            checkBoxVol_2.AutoSize = true;
            checkBoxVol_2.Font = new Font("맑은 고딕", 8F);
            checkBoxVol_2.Location = new Point(68, 150);
            checkBoxVol_2.Margin = new Padding(2);
            checkBoxVol_2.Name = "checkBoxVol_2";
            checkBoxVol_2.Size = new Size(63, 17);
            checkBoxVol_2.TabIndex = 222;
            checkBoxVol_2.Text = "음량 중";
            checkBoxVol_2.UseVisualStyleBackColor = true;
            checkBoxVol_2.Click += Bypass_CheckBox_Click;
            // 
            // checkBoxVol_1
            // 
            checkBoxVol_1.AutoSize = true;
            checkBoxVol_1.Font = new Font("맑은 고딕", 8F);
            checkBoxVol_1.Location = new Point(128, 132);
            checkBoxVol_1.Margin = new Padding(2);
            checkBoxVol_1.Name = "checkBoxVol_1";
            checkBoxVol_1.RightToLeft = RightToLeft.No;
            checkBoxVol_1.Size = new Size(63, 17);
            checkBoxVol_1.TabIndex = 220;
            checkBoxVol_1.Text = "음량 소";
            checkBoxVol_1.UseVisualStyleBackColor = true;
            checkBoxVol_1.Click += Bypass_CheckBox_Click;
            // 
            // checkBoxLight_On
            // 
            checkBoxLight_On.AutoSize = true;
            checkBoxLight_On.Font = new Font("맑은 고딕", 8F);
            checkBoxLight_On.Location = new Point(128, 102);
            checkBoxLight_On.Margin = new Padding(2);
            checkBoxLight_On.Name = "checkBoxLight_On";
            checkBoxLight_On.RightToLeft = RightToLeft.No;
            checkBoxLight_On.Size = new Size(48, 17);
            checkBoxLight_On.TabIndex = 220;
            checkBoxLight_On.Text = "점등";
            checkBoxLight_On.UseVisualStyleBackColor = true;
            checkBoxLight_On.Click += Bypass_CheckBox_Click;
            // 
            // checkBoxHeat_Reset
            // 
            checkBoxHeat_Reset.AutoSize = true;
            checkBoxHeat_Reset.Font = new Font("맑은 고딕", 8F);
            checkBoxHeat_Reset.Location = new Point(128, 77);
            checkBoxHeat_Reset.Margin = new Padding(2);
            checkBoxHeat_Reset.Name = "checkBoxHeat_Reset";
            checkBoxHeat_Reset.RightToLeft = RightToLeft.No;
            checkBoxHeat_Reset.Size = new Size(70, 17);
            checkBoxHeat_Reset.TabIndex = 220;
            checkBoxHeat_Reset.Text = "동작없음";
            checkBoxHeat_Reset.UseVisualStyleBackColor = true;
            checkBoxHeat_Reset.Click += Bypass_CheckBox_Click;
            // 
            // checkBoxIn
            // 
            checkBoxIn.AutoSize = true;
            checkBoxIn.Font = new Font("맑은 고딕", 8F);
            checkBoxIn.Location = new Point(128, 51);
            checkBoxIn.Margin = new Padding(2);
            checkBoxIn.Name = "checkBoxIn";
            checkBoxIn.RightToLeft = RightToLeft.No;
            checkBoxIn.Size = new Size(48, 17);
            checkBoxIn.TabIndex = 220;
            checkBoxIn.Text = "귀가";
            checkBoxIn.UseVisualStyleBackColor = true;
            checkBoxIn.Click += Bypass_CheckBox_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(8, 133);
            label25.Name = "label25";
            label25.Size = new Size(31, 15);
            label25.TabIndex = 3;
            label25.Text = "음량";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(8, 103);
            label24.Name = "label24";
            label24.Size = new Size(31, 15);
            label24.TabIndex = 3;
            label24.Text = "일괄";
            // 
            // checkBoxVol_0
            // 
            checkBoxVol_0.AutoSize = true;
            checkBoxVol_0.Font = new Font("맑은 고딕", 8F);
            checkBoxVol_0.Location = new Point(68, 132);
            checkBoxVol_0.Margin = new Padding(2);
            checkBoxVol_0.Name = "checkBoxVol_0";
            checkBoxVol_0.Size = new Size(59, 17);
            checkBoxVol_0.TabIndex = 220;
            checkBoxVol_0.Text = "음소거";
            checkBoxVol_0.UseVisualStyleBackColor = true;
            checkBoxVol_0.Click += Bypass_CheckBox_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(8, 78);
            label23.Name = "label23";
            label23.Size = new Size(55, 15);
            label23.TabIndex = 3;
            label23.Text = "외출난방";
            // 
            // checkBoxLight_Off
            // 
            checkBoxLight_Off.AutoSize = true;
            checkBoxLight_Off.Checked = true;
            checkBoxLight_Off.CheckState = CheckState.Checked;
            checkBoxLight_Off.Font = new Font("맑은 고딕", 8F);
            checkBoxLight_Off.Location = new Point(68, 102);
            checkBoxLight_Off.Margin = new Padding(2);
            checkBoxLight_Off.Name = "checkBoxLight_Off";
            checkBoxLight_Off.Size = new Size(48, 17);
            checkBoxLight_Off.TabIndex = 220;
            checkBoxLight_Off.Text = "소등";
            checkBoxLight_Off.UseVisualStyleBackColor = true;
            checkBoxLight_Off.Click += Bypass_CheckBox_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(8, 52);
            label22.Name = "label22";
            label22.Size = new Size(60, 15);
            label22.TabIndex = 3;
            label22.Text = "외출/귀가";
            // 
            // checkBoxHeat_Set
            // 
            checkBoxHeat_Set.AutoSize = true;
            checkBoxHeat_Set.Checked = true;
            checkBoxHeat_Set.CheckState = CheckState.Checked;
            checkBoxHeat_Set.Font = new Font("맑은 고딕", 8F);
            checkBoxHeat_Set.Location = new Point(68, 77);
            checkBoxHeat_Set.Margin = new Padding(2);
            checkBoxHeat_Set.Name = "checkBoxHeat_Set";
            checkBoxHeat_Set.Size = new Size(48, 17);
            checkBoxHeat_Set.TabIndex = 220;
            checkBoxHeat_Set.Text = "동작";
            checkBoxHeat_Set.UseVisualStyleBackColor = true;
            checkBoxHeat_Set.Click += Bypass_CheckBox_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(8, 25);
            label20.Name = "label20";
            label20.Size = new Size(55, 15);
            label20.TabIndex = 3;
            label20.Text = "출근안내";
            // 
            // checkBoxOut
            // 
            checkBoxOut.AutoSize = true;
            checkBoxOut.Checked = true;
            checkBoxOut.CheckState = CheckState.Checked;
            checkBoxOut.Font = new Font("맑은 고딕", 8F);
            checkBoxOut.Location = new Point(68, 51);
            checkBoxOut.Margin = new Padding(2);
            checkBoxOut.Name = "checkBoxOut";
            checkBoxOut.Size = new Size(48, 17);
            checkBoxOut.TabIndex = 220;
            checkBoxOut.Text = "외출";
            checkBoxOut.UseVisualStyleBackColor = true;
            checkBoxOut.Click += Bypass_CheckBox_Click;
            // 
            // checkBoxGoWork_Reset
            // 
            checkBoxGoWork_Reset.AutoSize = true;
            checkBoxGoWork_Reset.Checked = true;
            checkBoxGoWork_Reset.CheckState = CheckState.Checked;
            checkBoxGoWork_Reset.Font = new Font("맑은 고딕", 8F);
            checkBoxGoWork_Reset.Location = new Point(128, 24);
            checkBoxGoWork_Reset.Margin = new Padding(2);
            checkBoxGoWork_Reset.Name = "checkBoxGoWork_Reset";
            checkBoxGoWork_Reset.Size = new Size(59, 17);
            checkBoxGoWork_Reset.TabIndex = 220;
            checkBoxGoWork_Reset.Text = "미사용";
            checkBoxGoWork_Reset.UseVisualStyleBackColor = true;
            checkBoxGoWork_Reset.Click += Bypass_CheckBox_Click;
            // 
            // checkBoxGoWork_Set
            // 
            checkBoxGoWork_Set.AutoSize = true;
            checkBoxGoWork_Set.Font = new Font("맑은 고딕", 8F);
            checkBoxGoWork_Set.Location = new Point(68, 24);
            checkBoxGoWork_Set.Margin = new Padding(2);
            checkBoxGoWork_Set.Name = "checkBoxGoWork_Set";
            checkBoxGoWork_Set.Size = new Size(48, 17);
            checkBoxGoWork_Set.TabIndex = 220;
            checkBoxGoWork_Set.Text = "사용";
            checkBoxGoWork_Set.UseVisualStyleBackColor = true;
            checkBoxGoWork_Set.Click += Bypass_CheckBox_Click;
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(button_BypassStat);
            groupBox12.Controls.Add(label_volume);
            groupBox12.Controls.Add(label_elv);
            groupBox12.Controls.Add(label_gas);
            groupBox12.Controls.Add(label_batch);
            groupBox12.Controls.Add(label_AiHeat);
            groupBox12.Controls.Add(label_InOut);
            groupBox12.Controls.Add(label_DataType);
            groupBox12.Controls.Add(label32);
            groupBox12.Controls.Add(label31);
            groupBox12.Controls.Add(label30);
            groupBox12.Controls.Add(label28);
            groupBox12.Controls.Add(label29);
            groupBox12.Controls.Add(label27);
            groupBox12.Controls.Add(label26);
            groupBox12.Location = new Point(1234, 199);
            groupBox12.Name = "groupBox12";
            groupBox12.Size = new Size(214, 164);
            groupBox12.TabIndex = 225;
            groupBox12.TabStop = false;
            groupBox12.Text = "Bypass 상태";
            groupBox12.Visible = false;
            // 
            // button_BypassStat
            // 
            button_BypassStat.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            button_BypassStat.Location = new Point(154, 20);
            button_BypassStat.Name = "button_BypassStat";
            button_BypassStat.Size = new Size(54, 134);
            button_BypassStat.TabIndex = 1;
            button_BypassStat.Text = "상태요청";
            button_BypassStat.UseVisualStyleBackColor = true;
            button_BypassStat.Visible = false;
            button_BypassStat.Click += Homenet_Tx_Button_Click;
            // 
            // label_volume
            // 
            label_volume.AutoSize = true;
            label_volume.Location = new Point(95, 144);
            label_volume.Name = "label_volume";
            label_volume.Size = new Size(17, 15);
            label_volume.TabIndex = 4;
            label_volume.Text = "--";
            // 
            // label_elv
            // 
            label_elv.AutoSize = true;
            label_elv.Location = new Point(95, 124);
            label_elv.Name = "label_elv";
            label_elv.Size = new Size(17, 15);
            label_elv.TabIndex = 5;
            label_elv.Text = "--";
            // 
            // label_gas
            // 
            label_gas.AutoSize = true;
            label_gas.Location = new Point(95, 104);
            label_gas.Name = "label_gas";
            label_gas.Size = new Size(17, 15);
            label_gas.TabIndex = 6;
            label_gas.Text = "--";
            // 
            // label_batch
            // 
            label_batch.AutoSize = true;
            label_batch.Location = new Point(95, 84);
            label_batch.Name = "label_batch";
            label_batch.Size = new Size(17, 15);
            label_batch.TabIndex = 7;
            label_batch.Text = "--";
            // 
            // label_AiHeat
            // 
            label_AiHeat.AutoSize = true;
            label_AiHeat.Location = new Point(95, 64);
            label_AiHeat.Name = "label_AiHeat";
            label_AiHeat.Size = new Size(17, 15);
            label_AiHeat.TabIndex = 8;
            label_AiHeat.Text = "--";
            // 
            // label_InOut
            // 
            label_InOut.AutoSize = true;
            label_InOut.Location = new Point(95, 44);
            label_InOut.Name = "label_InOut";
            label_InOut.Size = new Size(17, 15);
            label_InOut.TabIndex = 9;
            label_InOut.Text = "--";
            // 
            // label_DataType
            // 
            label_DataType.AutoSize = true;
            label_DataType.Location = new Point(95, 24);
            label_DataType.Name = "label_DataType";
            label_DataType.Size = new Size(17, 15);
            label_DataType.TabIndex = 10;
            label_DataType.Text = "--";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(9, 143);
            label32.Name = "label32";
            label32.Size = new Size(46, 15);
            label32.TabIndex = 3;
            label32.Text = "음량  : ";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(9, 123);
            label31.Name = "label31";
            label31.Size = new Size(78, 15);
            label31.TabIndex = 3;
            label31.Text = "엘리베이터 : ";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(9, 103);
            label30.Name = "label30";
            label30.Size = new Size(46, 15);
            label30.TabIndex = 3;
            label30.Text = "가스  : ";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(9, 83);
            label28.Name = "label28";
            label28.Size = new Size(46, 15);
            label28.TabIndex = 3;
            label28.Text = "일괄  : ";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(9, 63);
            label29.Name = "label29";
            label29.Size = new Size(90, 15);
            label29.TabIndex = 3;
            label29.Text = "인공지능난방 : ";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(9, 43);
            label27.Name = "label27";
            label27.Size = new Size(75, 15);
            label27.TabIndex = 3;
            label27.Text = "외출/귀가  : ";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(9, 23);
            label26.Name = "label26";
            label26.Size = new Size(74, 15);
            label26.TabIndex = 3;
            label26.Text = "데이터유형: ";
            // 
            // button_Clear
            // 
            button_Clear.Location = new Point(10, 284);
            button_Clear.Margin = new Padding(2);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(108, 105);
            button_Clear.TabIndex = 209;
            button_Clear.Text = "CLEAR";
            button_Clear.UseVisualStyleBackColor = true;
            button_Clear.Click += Communication_KS_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1119, 603);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox10);
            Controls.Add(groupBoxExecution);
            Controls.Add(groupBox12);
            Controls.Add(groupBoxSwitch);
            Controls.Add(groupBox11);
            Controls.Add(groupBox8);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(richTextBoxLog);
            Controls.Add(groupBoxConfiguration);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MinimumSize = new Size(1022, 548);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SKAI_다기능_Tester";
            FormClosed += FormMain_FormClosed;
            KeyDown += Execution_KeyDown;
            Resize += FormMain_Resize;
            groupBoxConfiguration.ResumeLayout(false);
            groupBoxCommunication.ResumeLayout(false);
            groupBoxCommunication.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxExecution.ResumeLayout(false);
            groupBoxSwitch.ResumeLayout(false);
            groupBoxSwitch.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            groupBox12.ResumeLayout(false);
            groupBox12.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxLog;
        private GroupBox groupBoxConfiguration;
        private Button buttonMake;
        private GroupBox groupBoxExecution;
        private Button buttonRemove;
        private Button buttonReset;
        private ComboBox comboBoxProtocols;
        //private Label labelProtocol;
       // private GroupBox groupBoxTestVector;
       // private TextBox textBoxTestVectorTest;
        //private TextBox textBoxTestVectorVer;
        //private TextBox textBoxTestVectorGroup;
        //private Label labelTestVectorTest;
        //private Label labelTestVectorVer;
        //private Label labelTestVectorGroup;
        //private CheckBox checkBoxVentilation;
        //private CheckBox checkBoxHeating;
        //private CheckBox checkBoxStandBy;
        //private CheckBox checkBoxScene;
        //private CheckBox checkBoxDimming;
        private CheckBox checkBoxLight;
        private GroupBox groupBoxSwitch;
        //private TextBox textBoxSwitchStandbyCount;
        //private TextBox textBoxSwitchLightCount;
        //private Label labelSwitchLightCount;
        //private Label labelSwitchStandbyCount;
        private TextBox textBoxSwitchID;
        private Label labelSwitchID;
       // private CheckBox checkBoxBatch;
        //private CheckBox checkBoxCmdState;
       // private CheckBox checkBoxCmdCtrlGroup;
       // private CheckBox checkBoxCmdSpec;
      // private CheckBox checkBoxCmdCtrlAll;
       // private CheckBox checkBoxTestVectorFormUse;
       /*
        private PictureBox pictureBoxStandby2;
        private PictureBox pictureBoxStandby1;
        private PictureBox pictureBoxLight6;
        private PictureBox pictureBoxLight5;
        private PictureBox pictureBoxLight4;
        private PictureBox pictureBoxLight3;
        private PictureBox pictureBoxLight2;
        private PictureBox pictureBoxLight1;
       */
        //private PictureBox pictureBoxStandby4;
        //private PictureBox pictureBoxStandby3;
        //private CheckBox checkBoxStandby1Manual;
        //private CheckBox checkBoxStandby1Auto;
        //private CheckBox checkBoxStandby4Auto;
        //private CheckBox checkBoxStandby4Manual;
        //private CheckBox checkBoxStandby3Auto;
        //private CheckBox checkBoxStandby3Manual;
        //private CheckBox checkBoxStandby2Auto;
        //private CheckBox checkBoxStandby2Manual;
       // private Label labelStandbyManual;
        //private Label labelStandbyAuto;
      //  private CheckBox checkBoxCmdOff;
        //private TextBox textBoxDimmingStep;
        //private TextBox textBoxSceneStep;
        //private Label labelDimmingStep;
        //private Label labelSceneStep;
        //private CheckBox checkBoxLight1;
        //private CheckBox checkBoxLight6;
        //private CheckBox checkBoxLight5;
        //private CheckBox checkBoxLight4;
        //private CheckBox checkBoxLight3;
        //private CheckBox checkBoxLight2;
        private TextBox textBoxCommunication;
        private GroupBox groupBoxCommunication;
        private ComboBox comboBoxCommunicationBaudrate;
        private ComboBox comboBoxCommunicationComPort;
        private Button buttonCommunicationSend;
        private Label labelCommunicationBaudrate;
        private Label labelCommunicationComPort;
        private Button buttonCommunicationConnection;
        private Button buttonCommunicationSearch;
        private CheckBox checkBoxCommunicationHex;
        private TextBox textBoxCommunicationRepeatCount;
        private Label labelCommunicationRepeatCount;
       // private CheckBox checkBoxCmdSetSBPV;
        //private TextBox textBoxSetSBPV;
       // private CheckBox checkBoxCmdGetSBPV;
        private GroupBox groupBox1;
       // private ComboBox comboBox14;
        //private CheckBox checkBoxCmdVent;
        
      
        private GroupBox groupBox3;
        
        private Label label19;
        private Label label18;
        private Label label17;
      
       
        private Label label14;
        private Label label13;
        
       
        private Button button_StatReq;
        private CheckBox checkBoxGasClose;
        private CheckBox checkBoxGasOpen;
        private GroupBox groupBox4;
        private Button button_BatchOn;
        private Button button_BatchOff;
        private GroupBox groupBox5;
        private Button button_GasDone;
        private Button button_GasClose;
        private Button button_GasOpen;
        private Button button_GasFail;
        private GroupBox groupBox6;
        private Button button_ElvArrived;
        private Button button_ElvFail;
        private Button button_ElvDone;
  
        private CheckBox checkBox_ElvCallReq;
        private CheckBox checkBox_BypassON;
        private CheckBox checkBox_BatchStatus;
        private CheckBox checkBox_GasCloseReq;
        private GroupBox groupBox2;
        private TextBox textBox_WeatherTemp;
        private Label label6;
        private CheckBox checkBox_TempMinus;
        private CheckBox checkBox_TempPlus;
        private Label label5;
        private ComboBox comboBox_WeatherCode;
        private Button button_SendWeather;
        private Label label7;
        private ComboBox comboBox_Finedust;
        private GroupBox groupBox8;
        private Button button_SendTime;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox_Year;
        private Label label8;
        private TextBox textBox_Second;
        private Label label11;
        private TextBox textBox_Minute;
        private Label label12;
        private TextBox textBox_Hour;
        private Label label15;
        private TextBox textBox_Day;
        private Label label10;
        private TextBox textBox_Month;
        private Label label9;
        private GroupBox groupBox9;
        private TextBox textBox_Car2Pos;
        private TextBox textBox_Car1Pos;
        private TextBox textBox_Car2Num;
        private TextBox textBox_Car1Num;
        private Label label2;
        private Label label4;
        private Label label1;
        private Label label3;
        private Label label_Parking_num;
        private Label label21;
        private Label label16;
        private Button button_SendParking;
        private GroupBox groupBox10;
        private CheckBox checkBox_Notice;
        private CheckBox checkBox_Guest;
        private CheckBox checkBox_Delivery;
        private Button button_SendNotice;
        private GroupBox groupBox11;
        private CheckBox checkBoxVol_1;
        private CheckBox checkBoxLight_On;
        private CheckBox checkBoxHeat_Reset;
        private CheckBox checkBoxIn;
        private Label label25;
        private Label label24;
        private CheckBox checkBoxVol_0;
        private Label label23;
        private CheckBox checkBoxLight_Off;
        private Label label22;
        private CheckBox checkBoxHeat_Set;
        private Label label20;
        private CheckBox checkBoxOut;
        private CheckBox checkBoxGoWork_Reset;
        private CheckBox checkBoxGoWork_Set;
        private Button button_BypassCtrl;
        private CheckBox checkBoxVol_3;
        private CheckBox checkBoxVol_2;
        private CheckBox checkBoxVol_NO;
        private GroupBox groupBox12;
        private Label label30;
        private Label label28;
        private Label label29;
        private Label label27;
        private Label label26;
        private Label label32;
        private Label label31;
        private Label label_volume;
        private Label label_elv;
        private Label label_gas;
        private Label label_batch;
        private Label label_AiHeat;
        private Label label_InOut;
        private Label label_DataType;
        private Button button_BypassStat;
        private Button button_Clear;
    }
}