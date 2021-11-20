using Grpc.Net.Client;
using GrprcServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GrprcServer.Greeter;

namespace DataLibrary.gRPC
{
    public class gRPCclients
    {
        #region Singelton
        private static readonly Lazy<gRPCclients> lazy =
        new Lazy<gRPCclients>(() => new gRPCclients());
        public static gRPCclients GetInstance { get { return lazy.Value; } }
        private gRPCclients()
        {
          
        }
        #endregion
        #region Fields
        private string _ServerIP= @"http://localhost:5000";
        #endregion
        #region Methods
        public string TestgRPCConnection(string userName)
        {
            string res;
            using (var channel = GrpcChannel.ForAddress(_ServerIP))
            {
                var client = new GreeterClient(channel);
                var input = new HelloRequest() { Name = userName };
                res = client.SayHello(input).Message;
            }
            return res;
        }
        #endregion
    }
}
