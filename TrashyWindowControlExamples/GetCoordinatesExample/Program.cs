using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

using TrashyWindowControl;

namespace GetCoordinatesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //make sure a process called "notepad" is already running befor starting this programm!
            Process proc = Process.GetProcessesByName("notepad").FirstOrDefault();
            WindowControl twc = new WindowControl();
            twc.process = proc;
            do
            {
                Console.WriteLine("x: " + twc.x);
                Console.WriteLine("y: " + twc.y);
                Console.WriteLine("height: " + twc.height);
                Console.WriteLine("width: " + twc.width);
                Thread.Sleep(2);
                Console.Clear();
            } while (true);





        }
    }
}
