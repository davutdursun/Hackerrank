namespace Hackerrank.TimeConversion;
public class Result
{
    [Theory]
    [InlineData("12:01:00PM", "12:01:00")]
    [InlineData("12:01:00AM", "00:01:00")]
    [InlineData("07:05:45PM", "19:05:45")]
    public void TimeConversionTest(string input, string expected)
    {
        // Arrange & Act
        var result = TimeConversion(input);

        // Assert
        Assert.Equal(result, expected);
    }

    public static string TimeConversion(string s)
    {
        var hour = int.Parse(s.Substring(0, 2));
        var minute = s.Substring(3, 2);
        var second = s.Substring(6, 2);
        var type = s.Substring(8, 2);

        hour = hour % 12;

        if (type == "PM")
        {
            hour += 12;
        }

        return $"{hour:D2}:{minute}:{second}";
    }
}
