using System;

namespace NumbersGame
{
    internal class Program
    {
        public static void WelcomeMessage()//Welcome messages in an own method, using void because no return.
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
        }
        public static int GenerateNumber (int value)
        {
            Random rnd = new Random(); //Random class with Next method that randomly generates a number between 1-20.
            int randomNumber = rnd.Next(1, value);
            return randomNumber;
        }

        static void Main(string[] args)
        {
            int random = GenerateNumber(21);//To generate only one randomnumber.
            bool isCorrectGuess = false; //Bool generates true or false answer.
            int guesses = 0;

            WelcomeMessage(); //Calling my method.

            while (!isCorrectGuess)//while loop with condition if NOT false, keep going.
            {
                int.TryParse(Console.ReadLine(), out int guess);//Try Parse to make sure no error.
                guesses++; //counter

                //if statement with two terms, either IF to high of ELSE IF to low. Then un ELSE if neither of the terms applies.
                if (guess > random)
                {
                    Console.WriteLine("Tyvärr du gissade för högt!");
                }
                else if (guess < random)
                {
                    Console.WriteLine("Tyvärr du gissade för lågt!");
                }
                else
                {
                    Console.WriteLine("Wohoo! Du gjorde det!");
                    isCorrectGuess = true;//Bool becomes true.
                    Console.WriteLine("Du vann!");
                }

                if (guesses == 5 && !isCorrectGuess)//a separated IF with two terms if guesses is 5 and NOT false.
                {
                    Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
                    break;
                }
                

            }

            

            Console.ReadKey();
        }
    }
}
