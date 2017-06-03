using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

using TrashyWindowControl;

namespace SetCoordinatesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //make sure a process called "notepad" is already running befor starting this programm! 
            WindowControl twc = new WindowControl();
            twc.process = Process.GetProcessesByName("notepad").FirstOrDefault();
            char input;

            Console.WriteLine("Move the window with WASD!");
            Console.WriteLine("You can change the height with R/F and the width with T/G");
            do
            {
                input = Console.ReadKey().KeyChar;
                input = Char.ToLower(input);
                switch (input)
                {
                    case 'w':
                        {
                            twc.y = twc.y - 5;
                            break;
                        }
                    case 's':
                        {
                            twc.y = twc.y + 5;
                            break;
                        }
                    case 'd':
                        {
                            twc.x = twc.x + 5;
                            break;
                        }
                    case 'a':
                        {
                            twc.x = twc.x - 5;
                            break;
                        }
                    case 'r':
                        {
                            twc.height = twc.height + 5;
                            break;
                        }
                    case 'f':
                        {
                            twc.height = twc.height - 5;
                            break;
                        }
                    case 't':
                        {
                            twc.width = twc.width + 5;
                            break;
                        }
                    case 'g':
                        {
                            twc.width = twc.width - 5;
                            break;
                        }

                    
                }


            } while (true);




        }
    }
}
