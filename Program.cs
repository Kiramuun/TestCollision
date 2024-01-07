using Raylib_cs;
using TestCollision;
using static Raylib_cs.Raylib;

InitWindow(500, 500, "Hello World");

SetTargetFPS(30);

PositionMurs main = new PositionMurs();
Players p1 = new Players();
main.Init();

while (!WindowShouldClose())
{
    BeginDrawing();

    ClearBackground(Color.WHITE);

    main.GenerationMurs();
    p1.Player();

    EndDrawing();
}

CloseWindow();