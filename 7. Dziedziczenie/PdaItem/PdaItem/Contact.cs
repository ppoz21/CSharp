using System;
using System.IO;
using static System.Environment;

namespace PdaItem
{
    public class Contact : PdaItem
    {
        public Contact(string name) :
            base(name)
        {
            Name = name;
        }

        public override string Name
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
            set
            {
                string[] names = value.Split(' ');
                // obsługę błędów pominięto
                FirstName = names[0];
                LastName = names[1];
            }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public override string GetSummary()
        {
            return $"FirstName: { FirstName + NewLine }"
                + $"LastName: { LastName + NewLine }"
                + $"Address: {Address + NewLine }";
        }
    }
}
