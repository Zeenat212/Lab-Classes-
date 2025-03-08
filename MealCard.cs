using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes3
{
    internal class MealCard
    {
        public string StudentName;
        public int Balance;

        public MealCard(string studentName, int balance)
        {
            StudentName = studentName;
            Balance = balance;
        }

        public MealCard(string studentName) // Default balance 100
        {
            StudentName = studentName;
            Balance = 100;
        }

        public void BuyFood(int points)
        {
            if (Balance >= points)
            {
                Balance -= points;
                Console.WriteLine("Purchase successful. Remaining balance: " + Balance);
            }
            else
            {
                Console.WriteLine("Not enough points.");
            }
        }

        public void AddPoints(int points)
        {
            Balance += points;
            Console.WriteLine("New balance: " + Balance);
        }

    }
}
