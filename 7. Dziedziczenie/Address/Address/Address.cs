using System;
using static System.Environment;

namespace Address
{
    public class Address
    {
        public string StreetAddress;
        public string City;
        public string State;
        public string Zip;

        public override string ToString()
        {
            return $"{ StreetAddress + NewLine }"
                + $"{ City }, { State } { Zip }";
        }
    }
}
