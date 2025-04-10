using Raylib_cs;
public class Player : GameObject
{


    public Player(int x, int y, int speed, int width) : base(x, y, speed)
    { 
        _width = width;
    }

    public override void Draw()
    {
        Raylib.DrawRectangle(_x, _y, _width, 10, Color.Blue);
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

        if (GetLeftEdge() < 0)
        {
            _x = 0;
        }
        else if (GetRightEdge() > GameManager.SCREEN_WIDTH)
        {
            _x = GameManager.SCREEN_WIDTH - _width;
        }
    }

    public void MoveLeft()
    {
        _x -= _speed;
    }

    public void MoveRight()
    {
        _x += _speed;
    }

    


    // public override void CollideWith(GameObject other)
    // {
    //     _score = 0;
    //     _life = 3;
    //     if (other is Treasure)
    //     {
    //         Treasure treasure = (Treasure)other;
    //         _score += treasure.GetPoint();
    //         Treasure.Kill();
    //     }
    //     else if (other is Bomb)
    //     {
    //         Bomb bomb = (Bomb)other;
    //         _life -= bomb.LoseLife();
    //         Bomb.Kill();
    //     }


}