using DesignPatternSamples.Application.DTO;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public class DetranRSVerificadorPontosRepository : DetranVerificadorPontosRepositoryCrawlerBase
    {
        private readonly ILogger _Logger;

        public DetranRSVerificadorPontosRepository(ILogger<DetranRJVerificadorPontosRepository> logger)
        {
            _Logger = logger;
        }

        protected override Task<IEnumerable<PontosCNH>> PadronizarResultado(string html)
        {
            _Logger.LogDebug($"Padronizando o Resultado {html}.");
            return Task.FromResult<IEnumerable<PontosCNH>>(new List<PontosCNH>() { new PontosCNH() });
        }

        protected override Task<string> RealizarAcesso(Cnh veiculo)
        {
            _Logger.LogDebug($"Consultando débitos do veículo placa {veiculo.Numero} para o estado de RS.");
            return Task.FromResult("CONTEUDO DO SITE DO DETRAN/RS");
        }
    }
}
