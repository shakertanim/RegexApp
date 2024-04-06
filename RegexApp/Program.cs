namespace Regex;

public class Program
{
    public static void Main(string[] args)
    {
        bool exitOrContinue = true;
        while (exitOrContinue)
        {
            Console.Write("Enter a regular expression (or press ENTER to use the default ^[a-z]{1}$): ");
            string expression = Console.ReadLine();
            
            if (string.IsNullOrEmpty(expression))
            {
                expression = "^[a-z]{1}$";
            }
            
            Console.Write("Enter some input: ");
            string text = Console.ReadLine();
            RegexApp regexValidate = new RegexApp(text, expression);
            regexValidate.regexProgram();
            Console.WriteLine("Press ESC to end or any key to try again.");
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                exitOrContinue = false;
            }
        }
    }
}