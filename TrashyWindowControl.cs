using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace TrashyWindowControl
{
    public class WindowControl
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);




        private bool _repaint = true;

        public bool Repaint
        {
            get { return this._repaint; }
            set { this._repaint = value; }
        }


        private Process _process;

        public Process process
        {
            get
            {

                try
                {
                    Process.GetProcessById(_process.Id);
                }
                catch (ArgumentException)
                {
                    throw new System.InvalidOperationException("Process doesn't (exist anymore)!");
                }
                catch (InvalidOperationException)
                {
                    throw new System.InvalidOperationException("Process doesn't (exist anymore)!");
                }
                catch (NullReferenceException)
                {
                    throw new System.InvalidOperationException("Process doesn't (exist anymore)!");
                }


                if (this._process.HasExited)
                {
                    throw new System.InvalidOperationException("Process doesn't (exist anymore)!");
                }
                return this._process;

            }
            set
            {
                this._process = value;
            }
        }



        public int x
        {
            get
            {

                GetWindowRect(process.MainWindowHandle, out rect);
                return rect.Left;
            }
            set
            {
                GetWindowRect(process.MainWindowHandle, out rect);
                MoveWindow(this.process.MainWindowHandle, value, this.y, this.width, this.height, this._repaint);
            }

        }

        public int y
        {
            get
            {
                GetWindowRect(process.MainWindowHandle, out rect);
                return rect.Top;
            }
            set
            {
                GetWindowRect(process.MainWindowHandle, out rect);
                MoveWindow(this.process.MainWindowHandle, this.x, value, this.width, this.height, this._repaint);
            }
        }

        public int height
        {
            get
            {
                GetWindowRect(process.MainWindowHandle, out rect);
                return rect.Bottom - rect.Top;
            }
            set
            {
                GetWindowRect(process.MainWindowHandle, out rect);
                MoveWindow(this.process.MainWindowHandle, this.x, this.y, this.height, value, this._repaint);
            }
        }

        public int width
        {
            get
            {

                GetWindowRect(process.MainWindowHandle, out rect);
                return rect.Right - rect.Left;
            }
            set
            {
                GetWindowRect(process.MainWindowHandle, out rect);
                MoveWindow(this.process.MainWindowHandle, this.x, this.y, value, this.height, this._repaint);
            }
        }



        private RECT rect;

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }





    }
}
