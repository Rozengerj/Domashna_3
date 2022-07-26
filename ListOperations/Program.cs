string input = Console.ReadLine();
List<int> list = input.Split(' ').Select(x => int.Parse(x)).ToList();
string commands = Console.ReadLine();
List<string> commandChecker = commands.Split(' ').ToList();
while (commands != "end")
{
    if (commandChecker[0] == "Remove")
    {
        if (int.Parse(commandChecker[1]) <= list.Count) 
        { 
            list.RemoveAt(int.Parse(commandChecker[1]));
        }
        else
        {
            Console.WriteLine("invalid index");
        }
    } 
    if (commandChecker[0] == "Insert")
    {
        list.Insert(int.Parse(commandChecker[2]), int.Parse(commandChecker[1]));
    }
    if (commandChecker[0] == "Add")
    {
        list.Add(int.Parse(commandChecker[1]));
    }
    if (commandChecker[1] == "left")
    {
        for (int i = 0; i < int.Parse(commandChecker[2]); i++)
        {
            int tempNum = list[0];
            list.RemoveAt(0);
            list.Add(tempNum);
        }
    }
    if (commandChecker[1] == "right")
    {
        for (int i = 0; i < int.Parse(commandChecker[2]); i++)
        {
            int tempNum = list[list.Count-1];
            list.RemoveAt(list.Count-1);
            list.Insert(0,tempNum);
        }   
    }
    commands = Console.ReadLine();
    commandChecker = commands.Split(' ').ToList();
}
Console.WriteLine(string.Join(" ", list));