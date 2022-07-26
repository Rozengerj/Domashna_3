string input = Console.ReadLine();
List<int> list = input.Split(' ').Select(x => int.Parse(x)).ToList();
string commands = Console.ReadLine();
List<string> commandChecker = commands.Split(' ').ToList();
while (commands != "end")
{
    if (commandChecker[0] == "Delete")
    {
        while (list.Contains(int.Parse(commandChecker[1])) == true)
        list.Remove(int.Parse(commandChecker[1]));
    }
    if (commandChecker[0] == "Insert")
    {
        list.Insert(int.Parse(commandChecker[2]), int.Parse(commandChecker[1]));
    }
    commands = Console.ReadLine();
    commandChecker = commands.Split(' ').ToList();
}
Console.WriteLine(string.Join(" ", list));