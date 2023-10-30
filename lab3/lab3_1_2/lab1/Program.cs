using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8;
            //Khai báo và khởi tạo mảng một chiều
            int[] m = { 1, 2, 3, 2, 1 };
            // duyệt mảng và in dữ liệu
            for (int i = 0; i < m.Length; i++)
            {
                Console.Write(" {0} ", m[i]);
            }
            // Tìm phần tử lớn nhất
            int max = m[0];
            for (int i = 1; i<m.Length; i++)
            {
                if (max < m[i])
                {
                    max = m[i];
                }
            }
            Console.WriteLine("\nPhần tử lớn nhất: " + max);
            // Kiểm tra mảng có đối xứng không
            bool kt  = true;
            for (int i = 0; i< m.Length/2; i++)
            {
                if (m[i] != m[m.Length - 1 - i])
                {
                    kt = false;
                    break;
                }
            }
            if (kt)
            {
                Console.WriteLine("Mảng đối xứng");

            }
            else {
                Console.WriteLine("Mảng không đối xứng");
            }

            //Khai báo và khởi tạo mảng 2 chiều
            int[,] a = { { 4, 6, 9 }, { 5, 10, 11 }, { 6, 12, 13 }, { 7, 14, 15 } };
            //Duyệt mảng và in theo hàng cột
            Console.WriteLine("Noi dung mang: ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(" {0} ", a[i, j]);
                }
                Console.WriteLine();
            }
            // Tìm các phần tử có chỉ số hàng bằng chỉ số cột
            Console.WriteLine("Cac phan tu co chi so hang bang chi so cot: ");
            for(int i = 0;i < a.GetLength(0); i++)
            {
                for(int j = 0;j < a.GetLength(1); j++)
                {
                    if(i==j)
                    {
                        Console.Write(" {0} ", a[i, j]);
                    }
                }
            }
            // Các phần tử lớn nhất trên hàng
            Console.WriteLine("Cac phan tu lon nhat tren hang") ;
            for(int i = 0;i<a.GetLength(0); i++)
            {
                int maX = a[i,0];
                for(int j = 0;j<a.GetLength(1); j++)
                {
                    if (maX < a[i, j])
                    {
                        maX = a[i,j];
                    }
                }
                Console.WriteLine("Hang {0}:{1}", i, maX);
            }

        }
    }
}
