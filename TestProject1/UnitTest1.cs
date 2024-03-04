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
    public void Test1(int n, int expected)
    {
        int result = ProgramBracketCombinations.BracketCombinations(n);
        Assert.Equal(expected, result);
    }
}