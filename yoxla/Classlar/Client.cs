using System;
using System.Threading;

namespace Classlar
{
    public class Client
    {
        public Client(string ip, int port)
        {
            this.Ip = ip;
            this.Port = port;
        }

        bool _isConnected; //public yazmasaq olur private
        public string Ip { get; private set; }
        public int Port { get; private set; }

        public bool IsConnected { get
            {
                return _isConnected;
            }
        }

        public void Connect()
        {
            Console.WriteLine($"Connecting to {Ip}:{Port}..");
            Thread.Sleep(1300);
            _isConnected = true;
            Console.WriteLine($"Connected to {Ip}:{Port}");
        }

        public void Disconnect()
        {
            Console.WriteLine($"Disconnecting to {Ip}:{Port}..");
            Thread.Sleep(1300);
            _isConnected = false;
            Console.WriteLine($"Disconnected to {Ip}:{Port}");
        }
    }
}
