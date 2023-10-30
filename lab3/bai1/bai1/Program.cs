using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{

    internal class Program
    {
        static bool ktsonguyento( int n)
        {
            if (n < 2)
            {
                return false;
            }
            else
            {
                if (n%2 == 0)
                {
                    return false;
                } else
                {
                    for (int i = 2;i<n;i++)
                    {
                        if(n%i == 0)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[] a = { 5, 4, 2, 7, 8, 10, 9, 1, 6, 3 };
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.Write("Phan tu nho nhat cua mang:"+ min);
            Console.WriteLine();
            Array.Reverse(a);
            for (int i = 0;i < a.Length; i++)
            {
                Console.Write(" {0} ", a[i]);
            }
            Console.WriteLine();

            Array.Sort(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" {0} ", a[i]);
            }
            Console.WriteLine();
            Console.Write("Kiem tra so nguyen to: ");
            foreach (int n in a)
            {
                if (ktsonguyento(n))
                {
                    Console.Write(n + " ");
                }
            }
            // in ra số lượng các số dương liên tiếp nhiều nhất
            Console.Write("\nTong so duong: ");
            int[] arr = {1, 2, 3, 6, -7, -1, 8, 9 };
            int CurrentCount = 0;
            int maxCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    CurrentCount++;
                    if (CurrentCount > maxCount)
                    {
                        maxCount = CurrentCount;
                    } 
                }
                else
                {
                    CurrentCount = 0;
                }
            }
            Console.WriteLine(maxCount);
            // Tính trung bình cộng các phần tử dương
            Console.WriteLine("\nTinh trung binh cong cac phan tu duong: ");
            double tbc = 0;
            double sum = 0;
            int count = 0;
            foreach (int n in arr)
            {
                if (n> 0)
                {
                    sum += n;
                    count++;
                }
            }
            if(count > 0)
            {
                tbc = sum / count;
                Console.WriteLine(tbc);
            }
            Console.WriteLine("Kiem tra mang co chua phan tu am duong: ");
            bool check = false;
            for (int i = 0;i < arr.Length-1;i++)
            {
                if (arr[i] >= 0 && arr[i+1] < 0 || arr[i] < 0 && arr[i+1] >=0) {
                    check = true;
                }
            }
            if (check)
            {
                Console.WriteLine("am duong dan xen");
            } else
            {
                Console.WriteLine("am duong khong dan xen");
            }
        }
    }
}
