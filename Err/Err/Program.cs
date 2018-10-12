using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Err
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> {1,2,3,4,5,6 };
            List<int> small = getSmaller(numbers, 3);

            foreach (int number in small)
                Console.WriteLine(number);

            Console.ReadLine();
            
        }

        private static List<int> getSmaller(List<int> numbers, int v)
        {
            List<int> smallest = new List<int>();

            while (smallest.Count<v) {
                int min = getSmaller(numbers);
                smallest.Add(min);
                numbers.Remove(min);
            }

            return smallest;

        }

        private static int getSmaller(List<int> list) {
            int min = list[0];

            for(int i = 1;i <list.Count;i++) {
                if (list[i] > min)
                    min = list[i];
            }

            return min;
        }
    }
}
