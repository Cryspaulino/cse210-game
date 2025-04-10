using Raylib_cs;

public class Treasure : GameObject
{

    public Treasure(int x, int y, int speed) : base(x, y, speed)
    {}

    public override void Draw()
    {
        Raylib.DrawCircle(_x, _y, 8, Color.Green);
    }

    public override void ProcessActions()
    {
        _y += _speed;
    }

    // public int GetPoint()
    // {
    //     return _score + 1;
    // }
    // public override void Kill()
    // {}

}