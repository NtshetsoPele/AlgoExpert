
int[] sorted = SortedSquared.SortedSquaredArray([1, 4]);
Console.WriteLine(sorted.Select(x => x.ToString()).Aggregate((a, b) => $"{a}, {b}"));

sorted = SortedSquared.SortedSquaredArray([1, 2, 3, 5, 6, 8, 9]);
Console.WriteLine(sorted.Select(x => x.ToString()).Aggregate((a, b) => $"{a}, {b}"));