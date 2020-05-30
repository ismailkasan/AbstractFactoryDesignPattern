using AbstractFactoryDesignPattern.Interfaces;

namespace AbstractFactoryDesignPattern.Modeller
{

    /// <summary>
    /// Mercedes nesnesi IAraba interfaceden türettim
    /// </summary>
    public class Mercedes : IAraba
    {
        /// <summary>
        /// Araba Modelini getirir.
        /// </summary>
        /// <returns></returns>
        public string GetArabaModeli()
        {
            return "CLS 350";
        }
    }
}
