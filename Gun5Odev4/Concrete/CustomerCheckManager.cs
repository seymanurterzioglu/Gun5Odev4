
using Gun5Odev4.Abstract;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using static Gun5Odev4.Entities.Program;

namespace Gun5Odev4.Concrete
{
    public class CustomerCheckManager :ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }

    }
}
