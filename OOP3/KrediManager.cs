using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager     //Temel Class bu , aynı. Ama kullanıldığı yerler farklı örneğin TasitKrediManager,KonutKrediManager.. gibi. Bu yüzden class oluşturduktan sonra class ismi yerine interface yazdık burada.
    {
        void Hesapla();
        void BiseyYap();


        

        

    }
}
