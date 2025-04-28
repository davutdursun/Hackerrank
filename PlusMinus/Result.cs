namespace Hackerrank.PlusMinus;
public class Result
{

    public static float[] PlusMinus(List<int> arr)
    {
        float totalCount = arr.Count;
        float pCount = arr.Where(x => x > 0).Count();
        float nCount = arr.Where(x => x < 0).Count();
        float zCount = arr.Where(x => x == 0).Count();

        float pRatio = pCount / totalCount;
        float nRatio = nCount / totalCount;
        float zRatio = zCount / totalCount;

        //Console.WriteLine(pRatio.ToString("N6"));
        //Console.WriteLine(nRatio.ToString("N6"));
        //Console.WriteLine(zRatio.ToString("N6"));

        return [
            (float)Math.Round(pRatio, 6),
            (float)Math.Round(nRatio, 6),
            (float)Math.Round(zRatio, 6)
        ];
    }

    [Theory]
    [InlineData(new int[] { 1, 1, 0, -1, -1 }, new float[] { 0.400000f, 0.400000f, 0.200000f })]
    [InlineData(new int[] { -4, 3, -9, 0, 4, 1 }, new float[] { 0.500000f, 0.333333f, 0.166667f })]
    public void PlusMinusTest(int[] arr, float[] expected)
    {
        // Arrange
        var input = arr.ToList();

        // Act
        var result = PlusMinus(input);

        // Assert
        Assert.Equal(expected, result);
    }
}
