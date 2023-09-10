namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var books = Repository.Books;
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }

            MyDelegate2 del1 = new MyDelegate2(BookFunctions.GetPrice);
            MyDelegate2 del3 = BookFunctions.GetTitle;
            MyDelegate2 del4 =B =>B. GetAuthors();



            ///BCL Delegate

            Book book1 = new Book("2","title1",new string[] {"ahmed","mohsen"},new DateTime(14,5,2020),156);
            Func<Book,string>fun =BookFunctions.GetPrice;
            Console.WriteLine(fun(book1));




            // c.Anonymous Method(GetISBN)

            MyDelegate2 del6 = s => s.Title;
            LibraryEngine.ProcessBooks(books,del6);


            //d.Lambda Expression(GetPublicationDate)

            MyDelegate2 del5 = (Book B) => { return B.ISBN; };
            LibraryEngine.ProcessBooks(books, del5);

        }
    }
} 