using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wrireSpeedTest
{
    internal class write
    {
        public void wr(ConsoleKeyInfo key, string txt)
        {
            char[] a = txt.ToCharArray().ToArray();
            string kkk = key.KeyChar.ToString();
            
            foreach (char i in a)
            {
                Console.WriteLine(a.ToString());
                if (kkk == i.ToString())
                {
                    Console.WriteLine("dj");
                }
            }
        }
    }
}
