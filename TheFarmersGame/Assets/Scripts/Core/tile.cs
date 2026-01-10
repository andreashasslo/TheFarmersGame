namespace TheFarmersGame.Core.Model;

public abstract class Tile
{
    public abstract void Resolve(
        GameState state,
        Player player
    );
}
