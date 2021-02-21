using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    
    class GercekMusteri: Musteri            //Gerçek müşteri bir Musteri dir demek.  Musteri de olan özellikler GercekMusteri de vardır. Musterideki özellikleri buraya yazmaya gerek yok.
    {
       
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
