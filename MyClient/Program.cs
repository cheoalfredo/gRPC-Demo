using System;
using Grpc.Net.Client;
using System.Threading.Tasks;
using MyServer;

namespace MyClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new OperacionMatematica.OperacionMatematicaClient(channel);
            var reply = await client.DivideAsync(new MyServer.DivisionRequest
            {
                Dividendo = 524,
                Divisor = 63
            });

            Console.WriteLine("cociente: " + reply.Cociente);
            Console.WriteLine("Residuo : " + reply.Residuo);
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}