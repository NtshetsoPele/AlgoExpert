
int[] resultArray = TwoSum.GetTwoNumberSum(array: [3, 5, -4, 8, 11, 1, -1, 6], targetSum: 10);
Console.WriteLine(string.Join(", ", resultArray));

resultArray = TwoSum.GetTwoNumberSum(array: [4, 6], targetSum: 10);
Console.WriteLine(string.Join(", ", resultArray));

resultArray = TwoSum.GetTwoNumberSum(array: [4, 6, 1], targetSum: 5);
Console.WriteLine(string.Join(", ", resultArray));