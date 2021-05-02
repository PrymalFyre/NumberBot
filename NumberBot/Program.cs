using System;

namespace NumberBot
{
    class Program
    {
        //takes the players input and converts it to guess
        private static int GetGuess()
        {
            int guess = 0;
            try
            {
                guess = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("It appears your guess is invalid.");
                Console.WriteLine("Please try another");
                guess = GetGuess();
            }
            return guess;
        }

        static void Main(string[] args)
        {
            //introduce NumberBot and invite to play
            Console.WriteLine("Greetings, I am NumberBot");
            Console.WriteLine("If you would like to play a game.");

            //generate random number
            int randomNumber = new Random().Next(1, 25);
            Console.WriteLine("Guess a number between 1 and 25");

            //keep track of how many tries
            int maxTries = 5;
            int tryTracker = 0;

            //each guess counts as a try. 5 tries to win
            while(true)
            {
                int guess = GetGuess();
                tryTracker++;

                //start to compare guess with randomNumber
                if (guess == randomNumber)
                {
                    Console.WriteLine("Excellent and well done. You have guessed the correct number.");
                    break;
                }
                if (guess > randomNumber)
                {
                    Console.WriteLine("Good guess, but too HIGH.");
                }
                if (guess < randomNumber)
                {
                    Console.WriteLine("Nice try, but too LOW.");
                }
                if (tryTracker == maxTries)
                {
                    Console.WriteLine("How unfortunate. It looks as though you are out of tries.");
                    Console.WriteLine($"The number you were trying to guess was {randomNumber}.");
                    Console.WriteLine("Thank you for playing.");
                    break;
                }
                Console.WriteLine($"You only have {maxTries - tryTracker} left.");
                Console.WriteLine("Try again. NumberBot still believes in you.");
            }





        }
    }
}
