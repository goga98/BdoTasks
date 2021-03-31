using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampleone
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 4, 5, 7, 10, 3 };
            int[] y = { 2, 3, 12, 6 };
            SecondTask(x,y);
            Console.ReadKey();
        }

        static void SecondTask(int[] x, int[]y)
        {
            int temp = 0;
            int[] combined = x.Concat(y).ToArray();
            for (int i = 0; i < combined.Length; i++)
            {
                for (int j = i + 1; j < combined.Length; j++)
                {
                    if (combined[i] > combined[j])
                    {
                        temp = combined[j];
                        combined[j] = combined[i];
                        combined[i] = temp;
                    }                  
                }
                Console.WriteLine(combined[i]);
            }

        }
    }
}
