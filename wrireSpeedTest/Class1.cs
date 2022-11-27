using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wrireSpeedTest
{
    internal class write
    {
        int posicion_x = 0;
        int posicion_y = 0;
        //public int time = 60;
        public int window = 0;
        int count = 0;
        int count_rrr = 0;

        public void wr(string txt, string name)
        {
            //char[] a = txt.ToCharArray();
            char[] c = txt.ToArray();
            //Class2 t = new Class2();
            
            //char kkk = key.KeyChar;
            //Console.SetCursorPosition(posicion, 0);
            //Console.WriteLine(kkk);
            //posicion++;
            /*            if (Class2.time != 0)
                        {*/
            if (window == 0)
            {

                foreach (char i in c)
                {
                    Console.SetCursorPosition(0, 25);
                    ConsoleKeyInfo key = Console.ReadKey();
                    char kkk = key.KeyChar;
                    Console.SetCursorPosition(0, 25);
                    Console.WriteLine("     ");
                    Console.SetCursorPosition(0, 11);
                    Console.WriteLine("     ");
                    if (Class2.time == 0)
                    {
                        window = 1;
                        break;
                    }
                    //Console.WriteLine(i + " " + kkk);
                    try
                    {
                        if (kkk == i)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(posicion_x, posicion_y);
                            Console.WriteLine(kkk);
                            count_rrr++;
                            posicion_x++;
                        }
                        else if (kkk != i)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(posicion_x, posicion_y);
                            Console.WriteLine(kkk);
                            count++;
                            count_rrr++;
                            posicion_x++;
                        }
                    }
                    catch { posicion_y += 1; posicion_x = 0; }

                }
                //time = 0;
                window = 1;
                Class2.islitenning = false;
            }
            else if (window == 1)
            {
                window = 1;
                double sec = ((double)count_rrr / (double)Class2.time) / 60; // сделать проверку на время и делить не на 0, а на 1
                double min = ((double)count_rrr / (double)Class2.time);
                Console.SetCursorPosition(0, 14);
                Console.WriteLine("Имя - " + name);
                //Console.SetCursorPosition(0, 15);
                Console.WriteLine("Ваш результат символов в секунду - " + sec);
                //Console.SetCursorPosition(0, 16);
                Console.WriteLine("Ваш результат символов в минуту - " + min);
                Console.WriteLine("Количевство ошибок - " + count);
                Console.WriteLine("Нажмите enter чтобы сохранить");
                ConsoleKeyInfo keyn = Console.ReadKey();
                if (keyn.Key == ConsoleKey.Enter)
                {
                    user statistic = new user();
                    statistic.Name = name;
                    statistic.word_second = sec;
                    statistic.word_minute = min;
                    statistic.word_error = count;
                    best.Statistic_User(statistic);
                }

                window = 2;
            }
        }
    }
}
