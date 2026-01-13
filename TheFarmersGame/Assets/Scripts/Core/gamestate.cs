namespace TheFarmersGame.Core;

public class GameState
{
    public List<Player> Players { get; set; }
    public int CurrentPlayerIndex { get; set; }
    //public Board Board { get; set; }
    public RandomState RNG { get; set; }
}

