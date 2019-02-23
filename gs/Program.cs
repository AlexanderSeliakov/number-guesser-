using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace gs
{
    class Program
    {
        static void Main(string[] args)
        {
            //difining our class
            numberGuesser ng = new numberGuesser();

            //difining the range
            ng.MaximumNumber = 200;

            //ask a user to think of a number
            ng.AskUser();

            //guessing the number
            ng.NumGuesser();

            //anounce the result
            Console.WriteLine($"*****your Num is {ng.MinimumNumber}*****");
            Console.ReadKey();

        }
    }
}
