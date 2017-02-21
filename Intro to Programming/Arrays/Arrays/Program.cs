using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static int[] nums = new int[] {10, 50, 20, 40, 6};
        static Random rand = new Random();
        static void Main(string[] args)
        {
            int nums1 = rand.Next(0, nums.Count());
            Console.WriteLine(nums1);
            
            Console.ReadKey();
        }
    }
}
