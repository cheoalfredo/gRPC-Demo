using System.Threading.Tasks;
using Grpc.Core;

namespace MyServer
{

    public class OperacionService : OperacionMatematica.OperacionMatematicaBase
    {
        public override Task<DivisionResponse> Divide(DivisionRequest request, ServerCallContext context)
        {                        
            var result = new DivisionResponse();
            result.Cociente = request.Dividendo / request.Divisor;
            result.Residuo = request.Dividendo % request.Divisor;
            return Task.FromResult(result);
        }

    }

}