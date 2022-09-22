using System;
using System.Collections.Generic;

namespace DataSensitivitySample
{
    public class Trip
    {
        public const int MaximumNumbersOfTravelers = 9;
        private List<string> _passengers;
        public IReadOnlyCollection<string> Passengers => _passengers.AsReadOnly();
        public Trip()
        {
            this._passengers = new List<string>();
        }
        public void AddPassenger(params string[] names)
        {
            if (Passengers.Count + names.Length > MaximumNumbersOfTravelers) throw new Exception("Passengers limit exceed");
            foreach (var name in names)
                _passengers.Add(name);
        }
    }
}
