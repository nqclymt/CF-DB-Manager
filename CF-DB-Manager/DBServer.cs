using Grpc.Core;
using MagicOnion.Server;
using System;
using Cosmos;
using CF_DB_Manager.Redis;
namespace CF_DB_Manager
{
    class DBServer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RPC DBServer Start UP . . . . . . ");
            Utility.Debug.SetHelper(new DBDebugHelper());
            InitDBManager();
            var service = MagicOnionEngine.BuildServerServiceDefinition(isReturnExceptionStackTraceInErrorDetail: true);
            var server = new global::Grpc.Core.Server
            {
                Services = { service },
                Ports = { new ServerPort("localhost", 14567, ServerCredentials.Insecure) }
            };
            server.Start();
            while (true)
            {

            }
        }
        static void InitDBManager()
        {
            RedisManager.Instance.SetUp();
        }
    }
}
