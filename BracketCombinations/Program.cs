namespace BracketCombinations;

public class ProgramBracketCombinations
{
    // By doing sum search I found a formula that can achieve what this problem want
    // called Catalan number (Catalan Formula)
    // where catalan formula is ==> (2n!) / (n+1)! n!

    public static int BracketCombinations(int num)
    {
        return Factorial(2 * num) / (Factorial(num + 1) * Factorial(num));
    }

    public static int Factorial(int num)
    {
        int res = 1;
        for (int i = num; i > 0; i--)
        {
            res = res * i;
        }

        return res;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}