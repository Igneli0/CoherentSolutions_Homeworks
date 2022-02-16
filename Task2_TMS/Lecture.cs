using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_TMS
{
    internal class Lecture : Entities
    {
        public string Topic { get; set; } = string.Empty;

        public Lecture(string topic, string description) : base(description)
        {
            Topic = topic;
        }
    }
}
