using AbstractFactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Jantlar
{
    /// <summary>
    /// Bmw jantının nesnesini Ijant interfaceden türetiyorum
    /// </summary>
    public class BmwJant : IJant
    {
        /// <summary>
        /// Jant çapını getiren method
        /// </summary>
        /// <returns></returns>
        public int GetJantCapi()
        {
            return 19;
        }
    }
}
