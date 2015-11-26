namespace _01.Chat_service
{
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Sockets;

    using IronMQ;


    class MessagePoster
    {
        static void Main(string[] args)
        {
            Client client = new Client("564b989373d0cd0006000113", "pvdw0JaLVzKiqEpXHv67");
            Queue queue = client.Queue("Cool-Chat-Room");
            Console.WriteLine("Enter chat message: ");
            var ip = GetIp();
            while (true)
            {
                string msg = Console.ReadLine();
                var result = ip + " : " + msg;
                queue.Push(result);
                Console.WriteLine("Message sent to the server.");
            }
        }

        public static string GetIp()
        {
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                }
            }

            return localIP;
        }
    }
}
