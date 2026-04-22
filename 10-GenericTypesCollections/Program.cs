using System;
using System.Collections.Generic;
using _10_GenericTypesCollections.GenericC;
using _10_GenericTypesCollections.Models;
using static System.Net.WebRequestMethods;
namespace _10_GenericTypesCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new(1, "Martin Eden", "Jack London", 1909, 400);
            Book book2 = new Book(2, "1984", "George Orwell", 1949, 328);
            Book book3 = new Book(3, "Animal Farm", "George Orwell", 1945, 112);
            Book book4 = new Book(4, "Ağ Gəmi", "Cingiz Aytmatov", 1970, 200);
            Book book5 = new Book(5, "Qırıq Budaq", "Elçin", 1998, 350);


            book1.DisplayInfo();
            book2.DisplayInfo();
            book3.DisplayInfo();
            book4.DisplayInfo();
            book5.DisplayInfo();

            Library<Book> library = new Library<Book>("Milli Kitabxana");

            library.Add(book1);
            library.Add(book2);
            library.Add(book3);
            library.Add(book4);
            library.Add(book5);

            Console.WriteLine("Kitab sayı: " + library.Count());

            library.FindByIndex(0).DisplayInfo();
            library.FindByIndex(2).DisplayInfo();

            foreach (var b in library.GetAll())
                b.DisplayInfo();

            List<Member> members = new List<Member>()
        {
            new Member(1,"Ali Məmmədov","ali@mail.com"),
            new Member(2,"Leyla Həsənova","leyla@mail.com"),
            new Member(3,"Vüqar Əliyev","vuqar@mail.com")
        };

            members[0].BorrowBook(book1);
            members[0].BorrowBook(book2);
            members[0].DisplayBorrowedBooks();

            members[0].ReturnBook(1);
            members[0].DisplayBorrowedBooks();

            members[0].BorrowBook(book3);
            members[0].BorrowBook(book4);
            members[0].BorrowBook(book5);


            BookManager manager = new BookManager();
            manager.AddBook(book1);
            manager.AddBook(book2);
            manager.AddBook(book3);
            manager.AddBook(book4);
            manager.AddBook(book5);

            foreach (var b in manager.GetBooksByAuthor("George Orwell"))
                b.DisplayInfo();


            manager.AddToWaitingQueue("Nigar");
            manager.AddToWaitingQueue("Rəşad");
            manager.AddToWaitingQueue("Səbinə");

            Console.WriteLine("Xidmət edilir: " + manager.ServeNextInQueue());


            manager.ReturnBook(book1);
            manager.ReturnBook(book2);
            manager.ReturnBook(book3);

            Console.WriteLine("Son kitab: " + manager.GetLastReturnedBook()?.Title);

            manager.RecentlyReturned.Pop();

            Console.WriteLine("Yeni son kitab: " + manager.GetLastReturnedBook()?.Title);


            var found = manager.SearchByTitle("1984");
            if (found != null) found.DisplayInfo();

            var notFound = manager.SearchByTitle("Harry Potter");
            if (notFound == null)
                Console.WriteLine("Tapılmadı");


            Console.WriteLine("Ümumi kitab: " + manager.Books.Count);
            Console.WriteLine("Ümumi üzv: " + members.Count);
            Console.WriteLine("Növbə sayı: " + manager.WaitingQueue.Count);
            Console.WriteLine("Stack sayı: " + manager.RecentlyReturned.Count);

            int minYear = int.MaxValue;
            int maxYear = int.MinValue;

            foreach (var b in manager.Books)
            {
                if (b.Year < minYear) minYear = b.Year;
                if (b.Year > maxYear) maxYear = b.Year;
            }

            Console.WriteLine("Ən köhnə il: " + minYear);
            Console.WriteLine("Ən yeni il: " + maxYear);

            Console.WriteLine("          KİTABXANA STATİSTİKASI");

            Console.WriteLine($"Ümumi kitab sayı: {manager.Books.Count}");
            Console.WriteLine($"Sistemdəki üzv sayı: {members.Count}");
            Console.WriteLine($"Növbədə gözləyənlərin sayı: {manager.WaitingQueue.Count}");
            Console.WriteLine($"Son qaytarılan (Stack) kitab sayı: {manager.RecentlyReturned.Count}");

            if (manager.Books.Count > 0)
            {
                int minyear = int.MaxValue;
                int maxyear = int.MinValue;
                Book oldestBook = null;
                Book newestBook = null;

                foreach (var b in manager.Books)
                {
                    if (b.Year < minYear)
                    {
                        minYear = b.Year;
                        oldestBook = b;
                    }

                    if (b.Year > maxYear)
                    {
                        maxYear = b.Year;
                        newestBook = b;
                    }
                }

                Console.WriteLine($"Ən köhnə kitab: {oldestBook.Title} ({minYear})");
                Console.WriteLine($"Ən yeni kitab: {newestBook.Title} ({maxYear})");
            }
            else
            {
                Console.WriteLine("Sistemdə analiz ediləcək kitab yoxdur.");
            }

        }
    }
}

    

