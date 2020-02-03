using System;
using static System.Environment;
namespace Address
{
    public class InternationalAddress : Address
    {
        public string Country;

        public override string ToString()
        {
            return base.ToString() + NewLine + Country;
        }
    }
}
