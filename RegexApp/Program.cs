namespace Regex;

public class Program
{
    public static void Main(string[] args)
    {
        bool exitOrContinue = true;
        while (exitOrContinue)
        {
            Console.Write("Enter a regular expression (or press ENTER to use the default): ");
            string expression = Console.ReadLine();
            Console.Write("Enter some input: ");
            string text = Console.ReadLine();
            RegexApp r = new RegexApp(text, expression);



            r.regexProgram();

            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                exitOrContinue = false;
            }
        }
    }
}