using System;
using System.Collections.Generic;
using System.Text;
using static Gun5Odev4.Entities.Program;
//burada diger dosyadaki leri kullanabilmek icin dosyayı ekledik


namespace Gun5Odev4.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer); 
    }
}
