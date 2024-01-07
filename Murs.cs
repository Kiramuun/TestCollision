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
    /*Random carréRef = new Random();
    int xA, yA, whA, xB, yB, whB;

    public void Init()
    {
        xA = carréRef.Next(50, 400);
        yA = carréRef.Next(50, 400);
        whA = carréRef.Next(10, 150);

        xB = carréRef.Next(50, 400);
        yB = carréRef.Next(50, 400);
        whB = carréRef.Next(10, 150);
    }

    public void Render()
    {
        if (whA > whB) { DrawRectangle(xA, yA, whA, whA, Color.RED); DrawRectangle(xB, yB, whB, whB, Color.VIOLET); }
        else { DrawRectangle(xB, yB, whB, whB, Color.VIOLET); DrawRectangle(xA, yA, whA, whA, Color.RED); }

        if ((xB >= xA && yB >= yA) && (xB <= xA + whA && yB <= yA + whA) ||
            (xA >= xB && yA >= yB) && (xA <= xB + whB && yA <= yB + whB) ||
            (xB <= xA && yB <= yA) && (xB >= xA + whA && yB >= yA + whA) ||
            (xA <= xB && yA <= yB) && (xA >= xB + whB && yA >= yB + whB) ||
            (xB + whB >= xA && yB + whB >= yA) && (xB + whB <= xA + whA && yB + whB <= yA + whA) ||
            (xA + whA >= xB && yA + whB >= yB) && (xA + whA <= xB + whB && yA + whA <= yB + whB) ||
            (xB + whB <= xA && yB + whB <= yA) && (xB + whB >= xA + whA && yB + whB >= yA + whA) ||
            (xA + whA <= xB && yA + whA <= yB) && (xA + whA >= xB + whB && yA + whA >= yB + whB))
        {
            DrawText("Craaaaasshhhhh", 150, 50, 20, Color.BLACK);
        }

    }

    public void Auto() { Init(); }*/
}
