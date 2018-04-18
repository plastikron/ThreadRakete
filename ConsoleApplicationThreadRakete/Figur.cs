using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplicationThreadRakete
{
    public class Figur
    {
        int x;
        int y;
        int speedx;
        int speedy;
        ConsoleColor color;
        Object o;
        int lifetime = 5;
        DateTime starttime;
        Thread mythread;

        public ConsoleColor MyColor
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public int Speedx
        {
            get
            {
                return speedx;
            }

            set
            {
                speedx = value;
            }
        }

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public object Lockobject
        {
            get
            {
                return o;
            }

            set
            {
                o = value;
            }
        }

        public int Speedy
        {
            get
            {
                return speedy;
            }

            set
            {
                speedy = value;
            }
        }

        public int Lifetime
        {
            get
            {
                return lifetime;
            }

            set
            {
                lifetime = value;
            }
        }

        public DateTime Starttime
        {
            get
            {
                return starttime;
            }

            set
            {
                starttime = value;
            }
        }

        public Thread Mythread
        {
            get
            {
                return mythread;
            }

            set
            {
                mythread = value;
            }
        }
    }
}
