using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Interfaces
{
    /// <summary>
    /// Marka oluşturan base interface
    /// </summary>
    public interface IMarkaFactory
    {
        /// <summary>
        /// Araba Nesnesini oluşturan method
        /// </summary>
        /// <returns></returns>
        IAraba ArabaOlustur();

        /// <summary>
        /// Jant nesnesini oluşturan method
        /// </summary>
        /// <returns></returns>
        IJant JantOlustur();
    }
}
