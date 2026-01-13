namespace TheFarmersGame.Core;

public class Player
{
    public int Id { get; }
    public string Name { get; }
    public string Color { get; }
    public int Money { get; internal set; }
    public int Position { get; internal set; }

    public Player(int id, string name, string color, int startMoney)
    {
        Id = id;
        Name = name;
        Color = color;
        Money = startMoney;
        Position = 0;
    }
}
