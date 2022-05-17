/*
HiLo Specification
cse210_02
Kaleb Hingsberger
*/

using System;

namespace cse210_02
{
    public class Card
    {
        public int firstCard = 0;
        public int secondCard = 0;
        public Card()
        {

        }

        public void GetFirstCard()
        {
            Random random1 = new Random();
            firstCard = random1.Next(1, 14);
        }

        public void GetSecondCard()
        {
            Random random2 = new Random();
            secondCard = random2.Next(1,14);

            while (firstCard == secondCard)
            {
                secondCard = random2.Next(1,14);
            }
        }
        public void DisplayFirstCard()
        {
            Console.WriteLine($"The card is: {firstCard}");
        }
        public void DisplaySecondCard()
        {
            Console.WriteLine($"Next card was: {secondCard}");
        }

        public bool Guess(string guess)
        {
            bool goodGuess = false;
            
            if (firstCard < secondCard && guess == "h")
            {
                goodGuess = true;
            }
            else if (firstCard > secondCard && guess == "l")
            {
                goodGuess = true;
            }
            else
            {
                goodGuess = false;
            }
            return goodGuess;
        }
    }
}
