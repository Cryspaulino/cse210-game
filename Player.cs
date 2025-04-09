using Raylib_cs;
public class Player : GameObject
{

    public Player(int x, int y, int speed) : base(x, y, speed)
    { }

    public override void Draw()
    {
        Raylib.DrawRectangle(_x, _y, 50, 10, Color.Blue);
    }

    public override void ProcessActions()
    {
        if (Raylib.IsKeyDown(KeyboardKey.Left))
        {
            MoveLeft();
        }

        if (Raylib.IsKeyDown(KeyboardKey.Right))
        {
            MoveRight();
        }

        // if (GetLeftEdge() < GameManager.SCREEN_WIDTH)
        // {
        //     _x = 0;
        // }
        // if (GetRightEdge() > GameManager.SCREEN_WIDTH)
        // {
        //     _x = GameManager.SCREEN_WIDTH - 60;
        // }
    }

    public void MoveLeft()
    {
        _x -= _speed;
    }

    public void MoveRight()
    {
        _x += _speed;
    }

}