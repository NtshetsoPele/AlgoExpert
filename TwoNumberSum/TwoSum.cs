namespace TwoNumberSum;

public static class TwoSum
{
    public static int[] GetTwoNumberSum(int[] array, int targetSum)
    {
        var uniqueSet = GetUniqueSet(array);

        return GetTwoSumArray(array, targetSum, uniqueSet);
    }

    private static HashSet<int> GetUniqueSet(int[] array)
    {
        var set = new HashSet<int>();

        foreach (var num in array)
        {
            set.Add(num);
        }

        return set;
    }

    private static int[] GetTwoSumArray(int[] array, int targetSum, HashSet<int> uniqueSet)
    {
        for (var i = 0; i < array.Length; i++)
        {
            (int addendA, int addendB) = GetAddends(arrayIndex: i, array, targetSum);

            if (TwoSumExists(addendA, addendB, uniqueSet))
            {
                return [addendB, addendA];
            }
        }

        return [];
    }

    private static (int addendA, int addendB) GetAddends(int arrayIndex, int[] array, int targetSum)
    {
        var addendA = array[arrayIndex];
        var addendB = targetSum - addendA;

        return (addendA, addendB);
    }

    private static bool TwoSumExists(int addendA, int addendB, HashSet<int> uniqueSet) =>
        addendB != addendA &&
        uniqueSet.Contains(addendB) &&
        uniqueSet.Contains(addendA);
}