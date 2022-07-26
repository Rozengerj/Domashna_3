string input = Console.ReadLine();
List<int> field = input.Split(' ').Select(x => int.Parse(x)).ToList();
string bombInput = Console.ReadLine();
List<int> bomb = bombInput.Split(' ').Select(x => int.Parse(x)).ToList();
int bombPlacement = field.IndexOf(bomb[0]);
while (field.Contains(bomb[0]))
{
    for (int j = 0; j < bomb[1]*2 +1; j++)
    {
        if(field.Count > bombPlacement - bomb[1])
        {
            field.RemoveAt(bombPlacement - bomb[1]);
        }
    }
}
Console.WriteLine(field.Sum());
