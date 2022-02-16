using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task2_TMS
{
    internal class Entities : ICloneable
    {
        public string Description { get; set; } = string.Empty;

        public Entities(string description)
        {
            Description = description;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

    }
}
