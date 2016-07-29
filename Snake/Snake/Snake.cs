using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public enum Direction { UP, DOWN, LEFT, RIGHT}

    class Snake
    {
        Direction dir;
        List<Point> body = new List<Point>();
        int Lenght, x, y;

        public Snake()
        {
            dir = Direction.LEFT;
            Lenght = 4;
            x = (Console.WindowWidth - 1) / 2;
            y = Console.WindowHeight / 2;

            for (int i = 0; i < Lenght; i++)
                body.Add(new Point(x+i, y, PointClass.SnakePoint));
            Draw();
        }


        internal bool BorderHit(List<Point> lp)
        {
            foreach (Point p in lp)
                if (p.x == x && p.y == y)
                    return true;
            for(int i = 1; i < body.Count(); i++)
            {
                if (body[i].x == x && body[i].y == y)
                    return true;
            }

//            foreach (Point p in body)
//                if (p.x == x && p.y == y)
//                    return true;

            return false;
        }

        internal void SetPosition(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        internal void Move(Direction dir)
        {
            Clear();

            this.dir = dir;
            body.RemoveAt(body.Count()-1);
            switch (dir)
            {
                case Direction.UP:
                    y--; break;
                case Direction.DOWN:
                    y++; break;
                case Direction.LEFT:
                    x--; break;
                case Direction.RIGHT:
                    x++; break;
            }
            body.Insert(0, new Point(x, y, PointClass.SnakePoint));

            Draw();
        }

        internal Direction CurrentDir()
        {
            return dir;
        }

        internal bool MouseHit(List<Mouse> mouse)
        {
            foreach (Mouse m in mouse)
                if (m.x == x && m.y == y)
                {
                    body.Add(new Point(x, y, PointClass.SnakePoint));
                    m.Clear();
                    mouse.Remove(m);
                    return true;
                }
            return false;
        }

        internal void Draw()
        {
            foreach (Point p in body) p.Draw();
        }
        internal void Clear()
        {
            foreach (Point p in body) p.Clear();
        }
    }
}
