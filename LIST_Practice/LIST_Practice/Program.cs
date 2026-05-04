// See https://aka.ms/new-console-template for more information
//var list = new List<int>();
List<int> list = new List<int>();
list.Add(1);
list.AddRange(new int[] { 2, 3, 4 });
Console.WriteLine(string.Join(", ", list)); // Output: 1, 2, 3, 4
list.Reverse();
Console.WriteLine(string.Join(", ", list)); // Output: 4, 3, 2, 1

void Output(List<int> list)
{
    //Console.WriteLine(string.Join(", ", list));
}
