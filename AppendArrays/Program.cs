
List<string> list = Console.ReadLine().Split(' ').ToList(); 
List<int> final = new List<int>();
while (list.To().Contains(" ") == true)
    {
    list.ToString().Remove(' ').ToList();
    Console.WriteLine(string.Join(" ", list));
    }

while (list.Contains("3") == true)
{
    int startingPos = list.FindLastIndex(x => x.ToString().Contains('|'));
    for (int i = startingPos+1; i < list.Count; i++)
    {
        final.Add(int.Parse(list[i]));
    }
    list.RemoveAt(startingPos);
}
Console.WriteLine(string.Join(" ", final));
//i cant solve this