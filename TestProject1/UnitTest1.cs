using BracketCombinations;

namespace TestProject1;

public class UnitTest1
{
    [Theory]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(3, 5)]
    [InlineData(4, 14)]
    [InlineData(5, 42)]
    [InlineData(6, 132)]
    [InlineData(7, 429)]
    [InlineData(8, 1430)]
    [InlineData(9, 4862)]
    public void Test1(int n, long expected)
    {
        long result = ProgramBracketCombinations.BracketCombinations(n);
        Assert.Equal(expected, result);
    }
}