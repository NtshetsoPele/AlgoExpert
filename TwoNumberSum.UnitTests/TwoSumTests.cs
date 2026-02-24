namespace TwoNumberSum.UnitTests;

public class TwoSumTests
{
    [Fact]
    public void TwoNumberSum_NullArray_ThrowsNullReferenceException()
    {
        // Arrange
        int[]? array = null;
        int targetSum = 10;

        // Act & Assert
        Assert.Throws<NullReferenceException>(() => TwoSum.GetTwoNumberSum(array!, targetSum));
    }

    [Fact]
    public void TwoNumberSum_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] array = [];
        int targetSum = 10;

        // Act
        int[] result = TwoSum.GetTwoNumberSum(array, targetSum);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void TwoNumberSum_SingleElement_ReturnsEmptyArray()
    {
        // Arrange
        int[] array = [5];
        int targetSum = 10;

        // Act
        int[] result = TwoSum.GetTwoNumberSum(array, targetSum);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void TwoNumberSum_TwoElementsValidPair_ReturnsCorrectPair()
    {
        // Arrange
        int[] array = [3, 5];
        int targetSum = 8;

        // Act
        int[] result = TwoSum.GetTwoNumberSum(array, targetSum);

        // Assert
        Assert.Equal(2, result.Length);
        Assert.Contains(3, result);
        Assert.Contains(5, result);
    }

    [Fact]
    public void TwoNumberSum_TwoElementsNoValidPair_ReturnsEmptyArray()
    {
        // Arrange
        int[] array = [3, 5];
        int targetSum = 10;

        // Act
        int[] result = TwoSum.GetTwoNumberSum(array, targetSum);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void TwoNumberSum_MultipleElementsValidPair_ReturnsCorrectPair()
    {
        // Arrange
        int[] array = [3, 5, -4, 8, 11, 1, -1, 6];
        int targetSum = 10;

        // Act
        int[] result = TwoSum.GetTwoNumberSum(array, targetSum);

        // Assert
        Assert.Equal(2, result.Length);
        int sum = result[0] + result[1];
        Assert.Equal(targetSum, sum);
    }

    [Fact]
    public void TwoNumberSum_MultipleElementsNoValidPair_ReturnsEmptyArray()
    {
        // Arrange
        int[] array = [1, 2, 3, 4, 5];
        int targetSum = 20;

        // Act
        int[] result = TwoSum.GetTwoNumberSum(array, targetSum);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void TwoNumberSum_NegativeNumbers_ReturnsCorrectPair()
    {
        // Arrange
        int[] array = [-1, -2, -3, -4, -5];
        int targetSum = -8;

        // Act
        int[] result = TwoSum.GetTwoNumberSum(array, targetSum);

        // Assert
        Assert.Equal(2, result.Length);
        int sum = result[0] + result[1];
        Assert.Equal(targetSum, sum);
    }
}