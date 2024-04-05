namespace Regex;

using System.Text.RegularExpressions;
class RegexApp
{
    string inputExpression;
    string regularExpression;

    public RegexApp(string inputExpression, string regularExpression)
    {
        this.inputExpression = inputExpression;
        this.regularExpression = regularExpression;
    }

    public void regexProgram()
    {
        Regex obj = new Regex(this.regularExpression);
        bool result;
        result = obj.IsMatch(this.inputExpression);
        if (result)
        {
            Console.WriteLine($"{this.inputExpression} matches {this.regularExpression}? {result}");
        }
        else
        {
            Console.WriteLine($"{this.inputExpression} matches {this.regularExpression}? {result}");
        }
    }
}