using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace bai4
{
    class Employee
    {
        private int id;
        private string name;
        private int age;
        public Employee() { }
        public Employee(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public void setId(int id)
        {
            this.id = id;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public int getId() { return id; }
        public string getName() { return name; }
        public int getAge() { return age; }
        public void Display()
        {
            Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}");
        }
    }
    class Department
    {
        private Employee[] emp;
        private string name;
        public Department() { }
        public Department(int employeeCount, string name) 
        {
            this.name = name;
            emp = new Employee[employeeCount];
        }
        public Employee this[int index]
        {
            get { return emp[index]; }
            set { emp[index] = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Department itDepartment = new Department(3,"IT");

            // Đặt thông tin cho mỗi nhân viên
            itDepartment[0] = new Employee(1, "John", 30);
            itDepartment[1] = new Employee(2, "Jane", 35);
            itDepartment[2] = new Employee(3, "Mike", 28);

            // Hiển thị thông tin của mỗi nhân viên trong phòng ban
            Console.WriteLine("Employees in the IT department:");
            for (int i = 0; i < 3; i++)
            {
                itDepartment[i].Display();
            }
        }
    }
}
