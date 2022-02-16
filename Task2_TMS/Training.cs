using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_TMS
{
    internal class Training : Entities, ICloneable
    {

        public List<Entities> trainingList = new List<Entities>();
      
        public Training(string description) : base(description)
        {
            Description = description;
        }

        //Adding method
        public void Add(Entities item)
        {
            this.trainingList.Add(item);
        }

        public object Clone()
        {
            List<Entities> cloneList = new List<Entities>();

            foreach (var item in trainingList)
            {
                var temp = item.Clone();
                cloneList.Add((Entities)item);
            }

            return new Training(Description)
            {
                trainingList = cloneList
            };
        }

        public override string ToString()
        {
            StringBuilder sb = new();

            foreach (var item in trainingList)
            {
                sb.Append($" {item},\n");
            }

            return sb.ToString();
        }

        //Is Practical method
        public bool IsPractical()
        {
            foreach (var item in trainingList)
            {
                if (item is Lecture)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
