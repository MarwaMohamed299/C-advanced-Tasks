using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Repository
    {
        public static List<Book>  Books{get;set;}
             =new List<Book>()
        {
            new Book(){ ISBN ="8",Title= "Dentition" ,Authors=new string[] {"mohamed","mariam" },PublicationDate= DateTime.Now ,Price=15},
            new Book { ISBN ="2",Title= "Material" , Authors= new string[]{"Youssef","hussein"},PublicationDate= DateTime.Now ,Price=88 },
            new Book { ISBN ="97",Title= "Crown" , Authors= new string[]{"yara","sandy"},PublicationDate=  DateTime.Now ,Price=99},
            new Book { ISBN ="99",Title= "Pedo" , Authors= new string[]{"osama","reem"},PublicationDate=  DateTime.Now ,Price=155}




            };


        
    }
}
