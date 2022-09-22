using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using UOM.Domain.Model.Dimensions;

namespace UOM.Persistence.EF.Repositories
{
    public class DimensionRepository : IDimensionRepository
    {
        private readonly UomContext _context;
        public DimensionRepository(UomContext context)
        {
            _context = context;
        }
        public void Add(Dimension dimension)
        {
            _context.Dimensions.Add(dimension);
            _context.SaveChanges();
        }
        public Dimension GetById(long id)
        {
            return _context.Dimensions.FirstOrDefault(a => a.Id == id);
        }

        public List<Dimension> GetAll()
        {
            return _context.Dimensions.ToList();
        }
    }
}