using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UOM.Application.Contracts;
using UOM.Domain.Model.Dimensions;

namespace UOM.Application
{
    public class DimensionService : IDimensionService
    {
        private IDimensionRepository _repository;
        public DimensionService(IDimensionRepository repository)
        {
            _repository = repository;
        }

        public long DefineDimension(DefineDimensionDto dto)
        {
            var dimension = new Dimension(dto.Name, dto.Symbol);
            _repository.Add(dimension);
            return dimension.Id;
        }

        public List<DimensionDto> GetAll()
        {
            var data = _repository.GetAll();
            return data.Select(MapDimension).ToList();
        }

        public DimensionDto GetDimension(long id)
        {
            var dimension = _repository.GetById(id);
            return MapDimension(dimension);
        }

        private static DimensionDto MapDimension(Dimension dimension)
        {
            return new DimensionDto()
            {
                Id = dimension.Id,
                Symbol = dimension.Symbol,
                Name = dimension.Name
            };
        }
    }
}
