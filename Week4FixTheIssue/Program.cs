using System;

namespace Week4FixTheIssue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, please help me fix the three bugs exist in this program.");
            SSL ssl = new SSL();

            Item numOne = new Item(1);
            ssl.addToHead(numOne);

            Item numThree = new Item(3);
            ssl.addToTail(numThree);

            Item numTwo = new Item(2);
            ssl.addInBetween(numOne, numTwo);

            Item numFour = new Item(4);
            ssl.addToTail(numFour);

            Item numFive = new Item(5);
            ssl.addToTail(numFive);

            Item numSix = new Item(6);
            ssl.addToTail(numSix);

            Item tempNum = new Item(11);

            ssl.print();

            if (ssl.searchIssue(6))
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not found");
            }
            Console.ReadKey();
        }
    }
}
