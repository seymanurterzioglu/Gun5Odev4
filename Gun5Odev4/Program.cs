using System;
using Gun5Odev4.Abstract;
using Gun5Odev4.Concrete;
using static Gun5Odev4.Entities.Program;
using MernisServiceReference;
using Gun5Odev4.Adapters;



namespace Gun5Odev4
{
    partial class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisSErviceAdapter());
            customerManager.Save(new Customer { DateOfBirth=new DateTime(1998,10,6),FirstName
            ="Seyma",LastName="Terzioglu",NationalityId="159357"});

            Console.ReadLine();
        }
    }
}
 