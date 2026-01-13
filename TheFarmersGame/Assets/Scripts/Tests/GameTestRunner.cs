// Purpose: Test the core engine functionalities of The Farmers Game.

using Bondespelet.Core;

public class GameTestRunner
{
    private readonly GameEngine _engine;

    public GameTestRunner(GameEngine engine)
    {
        _engine = engine;
    }

    // ===== INPUT =====

    public void SetupPlayers()
    {
        Console.Write("Antal spelare: ");
        int playerCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < playerCount; i++)
        {
            Console.WriteLine($"Spelare {i + 1}:");

            Console.Write("Namn: ");
            string name = Console.ReadLine();

            Console.Write("Färg: ");
            string color = Console.ReadLine();

            var player = new Player(
                id: i,
                name: name,
                color: color,
                startMoney: 100000
            );

            _engine.AddPlayer(player);
        }
    }

    // ===== PRESENTATION =====

    public void PrintPlayerStats()
    {
        Console.WriteLine("=== Spelarstatus ===");

        foreach (var player in _engine.GameState.Players)
        {
            Console.WriteLine(
                $"Namn: {player.Name}, " +
                $"Färg: {player.Color}, " +
                $"Pengar: {player.Money}, " +
                $"Position: {player.Position}"
            );
        }

        Console.WriteLine("====================");
    }

    // ===== TESTLOOP =====

    public void RunSingleTurn()
    {
        var currentPlayer = _engine.GameState.CurrentPlayer;

        Console.WriteLine($"Tur: {currentPlayer.Name}");

        _engine.PlayTurn();

        PrintPlayerStats();
    }
}
