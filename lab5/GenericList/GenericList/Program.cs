using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public double Avg {  get; set; }
        public override string ToString()
        {
            return "\nId:" + Id + "\nFullName:" + FirstName + " " + LastName
                + "\nGender:" + (Gender ? "Male" : "Female") + "\nAverage mark:" + Avg;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>()
            {
                new Student { Id = 1,FirstName = "Nguyen Thu", LastName = "Phuong", Avg = 9.15},
                new Student { Id = 2,FirstName = "Nguyen Thu", LastName = "Phuong", Avg = 9.2},
                new Student { Id = 3,FirstName = "Nguyen Thu", LastName = "Phuong", Avg = 9.3},
                new Student { Id = 4,FirstName = "Nguyen Thu", LastName = "Phuong", Avg = 9.4},
                new Student { Id = 5,FirstName = "Nguyen Thu", LastName = "Phuong", Avg = 9.5}
            };
            while (true)
            {

                Console.WriteLine("==========MENU==========");
                Console.WriteLine("1. In danh sach");
                Console.WriteLine("2. Tim sinh vien co diem cao nhat");
                Console.WriteLine("3. Thoat");
                Console.Write("Chon: ");
                int luachon = int.Parse(Console.ReadLine());
                switch (luachon)
                {
                    case 1:
                        Console.WriteLine("Danh sach sinh vien");
                        foreach (var student in list)
                        {
                            Console.WriteLine(student);
                        }
                        break;
                    case 2:
                        double max = list[0].Avg;
                        Student stmax = list[0];

                        foreach (var student in list)
                        {
                            if (student.Avg > max)
                            {
                                max = stmax.Avg;
                                stmax = student;
                            }
                        }
                        Console.WriteLine("Sinh vien co diem cao nhat la: ");
                        Console.WriteLine(stmax);
                        break;
                    case 3:
                        Environment.ExitCode = 0;
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le");
                        break;
                }
            }

        }
    }
}
