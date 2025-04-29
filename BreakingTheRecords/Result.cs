namespace Hackerrank.BreakingTheRecords;
public class Result
{
    [Theory]
    [InlineData(new int[] { 12, 24, 10, 24}, new int[] {1, 1})]
    [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 3, 0 })]
    public void BreakingTheRecordsTest(int[] scores, int[] records)
    {
        // Arrange
        var scoreList = scores.ToList();

        // Act
        var result = BreakingTheRecords(scoreList).ToArray();

        // Assert
        Assert.Equal(result, records);
    }

    public List<int> BreakingTheRecords(List<int> scores)
    {
        int min = scores[0];
        int max = scores[0];
        int minCount = 0;
        int maxCount = 0;

        for (int i = 1; i < scores.Count; i++)
        {
            if (scores[i] < min)
            {
                minCount++;
                min = scores[i];
            }
            if (scores[i] > max)
            {
                maxCount++;
                max = scores[i];
            }
        }
        return [maxCount, minCount];
    }
}
