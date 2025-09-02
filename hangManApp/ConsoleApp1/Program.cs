using System;
using System.Text;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Välkommen till hänga gubbe! \nDu har 5 liv på dig att gissa rätt ord :)");

        int lifeLeft = 5;
        String[] wordList = ["spel", "test", "huskur", "hangman"];

        Random random = new Random();

        string secretWord = wordList[random.Next(wordList.Length)];

        StringBuilder displayString = new StringBuilder();

        for (int i = 0; i < secretWord.Length; i++)
        {

            displayString.Append('_');

        }
        int secret = secretWord.Length;

        while (lifeLeft > 0)
        {

            Console.WriteLine("Välj bokstav: ");
            Console.WriteLine("Liv kvar: " + lifeLeft);

            Console.WriteLine(displayString);

            string guess = Console.ReadLine();

            if (!string.IsNullOrEmpty(guess))
            {

                int i = 0;

                bool found = false;

                foreach (char letter in secretWord)
                {
                    if (letter == guess[0])
                    {
                        found = true;
                        displayString[i] = letter;
                        //Console.WriteLine("Rätt!");
                        secret--;
                    }

                    i++;
                }


                if (secret == 0)
                {
                    Console.WriteLine("Du vann");
                    break;
                }


                if (!found)
                {
                    lifeLeft--;
                    Console.WriteLine("Fel!");
                }

 

            }

            else
            {
                Console.WriteLine("får inte vara tomt!");
            }

        }


 
    }



    }