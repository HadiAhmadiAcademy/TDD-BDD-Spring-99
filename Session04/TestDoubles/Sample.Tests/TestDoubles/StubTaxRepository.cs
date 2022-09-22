using System;
using System.Collections.Generic;
using System.Text;
using Sample.Taxes;

namespace Sample.Tests.TestDoubles
{
    public class StubTaxRepository : ITaxRepository
    {
        private double _taxRate;
        private StubTaxRepository()  { }
        public static StubTaxRepository CreateNewStub()
        {
            return new StubTaxRepository();
        }
        public StubTaxRepository WhichReturnsTaxRateAs(double taxRate)
        {
            this._taxRate = taxRate;
            return this;
        }
        public double GetCurrentTaxRate()
        {
            return _taxRate;
        }
    }
}
