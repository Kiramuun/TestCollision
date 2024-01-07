using Raylib_cs;
using static Raylib_cs.Raylib;

namespace TestCollision
{
    internal class Players
    {
        float xPos = 10,
              yPos = 10;
        int speed = 100;
        
        public void Render()
        {
            DrawRectangle((int)xPos, (int)yPos, 50, 50, Color.BLACK);
        }

        public void Mouv()
        {
            if(IsKeyDown(KeyboardKey.KEY_RIGHT)||IsKeyDown(KeyboardKey.KEY_D)) { xPos += speed * GetFrameTime(); }
            if(IsKeyDown(KeyboardKey.KEY_LEFT) || IsKeyDown(KeyboardKey.KEY_A)) { xPos -= speed * GetFrameTime(); }
            if(IsKeyDown(KeyboardKey.KEY_DOWN) || IsKeyDown(KeyboardKey.KEY_S)) { yPos += speed * GetFrameTime(); }
            if(IsKeyDown(KeyboardKey.KEY_UP) || IsKeyDown(KeyboardKey.KEY_W)) { yPos -= speed * GetFrameTime(); }
        }

        public void Player()
        {
            Mouv();
            Render();
        }

        /*public void Collision()
        {
            if(Player().position.X)
        }*/
    }
}
