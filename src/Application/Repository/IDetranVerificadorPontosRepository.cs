﻿using DesignPatternSamples.Application.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Repository
{
    public interface IDetranVerificadorPontosRepository
    {
        Task<IEnumerable<PontosCNH>> ConsultarDebitos(Cnh veiculo);
    }
}
