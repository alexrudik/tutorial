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
            Console.CursorVisible = false;
            Console.Title = "Змейка. Консольная версия";

            while (!sn.BorderHit(f.GetBorder()))
            {
                sn.Move(GetDirection(sn.CurrentDir()));
                if (sn.MouseHit(f.GetMouse())) f.NewMouse();
                Pause(300);
            }

            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("Игра окончена. Нажимте \"Ввод\"");
            Console.ReadLine();
        }

        private static void Pause(int ms)
        {
            System.Threading.Thread.Sleep(ms);
        }

        private static Direction GetDirection(Direction dir)
        {
            ConsoleKeyInfo key;

            if (Console.KeyAvailable)
            {
                key = Console.ReadKey(false);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        dir = Direction.UP;
                        break;
                    case ConsoleKey.DownArrow:
                        dir = Direction.DOWN;
                        break;
                    case ConsoleKey.LeftArrow:
                        dir = Direction.LEFT;
                        break;
                    case ConsoleKey.RightArrow:
                        dir = Direction.RIGHT;
                        break;

                }
                while (Console.KeyAvailable) key = Console.ReadKey(false);
            }

            return dir;
        }
    }
}
