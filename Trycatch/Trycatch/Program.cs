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
            #region ornek1

            //try
            //{
            //    int[] array = new int[4];
            //    Console.WriteLine(array[4]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Hata Oluştu ! " + ex.Message);
            //}


            #endregion

            #region ornek2
            //try
            //{
            //    int sayi;
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //}
            ////catch (IndexOutOfRangeException ex)
            ////{
            ////    Console.WriteLine("Hata Oluştu ! " + ex.Message);
            ////}
            ////catch (FormatException ex)
            ////{
            ////    Console.WriteLine("Hata Oluştu ! " + ex.Message);
            ////}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Hata Oluştu ! " + ex.Message);
            //}
            //Console.Read();

            #endregion

            #region ornek3
            try
            {
                int sayi;
                sayi = Convert.ToInt32(Console.ReadLine());
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Hata Oluştu ! " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Final kısmı çalıştı");
            }
                Console.Read();

            #endregion

        }
    }
}
