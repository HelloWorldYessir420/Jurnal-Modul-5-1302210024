using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurnal_Mod5_1302210024
{
    internal class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> InputDates;

        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.InputDates = new List<DateTime>();
        }

        public void addNewData(T data)
        {
            storedData.Add(data);
            InputDates.Add(DateTime.Now);
        }

        public void printAllData()
        {
            int j = 1;
            for (int i = 0; i < this.InputDates.Count; i++)
            {
                Console.WriteLine("Data " + j++ + " berisi : " + this.storedData[i] 
                    + " yang disimpan pada waktu UTC : " + this.InputDates[i]);
            }
        }
    }
}
