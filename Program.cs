using System;
using System.Linq;

namespace CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //Func<int, int, int> comparer =
            //          (a, b) =>
            //          {
            //              if (a % 2 == 0 && b % 2 != 0)
            //              {
            //                  return -1;
            //              }
            //              else if (a % 2 != 0 && b % 2 == 0)
            //              {
            //                  return 1;
            //              }

            //              return a.CompareTo(b);
            //          };

            //Array.Sort(nums, comparer);// за оправяне!!

            Array.Sort(nums, (a, b) =>
            {
                if (a % 2 == 0 && b % 2 != 0)
                {
                    return -1;
                }
                else if (a % 2 != 0 && b % 2 == 0)
                {
                    return 1;
                }

                return a.CompareTo(b);
            });



            Console.WriteLine(string.Join(" ",nums));
        }

        

    }
}
