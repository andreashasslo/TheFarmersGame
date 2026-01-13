namespace TheFarmersGame.Core;

public class GameEngine
{
    public GameState State { get; }

    public GameEngine(GameState state)
    {
        State = state;
    }

    public void StartGame()
    {
        State.CurrentPlayerIndex = 0;
    }

    public void PlayTurn()
    {
        var player = State.CurrentPlayer;

        int dice = RollDice();
        player.Position = (player.Position + dice) % State.Board.TileCount;

        var tile = State.Board.GetTile(player.Position);
        tile.Resolve(State, player);

        State.AdvanceToNextPlayer();
    }

    private int RollDice()
    {
        return Random.Shared.Next(1, 7);
    }
}
