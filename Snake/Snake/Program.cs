using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Field f = new Field();
            Snake sn = new Snake();

            Console.SetBufferSize(80, 25);

            f.SetBorder();
            f.NewMouse();
            f.Draw();

            sn.SetPosition(f.Width / 2, f.Height / 2);

            while (!sn.Hit())
            {
                sn.Move(GetDirection());
                sn.Draw();

                if (sn.MouseHit(f.GetMouse())) f.NewMouse();

                Pause(300);
            }
        }

        private static void Pause(int v)
        {
            throw new NotImplementedException();
        }

        private static object GetDirection()
        {
            throw new NotImplementedException();
        }
    }
}
