using System;
using System.Collections.Generic;

namespace Snake
{
    internal class Field
    {
        public int Width { get; internal set; }
        public int Height { get; internal set; }


        List<Point> Border = new List<Point>();
        List<Mouse> mouse = new List<Mouse>();

        public Field()
        {
            Width = Console.WindowWidth - 1;
            Height = Console.WindowHeight;
        }

        internal void Draw()
        {
            foreach (Point p in Border) p.Draw();
            foreach (Mouse m in mouse) m.Draw();
        }

        internal void NewMouse()
        {
            Random rnd = new Random();
           
            mouse.Add(new Mouse(rnd.Next(2, 77), rnd.Next(2, 22)));
        }

        internal object GetMouse()
        {
            throw new NotImplementedException();
        }

        internal void SetBorder()
        {
            for(int x = 0; x < Width; x++)
                for(int y = 0; y < Height; y++)
                {
                    if (x == 0 || x == Width-1 || y == 0 || y == Height-1)
                    {
                        //Point b = new Point(x, y, PointClass.BorderPoint);
                        Border.Add(new Point(x, y, PointClass.BorderPoint));
                    }
                }
        }

    }

}