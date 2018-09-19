using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace ClientServer
{
    public class Server
    {
        private Socket socket;
        private TcpClient client;
        private TcpListener listener;
        private static Dictionary<string, TcpClient> dicClient = new Dictionary<string, TcpClient>();

        public int cont = 0;
        public string readOut;
        public static string readData;
        public static bool dataBru = false;

        bool socketRunnig = false;

        List<TcpClient> listClient = new List<TcpClient>();

        public Server() { }
        public Server(string serverIp)
        {
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());

            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    serverIp = address.ToString();
                }
            }
        }

        public void Start(string serverPort)
        {

        }

        public void Read()
        {

        }
    }
}
