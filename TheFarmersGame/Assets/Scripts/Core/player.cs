public class Player
{
    private readonly string _name;     // readonly – ändras aldrig efter skapande
    private int _position;              // read-write – ändras under spelet
    private int _money;                 // read-write – ändras under spelet
    private int _id;                    // read-only utifrån, skrivbart via konstruktor

    // Properties
    public string Name => _name;        // readonly, bara get
    public int Position
    {
        get => _position;
        internal set => _position = value; // intern modifiering via GameEngine
    }
    public int Money
    {
        get => _money;
        internal set => _money = value;   // intern modifiering via GameEngine
    }
    public int Id => _id;               // readonly

    public Player(int id, string name, int startMoney)
    {
        _id = id;
        _name = name;
        _money = startMoney;
        _position = 0;
    }
}
