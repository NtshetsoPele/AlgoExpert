
// indices                  0, 1, 2,  3,  4, 5,  6, 7
var array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
var sequence = new List<int> { 1, 6, -1, 10 };

Console.WriteLine(Subsequence.IsValidSubsequence(array, sequence));