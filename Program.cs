using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_Snail_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] array = { new []{1, 2, 3}, new []{4, 5, 6}, new []{7, 8, 9} };
            foreach (int i in SnailSolution.Snail(array)) { Console.Write(i); };
            Console.ReadKey();
        }
    }
}
