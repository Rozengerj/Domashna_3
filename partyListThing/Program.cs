int commandsAmount = int.Parse(Console.ReadLine());
List<string> people = new List<string>();
for (int i = 0; i < commandsAmount; i++)
{
    string commands = Console.ReadLine();
    List<string> commandChecker = commands.Split(' ').ToList();
    if (commandChecker[2] == "going!")
    {
        if (people.Contains(commandChecker[0])==true)
        {
            Console.WriteLine(commandChecker[0]+" is already on the list");
        }
        else
        {
            people.Add(commandChecker[0]);
        }
    }
    if (commandChecker[2] == "not")
    {
        if (people.Contains(commandChecker[0]) == true)
        {        
            people.Remove(commandChecker[0]);
        }
        else
        {
            Console.WriteLine(commandChecker[0] + " is not on the list");
        }
    }
}
Console.WriteLine(string.Join(" ", people));