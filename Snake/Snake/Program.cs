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

            f.Draw();
            f.NewMouse();
            sn.SetPosition(f.Whith / 2, f.Lenght / 2);

            while (!sn.Hit())
            {
                sn.Move(GetDirection());
                sn.Draw();

                if (sn.MouseHit(f.Mouse())) f.NewMouse();

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
