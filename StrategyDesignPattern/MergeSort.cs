using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //immplemnation
            Console.WriteLine("MergeSort list");
        }
    }
}
