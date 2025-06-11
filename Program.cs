using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K24GD_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào 2 số a và b:");
            int[] array = { 1, 2, 3 };
            //Console.WriteLine("Array[3] = " + array[3]);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Array[{i}] = {array[i]}");
            }
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Thuong là: " + TinhThuong(a, b));

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZeroException:" + ex.Message);
                Console.WriteLine("DivideByZeroException:" + ex.StackTrace);
            }

            catch (FormatException ex)
            {
                Console.WriteLine("FormatException:" + ex.Message);
                Console.WriteLine("FormatException:" + ex.StackTrace);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("ArithmeticException:" + ex.Message);
                Console.WriteLine("ArithmeticException:" + ex.StackTrace);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception test:" + ex.Message);
                Console.WriteLine("Exception test:" + ex.StackTrace);

            }
            finally
            {
                Console.WriteLine("finally:");
            }
            ;

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
        static float TinhThuong(float a, float b)
        {
            Console.WriteLine("Nhập vào 2 số a và b:");
            if (b == 0)
            {
                Console.WriteLine("Lỗi b = 0");
                throw new Exception("Input Lỗi b = 0 !!!");
            }
            float c = (a / b);
            return c;
        }
        static void CauseFormatException()
        {
            string s = "Hello World!";
        }

        public class InvalidAgeCuaToiExpecption : Exception
        {
            public InvalidAgeCuaToiExpecption(string message) : base(message) { }
        }
    }
}