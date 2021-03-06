using System;
using System.Collections.Generic;
using System.Text;
using Gun5Odev4.Abstract;
using static Gun5Odev4.Entities.Program;

//Starbacks müşterileri veri tabanına kaydediyor.Aynı zamanda müşterileri kaydederken , mutlaka mernis doğrulaması isityor.
//Starbacks müşteriler için her kahve alımında yıldız kazandırmak istiyor.

namespace Gun5Odev4.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager 
    {
        private ICustomerCheckService _customerCheckService;
        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if(_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person.");
            }
        }

        

        
        
    }
}
