using AbstractFactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Modeller
{
    /// <summary>
    /// OPEL nesnesi IAraba interfaceden türettim
    /// </summary>
    public class Opel : IAraba
    {
        /// <summary>
        /// Araba Modelini getirir.
        /// </summary>
        /// <returns></returns>
        public string GetArabaModeli()
        {
            return "Insignia";
        }
    }
}
