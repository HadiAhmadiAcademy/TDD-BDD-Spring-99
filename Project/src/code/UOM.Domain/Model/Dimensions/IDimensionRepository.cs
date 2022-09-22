using System.Collections.Generic;
using System.Diagnostics;

namespace UOM.Domain.Model.Dimensions
{
    public interface IDimensionRepository
    {
        void Add(Dimension dimension);
        Dimension GetById(long id);
        List<Dimension> GetAll();
    }
}