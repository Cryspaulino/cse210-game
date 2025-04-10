public abstract class GameObject
{
    protected int _x;
    protected int _y;
    protected int _width;
    protected int _height;
    protected int _speed;
    // protected int _score;
    // protected bool _life;


    public GameObject(int x, int y, int speed)
    {
        _x = x;
        _y = y;
        _speed = speed;
        // _score = score;
        // _life = life;
    }

    public abstract void Draw();

    public virtual int GetLeftEdge()
    {
        return _x;
    }

    public virtual int GetRightEdge()
    {
        return _x + _width;
    }

    public virtual int GetTopEdge()
    {
        return _y;
    }

    public virtual int GetBottomEdge()
    {
        return _y + _height;
    }

    public virtual void ProcessActions()
    {

    }

    public virtual void CollideWith()
    {}

    // public virtual bool IsAlive()
    // {
    //     return _life = true;
    // }

    // public virtual bool Kill()
    // {
    //     return _life = false;
    // }
}