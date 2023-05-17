using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probability_project
{
    internal class Program
    {
        static void Main(string[] args)               //mohamed ahmed elhossiny 
                                                      //amar yasser frag
        {
            Console.Write("Enter the number of items: ");
            int n = int.Parse(Console.ReadLine());

            int[] values = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter item value {0}: ", i + 1);
                values[i] = int.Parse(Console.ReadLine());
            }
            // Sort the array
            Array.Sort(values);

            int median;
            if (n % 2 == 0)
            {
                median = (values[n / 2] + values[n / 2 - 1]) / 2;
            }
            else
            {
                median = values[n / 2];
            }
            // Calculate the mode
            int mode = 0;
            int maxCount = 0;
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (values[j] == values[i])
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    mode = values[i];
                }
            }

            int range = values[n - 1] - values[0];

            int q1 = values[(int)Math.Ceiling((double)n / 4) - 1];
            int q3 = values[(int)Math.Ceiling((double)3 * n / 4) - 1];

            int p90 = values[(int)Math.Ceiling((double)9 * n / 10) - 1];

            int interquartile = q3 - q1;

            int lowerBound = (int)(q1 - (1.5 * interquartile));
            int upperBound = (int)(q3 + (1.5 * interquartile));
            Console.Write("Enter input value: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("The median is {0}", median);

            Console.WriteLine("The mode is {0}", mode);
            Console.WriteLine("The range is {0}", range);

            Console.WriteLine("The first quartile is {0}", q1);
            Console.WriteLine("The third quartile is {0}", q3);

            Console.WriteLine("The P90 is {0}", p90);

            Console.WriteLine("The interquartile is {0}", interquartile);

            Console.WriteLine("The outlier region boundaries are {0} and {1}",
           lowerBound, upperBound);

            if (input < lowerBound || input > upperBound)
            {
                Console.WriteLine("The input value is an outlier");
            }
            else
            {
                Console.WriteLine("The input value is not an outlier");
            }

        }
    }
}
