using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplicationThreadRakete
{
    public class Rakete : Figur, IConsoleObjects
    {
        public void Display()
        {
            Console.SetCursorPosition(this.X, this.Y);
            ConsoleColor c = Console.ForegroundColor;
            Console.ForegroundColor = this.MyColor;
            Console.Write("/-----\\");
            Console.SetCursorPosition(this.X + 1, this.Y - 1);
            Console.Write("/   \\");
            Console.SetCursorPosition(this.X + 2, this.Y - 2);
            Console.Write("/ \\");
            Console.SetCursorPosition(this.X + 3, this.Y - 3);
            Console.Write("|");
            Console.SetCursorPosition(this.X + 3, this.Y - 4);
            Console.Write("^");
            Console.ForegroundColor = c;

        }

        public void MoveUp()
        {
            Boolean status = true;
            while (status)
            {
                lock (this.Lockobject)
                { 
                    if ((DateTime.Now - Starttime).TotalSeconds > Lifetime)
                    {
                        status = false;
                        this.Delete();
                        Mythread.Abort();
                    }
                    this.Delete();
                    this.Y -= this.Speedy;
                    this.X += this.Speedx;

                    if (this.Y <= this.Speedy || this.Y <= 4)
                    {
                        this.Y = Console.WindowHeight -2;
                    }
                    if(this.X >= Console.WindowWidth - this.Speedx -3)
                    {
                        this.X = 50;
                    }
                    this.Display();
                    Thread.Sleep(50);
                }           
            }
    }

        private void Delete()
        {
            Console.SetCursorPosition(this.X, this.Y);
            ConsoleColor c = Console.ForegroundColor;
            Console.ForegroundColor = Console.BackgroundColor;
            Console.Write("/-----\\");
            Console.SetCursorPosition(this.X + 1, this.Y - 1);
            Console.Write("/   \\");
            Console.SetCursorPosition(this.X + 2, this.Y - 2);
            Console.Write("/ \\");
            Console.SetCursorPosition(this.X + 3, this.Y - 3);
            Console.Write("|");
            Console.SetCursorPosition(this.X + 3, this.Y - 4);
            Console.Write("^");
            Console.ForegroundColor = c;
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Start(Thread th)
        {
            this.Starttime = DateTime.Now;
            this.Mythread = th;
        }
    }
}
