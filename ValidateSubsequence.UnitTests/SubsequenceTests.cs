namespace ValidateSubsequence.UnitTests;

public class SubsequenceTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1, 3, 4 }, true)]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 2, 4 }, true)]
    [InlineData(new[] { 5, 1, 22, 25, 6, -1, 8, 10 }, new[] { 1, 6, -1, 10 }, true)]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 4 }, true)]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1 }, true)]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 4 }, true)]
    [InlineData(new[] { 1 }, new[] { 1 }, true)]
    public void IsValidSubsequence_ValidSequences_ReturnsTrue(int[] arrayValues, int[] sequenceValues, bool expected)
    {
        // Arrange
        var array = new List<int>(arrayValues);
        var sequence = new List<int>(sequenceValues);

        // Act
        var result = Subsequence.IsValidSubsequence(array, sequence);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 4, 2 })]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1, 5 })]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 4, 5 })]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 5 })]
    [InlineData(new[] { 1 }, new[] { 2 })]
    [InlineData(new[] { 5, 1, 22, 25, 6, -1, 8, 10 }, new[] { 1, 6, 10, -1 })]
    public void IsValidSubsequence_InvalidSequences_ReturnsFalse(int[] arrayValues, int[] sequenceValues)
    {
        // Arrange
        var array = new List<int>(arrayValues);
        var sequence = new List<int>(sequenceValues);

        // Act
        var result = Subsequence.IsValidSubsequence(array, sequence);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidSubsequence_EmptySequence_ReturnsTrue()
    {
        // Arrange
        var array = new List<int> { 1, 2, 3, 4 };
        var sequence = new List<int>();

        // Act
        var result = Subsequence.IsValidSubsequence(array, sequence);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValidSubsequence_EmptyArrayNonEmptySequence_ReturnsFalse()
    {
        // Arrange
        var array = new List<int>();
        var sequence = new List<int> { 1, 2 };

        // Act
        var result = Subsequence.IsValidSubsequence(array, sequence);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidSubsequence_BothEmpty_ReturnsTrue()
    {
        // Arrange
        var array = new List<int>();
        var sequence = new List<int>();

        // Act
        var result = Subsequence.IsValidSubsequence(array, sequence);

        // Assert
        Assert.True(result);
    }
}