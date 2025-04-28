namespace Hackerrank.MiniMaxSum;
public class Result
{
    public static long[] MiniMaxSum(List<long> arr)
    {
        long sum = arr.Sum();
        long max = arr.Max();
        long min = arr.Min();

        // Console.Write($"{sum-max} {sum-min}");

        return [sum-max, sum-min];
    }

    [Theory]
    [InlineData(new long[] {1,3,5,7,9}, new long[] {16,24})]
    [InlineData(new long[] { 1, 2, 3, 4, 5 }, new long[] { 10, 14 })]
    public void MiniMaxSumTest(long[] arr, long[] expected)
    {
        // Arrange
        var input = arr.ToList();

        // Act
        var result = MiniMaxSum(input);

        // Assert
        Assert.Equal(expected, result);
    }
}
