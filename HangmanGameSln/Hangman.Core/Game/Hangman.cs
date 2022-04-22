using System;
using HangmanRenderer.Renderer;

namespace Hangman.Core.Game
{
    public class HangmanGame
    {
        private GallowsRenderer _renderer;
        
        private string _guessProgress;
        private string _guessword;
        private int _numberoflives;
        //private object GuessedWords;

        // private string guesword;
        // private int _AddGuess;


        public HangmanGame()
        {
            _renderer = new GallowsRenderer();
        }

        /*public void _AddGuess(char letter)
      {
          char[] guessProgressArray = _guessword.ToCharArray();

          for (int index = 0; index < _guessword.Length; index++)
          {
              if (_guessword[index] == letter)
              {
                  guessProgressArray[index] = letter;
              }
          }
      }*/



        public void Run()
        {
            _numberoflives = 6;

            _renderer.Render(5, 5, 6);

            string[] _words = { "monotonous", "seeds", "flower", "man", "run", "hang", "fun", "computer", "seeds", "fortunate", "autumn", "chair", "aluve", "follow", "guess", "made", "adventurous", "information", "dependence", "governor", "alias" };

            Random random = new Random();

            var index = random.Next(_numberoflives);
            _ = random.Next(0, 20);
            string GuessWords = _words[index];

            // char[] guess = new char[GuessWords.Length];
            char[] guess = GuessWords.ToCharArray();

            _renderer.Render(5, 5, 6);

            Console.SetCursorPosition(0, 13);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Your current guess: ");
            Console.WriteLine("--------------");
            Console.SetCursorPosition(0, 17);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("What is your next guess: ");
            var nextGuess = Console.ReadLine();

            for (int i = 0; i < guess.Length; i++)
            {
                _guessProgress += "*";
                Console.SetCursorPosition(0, 20);
            }

            while (_numberoflives > 0)
            {
                _renderer.Render(5, 5, _numberoflives);
                Console.SetCursorPosition(0, 13);
                char playerguess = char.Parse(Console.ReadLine());

                char[] guessProgressArray = _guessProgress.ToCharArray();

                bool correct = false;

                for (int i = 0; i < guess.Length; i++)
                {
                    if (guess[i] == playerguess)
                    {
                        guessProgressArray[i] = guess[i];
                        correct = true;
                    }
                }
                _guessProgress = new string(guessProgressArray);
                Console.SetCursorPosition(0, 18);

                Console.Write(_guessProgress);

                if (!correct)
                {
                    _numberoflives--;
                    _renderer.Render(5, 5, _numberoflives);
                }

                // Console.WriteLine( "You lose");

            }
        }
        /* for (int i = 6; i < 0; i--)
        {
            _renderer.Render(5, 5, _numberoflives);
            char playerguess = char.Parse(Console.ReadLine());
            char[] guessProgressArray = _guessProgress.ToCharArray();

            for (int o = 0; i < guess.Length; i++)
            {
                if (guess[i] == playerguess)
                {

                }
                else
                {

                }
            }
        }
        _renderer.Render(5, 5, 6);*/

        /*string guessword;
        {
            _guessword = guessword = nextGuess;
        }*/

        //  char[] guess = _guessword.ToCharArray;

        /*for (int Index = 0; Index < guess.Length; Index++)
        {
            _guessProgress += "*";
        }
        string GetGuessprogress()
        {
            return _guessProgress;
        }*/

        // Console.WriteLine(_guessword);
        //Console.WriteLine(GetGuessprogress());
        //Console.WriteLine(_guessProgress);


        /* string AddGuess(char letter)
         {
             char[] guessProgressArray = _guessword.ToCharArray();
             for (int index = 0; index < _guessword.Length; index++)
             {
                 if (_guessword[index] == letter)
                 {
                     guessProgressArray[index] = letter;
                 }
             }
         }*/


        /* int wrong = 0;
         _renderer.Render(5, 5, _numberoflives);

         if (wrong == 6)
         {
             _renderer.Render(5, 5, 6);
         }
         else if (wrong == 5)
         {
             _renderer.Render(5, 5, 5);
         }
         else if (wrong == 4)
         {
             _renderer.Render(5, 5, 4);
         }
         else if (wrong == 3)
         {
             _renderer.Render(5, 5, 3);
         }
         else if (wrong == 2)
         {
             _renderer.Render(5, 5, 2);
         }
         else if (wrong == 1)
         {
             _renderer.Render(5, 5, 1);
         }
         else if (wrong == 0)
         {
             _renderer.Render(5, 5, 0);
         }*/


        // Console.WriteLine(wrong);
        //Console.WriteLine(_guessProgress);

    }

}
