﻿using Raylib_cs;
using static Raylib_cs.Raylib;

namespace TestCollision
{
    internal class Players
    {
        public float xPos = 10,
                     yPos = 10;
        public int speedD = 100,
                   speedG = 100,
                   speedH = 100,
                   speedB = 100,
                   playerLarg = 50;
        
        public void Render()
        {
            DrawRectangle((int)xPos, (int)yPos, playerLarg, playerLarg, Color.BLACK);
        }

        public void Mouv()
        {
            if(IsKeyDown(KeyboardKey.KEY_RIGHT)||IsKeyDown(KeyboardKey.KEY_D)) { xPos += speedD * GetFrameTime(); }
            if(IsKeyDown(KeyboardKey.KEY_LEFT) || IsKeyDown(KeyboardKey.KEY_A)) { xPos -= speedG * GetFrameTime(); }
            if(IsKeyDown(KeyboardKey.KEY_DOWN) || IsKeyDown(KeyboardKey.KEY_S)) { yPos += speedB * GetFrameTime(); }
            if(IsKeyDown(KeyboardKey.KEY_UP) || IsKeyDown(KeyboardKey.KEY_W)) { yPos -= speedH * GetFrameTime(); }
        }

        public void Player()
        {
            Mouv();
            Render();
        }
    }
}
