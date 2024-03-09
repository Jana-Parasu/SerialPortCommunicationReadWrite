using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPortReadWrite.Services.DIInterfaces
{
    public interface ISerialPortManager
    {        
        Task<string[]> GetAvailablePortsAsync();
        Task<SerialPort> ConnectAsync(IProgress<int> progress,string portName, 
                                                        string baudrate, string dataBits,
                                                        string stopBits, string parityBits);
        Task<SerialPort> DisconnectAsync(IProgress<int> progress);
        Task<bool> WriteAsync(string data,bool writeLine);
        Task<string> ReadAsync();        
    }
}
