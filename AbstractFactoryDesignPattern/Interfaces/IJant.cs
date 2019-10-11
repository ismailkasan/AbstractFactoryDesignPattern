using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Interfaces
{
    /// <summary>
    /// Jant Nesnelerimin türetileceği base interface
    /// </summary>
   public interface IJant
    {
        /// <summary>
        /// Jantın çapını getiren method
        /// </summary>
        /// <returns></returns>
        int GetJantCapi();
    }
}
