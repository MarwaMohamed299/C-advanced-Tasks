using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
        public class LibraryEngine
        {
            public static void ProcessBooks(List<Book> bList, MyDelegate2 fPtr)
            {
                foreach (Book B in bList)
                {
                    Console.WriteLine(fPtr(B));
                }
            }
        public static void ProcessBooksBCL(List<Book> bList, Func<Book,string> fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
    
}
