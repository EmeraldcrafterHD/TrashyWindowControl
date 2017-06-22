# TrashyWindowControl
Control a Window in Windows! A useless nuget package :0


## How to install

Run this command in your nuget console to install this package:

    PM> Install-Package TrashyWindowControl
    

## How to use

First, add this namespace to your program:
``` csharp
    using TrashyWindowControl;
```

Then, set the process (make sure the process is already running) you want to control:

``` csharp
    WindowControl twc = new WindowControl();
    twc.process = randomProcess;
```
If you want, you can deactivate "Repaint", it's activated by default
When it's on, the system tells the window that you have moved, that it needs to be redrawn.

In this example we deactivate it:


``` csharp
    twc.Repaint = false;
```

Now we can get or set _x/y coordinates_, _high_ and _width_ from the window of the process we set earlier
For example:

``` csharp
    Console.WriteLine("x: " + twc.x);
    Console.WriteLine("y: " + twc.y);
    Console.WriteLine("height: " + twc.height);
    Console.WriteLine("width: " + twc.width);
```
``` csharp
    twc.x  = Convert.ToInt32(Console.ReadLine());
    twc.y = Convert.ToInt32(Console.ReadLine());
    twc.heigh = Convert.ToInt32(Console.ReadLine());
    twc.widt = Convert.ToInt32(Console.ReadLine());
```



If you have any questions, feel free to ask!
