using SerialPortReadWrite.Services.DIInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortReadWrite
{
    public partial class HomeWindow : Form
    {
        private readonly ISerialPortManager serialPortManager;
        //public event EventHandler<string> DataReceived;
        private string DataIn;
        
        public HomeWindow(ISerialPortManager serialPortManager)
        {
            InitializeComponent();
            this.serialPortManager = serialPortManager;
            this.Load += MainForm_Load;
        }

        /// <summary>
        /// MainForm_Load Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                //GETTING AVAILABLE PORTS AND HANDLING THAT RESPONSE SAME.
                string[] availablePorts = await serialPortManager.GetAvailablePortsAsync();
                HandleAvailablePortsStateChecking(availablePorts);

                if (availablePorts.Count() == 0)
                    LogAvailableSerialPorts(availablePorts);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting available serial ports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Exception : Error getting available serial ports: File -'HomeWindow.cs', Method- 'MainForm_Load()' " + ex.Message);
            }
        }

        private void LogAvailableSerialPorts(string[] availablePorts)
        {
            Console.WriteLine(DateTime.Now + " : Available serial port's to configured..");
            availablePorts.ToList().ForEach(item => Console.WriteLine(item));            
        }

        /// <summary>
        /// Handling Available Ports State Checking, to Configure further.
        /// </summary>
        /// <param name="availablePorts"></param>
        private void HandleAvailablePortsStateChecking(string[] availablePorts)
        {
            try
            {
                if (availablePorts.Count() == 0)
                    SuggestUserToVSPD();
                else
                    comboBoxPorts.Items.AddRange(availablePorts);
            }
            catch (Exception ex)
            {                
                Console.WriteLine("Exception : Error while handle available serial ports: File -'HomeWindow.cs', Method- 'HandleAvailablePortsStateChecking()' " + ex.Message);
            }           
        }

        /// <summary>
        /// Scenerio : NO SERIAL PORTS AVAILABLE IN YOUR PC/LAPTOP
        /// Info to the User : Virtual Serial Port Driver(VSPD), can help for NO Serial port available, OR more Serial ports 
        /// when looking for. Then Use 'Putty' software to view sending data from one port.Also 
        /// 'Tera Term VT' can help to evaluate Send & Receive the data from one Serial port to another.
        /// </summary>
        private void SuggestUserToVSPD()
        {
            try
            {
                //Just Invisible of Port Configuration    
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;

                MessageBox.Show("Virtual Serial Port Driver(VSPD), can help for NO Serial port available, " +
                                "OR more Serial ports when looking for. Then Use 'Putty' software to view sending data from one port.Also 'Tera Term VT' can help to evaluate Send and  Receive the data from one Serial port to another.", "Seems, NO SERIAL PORTS AVAILABLE IN YOUR PC/LAPTOP!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Console.WriteLine(DateTime.Now + " : NO any serial port's found in the PC/LAPTOP");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : Error while handle available serial ports which PC/Laptop has NO Serial ports: File -'HomeWindow.cs', Method- 'SuggestUserToVSPD()' " + ex.Message);
            }            
        }

        /// <summary>
        /// Connect Serial Port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonConnect_Click(object sender, EventArgs e)
        {
            //ShowProgressBar();
            //HideProgressBar();

           // bool IsAllParamsSet = SetSerialPortParameters();
            //ProgressBar.Value = 0;
            try
            {
                //IProgress<int> progress = new Progress<int>(value =>
                //{
                //    ProgressBar.Value = value;
                //});
                //ProgressBar.Visible = true;

                string portName = comboBoxPorts.SelectedItem as string;
                //if (!string.IsNullOrEmpty(portName))
                //{
                //serialPortManager.DataReceived += SerialPortManager_DataReceived;
                serialPort1 = await serialPortManager.ConnectAsync(ShowProgressBar(), portName,cbxBaudRate.Text,cbxDataBits.Text,
                                                         cbxStopBits.Text,cbxParity.Text);                
                if (serialPort1 == null)
                    return;
                Console.WriteLine(DateTime.Now + " : CONNECTED and configured serial port - " + serialPort1.PortName + " Successfully!!");
                if (serialPort1.IsOpen)
                    HandleGUItoEnableFunctions(true);

                serialPort1.DataReceived += SerialPort_DataReceived;
                //ConnectedPort.DataReceived += SerialPortManager_DataReceived;
                buttonConnect.Enabled = false;
                buttonDisconnect.Enabled = true;
                lblConnetedState.Visible = true;
                lblDisconnectedState.Visible = false;
                //}
                //HideProgressBar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to serial port: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Exception : Error connecting to serial port: File -'HomeWindow.cs', Method- 'buttonConnect_Click()' " + ex.Message);
            }           
        }

        /// <summary>
        /// Display progress bar to show the progress when 
        /// connecting & Disconnecting the serial port.
        /// </summary>
        /// <returns></returns>
        private System.IProgress<int> ShowProgressBar()
        {
            IProgress<int> progress = null;
            try
            {                
                ProgressBar.Value = 0;
                progress = new Progress<int>(value =>
                {
                    ProgressBar.Value = value;
                });
                ProgressBar.Visible = true;

                return progress;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : Error while handling Progress bar control : File -'HomeWindow.cs', Method- 'ShowProgressBar()' " + ex.Message);
                return progress;
            }
        }

        /// <summary>
        /// Disconnecting the serial port which was in connecting state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonDisconnect_Click(object sender, EventArgs e)
        {
            ProgressBar.Value = 0;
            try
            {
                //IProgress<int> progress = new Progress<int>(value =>
                //{
                //    ProgressBar.Value = value;
                //});
                //ProgressBar.Visible = true;
                serialPort1 = await serialPortManager.DisconnectAsync(ShowProgressBar());
                Console.WriteLine(DateTime.Now + " : DISCONNECTED, configured serial port - " + serialPort1.PortName);
                if (!serialPort1.IsOpen)
                    HandleGUItoEnableFunctions(false);
                serialPort1.DataReceived -= SerialPort_DataReceived;
                buttonConnect.Enabled = true;
                buttonDisconnect.Enabled = false;
                lblDisconnectedState.Visible = true;
                lblConnetedState.Visible = false;

                ProgressBar.Value = 0;
                ProgressBar.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error disconnecting from serial port: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Exception : Error disconnecting from serial port:: File -'HomeWindow.cs', Method- 'buttonDisconnect_Click()' " + ex.Message);
            }
        }

        /// <summary>
        /// Handle GUI to Enable some func during Port connected 
        /// and Disconnected state.
        /// </summary>
        /// <param name="IsEnableRequired"></param>
        private void HandleGUItoEnableFunctions(bool IsEnableRequired)
        {
            try
            {
                if (IsEnableRequired)
                {
                    groupBox2.Visible = true;
                    groupBox3.Visible = true;
                }
                else
                {
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : Error while Handle GUI to Enable some func during Port connected/Disconnecetd : File -'HomeWindow.cs', Method- 'HandleGUItoEnableFunctions()' " + ex.Message);
            }
        }

        /// <summary>
        /// Sending/writing data from Configured Serial port to paired port.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private async void buttonSend_Click(object sender, EventArgs e)
        //{
        //    try
        //    {  
        //        string dataToSend = textBoxDataToSend.Text;
        //        await serialPortManager.WriteAsync(dataToSend,rbWriteLine.Checked);
        //        Console.WriteLine(DateTime.Now + " : Write Or send data : " + dataToSend);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error writing to serial port: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Console.WriteLine("Exception : Error writing to serial port: File -'HomeWindow.cs', Method- 'buttonSend_Click()' " + ex.Message);
        //    }
        //}

        //private void SerialPortManager_DataReceived(object sender, string data)
        //{
        //    try
        //    {
        //        if (textBoxReceivedData.InvokeRequired)
        //        {
        //            textBoxReceivedData.Invoke((MethodInvoker)(() => SerialPortManager_DataReceived(sender, data)));
        //        }
        //        else
        //        {
        //            textBoxReceivedData.AppendText(data + Environment.NewLine);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Exception : Error while handling Progress bar control : File -'HomeWindow.cs', Method- 'ShowProgressBar()' " + ex.Message);

        //    }

        //}

        /// <summary>
        /// Clearing the data which was Write/Send to Paired Serial port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearOutData_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxDataToSend.Text))
                    textBoxDataToSend.Text = "";

                Console.WriteLine(DateTime.Now + " : Cleared send/write data to paired serial port.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : Error Clearing the data which was Write/Send to Paired Serial port : File -'HomeWindow.cs', Method- 'btnClearOutData_Click()' " + ex.Message);
            }
        }

        /// <summary>
        /// Receiving the data from Paired Serial port to our configured port.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                DataIn = await serialPortManager.ReadAsync();
                this.Invoke(new EventHandler(ShowData));                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : Error while Receiving the data from paired Serial port to our configured port : File -'HomeWindow.cs', " +
                                   "Method- 'SerialPort_DataReceived()' " + ex.Message);
            }
           
        }

        /// <summary>
        /// Display read/receiving data from paired serial port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowData(object sender, EventArgs e)
        {
            try
            {
                if (rbAppendwithOldData.Checked)
                {
                    //Append with Old data & display recieving data  
                    textBoxReceivedData.Text += DataIn;
                    Console.WriteLine(DateTime.Now + " : Read Or receive data : " + textBoxReceivedData.Text);
                }                    
                else
                {
                    //Just display recieving data without append 
                    textBoxReceivedData.Text = DataIn;
                    Console.WriteLine(DateTime.Now + " : Read Or receive data : " + textBoxReceivedData.Text);
                }
                    
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : Error while Display read/receiving data from paired serial port: File -'HomeWindow.cs', " +
                                   "Method- 'ShowData()' " + ex.Message);
            }
            

        }

        /// <summary>
        /// Clearing the data which was Read/Received from Paired Serial port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearInData_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxReceivedData.Text))
                    textBoxReceivedData.Text = "";

                Console.WriteLine(DateTime.Now + " : Cleared received/read data from paired serial port.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : Error while Clearing the data which was Read/Received from Paired Serial port : File -'HomeWindow.cs', " +
                                   "Method- 'btnClearInData_Click()' " + ex.Message);
            }
            
        }

        /// <summary>
        /// Writing/sending data to the paired serial port.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void tbxSendDataTxtChanged(object sender, EventArgs e)
        {
            try
            {
                string dataToSend = textBoxDataToSend.Text;
                Console.WriteLine(DateTime.Now + " : Write Or send data : " + dataToSend);
                await serialPortManager.WriteAsync(dataToSend, rbWriteLine.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to serial port: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Serial port communication GUI Window/Home window Closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HomeWindowClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    serialPort1.Dispose();
                    Console.WriteLine(DateTime.Now + " : DISCONNECTED, configured serial port -" + serialPort1.PortName + ", " +
                                                     "through closing serial port communication UI Window");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : Error while Serial port communication GUI Window/Home window Closing : File -'HomeWindow.cs', " +
                                   "Method- 'HomeWindowClosing()' " + ex.Message);
            }
                           
        }

        /// <summary>
        /// Mode changed receiving data - RECEIVING DATA ONLY
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbJustDiplayRecTxt_Chkd(object sender, EventArgs e)
        {
            Console.WriteLine(DateTime.Now + " : Display receiving/read data mode Changed to : DON'T APPEND WITH OLD DATA");
        }

        /// <summary>
        /// Mode changed receiving data - APPEND WITH OLD DATA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbAppendwithOldData_Chkd(object sender, EventArgs e)
        {
            Console.WriteLine(DateTime.Now + " : Display receiving/read data mode Changed to : APPEND WITH OLD DATA");
        }

        /// <summary>
        /// Mode changed writing data - WRITE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbSendWrite_Chkd(object sender, EventArgs e)
        {
            Console.WriteLine(DateTime.Now + " : Display receiving/read data mode Changed to : WRITE");
        }

        /// <summary>
        /// Mode changed writing data - WRITELINE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbSendWriteLine_Chkd(object sender, EventArgs e)
        {
            Console.WriteLine(DateTime.Now + " : Writing/Send data display port mode Changed to : WRITELINE");
        }
        
    }

}
