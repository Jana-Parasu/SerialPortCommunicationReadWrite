
namespace SerialPortReadWrite
{
    partial class HomeWindow
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDisconnectedState = new System.Windows.Forms.Label();
            this.lblConnetedState = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.cbxDataBits = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxParity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxStopBits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDataToSend = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rbWrite = new System.Windows.Forms.RadioButton();
            this.rbWriteLine = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.rbJustDiplayRecTxt = new System.Windows.Forms.RadioButton();
            this.rbAppendwithOldData = new System.Windows.Forms.RadioButton();
            this.textBoxReceivedData = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDisconnectedState);
            this.groupBox1.Controls.Add(this.lblConnetedState);
            this.groupBox1.Controls.Add(this.ProgressBar);
            this.groupBox1.Controls.Add(this.cbxDataBits);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbxParity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbxStopBits);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxBaudRate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonDisconnect);
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Controls.Add(this.comboBoxPorts);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(951, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port Configuration";
            // 
            // lblDisconnectedState
            // 
            this.lblDisconnectedState.AutoSize = true;
            this.lblDisconnectedState.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisconnectedState.ForeColor = System.Drawing.Color.Red;
            this.lblDisconnectedState.Location = new System.Drawing.Point(351, 112);
            this.lblDisconnectedState.Name = "lblDisconnectedState";
            this.lblDisconnectedState.Size = new System.Drawing.Size(270, 34);
            this.lblDisconnectedState.TabIndex = 15;
            this.lblDisconnectedState.Text = "STATE : Disconnected ";
            this.lblDisconnectedState.Visible = false;
            // 
            // lblConnetedState
            // 
            this.lblConnetedState.AutoSize = true;
            this.lblConnetedState.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnetedState.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblConnetedState.Location = new System.Drawing.Point(351, 112);
            this.lblConnetedState.Name = "lblConnetedState";
            this.lblConnetedState.Size = new System.Drawing.Size(229, 34);
            this.lblConnetedState.TabIndex = 14;
            this.lblConnetedState.Text = "STATE : Connected";
            this.lblConnetedState.Visible = false;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(12, 149);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(931, 23);
            this.ProgressBar.TabIndex = 13;
            this.ProgressBar.Visible = false;
            // 
            // cbxDataBits
            // 
            this.cbxDataBits.FormattingEnabled = true;
            this.cbxDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cbxDataBits.Location = new System.Drawing.Point(169, 79);
            this.cbxDataBits.Name = "cbxDataBits";
            this.cbxDataBits.Size = new System.Drawing.Size(162, 24);
            this.cbxDataBits.TabIndex = 12;
            this.cbxDataBits.Text = "8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "DATA BITS";
            // 
            // cbxParity
            // 
            this.cbxParity.FormattingEnabled = true;
            this.cbxParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cbxParity.Location = new System.Drawing.Point(462, 79);
            this.cbxParity.Name = "cbxParity";
            this.cbxParity.Size = new System.Drawing.Size(162, 24);
            this.cbxParity.TabIndex = 10;
            this.cbxParity.Text = "None";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(354, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "PARITY BITS";
            // 
            // cbxStopBits
            // 
            this.cbxStopBits.FormattingEnabled = true;
            this.cbxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cbxStopBits.Location = new System.Drawing.Point(770, 35);
            this.cbxStopBits.Name = "cbxStopBits";
            this.cbxStopBits.Size = new System.Drawing.Size(162, 24);
            this.cbxStopBits.TabIndex = 8;
            this.cbxStopBits.Text = "One";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(652, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "STOP BITS";
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.cbxBaudRate.Location = new System.Drawing.Point(462, 32);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(162, 24);
            this.cbxBaudRate.TabIndex = 6;
            this.cbxBaudRate.Text = "9600";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "BAUD RATE";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconnect.Location = new System.Drawing.Point(785, 74);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(160, 40);
            this.buttonDisconnect.TabIndex = 4;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = false;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(645, 74);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(136, 40);
            this.buttonConnect.TabIndex = 3;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(169, 33);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(162, 24);
            this.comboBoxPorts.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "SERIAL/COM PORTS ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(6, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(923, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "These set of configured serial port can Write and Send the data to Other Serial P" +
    "ort\'s, Similarly Read the receiving data from Other Serial Port\'s. ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textBoxDataToSend
            // 
            this.textBoxDataToSend.Location = new System.Drawing.Point(9, 21);
            this.textBoxDataToSend.Multiline = true;
            this.textBoxDataToSend.Name = "textBoxDataToSend";
            this.textBoxDataToSend.Size = new System.Drawing.Size(281, 179);
            this.textBoxDataToSend.TabIndex = 1;
            this.textBoxDataToSend.TextChanged += new System.EventHandler(this.tbxSendDataTxtChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.rbWrite);
            this.groupBox2.Controls.Add(this.rbWriteLine);
            this.groupBox2.Controls.Add(this.textBoxDataToSend);
            this.groupBox2.Location = new System.Drawing.Point(14, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 234);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send Data";
            this.groupBox2.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(6, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(377, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Typing on above text box will be send to paired port.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(298, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear Out Data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnClearOutData_Click);
            // 
            // rbWrite
            // 
            this.rbWrite.AutoSize = true;
            this.rbWrite.Location = new System.Drawing.Point(309, 26);
            this.rbWrite.Name = "rbWrite";
            this.rbWrite.Size = new System.Drawing.Size(62, 21);
            this.rbWrite.TabIndex = 5;
            this.rbWrite.TabStop = true;
            this.rbWrite.Text = "Write";
            this.rbWrite.UseVisualStyleBackColor = true;
            this.rbWrite.CheckedChanged += new System.EventHandler(this.rbSendWrite_Chkd);
            // 
            // rbWriteLine
            // 
            this.rbWriteLine.AutoSize = true;
            this.rbWriteLine.Checked = true;
            this.rbWriteLine.Location = new System.Drawing.Point(309, 66);
            this.rbWriteLine.Name = "rbWriteLine";
            this.rbWriteLine.Size = new System.Drawing.Size(93, 21);
            this.rbWriteLine.TabIndex = 6;
            this.rbWriteLine.TabStop = true;
            this.rbWriteLine.Text = "Write Line";
            this.rbWriteLine.UseVisualStyleBackColor = true;
            this.rbWriteLine.CheckedChanged += new System.EventHandler(this.rbSendWriteLine_Chkd);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.rbJustDiplayRecTxt);
            this.groupBox3.Controls.Add(this.rbAppendwithOldData);
            this.groupBox3.Controls.Add(this.textBoxReceivedData);
            this.groupBox3.Location = new System.Drawing.Point(477, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(486, 234);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Received Data";
            this.groupBox3.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(14, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(468, 27);
            this.label8.TabIndex = 15;
            this.label8.Text = "On above Text box, receiving data from paired port will be diplayed.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Goldenrod;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(317, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "Clear In Data";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnClearInData_Click);
            // 
            // rbJustDiplayRecTxt
            // 
            this.rbJustDiplayRecTxt.AutoSize = true;
            this.rbJustDiplayRecTxt.Location = new System.Drawing.Point(314, 26);
            this.rbJustDiplayRecTxt.Name = "rbJustDiplayRecTxt";
            this.rbJustDiplayRecTxt.Size = new System.Drawing.Size(168, 21);
            this.rbJustDiplayRecTxt.TabIndex = 8;
            this.rbJustDiplayRecTxt.TabStop = true;
            this.rbJustDiplayRecTxt.Text = "Diplay Receiving Data";
            this.rbJustDiplayRecTxt.UseVisualStyleBackColor = true;
            this.rbJustDiplayRecTxt.CheckedChanged += new System.EventHandler(this.rbJustDiplayRecTxt_Chkd);
            // 
            // rbAppendwithOldData
            // 
            this.rbAppendwithOldData.AutoSize = true;
            this.rbAppendwithOldData.Checked = true;
            this.rbAppendwithOldData.Location = new System.Drawing.Point(315, 66);
            this.rbAppendwithOldData.Name = "rbAppendwithOldData";
            this.rbAppendwithOldData.Size = new System.Drawing.Size(149, 21);
            this.rbAppendwithOldData.TabIndex = 9;
            this.rbAppendwithOldData.TabStop = true;
            this.rbAppendwithOldData.Text = "Append and Diplay";
            this.rbAppendwithOldData.UseVisualStyleBackColor = true;
            this.rbAppendwithOldData.CheckedChanged += new System.EventHandler(this.rbAppendwithOldData_Chkd);
            // 
            // textBoxReceivedData
            // 
            this.textBoxReceivedData.Location = new System.Drawing.Point(14, 21);
            this.textBoxReceivedData.Multiline = true;
            this.textBoxReceivedData.Name = "textBoxReceivedData";
            this.textBoxReceivedData.ReadOnly = true;
            this.textBoxReceivedData.Size = new System.Drawing.Size(294, 179);
            this.textBoxReceivedData.TabIndex = 1;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 470);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Com port Communication";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeWindowClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.TextBox textBoxDataToSend;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxReceivedData;
        private System.Windows.Forms.ComboBox cbxDataBits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxParity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxStopBits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.RadioButton rbWrite;
        private System.Windows.Forms.RadioButton rbWriteLine;
        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbJustDiplayRecTxt;
        private System.Windows.Forms.RadioButton rbAppendwithOldData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDisconnectedState;
        private System.Windows.Forms.Label lblConnetedState;
    }
}

