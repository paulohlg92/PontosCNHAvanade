using AutoMapper;
using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Services;
using DesignPatternSamples.WebAPI.Models;
using DesignPatternSamples.WebAPI.Models.Detran;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.WebAPI.Controllers.Detran
{
    [Route("api/Detran/[controller]")]
    [ApiController]
    public class PontosCNHController : ControllerBase
    {
        private readonly IMapper _Mapper;
        private readonly IDetranVerificadorPontosService _DetranVerificadorPontosServices;

        public PontosCNHController(IMapper mapper, IDetranVerificadorPontosService detranVerificadorPontosServices)
        {
            _Mapper = mapper;
            _DetranVerificadorPontosServices = detranVerificadorPontosServices;
        }

        [HttpGet()]
        [ProducesResponseType(typeof(SuccessResultModel<IEnumerable<PontosCnhModel>>), StatusCodes.Status200OK)]
        public async Task<ActionResult> Get([FromQuery]CnhModel model)
        {
            var debitos = await _DetranVerificadorPontosServices.ConsultarDebitos(_Mapper.Map<Cnh>(model));

            var result = new SuccessResultModel<IEnumerable<PontosCnhModel>>(_Mapper.Map<IEnumerable<PontosCnhModel>>(debitos));

            return Ok(result);
        }
    }
}