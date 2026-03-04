namespace SortedSquaredArray.UnitTests;

public sealed class SortedSquaredTests
{
    [Fact]
    public void SortedSquaredArray_NullArray_ThrowsNullReferenceException()
    {
        // Arrange
        int[]? array = null;

        // Act & Assert
        Assert.Throws<NullReferenceException>(() => SortedSquared.SortedSquaredArray(array!));
    }

    [Fact]
    public void SortedSquaredArray_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] array = Array.Empty<int>();

        // Act
        int[] result = SortedSquared.SortedSquaredArray(array);

        // Assert
        Assert.Empty(result);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(-1, 1)]
    [InlineData(5, 25)]
    [InlineData(-5, 25)]
    [InlineData(10, 100)]
    public void SortedSquaredArray_SingleElement_ReturnsSquaredValue(int value, int expectedSquare)
    {
        // Arrange
        int[] array = [value];

        // Act
        int[] result = SortedSquared.SortedSquaredArray(array);

        // Assert
        Assert.Single(result);
        Assert.Equal(expectedSquare, result.First());
    }

    [Fact]
    public void SortedSquaredArray_AllPositiveNumbers_ReturnsSquaredAndSorted()
    {
        // Arrange
        int[] array = [1, 2, 3, 4, 5];
        int[] expected = [1, 4, 9, 16, 25];

        // Act
        int[] result = SortedSquared.SortedSquaredArray(array);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SortedSquaredArray_AllNegativeNumbers_ReturnsSquaredAndSorted()
    {
        // Arrange
        int[] array = [-5, -4, -3, -2, -1];
        int[] expected = [1, 4, 9, 16, 25];

        // Act
        int[] result = SortedSquared.SortedSquaredArray(array);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SortedSquaredArray_MixedPositiveAndNegative_ReturnsSquaredAndSorted()
    {
        // Arrange
        int[] array = [-3, -1, 0, 1, 3];
        int[] expected = [0, 1, 1, 9, 9];

        // Act
        int[] result = SortedSquared.SortedSquaredArray(array);

        // Assert
        Assert.Equal(expected, result);
    }
}