namespace ValidateSubsequence;

public static class Subsequence
{
    public static bool IsValidSubsequence(List<int> array, List<int> sequence)
    {
        var sequenceIndex = 0;

        return sequence.All((int nextNum) => NextInRemainingSubarray(nextNum, ref sequenceIndex, array));
    }

    private static bool NextInRemainingSubarray(int nextNum, ref int sequenceIndex, List<int> array)
    {
        for (; sequenceIndex < array.Count;)
        {
            if (nextNum == array[sequenceIndex++])
            {
                return true;
            }
        }

        return false;
    }
}