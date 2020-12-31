using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using DesignPatternSamples.Application.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Implementations
{
    public class DetranVerificadorPontosServices : IDetranVerificadorPontosService
    {
        private readonly IDetranVerificadorPontosFactory _Factory;

        public DetranVerificadorPontosServices(IDetranVerificadorPontosFactory factory)
        {
            _Factory = factory;
        }

        public Task<IEnumerable<PontosCNH>> ConsultarDebitos(Cnh veiculo)
        {
            IDetranVerificadorPontosRepository repository = _Factory.Create(veiculo.UF);
            return repository.ConsultarDebitos(veiculo);
        }
    }
}
