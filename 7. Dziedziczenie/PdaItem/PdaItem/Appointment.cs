using System;
using static System.Environment;

namespace PdaItem
{
    public class Appointment : PdaItem
    {
        public Appointment(string name) :
            base(name)
        {
            Name = name;
        }

        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Location { get; set; }

        // ...

        public override string GetSummary()
        {
            return $"Subject: { Name + NewLine }"
                + $"Start: { StartDateTime + NewLine }"
                + $"End: { EndDateTime + NewLine }"
                + $"Location: { Location }";
        }
    }
}
