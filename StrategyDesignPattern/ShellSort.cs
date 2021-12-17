using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //immplementation 
            Console.WriteLine("ShellSort list");
        }


        //private  void ShellSortRun(string[] arr, int n)
        //{
        //    string temp;
        //    int i, j, pos;
        //    pos = 3;
        //    while (pos > 0)
        //    {
        //        for (i = 0; i < n; i++)
        //        {
        //            j = i;
        //            temp = arr[i];
        //            while ((j >= pos) && (arr[j - pos] > temp))
        //            {
        //                arr[j] = arr[j - pos];
        //                j = j - pos;
        //            }
        //            arr[j] = temp;
        //        }
        //        if (pos / 2 != 0)
        //            pos = pos / 2;
        //        else if (pos == 1)
        //            pos = 0;
        //        else
        //            pos = 1;
        //    }
        //}
    }
}
