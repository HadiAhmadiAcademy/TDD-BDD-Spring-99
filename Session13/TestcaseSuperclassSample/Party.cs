using System;
using System.Collections.Generic;
using System.Linq;

namespace TestcaseSuperclassSample
{
    public abstract class Party
    {
        public List<string> Addresses { get; private set; }
        protected Party()
        {
            this.Addresses = new List<string>();    
        }
        public void AddAddress(string address)
        {
            Addresses.Add(address);
        }
    }
    public class IndividualParty : Party
    {

    }
    public class LegalParty : Party
    {

    }
}
