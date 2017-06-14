using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UI_Play
{
    /**
     * This class manage TCP socket
     **/
    class SocketManager
    {
        static public Socket client;

        static public void ConnectMPD(string adress)
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(adress), 6600);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            Byte[] _data = new Byte[1024];

            try
            {
                client.Connect(ipep);
            }
            catch(Exception ex)
            {
                Console.Write(ex);
                throw;
            }
            
            client.Receive(_data);
        }

        static public string AddNewLine(string _temp)
        {
            string _return;
            _return = _temp + "\n";
            return _return;
        }

        static public string Comunicate(string command)
        {
            Byte[] _send = new Byte[1024];
            Byte[] _recieve = new Byte[1024];

            string _buf = AddNewLine(command);

            _send = Encoding.Default.GetBytes(_buf);
            client.Send(_send);

            client.Receive(_recieve);
            _buf = Encoding.UTF8.GetString(_recieve);

            _buf = _buf.Substring(0, _buf.IndexOf('\0'));

            return _buf;
        }
    }
}
