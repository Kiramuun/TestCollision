using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace TestCollision
{
    internal class Murs
    {
        public Vector2 axeMurs;
        public ushort largMurs { get; private set; }

        public Murs(Vector2 _pos, ushort _larg)
        {
            axeMurs = _pos;
            largMurs = _larg;
        }

        public Murs()
        {
        }

        public void Draw()
        {
            DrawRectangle((int)axeMurs.X, (int)axeMurs.Y, largMurs, largMurs, Color.RED);
        }
    }
}
