using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Input();
            book.PrintBook();
            Console.WriteLine("\t\t<--------------|Search a Book|-------------->");

            Console.WriteLine("Enter The Book Title Do you want to Search: ");
            string book1 = Console.ReadLine();
            for (int i = 0; i < book.Title.Length; i++)
            {
                if (book.Title[i] == book1)
                {
                    book.Search(book1);
                }
            }
        }



    }
}
   