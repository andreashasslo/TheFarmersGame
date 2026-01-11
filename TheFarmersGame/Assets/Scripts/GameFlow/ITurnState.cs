interface ITurnState
{
    void Enter(GameState state);
    void Update();
    void Exit();
}

/* Exempel:
- RollDiceState
- MovePlayerState
- ResolveTileState
- EndTurnState */

