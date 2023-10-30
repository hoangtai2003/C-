using System;

namespace classandoop
{
    class Student
    {
        private string id;
        private string name;
        private double mark1, mark2, mark3;

        public string Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public double Mark1 { get { return mark1; } set { mark1 = value; } }
        public double Mark2 { get { return mark2; } set { mark2 = value; } }
        public double Mark3 { get { return mark3; } set { mark3 = value; } }
        public Student() {
        }
        public Student(string id, string name, double mark1, double mark2, double mark3) 
        { 
            this.id = id;
            this.name = name;
            this.mark1 = mark1;
            this.mark2 = mark2;
            this.mark3 = mark3;
        }
        public void Display()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Mark1: {0}\nMark2: {1}\nMark3: {2}", mark1, mark2, mark3);
        }

        public double Average()
        {
            double avg = (mark1 + mark2 + mark3) / 3;
            return avg;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("S001", "Tran Tuan Kiet", 10, 9.5, 8);
            st.Display();
            double avg = st.Average();
            int sum = st.Add(10, 5);
            Console.WriteLine(avg);
            Console.WriteLine(sum);
        }
    }
}
