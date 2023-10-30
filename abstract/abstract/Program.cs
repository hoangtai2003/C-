using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    public abstract class Person
    {
        // Phương thức trừu tượng
        public void Speak()
        {
            Console.WriteLine("Moi nguoi deu noi Tieng Viet");
        }
        // Phương thức trừu tượng
        public abstract void DoWork();
        public abstract void EnvironmentWork();
    }
    class Employee : Person
    { 
        public override void DoWork()
        {
            Console.WriteLine("Lam viec rat vat va");
        }
        public override void EnvironmentWork()
        {
            Console.WriteLine("Lam viec tai cac nha may rat doc hai");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.DoWork();
            e.EnvironmentWork();
        }
    }
}
