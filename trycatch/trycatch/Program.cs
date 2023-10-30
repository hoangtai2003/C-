using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
namespace trycatch
{
    //class Product
    //{
    //    private int price;
    //    public int Price
    //    {
    //        set
    //        {
    //            if (value < 0)
    //            {
    //                throw new ArithmeticException("Gia phai >=0");
    //            } else
    //            {
    //                price = value;
    //            }
    //        }
    //        get { return price; }
    //    }
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            // Biết rõ ngoại lệ xảy ra
            //int a = 10;
            //int b = 0;
            //int c;
            //try
            //{
            //    c = a/b;
            //}
            //catch (ArithmeticException ex)
            //{
            //    Console.WriteLine("Thong bao loi: " + ex.Message);
            //}

            // Không biết ngoại lệ nào có thể xảy ra
            //string[] names = new string[3];
            //try
            //{
            //    names[3] = "Itpd";
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Thong bao loi: " + ex.Message);
            //}

            //try
            //{
            //    Product p = new Poroduct();
            //    p.price = 0;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            string[] names = { "So", "Hai", "Dong" };
            int num = 0;
            int result;
            try
            {
                Console.WriteLine("Day la khoi try catch ngoai");
                try
                {
                    result = 13 / num;
                }
                catch(ArgumentException exp)
                {
             
                    Console.WriteLine(exp.Message);
                }
                names[3] = "chung";
            }
            catch(IndexOutOfRangeException exp) { 
                Console.WriteLine(exp.Message);
            }
       
        }
    }
}
