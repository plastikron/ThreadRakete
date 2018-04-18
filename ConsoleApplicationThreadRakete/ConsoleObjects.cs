using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplicationThreadRakete
{
    /*
     * Container für Konsolenobjekte
     */
    class ConsoleObjects
    {
        List<IConsoleObjects> listObjects = null;

        public ConsoleObjects()
        {
            listObjects = new List<IConsoleObjects>();
        }
        public void AddObject(IConsoleObjects consobject)
        {
            listObjects.Add(consobject);
        }
        public void DisplayAll()
        {
            foreach(IConsoleObjects co in listObjects)
            {
                co.Display();
            }
        }
        public void MoveAllUp()
        {
            foreach(IConsoleObjects co in listObjects)
            {
                int i = 0;
                Thread th = new Thread(new ThreadStart(co.MoveUp));

                co.Start(th);
                th.Name = i.ToString();
                i++;
                th.Start();
            }
        }
    }
}
