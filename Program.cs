using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MealCard card = new MealCard("Alice");
            card.BuyFood(30);
            card.AddPoints(20);
            card.BuyFood(100);


        }
    }
}
