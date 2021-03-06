using Gun5Odev4.Abstract;
using System;


//Kahve dükkanları için müşteri yönetimi yapan bir sistem yazmak istiyoruz.

namespace Gun5Odev4.Entities
{
    public class Program
    {
        public class Customer : IEntity
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string NationalityId { get; set; }

        }
    }
}
