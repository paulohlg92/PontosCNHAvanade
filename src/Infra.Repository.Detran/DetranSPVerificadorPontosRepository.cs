using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public class DetranSPVerificadorPontosRepository : IDetranVerificadorPontosRepository
    {
        private readonly ILogger _Logger;

        public DetranSPVerificadorPontosRepository(ILogger<DetranSPVerificadorPontosRepository> logger)
        {
            _Logger = logger;
        }

        public Task<IEnumerable<PontosCNH>> ConsultarDebitos(Cnh veiculo)
        {
            _Logger.LogDebug($"Consultando débitos do veículo placa {veiculo.Numero} para o estado de SP.");
            return Task.FromResult<IEnumerable<PontosCNH>>(new List<PontosCNH>() { new PontosCNH() });
        }
    }
}
