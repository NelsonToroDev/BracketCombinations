namespace BracketCombinations;

public class ProgramBracketCombinations
{
    // By doing sum search I found a formula that can achieve what this problem want
    // called Catalan number (Catalan Formula)
    // where catalan formula is ==> (2n!) / (n+1)! n!

    public static long BracketCombinations(int num)
    {
        return Factorial(2 * num) /(Factorial(num + 1) * Factorial(num));
    }

    public static long Factorial(int num)
    {
        long k = 1;
        for (int i = num; i >= 1; i--)
        {
            k *= i;
        }

        return k;
    }

    static void Main(string[] args)
    {
        BracketCombinations(7);
    }
}