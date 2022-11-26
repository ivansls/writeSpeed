
using wrireSpeedTest;

write wr = new write();
string txt = "привет Иван, как дела?";
Console.WriteLine(txt);
while (true)
{
    ConsoleKeyInfo key = Console.ReadKey(true);

    wr.wr(key, txt);
}