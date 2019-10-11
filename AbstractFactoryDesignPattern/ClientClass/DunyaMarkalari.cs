using AbstractFactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.ClientClass
{
    /// <summary>
    /// Clientların marka,araba ve jant oluşturmak istediklerinde bu objeyi kullanacaklar
    /// </summary>
    public class DunyaMarkalari
    {
        /// <summary>
        /// oluşturulacak arabayı tuttuğumuz değişken
        /// </summary>
        private readonly IAraba _araba;

        /// <summary>
        /// Oluşturulacak jantı tuttuğumuz değişken
        /// </summary>
        private readonly IJant _jant;

        /// <summary>
        /// Nesneye constructor da hangi markayı verirsem o markanın objesini oluşturur.
        /// </summary>
        /// <param name="markaFactory"></param>
        public DunyaMarkalari(IMarkaFactory markaFactory)
        {
            _araba = markaFactory.ArabaOlustur();
            _jant = markaFactory.JantOlustur();
        }

        /// <summary>
        /// Oluşturulan arabanın modelini getirir. 
        /// </summary>
        /// <returns></returns>
        public string ArabaModeli()
        {
            return _araba.GetArabaModeli();
        }

        /// <summary>
        /// Oluşturulan jantın çapını getirir. 
        /// </summary>
        /// <returns></returns>
        public int JantCapi()
        {
            return _jant.GetJantCapi();
        }
    }
}
