using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gs
{
    /// <summary>
    /// Ask the user to guess a number between range we made
    /// </summary>
    public class numberGuesser
    {
        #region guess range prorerties

        /// <summary>
        /// the larger number we ask the user to guess
        /// </summary>
        public int MaximumNumber { get; set;} = 200;

        /// <summary>
        /// the current known minimun number the user is thinking of
        /// </summary>
        public int MinimumNumber { get; private set; }

        /// <summary>
        /// the current known maximum number  the user is thinking of
        /// </summary>
        public int Guess { get; private set; }  //guessing step

        #endregion

        public numberGuesser()
        {
            
            MaximumNumber = 200;

        }

        /// <summary>
        /// ask user to think of a number
        /// </summary>
        public void AskUser()
        {
            //ask user a num
            Console.WriteLine($"guess the number between {MinimumNumber} and {MaximumNumber} and press Y as 'Yes' and N as 'No'");
            Console.ReadLine();
        }

        /// <summary>
        /// series of questions to figure out the number
        /// </summary>
        public void NumGuesser()
        {
            //defining gusser num
            Guess = MaximumNumber / 2;

            //guessing loop
            while (MinimumNumber != MaximumNumber)
            {

                Console.WriteLine($"is your num between {MinimumNumber} and {Guess}");
                string response = Console.ReadLine();
                // '?.' means is = 0; FirstOtDefault checks 1st char 
                if (response?.ToLower().FirstOrDefault() == 'y')
                {
                    MaximumNumber = Guess;
                    Guess = Guess - (Guess - MinimumNumber) / 2;

                }
                else
                {
                    MinimumNumber = Guess + 1;
                    int remainingDifference = MaximumNumber - Guess;
                    Guess = MaximumNumber - remainingDifference / 2;
                }

                // if 2 nims left
                if (MinimumNumber + 1 == MaximumNumber)
                {
                    Console.WriteLine($"is your num {MinimumNumber}");
                    response = Console.ReadLine();
                    if (response?.ToLower().FirstOrDefault() == 'y')
                    {
                        break;

                    }
                    else
                    {
                        MinimumNumber = MaximumNumber;
                        break;
                    }
                }
            }

        }
    }
}
