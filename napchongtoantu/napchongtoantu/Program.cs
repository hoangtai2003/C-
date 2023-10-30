using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napchongtoantu
{
    class NapChong
    {
        static int sum(int a)
        {
            int s = 0;
            for (int i = 1; i < a; i++)
            {
                s += i;
            }
            return s;
        }
        static int sum(int a, int b)
        {
            int s = 0;
            for (int i = a; i <= b; i++) {
                s += i;
            }
            return s;
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static double Add(double a, double b)
        {
            return a + b;
        }
    }
    class Animal
    {
        string name;
        public Animal(string name)
        {
            this.name = name;
        }

        public void Eat()
        {
            Console.WriteLine("Dong vat an mot vai thu");
        }
        public void DoSomething()
        {
            Console.WriteLine("Dong vat lam mot vai thu");
        }
    }
    class Canime : Animal
    {
        public Canime():base("Lion")
        {
            Console.WriteLine("Hoang Tai");
        }
    }
    //class Cat : Animal
    //{
    //    public void Actions()
    //    {
    //        Eat();
    //        DoSomething();
    //    }
    //}
    //class Dog : Animal
    //{
    //    public void eat()
    //    {
    //        Console.WriteLine("Dog eating");
    //    }
    //    public void DoAction()
    //    {
    //        Dog d = new Dog();
    //        d.eat();
    //        base.Eat();
    //    }
    //}
    class Person
    {
        string id;
        string name;
        string address;
        string phone;
        public Person(string id, string name, string address, string phone)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
        }
        public void Display()
        {
            Console.WriteLine(id + name + );
        }
    }
    class Staff : Person
    {
        int salary;
        public Staff(string id, string name, string address, string phone, int salary):base(id, name, address, phone)
        {
            this.salary = salary;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cat cat = new Cat();
            //Dog dog = new Dog();
            //cat.Actions();
            //dog.DoAction();
            //Canime canime = new Canime();
            Staff staff = new Staff("1", "Tai", "Nam Dinh", "098897", 1000);

        }
    }
}
