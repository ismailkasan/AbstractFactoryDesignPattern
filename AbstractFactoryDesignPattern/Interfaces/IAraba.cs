using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Interfaces
{
    /// <summary>
    /// Araba nesnelerimin türetildiği base interface
    /// </summary>
    public interface IAraba
    {
        /// <summary>
        /// Arabanın adını getiren method
        /// </summary>
        /// <returns></returns>
        string GetArabaModeli();
    }
}
