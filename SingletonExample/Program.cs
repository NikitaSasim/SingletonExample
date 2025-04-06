using System;
using System.Threading;
using SingletonExample;

var a = TimeStampSingleton.GetInstance();
Thread.Sleep(1000);

var b = TimeStampSingleton.GetInstance();
Thread.Sleep(1000);

var c = TimeStampSingleton.GetInstance();
Thread.Sleep(1000);


Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
