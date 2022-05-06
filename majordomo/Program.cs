using System;
using NetMQ;
using NetMQ.Sockets;

namespace majordomo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Majordomo!");
            using var dealer=new DealerSocket();
            dealer.Connect("tcp:127.0.0.1:5555");

            dealer.SendFrame("A new message");
        }
    }
}
