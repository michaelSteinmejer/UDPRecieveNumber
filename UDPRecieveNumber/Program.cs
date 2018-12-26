using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace UDPRecieveNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient udpServer = new UdpClient(7011);

            IPAddress ip = IPAddress.Parse("127.0.0.1"); 

            IPEndPoint RemoteIpEndPoint = new IPEndPoint(ip, 7011);
            //udpClient.Connect(RemoteIpEndPoint); //


            try
            {
                while (true)
                {
                Byte[] receiveBytes = udpServer.Receive(ref RemoteIpEndPoint);
                //Client is now activated");

                string receivedData = Encoding.ASCII.GetString(receiveBytes);
                Console.WriteLine(receivedData);
                

                Thread.Sleep(100);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
           
                
                
            
        }
    }
}
