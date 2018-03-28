using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exertionHW
{
    class Program
    {
        public static void ExeptionRandomArray()
        {
            Random rnd = new Random();
            int length = rnd.Next(0, 20);
            int fillnumbers = rnd.Next(0, 100);
            byte[] arrayExeption = new byte[length];
            try
            {
                for (int i = 0; i < fillnumbers; i++)
                {
                    int numbers = rnd.Next(256, 500);
                    byte numberstemp = (byte) numbers;
                    arrayExeption[i] =  numberstemp;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            foreach (var item in arrayExeption)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            ExeptionRandomArray();
            Console.ReadLine();
        }
    }
}
