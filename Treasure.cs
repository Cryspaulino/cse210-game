using Raylib_cs;

public class Treasure : GameObject
{

    public Treasure(int x, int y, int speed) : base(x, y, speed)
    {}

    public override void Draw()
    {
        Raylib.DrawCircle(_x, _y, 5, Color.Green);
    }

    public override void ProcessActions()
    {
        _y += _speed;
    }

}