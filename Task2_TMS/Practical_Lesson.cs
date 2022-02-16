using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_TMS
{
    internal class Practical_Lesson : Entities
    {
        public string LinkToTask { get; set; } = string.Empty;
        public string LinkToSolution { get; set; } = string.Empty;

        public Practical_Lesson(string linkToTask, string linkToSolution, string description) : base(description)
        {
            LinkToTask = linkToTask;
            LinkToSolution = linkToSolution;
        }
    }
}
