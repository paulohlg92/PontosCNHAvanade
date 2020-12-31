using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Services;
using Microsoft.Extensions.Caching.Distributed;
using System.Collections.Generic;
using System.Threading.Tasks;
using Workbench.IDistributedCache.Extensions;

namespace DesignPatternSamples.Application.Decorators
{
    public class DetranVerificadorPontosDecoratorCache : IDetranVerificadorPontosService
    {
        private readonly IDetranVerificadorPontosService _Inner;
        private readonly IDistributedCache _Cache;

        public DetranVerificadorPontosDecoratorCache(
            IDetranVerificadorPontosService inner,
            IDistributedCache cache)
        {
            _Inner = inner;
            _Cache = cache;
        }

        public Task<IEnumerable<PontosCNH>> ConsultarDebitos(Cnh veiculo)
        {
            return Task.FromResult(_Cache.GetOrCreate($"{veiculo.UF}_{veiculo.Numero}", () => _Inner.ConsultarDebitos(veiculo).Result));
        }
    }
}