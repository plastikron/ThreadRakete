using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplicationThreadRakete
{
    public class Superman : Figur, IConsoleObjects
    {

        public void MoveUp()
        {
            Boolean status = true;
            while (status)
            {
                if((DateTime.Now - Starttime).TotalSeconds > Lifetime)
                {
                    status = false;
                    Mythread.Abort();
                }
                lock (this.Lockobject)
                {
                    this.Delete();
                    this.Y -= this.Speedy;
                    this.X -= this.Speedx;

                    if (this.Y <= this.Speedy || this.Y <= 3)
                    {
                        this.Y = Console.WindowHeight + 3;
                    }
                    if(this.X <= this.Speedx || this.X >= Console.WindowWidth + this.Speedx)
                    {
                        this.Speedx = -this.Speedx;
                    }
                    Thread.Sleep(50);
                    this.Display();
                }
            }
        }
        public void Delete()
        {
            Console.SetCursorPosition(this.X, this.Y);
            ConsoleColor c = Console.ForegroundColor;
            Console.ForegroundColor = Console.BackgroundColor;
            Console.Write("/ \\");
            Console.SetCursorPosition(this.X + 1, this.Y - 1);
            Console.Write("|");
            Console.SetCursorPosition(this.X, this.Y - 2);
            Console.Write("\\|/");
            Console.SetCursorPosition(this.X + 1, this.Y - 3);
            Console.Write("o");
            Console.ForegroundColor = c;
        }

        public void Display()
        {
            int i = Console.WindowWidth;
            Console.SetCursorPosition(this.X, this.Y);
            ConsoleColor c = Console.ForegroundColor;
            Console.ForegroundColor = this.MyColor;
            Console.Write("/ \\");
            Console.SetCursorPosition(this.X+1, this.Y - 1);
            Console.Write("|");
            Console.SetCursorPosition(this.X, this.Y - 2);
            Console.Write("\\|/");
            Console.SetCursorPosition(this.X+1, this.Y - 3);
            Console.Write("o");
            Console.ForegroundColor = c;
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Start(Thread th)
        {
            this.Starttime = DateTime.Now;
            Mythread = th;
        }
    }
}
