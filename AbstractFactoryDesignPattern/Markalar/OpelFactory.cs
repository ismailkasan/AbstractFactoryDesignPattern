using AbstractFactoryDesignPattern.Interfaces;
using AbstractFactoryDesignPattern.Jantlar;
using AbstractFactoryDesignPattern.Modeller;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Markalar
{

    /// <summary>
    /// OpelFactory Opel fabrikası gibi düşünebirlirsiniz.
    /// IMarkaFactory interfaceden Bir tane araba ve jant
    /// oluşturan methodlarla araba ve jant oluşturuyoruz.
    /// </summary>
    public class OpelFactory : IMarkaFactory
    {
        public IAraba ArabaOlustur()
        {
            return new Opel();
        }

        public IJant JantOlustur()
        {
            return new OpelJant();
        }
    }
}
