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
                Console.WriteLine("Oh no. It appears your guess is out of bounds.");
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
                if (guess > 25 || guess < 1)
                {
                    Console.WriteLine("NumberBot would like to take this moment to remind you that the number you are guessing is between 1 and 25");
                    tryTracker--;
                }
                if (guess > randomNumber)
                {
                    Console.WriteLine("It is a good guess, but too HIGH.");
                }
                if (guess < randomNumber)
                {
                    Console.WriteLine("It is a good guess, but too LOW.");
                }
                if (tryTracker == maxTries)
                {
                    Console.WriteLine("How unfortunate. It looks as though you are out of tries.");
                    Console.WriteLine($"The number you were trying to guess was {randomNumber}.");
                    Console.WriteLine("Thank you for playing.");
                    break;
                }
                Console.WriteLine($"You still have {maxTries - tryTracker} tries left.");
                Console.WriteLine("Keep trying. NumberBot still believes in you.");
            }





        }
    }
}
