using AbstractFactoryDesignPattern.Interfaces;
using AbstractFactoryDesignPattern.Jantlar;
using AbstractFactoryDesignPattern.Modeller;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Markalar
{
    /// <summary>
    /// BmwFactory Bmw fabrikası gibi düşünebirlirsiniz.
    /// IMarkaFactory interfaceden Bir tane araba 
    /// ve jant oluşturan methodlarla araba ve jant oluşturuyoruz.
    /// </summary>
    public class BmwFactory : IMarkaFactory
    {
        public IAraba ArabaOlustur()
        {
            return new Bmw();
        }

        public IJant JantOlustur()
        {
            return new BmwJant();
        }
    }
}
