string passengers = Console.ReadLine();
List<int> Train = passengers.Split(' ').Select(x => int.Parse(x)).ToList();
int maxLimit = int.Parse(Console.ReadLine());
string commands = Console.ReadLine();
List<string> commandChecker = commands.Split(' ').ToList();
while(commands != "end")
{
    if(commandChecker[0] == "Add")
    {
        Train.Add(int.Parse(commandChecker[1]));
    }
    else
    {
        for (int i = 0; i < Train.Count; i++)
        {
            if (Train[i] + int.Parse(commandChecker[0]) <= maxLimit)
            {
                Train[i] += int.Parse(commandChecker[0]);
                break;
            }
        }
    }
    commands = Console.ReadLine();
    commandChecker = commands.Split(' ').ToList();
}
Console.WriteLine(string.Join(' ',Train));

