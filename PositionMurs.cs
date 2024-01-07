using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace TestCollision
{
    internal class PositionMurs
    {
        Random refMurs = new Random();
        int refX, refY;
        ushort refWH;

        public void Init()
        {
            refX = refMurs.Next(50, 400);
            refY = refMurs.Next(50, 400);
            refWH = (ushort)refMurs.Next(50, 150);
        }
        
        public void GenerationMurs()
        {
            Murs m1 = new Murs(new Vector2(refX, refY), refWH);
            m1.Draw();
        }
    }
}
