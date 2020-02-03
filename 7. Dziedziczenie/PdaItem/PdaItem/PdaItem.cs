using System;
namespace PdaItem
{
    public abstract class PdaItem
    {
        public PdaItem(string name)
        {
            Name = name;
        }
        public virtual string Name { get; set; }
        public abstract string GetSummary();
    }
}
