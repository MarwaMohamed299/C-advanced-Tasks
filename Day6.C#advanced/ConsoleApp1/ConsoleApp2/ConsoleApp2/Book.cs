using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Book
    {

            public string ISBN { get; set; }
            public string Title { get; set; }
            public string [] Authors{ get; set; }
            public DateTime PublicationDate { get; set; }
            public decimal Price { get; set; }
            public Book(string _ISBN, string _Title,
            string [] _Authors, DateTime _PublicationDate,
           decimal _Price)
            {
                throw new NotImplementedException();
            }

        public Book()
        {
        }
       
        public override string ToString()
        {
             return $" ISBN is{ISBN}: Publication date is {PublicationDate}: Price is{Price}: Title is{Title}: Authors are {Authors}";
        }

        internal string GetAuthors()
        {
            throw new NotImplementedException();
        }

       
    }
    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }
        public static string GetAuthors(Book B)
        {
            string Authors =string.Join(",", B.Authors);
            return Authors;
        }
        public static string GetPrice(Book B)
        {
            return B.Price.ToString();
        }
    }
   

    }
   

