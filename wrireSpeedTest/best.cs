using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace wrireSpeedTest
{
    internal class best
    {
        public static void Statistic_User(user statistic)
        {
            XmlSerializer xml = new XmlSerializer(typeof(user));
            using (FileStream fs = new FileStream("C:\\Users\\vanya\\Desktop\\testin.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, statistic);
            }
            Console.WriteLine("Успешно сохранилось");
        }
    }
}
