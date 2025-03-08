using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes4
{
    internal class Book
    {
        public string[] Title = new string[2];
        public int[] ISBN = new int[2];
        public double[] Price = new double[2];
        public int[] Major_Area = new int[2];
        public int[] Sub_Area = new int[2];
        public int[] NoPages = new int[2];

        public void Input()
        {
            for (int i = 0; i < Title.Length; i++)
            {
                Console.WriteLine("Enter Title of Book {0}", i + 1);
                Title[i] = Console.ReadLine();
            }
            for (int i = 0; i < ISBN.Length; i++)
            {
                Console.WriteLine("Enter ISBN of Book {0}", i + 1);
                ISBN[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < Price.Length; i++)
            {
                Console.WriteLine("Enter Price of Book {0}", i + 1);
                Price[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < Major_Area.Length; i++)
            {
                Console.WriteLine("Enter Major Area of Book {0}", i + 1);
                Major_Area[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < Sub_Area.Length; i++)
            {
                Console.WriteLine("Enter SUB AREA of Book {0}", i + 1);
                Sub_Area[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < NoPages.Length; i++)
            {
                Console.WriteLine("Enter No of Pages of Book {0}", i + 1);
                NoPages[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void PrintBook()
        {
            for (int i = 0; i < ISBN.Length; i++)
            {
                Console.WriteLine("\t\t<--------------|Book{0}|-------------->", i + 1);
                Console.WriteLine($"The Title of Book is: {Title[i]}");
                Console.WriteLine($"The ISBN of Book is: {ISBN[i]}");
                Console.WriteLine($"The Price of Book is: {Price[i]}");
                Console.WriteLine($"The Major Area of Book is: {Major_Area[i]}");
                Console.WriteLine($"The Sub Area of Book is: {Sub_Area[i]}");
                Console.WriteLine($"The No of Pages of Book are: {NoPages[i]}");
            }
        }
        public void Search(string book1)
        {
            for (int i = 0; i < Title.Length; i++)
            {
                if (Title[i] == book1)
                {
                    Console.WriteLine($"The Title of Book is: {Title[i]}");
                    Console.WriteLine($"The ISBN of Book is: {ISBN[i]}");
                    Console.WriteLine($"The Price of Book is: {Price[i]}");
                    Console.WriteLine($"The Major Area of Book is: {Major_Area[i]}");
                    Console.WriteLine($"The Sub Area of Book is: {Sub_Area[i]}");
                    Console.WriteLine($"The No of Pages of Book are: {NoPages[i]}");
                }
            }
        }
    }
}

