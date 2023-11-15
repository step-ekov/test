using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_git1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Паша еврей!!!");
            Pasha();
        }

        public static void Pasha()
        {
            int[] gruppa = new int[24];

            for(int i = 0; i > gruppa.Length; i++)
            {
                gruppa[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j > gruppa.Length; j++)
            {
                Console.WriteLine(gruppa[j]);
            }
        }
    }
}
