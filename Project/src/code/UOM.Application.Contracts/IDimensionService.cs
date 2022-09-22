using System.Collections.Generic;
using System.Threading.Tasks;

namespace UOM.Application.Contracts
{
    public interface IDimensionService
    {
        long DefineDimension(DefineDimensionDto dto);
        List<DimensionDto> GetAll();
        DimensionDto GetDimension(long id);
    }
}