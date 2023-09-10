using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HiringDate:IComparable
    {

        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }

       
    public HiringDate()

        {
            day = 1;
            month = 1;
            year = 2020;
        }
        public HiringDate(int day, int month, int year)
        {
            this.day = day; 
            this.month = month;
            this.year = year;
        }
    
        public int CompareTo(object? obj)
        {
            var right = obj as HiringDate;
            return this.year.CompareTo(right.year);

        }
       
    }
}

