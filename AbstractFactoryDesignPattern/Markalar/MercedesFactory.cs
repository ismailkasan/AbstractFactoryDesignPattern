using AbstractFactoryDesignPattern.Interfaces;
using AbstractFactoryDesignPattern.Jantlar;
using AbstractFactoryDesignPattern.Modeller;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Markalar
{

    /// <summary>
    /// MercedesFactory Mercedes fabrikası gibi düşünebirlirsiniz.
    /// IMarkaFactory interfaceden Bir tane araba ve jant oluşturan
    /// methodlarla araba ve jant oluşturuyoruz.
    /// </summary>
    public class MercedesFactory : IMarkaFactory
    {
        public IAraba ArabaOlustur()
        {
            return new Mercedes();
        }

        public IJant JantOlustur()
        {
            return new MercedesJant();
        }
    }
}
