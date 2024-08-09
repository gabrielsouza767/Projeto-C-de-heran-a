using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Smartphone NOKIA");
            Smartphone nokia = new Nokia( "123456", "NOKIA C20", "1212121212", 128);
            nokia.Ligar();
            nokia.InstalarApps("WhatsApp");

            Console.WriteLine("\n");

            Console.WriteLine("Smartphone Iphone:");
            Smartphone iphone = new Iphone( "123456", "Iphone 14", "2323232323", 256);
            iphone.ReceberLigacao();
            iphone.InstalarApps("Telegram");
            Console.ReadKey();
        }
    }
}
