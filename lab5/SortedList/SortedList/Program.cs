using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> list = new SortedList<string, string>();
            list.Add("E01", "Than Thi Thuy");
            list.Add("E02", "Le Hai Ha");
            list.Add("E03", "Nguyen Van Hung");
            list.Add("E04", "Hoang Thi Thom");
            list.Add("E05", "Trinh Van Chien");
            while (true)
            {
                Console.WriteLine("===========MENU==========");
                Console.WriteLine("1. In danh sach");
                Console.WriteLine("2. Tim kiem nhan vien co ten bat dau bang chu Th");
                Console.WriteLine("3. Xoa nhan vien co ma E04");
                Console.WriteLine("4. Kiem tra neu chua co nhan vien E06 thi them vao");
                Console.WriteLine("5. Exit");
                Console.Write("Chon: ");
                int luachon = int.Parse(Console.ReadLine());
                switch (luachon)
                {
                    case 1:
                        Console.WriteLine("Danh sach nhan vien");
                        foreach (var key in list.Keys)
                        {
                            Console.WriteLine(key + ":" + list[key]);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Tim kiem nhan vien co ten bat dau bang chu Th");
                        foreach (var key in list.Keys)
                        {
                            if (list[key].StartsWith("Th"))
                            {
                                Console.WriteLine(key +  ':' + list[key]);
                            }
                        }
                        break;
                    case 3:
                        list.Remove("E04");
                        break;
                    case 4:
                        if (!list.ContainsKey("E06"))
                        {
                            list.Add("E06", "Hoang Thi Thom");
                        }
                        break;  
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le");
                        break;
                }
            }
        }
    }
}
