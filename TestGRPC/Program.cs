using DataLibrary.gRPC;
using System;
using static System.Console;

namespace TestGRPC
{
    class Program
    {
        static void Main(string[] args)
        {
            var serverContext = gRPCclients.GetInstance;
            WriteLine(serverContext.TestgRPCConnection("Darek"));
            ReadKey();
        }
    }
}
