using AbstractFactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Jantlar
{
    /// <summary>
    /// Jant nesnesini Ijant interfaceden türetiyorum
    /// </summary>
    public class MercedesJant : IJant
    {
        /// <summary>
        /// Janbt çapını getiren method
        /// </summary>
        /// <returns></returns>
        public int GetJantCapi()
        {
            return 18;
        }
    }
}
