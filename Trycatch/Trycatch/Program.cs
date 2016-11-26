using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trycatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{

            //    int[] array = new int[4];
            //    Console.WriteLine(array[4]);

            //}
            //catch (IndexOutOfRangeException ex)
            //{

            //    Console.WriteLine("Hata Oluştu ! " + ex.Message);
            //}

            try
            {
                int sayi;
                sayi = Convert.ToInt32(Console.ReadLine());
            }
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Hata Oluştu ! " + ex.Message);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Hata Oluştu ! " + ex.Message);
            //}

            catch (Exception ex)
            {
                Console.WriteLine("Hata Oluştu ! " + ex.Message);
            }            

            Console.Read();
        }
    }
}
