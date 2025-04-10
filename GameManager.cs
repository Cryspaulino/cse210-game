using System.Buffers.Binary;
using Raylib_cs;

class GameManager
{
    public const int SCREEN_WIDTH = 800;
    public const int SCREEN_HEIGHT = 600;
    public const double SPAWN_POINTS_RATE = 0.02;
    public const double SPAWN_BOMBS_RATE = 0.02;
    private string _title;

    private List<GameObject> _gameObjects = new List<GameObject>();

    public GameManager()
    {
        _title = "CSE 210 Game";
    }

    /// <summary>
    /// The overall loop that controls the game. It calls functions to
    /// handle interactions, update game elements, and draw the screen.
    /// </summary>
    public void Run()
    {
        Raylib.SetTargetFPS(60);
        Raylib.InitWindow(SCREEN_WIDTH, SCREEN_HEIGHT, _title);
        // If using sound, un-comment the lines to init and close the audio device
        // Raylib.InitAudioDevice();

        InitializeGame();

        while (!Raylib.WindowShouldClose())
        {
            HandleInput();
            ProcessActions();

            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);

            DrawElements();

            Raylib.EndDrawing();
        }

        // Raylib.CloseAudioDevice();
        Raylib.CloseWindow();
    }

    /// <summary>
    /// Sets up the initial conditions for the game.
    /// </summary>
    /// 
    // private Player p;
    private void InitializeGame()
    {
        Player p = new Player(SCREEN_WIDTH / 2, SCREEN_HEIGHT - 50, 10, 50);
        _gameObjects.Add(p);


        // Treasure t1 = new Treasure(50, 50, 8);
        // Treasure t2 = new Treasure(100,50, 10);
        // _gameObjects.Add(t1);
        // _gameObjects.Add(t2);

        // Bomb b1 = new Bomb(70, 50, 11);
        // Bomb b2 = new Bomb(300,50, 4);
        // _gameObjects.Add(b1);
        // _gameObjects.Add(b2);

    }

    // private int GetRandomSpeed(int min, int max)
    // {
    //     Random rand = new Random();
    //     return rand.Next(1,10);
    // }

    private void SpawnItems()
    {
        Random random = new Random();
        double treasureAmount = random.NextDouble();
        // int _speedrandom = random.Next(1,10);

        if (treasureAmount < SPAWN_POINTS_RATE)
        {
            int x = random.Next(0, SCREEN_WIDTH);
            Treasure treasure = new Treasure(x,0,random.Next(5,8));
            _gameObjects.Add(treasure);
        }

         double bombAmount = random.NextDouble();

        if (bombAmount < SPAWN_BOMBS_RATE)
        {
            int x = random.Next(0, SCREEN_WIDTH);
            Bomb bomb = new Bomb(x,0,random.Next(5,8));
            _gameObjects.Add(bomb);
        }
    }

    /// <summary>
    /// Responds to any input from the user.
    /// </summary>
    private void HandleInput()
    {
        // if (Raylib.IsKeyDown(KeyboardKey.Left))
        // {
        //     _x = _x - 10;
        // }

    }

    private void CleanItems()
    {
        // _gameObjects.RemoveAll(e => ! e.isAlive());
    }

    /// <summary>
    /// Processes any actions such as moving objects or handling collisions.
    /// </summary>
    private void ProcessActions()
    {
        foreach (GameObject item in _gameObjects)
        {
            item.ProcessActions();
        }

        // for (int i = 0; i < _gameObjects.Count; i++)
        // {
        //     for (int j = i + 1; j < _gameObjects.Count; j++)
        //     {
        //         GameObject first = _gameObjects[i];
        //         GameObject second = _gameObjects[j];

        //         if (IsCollision(first, second))
        //         {
        //             first.CollideWith(second);
        //             second.CollideWith(first);
        //         }
        //     }
        // }

        SpawnItems();
        CleanItems();
        //SpawnItems() and Clean()
        //  if (Raylib.IsKeyDown(KeyboardKey.Left))
        //     {
        //         MoveLeft();
        //     }

            // if (Raylib.IsKeyDown(KeyboardKey.Right))
            // {
            //     MoveRight();
            // }
    }

    private bool IsCollision(GameObject first, GameObject second)
    {
        bool areTouching = false;

        if(first.GetRightEdge() >= second.GetLeftEdge()
        && first.GetLeftEdge() <= second.GetRightEdge()
        && first.GetBottomEdge() >= second.GetTopEdge()
        && first.GetTopEdge() <= second.GetBottomEdge())
        {
           return areTouching != false;
        }

        else {return areTouching;}

    }





















    /// <summary>
    /// Draws all elements on the screen.
    /// </summary>
    private void DrawElements()
    {
        foreach (GameObject item in _gameObjects)
        {
            item.Draw();
        }
    }
}

