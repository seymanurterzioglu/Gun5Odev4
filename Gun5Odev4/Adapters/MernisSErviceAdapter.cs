using Gun5Odev4.Abstract;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using static Gun5Odev4.Entities.Program;


namespace Gun5Odev4.Adapters
{
    public class MernisSErviceAdapter: ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer)
        {
           
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(
                Convert.ToInt64(customer.NationalityId),
                customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(),
                customer.DateOfBirth.Year);
        }
    }
}
