﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        public void ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi! :" + urun.Adi);
        }
        public void Ekle2 (string urunAdi,string Aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi! :" + urunAdi);
        }
    }
}
