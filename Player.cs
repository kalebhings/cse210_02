/*
HiLo Specification
cse210_02
Kaleb Hingsberger
*/

using System;

namespace cse210_02
{
    public class Player
    {
        Card card = new Card();
        public bool isPlaying = true;
        public int score = 300;
        public Player()
        {

        }
        
        public void StartGame()
        {

        }

        public void GetInput()
        {
            bool chooseCard = true;
            Console.Write("Play again? (y/n)");

            do
            {
                string playAgain = Console.ReadLine();

                if (playAgain == "y")
                {
                    isPlaying = true;
                    chooseCard = false;
                }
                else if (playAgain == "n")
                {
                    isPlaying = false;
                    chooseCard = false;
                }
                else{
                    chooseCard = true;
                    Console.WriteLine("Please enter a valid value");
                } 
            } while (chooseCard);
        }

        public  void DrawCards() 
        {
            if (!isPlaying)
            {
                return;
            }

            card.GetFirstCard();
            card.GetSecondCard();
        }

        public void CheckGuess()
        {
            card.DisplayFirstCard();
            Console.Write("Higher or lower (h/l): ");
            string playerGuess = "";
            bool invalidAnswer = true;

            do {
                playerGuess = Console.ReadLine();
                
                if (playerGuess == "h" || playerGuess == "l")
                {
                    invalidAnswer = false;
                }
                else
                {
                    Console.WriteLine("Invalid answer, please try again today");
                    invalidAnswer = true;
                }
            } while (invalidAnswer);
            
            card.DisplaySecondCard();

            bool guess = card.Guess(playerGuess);

            if (guess== true)
            {
                score += 100;
            }
            else
            {
                score -= 75;
            }
            Console.WriteLine($"Your score is: {score}");
        }
    }
}
