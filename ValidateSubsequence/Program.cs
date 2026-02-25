// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
var sequence = new List<int> { 1, 6, -1, 10 };

Console.WriteLine(IsValidSubsequence(array, sequence));

return;

static bool IsValidSubsequence(List<int> array, List<int> sequence)
{
    // Write your code here.
    var q1 = new Queue<int>(array);
    var q2 = new Queue<int>(sequence);
    while (q2.Count > 0)
    {
        if (q1.Peek() == q2.Peek())
        {
            q1.Dequeue();
            q2.Dequeue();
        }
        else
        {
            q1.Dequeue();
        }
    }

    return q2.Count == 0;
}