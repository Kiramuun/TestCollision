using System.Numerics;
using Raylib_cs;
using TestCollision;
using static Raylib_cs.Raylib;

InitWindow(1000, 1000, "Hello World");

SetTargetFPS(30);

Murs main = new(new Vector2(150, 200), 100);
Players p1 = new();

List<Murs> listeMurs = new List<Murs>();
listeMurs.Add(new Murs (new Vector2(150, 200), 100));




while (!WindowShouldClose())
{
    BeginDrawing();

    ClearBackground(Color.WHITE);

    for(int i = 0; i <= 1000; i+=50) { DrawLine(i, 0, i, 1000, Color.BLACK); }
    for(int i = 0; i <= 1000; i+=50) { DrawLine(0, i, 1000, i, Color.BLACK); }

    if(p1.xPos >= main.axeMurs.X - p1.playerLarg &&
       p1.xPos <= main.axeMurs.X + main.largMurs &&
       p1.yPos >= main.axeMurs.Y - p1.playerLarg &&
       p1.yPos <= main.axeMurs.Y + main.largMurs)
    {
        int diffX = (int)(main.axeMurs.X - p1.xPos + 100);
        int diffY = (int)(main.axeMurs.Y - p1.yPos + 100);

        if(diffX > 100)
        {
            diffX = 2 * (main.largMurs*2) / diffX;
            p1.xPos -= diffX;
        }

        if (diffY > 100)
        {
            diffY = 2 * (main.largMurs * 3) / diffY;
            p1.yPos -= diffY;
        }
    }

    

    main.Draw();
    p1.Player();

    EndDrawing();
}

CloseWindow();