string input1 = Console.ReadLine();
List<int> player1Cards = input1.Split(' ').Select(x => int.Parse(x)).ToList();
string input2 = Console.ReadLine();
List<int> player2Cards = input2.Split(' ').Select(x => int.Parse(x)).ToList();
int player1Score = 0;
int player2Score = 0;
for (int i = 0; i < Math.Min(player1Cards.Count,player2Cards.Count); i++)
{
    if (player1Cards[i] > player2Cards[i])
    {
        player1Score += player1Cards[i] + player2Cards[i];
    }
    else if (player1Cards[i] < player2Cards[i])
    {
        player2Score += player1Cards[i] + player2Cards[i];
    }
}
if (player1Score > player2Score)
{
    Console.WriteLine("First Player Wins! Sum: " + player1Score);
}
else if(player1Score < player2Score)
{
    Console.WriteLine("Second Player Wins! Sum: " + player1Score);
}