using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurnal_Mod5_1302210024
{
    internal class Penjumlahan
    {
        public void JumlahTigaAngka<T>(T satu, T dua, T tiga)
        {
            dynamic one, two, three;
            one = satu;
            two = dua;
            three = tiga;
            dynamic jumlah = one + two + three;
            Console.WriteLine(jumlah.ToString());

        }
    }
}
