using System;

namespace ParseURL
{
    class StartUp
    {
        static void Main()
        { 
            string input = Console.ReadLine();
            
            int indexProtocol = input.IndexOf(':');
            string protocol = input.Substring(0, indexProtocol);
            input = input.Remove(0, indexProtocol + 3);
            
            int indexSever = input.IndexOf('/');
            string server = input.Substring(0, indexSever);
            input = input.Remove(0, indexSever);

            Console.WriteLine("[protocol] = " + protocol);
            Console.WriteLine("[server] = " + server);
            Console.WriteLine("[resource] = " + input);
        }
    }
}