using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace TestCollision
{
    internal class Murs
    {
        public Vector2 axeMurs;
        ushort largMurs;
        
        public Murs(Vector2 _pos, ushort _larg)
        {
            axeMurs = _pos;
            largMurs = _larg;
        }

        public void Draw()
        {
            DrawRectangle((int)axeMurs.X, (int)axeMurs.Y, largMurs, largMurs, Color.RED);
        }
    }
}
