using System;

namespace Sample.Taxes
{
    public class TaxRepository : ITaxRepository
    {
        public double GetCurrentTaxRate()
        {
            //using (var connection = new SqlConnection())  //read value from database
            //{
            //}

            throw new NotImplementedException();
        }
    }
}