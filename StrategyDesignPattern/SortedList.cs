using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class SortedList
    {
        public List<string> List = new List<string>();
        private SortStrategy sortStrategy;

        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            this.sortStrategy = sortStrategy;
        }

        public void Add(string name)
        {
            List.Add(name); 
        }

        public void Sort()
        {
            sortStrategy.Sort(List);
            foreach (string name in List)
            {
                Console.WriteLine("" + name);
            }
            Console.WriteLine();
        }
    }
}
