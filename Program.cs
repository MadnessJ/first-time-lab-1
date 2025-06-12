using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace random_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insert text here");
        }
        public static void RandomNum(int num)
        {
            Console.WriteLine("Value: " + num);
                Random random = new Random((int) DateTime.Now.Ticks);
                for (int i = 0; i < num; i++) {
                    int value = random.Next(100);
                    Console.WriteLine(value + "");
            }
        }
    }
}