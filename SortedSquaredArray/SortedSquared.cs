namespace SortedSquaredArray;

public sealed class SortedSquared
{
    public static int[] SortedSquaredArray(int[] array)
    {
        var squares = new int[array.Length];

        for (var i = 0; i < array.Length; i++)
        {
            squares[i] = (int)Math.Pow(array[i], 2);
        }

        Array.Sort(squares);
        return squares;
    }
}