namespace Jurnal_Mod5_1302210024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Penjumlahan tambah = new Penjumlahan();
            tambah.JumlahTigaAngka<double>(13, 02, 21);

            Console.WriteLine("");

            SimpleDataBase<double> data = new SimpleDataBase<double>();
            data.addNewData(13);
            data.addNewData(02);
            data.addNewData(21);
            data.printAllData();
        }

    }
}