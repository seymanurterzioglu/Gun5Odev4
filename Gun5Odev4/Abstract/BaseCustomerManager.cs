using System;
using System.Collections.Generic;
using System.Text;
using Gun5Odev4.Abstract;
using Gun5Odev4.Entities;
using static Gun5Odev4.Entities.Program;

namespace Gun5Odev4.Abstract
{
     public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db:"+customer.FirstName);
        }
    }
}
