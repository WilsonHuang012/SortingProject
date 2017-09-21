using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(random.Next(1, 101));
            }

            Console.WriteLine("Before Sort:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }

            Console.WriteLine();
            List<int> result = SortingAlgorithm.BubbleSort(list);

            Console.WriteLine("After Sort:");
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
