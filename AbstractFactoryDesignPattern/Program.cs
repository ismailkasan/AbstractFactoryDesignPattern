using AbstractFactoryDesignPattern.ClientClass;
using AbstractFactoryDesignPattern.Markalar;
using System;

namespace AbstractFactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BmwFactory bmwFactory = new BmwFactory();
            OpelFactory opelFactory = new OpelFactory();
            MercedesFactory mercedesFactory = new MercedesFactory();

            DunyaMarkalari dunyaMarkalari = new DunyaMarkalari(bmwFactory);
            Console.WriteLine(String.Format("Araba Modeli:{0}, Jant Çapı:{1}", dunyaMarkalari.ArabaModeli(), dunyaMarkalari.JantCapi()));

            Console.WriteLine(Environment.NewLine);

            DunyaMarkalari dunyaMarkalari2 = new DunyaMarkalari(opelFactory);
            Console.WriteLine(String.Format("Araba Modeli:{0}, Jant Çapı:{1}", dunyaMarkalari2.ArabaModeli(), dunyaMarkalari2.JantCapi()));

            Console.WriteLine(Environment.NewLine);

            DunyaMarkalari dunyaMarkalari3 = new DunyaMarkalari(mercedesFactory);
            Console.WriteLine(String.Format("Araba Modeli:{0}, Jant Çapı:{1}", dunyaMarkalari3.ArabaModeli(), dunyaMarkalari3.JantCapi()));

            Console.Read();

        }
      
    }
}
