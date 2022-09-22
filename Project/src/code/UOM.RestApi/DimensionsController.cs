using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using UOM.Application.Contracts;

namespace UOM.RestApi
{
    [ApiController]
    [Route("api/[controller]")]
    public class DimensionsController : ControllerBase
    {
        private readonly IDimensionService _service;
        public DimensionsController(IDimensionService service)
        {
            _service = service;
        }
        [HttpPost]
        public long Post(DefineDimensionDto dto)
        {
           return _service.DefineDimension(dto);
        }

        [HttpGet("{id}")]
        public DimensionDto Get(long id)
        {
            return _service.GetDimension(id);
        }

        [HttpGet]
        public List<DimensionDto> Get()
        {
            return _service.GetAll();
        }
    }
}
