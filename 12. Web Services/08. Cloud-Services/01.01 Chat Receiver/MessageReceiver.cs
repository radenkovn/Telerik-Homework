namespace _01._01_Chat_Receiver
{
    using System;

    using IronMQ;
    using IronMQ.Data;

    class MessageReceiver
    {
        static void Main(string[] args)
        {
            Client client = new Client("564b989373d0cd0006000113", "pvdw0JaLVzKiqEpXHv67");
            Queue queue = client.Queue("Cool-Chat-Room");
            Console.WriteLine("Listening for new messages from the server:");
            while (true)
            {
                Message msg = queue.Get();
                if (msg != null)
                {
                    Console.WriteLine(msg.Body);
                    queue.DeleteMessage(msg);
                }
            }
        }
    }
}
