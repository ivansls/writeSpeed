
using System.Diagnostics.Metrics;
using wrireSpeedTest;

write wr = new write();
//Class2 tim = new Class2();
Console.WriteLine("Введите имя");
string name = Console.ReadLine();

Console.Clear();
string txt = "Текст - зафиксированная на каком-либо материальном носителе человеческая мысль; в общем плане связная и полная последовательность символов.";
Console.WriteLine(txt);
/*Thread th = new Thread(_ => {
    while (true)
    {
        Console.SetCursorPosition(0, 10);
        Console.WriteLine(wr.time);
        Thread.Sleep(1000);
        Console.SetCursorPosition(0, 10);
        Console.WriteLine("     ");
        wr.time--;
    }
});*/
Class2.th.Start();
  
while (true)
{
    /*if (wr.window == 0)
    {
        th.Start();
    }
    else
    {
        th.Abort();
    }*/
    //ConsoleKeyInfo key = Console.ReadKey(true);
    wr.wr(txt, name);
}