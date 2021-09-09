using System;
using HandsOnEFDBFirst.Entities;
using System.Linq;
using System.Collections.Generic;
namespace HandsOnEFDBFirst
{
    class Program
    {
        public static void GetAllBooks() //get All the books from book_Master
        {
            using(TrainingContext db=new TrainingContext())
            {
                List<BookMaster> list=db.BookMasters.ToList();
                foreach(var item in list)
                {
                    Console.WriteLine($"Book_Code:{item.BookCode}" +
                        $"Book_name:{item.BookName}" +
                        $"Year:{item.PubYear} Author:{item.Author} Category:{item.BookCategory}");
                }
            }
        }
        public static void GetAllBooksByAuthor(string author) //get All the books from book_Master
        {
            using (TrainingContext db = new TrainingContext())
            {
                List<BookMaster> list = db.BookMasters.Where(b => b.Author == author).ToList();
                foreach (var item in list)
                {
                    Console.WriteLine($"Book_Code:{item.BookCode}" +
                        $"Book_name:{item.BookName}" +
                        $"Year:{item.PubYear} Author:{item.Author} Category:{item.BookCategory}");
                }
            }
        }
        public static void GetBookByCode(decimal book_code) //get All the books from book_Master
        {
            using (TrainingContext db = new TrainingContext())
            {
                BookMaster book = db.BookMasters.SingleOrDefault(b => b.BookCode == book_code);
                if (book != null)
                {
                    Console.WriteLine($"Book_Code:{book.BookCode}" +
                            $"Book_name:{book.BookName}" +
                            $"Year:{book.PubYear} Author:{book.Author} Category:{book.BookCategory}");
                }
                else
                {
                    Console.WriteLine("Invalid BookCode");
                }
            }
        }
        public static void AddBook(BookMaster book)
        {
            using(TrainingContext db=new TrainingContext())
            {
                db.BookMasters.Add(book); //adds record to bookmaster table
                db.SaveChanges(); 
            }
        }
        public static void UpdateBook(BookMaster book)
        {
            using (TrainingContext db = new TrainingContext())
            {
                db.BookMasters.Update(book); //adds record to bookmaster table
                db.SaveChanges();
            }
        }
        public static void DeleteBook(decimal bookCode)
        {
            using (TrainingContext db = new TrainingContext())
            {
                BookMaster book = db.BookMasters.Find(bookCode);
                db.BookMasters.Remove(book); //adds record to bookmaster table
                db.SaveChanges();
            }
        }
        static void Main(string[] args)
        {
            GetAllBooks();
            //Console.WriteLine("Enter Book_Code");
            //decimal book_code = decimal.Parse(Console.ReadLine());
            //GetBookByCode(book_code);
            //Console.WriteLine("Enter Author Name");
            //string author = Console.ReadLine();
            //GetAllBooksByAuthor(author);
            BookMaster book = new BookMaster()
            {
                BookCode = 78987,
                BookCategory = "Programming",
                BookName = "Python step by step",
                Author = "ABC",
                PubYear = 2021
            };
            AddBook(book);
            GetAllBooks();
        }
    }
}
