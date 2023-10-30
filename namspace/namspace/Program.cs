using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Es = Electronic.Sony;
namespace namspace
{
    internal class DemoAlias
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //employee.Display();

            // sử dụng lớp bên trong namesapce
            Es.Xperiaz z = new Es.Xperiaz();
        }
    }
}
namespace Electronic
{
    namespace Sony
    {
        //public void Display()
        //{
        //    Console.WriteLine("Day la lop nhan vien");
        //}

        class Xperiaz
        {

        }
    }
}