using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Program
    {
        static int[] FlattenArray(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[] flattenedArray = new int[rows * cols]; // Tạo mảng một chiều có kích thước là rows * cols

            int index = 0; // Biến để theo dõi vị trí trong mảng một chiều

            // Duyệt qua từng phần tử trong mảng hai chiều và thêm vào mảng một chiều
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    flattenedArray[index] = matrix[i, j];
                    index++;
                }
            }

            return flattenedArray;
        }
        static void Main(string[] args)
        {
            int[,] a = { 
                { 1, 2, 5, 6 }, 
                { 3, 4, 7, 8 }, 
                { 5, 6, 9, 10 }, 
                { 6, 7, 2, 14 } };
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++) {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0;i< a.GetLength(0); i++)
            {
                for(int j = 0;j< a.GetLength(1); j++)
                {
                    if(i== j)
                    {
                        sum += a[i, j];
                    }
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine("Cac phan tu nho nhat tren cot: ");
            for (int j = 0;j< a.GetLength(0); j++)
            {
                int min = a[0, j];
                for (int i = 0; i < a.GetLength(1); i++)
                {
                    if(min > a[i, j])
                    {
                        min = a[i, j];
                    }
                   
                }
                Console.WriteLine("Cot {0}:{1}", j, min);

            }
            Console.WriteLine("Liet ke cac phan tu chia het cho 7: ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i,j] %7 == 0)
                    {
                        Console.WriteLine("Phan tu tai hang {0}, cot {1}: {2}", i + 1, j + 1, a[i, j]);
                    }
                }
            }
            Console.WriteLine("Tong cac phan tu nam tren duong vien cua mang: ");
            int tong =0;
            for (int i = 0;i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == 0 || i == a.GetLength(0) - 1 || j == 0 || j == a.GetLength(1) - 1)
                    {
                        tong += a[i, j];
                    }
                }
            }
            Console.WriteLine(tong);
            // Chuyển mảng 2 chiều thành 1 chiều
            int[] flattenedArray = FlattenArray(a);

            Console.WriteLine("Mang 1 chieu:");
            foreach (int num in flattenedArray)
            {
                Console.Write(num + " ");
            }

            Console.ReadLine();
        }
    }
}
