namespace _02.PubNub
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Sockets;
    using System.Threading.Tasks;

    public class PubNub
    {
        static void Main()
        {
            // Start the HTML5 Pubnub client
            //Process.Start("..\\..\\PubNub-HTML5-Client.html");

            System.Threading.Thread.Sleep(2000);

            PubnubAPI pubnub = new PubnubAPI(
                "pub-c-de6261aa-bb9e-4e17-a46c-ea4cb2b08f96",               // PUBLISH_KEY
                "sub-c-28202fc4-8d72-11e5-a7e4-0619f8945a4f",               // SUBSCRIBE_KEY
                "sec-c-ZDM3ZTEwY2UtMTMyZC00NWZmLTgzNDEtMGY3NjkyNzM4ZmM3",   // SECRET_KEY
                true                                                        // SSL_ON?
            );
            string channel = "demo-channel";

            // Publish a sample message to Pubnub
            List<object> publishResult = pubnub.Publish(channel, "Hello Pubnub!");
            Console.WriteLine(
                "Publish Success: " + publishResult[0].ToString() + "\n" +
                "Publish Info: " + publishResult[1]
            );
                
            // Subscribe for receiving messages (in a background task to avoid blocking)
            System.Threading.Tasks.Task t = new Task(
                () =>
                pubnub.Subscribe(
                    channel,
                    delegate(object message)
                    {
                        Console.WriteLine("Received Message -> '" + message + "'");
                        Console.Write("Enter a message to be sent to Pubnub: ");
                        return true;
                    }
                )
            );
            t.Start();

            var ip = GetIp();
            // Read messages from the console and publish them to Pubnub
            Console.Write("Enter a message to be sent to Pubnub: ");
            while (true)
            {
                var msg = Console.ReadLine();
                var result = ip + ": " + msg;
                pubnub.Publish(channel, result);
                Console.WriteLine("Message sent.");
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

