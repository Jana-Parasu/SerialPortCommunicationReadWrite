using SerialPortReadWrite.Services.DIInterfaces;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace SerialPortReadWrite.Services
{
    // Define the delegate type for the event handler
    //public delegate void DataReceivedEventHandler(object sender, string data);

    public class SerialPortManager : ISerialPortManager
    {
        private SerialPort serialPort;

        /// <summary>
        /// Get available serial ports from PC/LAPTOP to connect
        /// </summary>
        /// <returns></returns>
        public async Task<string[]> GetAvailablePortsAsync()
        {
            return await Task.Run(() => SerialPort.GetPortNames());
        }

        /// <summary>
        /// ASYNC method to connect and configured the serial port
        /// </summary>
        /// <returns></returns>
        public async Task<SerialPort> ConnectAsync(IProgress<int> progress, 
                                             string portName, string baudrate, string dataBits,
                                              string stopBits, string parityBits)
        {
           
            try
            {                            
                serialPort = new SerialPort(portName);
                if (!SetSerialPortParameters(baudrate, dataBits, stopBits, parityBits))
                    return null;
                
                //serialPort.DataReceived += SerialPort_DataReceived;
               
                 await Task.Run(() =>
                {
                    try
                    {
                        if (serialPort != null)
                            serialPort.Open();

                        //serialPort.DataReceived += SerialPort_DataReceived;
                    }
                    catch (System.IO.IOException ioExp)
                    {
                        Console.WriteLine("Exception : System.IO.IOException Occured While connecting serial ports: File -" +
                                          "'SerialPortManager.cs', Method- 'ConnectAsync()' " + ioExp.Message);
                    }
                    catch (UnauthorizedAccessException unAuthAccException)
                    {
                        Console.WriteLine("Exception : UnauthorizedAccessException Occured While connecting serial ports: File -" +
                                          "'SerialPortManager.cs', Method- 'ConnectAsync()' " + unAuthAccException.Message);                        
                    }

                    for (int i = 0; i <= 100; i += 10)
                    {
                        progress.Report(i);
                        Task.Delay(100).Wait();
                    }
                });
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to serial port: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Exception : Error connecting to serial port: File -" +
                                  "'SerialPortManager.cs', Method- 'ConnectAsync()' " + ex.Message);
            }

            return serialPort;
        }

        /// <summary>
        /// ASYNC method to Disconnect configured and connected port
        /// </summary>
        /// <returns></returns>
        public async Task<SerialPort> DisconnectAsync(IProgress<int> progress)
        {
            try
            {
                await Task.Run(() =>
                {
                    if (serialPort != null && serialPort.IsOpen)
                    {
                        //serialPort.DataReceived -= SerialPort_DataReceived;
                        serialPort.Close();
                        serialPort.Dispose();

                        for (int i = 0; i <= 100; i += 10)
                        {
                            progress.Report(i);
                            Task.Delay(100).Wait();
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error disconnecting from serial port: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Exception : Error disconnecting from serial port: File -" +
                                  "'SerialPortManager.cs', Method- 'DisconnectAsync()' " + ex.Message);
            }

            return serialPort;
        }

        /// <summary>
        /// /// <summary>
        /// ASYNC method to Write/send data to paired port
        /// </summary>
        /// <returns></returns>
        /// </summary>
        /// <param name="data"></param>
        /// <param name="writeline"></param>
        /// <returns></returns>
        public async Task<bool> WriteAsync(string data, bool writeline)
        {
            try
            {
                if (serialPort != null && serialPort.IsOpen)
                {
                    if(writeline)
                    await Task.Run(() => serialPort.WriteLine(data));
                    else
                    await Task.Run(() => serialPort.Write(data));
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to serial port: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Exception : Error writing to serial port: File -" +
                                  "'SerialPortManager.cs', Method- 'WriteAsync()' " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Setting other parameters with PORT NAME to connect and configure the serial port.
        /// </summary>
        /// <param name="baudrate"></param>
        /// <param name="dataBits"></param>
        /// <param name="stopBits"></param>
        /// <param name="parityBits"></param>
        /// <returns></returns>
        private bool SetSerialPortParameters(string baudrate, string dataBits, string stopBits, string parityBits)
        {
            try
            {  
                serialPort.BaudRate = Convert.ToInt32(baudrate);
                serialPort.DataBits = Convert.ToInt32(dataBits);
                serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopBits);
                serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), parityBits);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error configuring parameters to serial port: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Exception : Error configuring parameters to serial port: File -" +
                                  "'SerialPortManager.cs', Method- 'SetSerialPortParameters()' " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ASYNC method to Read/receive data from paired port
        /// </summary>
        /// <returns></returns>
        public async Task<string> ReadAsync()
        {
            try
            {
                return await Task.Run(() => serialPort.ReadExisting());
            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception : Error configuring parameters to serial port: File -" +
                                  "'SerialPortManager.cs', Method- 'ReadAsync()' " + ex.Message);
                return null;
            }
           
        }
    }
}
