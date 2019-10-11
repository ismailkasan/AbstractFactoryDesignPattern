using AbstractFactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Modeller
{
    /// <summary>
    /// BMW nesnesi IAraba interfaceden türettim
    /// </summary>
    public class Bmw : IAraba
    {
        /// <summary>
        /// Araba modelini getirir
        /// </summary>
        /// <returns></returns>
        public string GetArabaModeli()
        {
            return "7.40";
        }
    }
}
