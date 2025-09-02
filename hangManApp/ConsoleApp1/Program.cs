



using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        String secretWord = "spel";
        int lifeLeft = 5;

        StringBuilder displayString = new StringBuilder();

        for (int i = 0; i < secretWord.Length; i++) {

            displayString.Append('_');

        }

        Console.WriteLine(displayString);

    }

    




}