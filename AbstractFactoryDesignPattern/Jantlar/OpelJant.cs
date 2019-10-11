using AbstractFactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Jantlar
{
    /// <summary>
    /// Opel Jantlarını Ijant interfaceden türetiyorum
    /// </summary>
    public class OpelJant : IJant
    {
        /// <summary>
        ///JAnt çapını getiren method
        /// </summary>
        /// <returns></returns>
        public int GetJantCapi()
        {
           return 17;
        }
    }
}
