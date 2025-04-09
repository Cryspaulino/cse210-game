using Raylib_cs;

public class Bomb : GameObject
{

    public Bomb(int x, int y, int speed) : base(x, y, speed)
    {}

    public override void Draw()
    {
        Raylib.DrawRectangle(_x, _y, 15, 15, Color.Red);
    }

    public override void ProcessActions()
    {
        _y += _speed;
    }

}