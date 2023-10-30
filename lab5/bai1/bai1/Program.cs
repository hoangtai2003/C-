using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai1
{
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return "\nId:" + Id + "\nTitle:" + Title + "\nAuthor:" + Author
                + "\nPublisher:" + Publisher + "\nYear:" + Year + "\nPrice:" + Price;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8;
            List<Book> list = new List<Book>()
            {
                new Book() { Id = 1, Title = "To Kill a Mockingbird", Author="Harper Lee", Publisher = "HarperCollins", Year=1960, Price=10.99M},
                new Book() { Id = 2, Title = "1984", Author="George Orwell", Publisher = "HarperCollins", Year=2014, Price=9.99M},
                new Book() { Id = 3, Title = "The Great Gatsby", Author="F. Scott Fitzgerald", Publisher = "HarperCollins", Year=2014, Price=12.5M},
                new Book() { Id = 4, Title = "Pride and Prejudice", Author="Jane Austen", Publisher = "HarperCollins", Year=1960, Price=8.99M},
                new Book() { Id = 5, Title = "The Catcher in the Rye", Author="J.D. Salinger", Publisher = "HarperCollins", Year=1960, Price=11.25M},
                new Book() { Id = 6, Title = "The Hobbit", Author="J.R.R. Tolkien", Publisher = "Nhi Dong", Year=1960, Price=9.95M},
                new Book() { Id = 7, Title = "To the Lighthouse", Author="Virginia Woolf", Publisher = "HarperCollins", Year=1960, Price=10M},
                new Book() { Id = 8, Title = "Moby-Dick", Author="Herman Melville", Publisher = "HarperCollins", Year=1960, Price=13.5M},
                new Book() { Id = 9, Title = "Brave New World", Author="Aldous Huxley", Publisher = "HarperCollins", Year=1960, Price=10.5M},
                new Book() { Id = 10, Title = "The Lord of the Rings", Author="J.R.R. Tolkien", Publisher = "HarperCollins", Year=1960, Price=25.0M}
            };

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Hiển thị danh sách tăng dần theo giá");
                Console.WriteLine("2. Tim sach theo tieu de");
                Console.WriteLine("3. Tim sach xuat ban nam 2014");
                Console.WriteLine("4. Xoa sach cua nha xuat ban 'Nhi Dong'");
                Console.WriteLine("5. Thoat chuong trinh");
                Console.Write("Chon: ");

                int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Danh sách sách tăng dần theo giá");
                            var booksByPrice = list.OrderBy(book => book.Price);
                            foreach (var book in booksByPrice)
                            {
                                Console.WriteLine($"{book.Title} - Price: {book.Price:C}");
                            }
                            break;

                        case 2:
                            Console.WriteLine("Tim sach theo tieu de: ");
                            string name = Console.ReadLine();
                            var Searchbook = list.FirstOrDefault(book => book.Title == name);
                            if (Searchbook != null)
                            {
                                Console.WriteLine($"Quyen sach co tieu de '{name}' co gia: {Searchbook.Price:C}");
                            }
                            else
                            {
                                Console.WriteLine("Khong tim thay quyen sach co tieu de nhu vay.");
                            }

                            break;
                        case 3:
                            Console.WriteLine("Sach xuat ban nam 2014");
                            var bookPublisher = list.Where(book => book.Year == 2014);
                            foreach (var book in bookPublisher)
                            {
                                Console.WriteLine(book.Title);
                            }
                            break;
                        case 4:
                            Console.WriteLine("Xoa sach cua nha xuat ban 'Nhi Dong'");
                            list.RemoveAll(book => book.Publisher == "Nhi Dong");
                            Console.WriteLine("Danh sach: ");
                            foreach (var ds in list)
                            {
                                Console.Write(ds);
                            }
                            break;
                        case 5:
                            Environment.Exit(0);
                        break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }
            }
        }
    }
}
