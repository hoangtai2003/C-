using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_3
{
    public class Chapter
    {
        private string name;
        private string content;
        public Chapter() { }
        public Chapter(string name, string content)
        {
            this.name = name;
            this.content = content;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        public override string ToString()
        {
            return name + "\n" + content;
        }
    }
    public class Book
    {
        private string name;
        private Chapter[] chapters;

        public Book() { }
        public Book(string name, int n)
        {
            this.name = name;
            chapters = new Chapter[n];
        }
        public string Name {  
            get { return name;} 
            set
            {
                if (name == value) {
                    throw new ArgumentNullException();
                }
                name = value;
            }
        }
        // index thứ nhất có một tham số kiểu int
        public Chapter this[int index]
        {
            get
            {
                if (index < 0 || index > chapters.Length-1) {
                    return null;
                }
                return chapters[index];

            }
            set
            {
                if (index < 0 || index > chapters.Length - 1)
                {
                    return chapters[index];
                }
                return [index] = value
            }
        }
        // indexer thứ hai có một tham số kiểu string
        public Chapter this[string name]
        {
            get
            {
                foreach(Chapter chapter in chapters)
                {
                    if (chapter.Name == name)
                    {
                        return chapter;
                    }

                }
                return null;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // tạo đối tượng book
            Book book = new Book("Programming with Csharp", 4);
            // Nhập thông tin các chương
            book[0] = new Chapter("Chapter 1", "Tay du ky");
            book[1] = new Chapter("Chapter 2", "Hary Porter");
            book[2] = new Chapter("Chapter 3", "Than thoai hy lap");
            book[3] = new Chapter("Chapter 4", "Cay den than");
            // in thông tin sách
            Console.WriteLine("Thong tin sach: ");
            Console.WriteLine(book.Name);
            // Danh sách chương
            for (int i = 0;i<4; i++)
            {
                Console.WriteLine(book[i]);
            }
            // Thông tin chương 3
        }
    }
}
