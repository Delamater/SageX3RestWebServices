using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestWebServices01.Models;

namespace RestWebServices01.Services
{
    public class ContactRepository
    {
        public Contact[] GetAllContacts()
        {
            return new Contact[]
            {
                new Contact
                {
                    Id = 1,
                    Name = "Bob Delamater"
                },

                new Contact
                {
                    Id = 2,
                    Name = "Pam Nightingale"
                }
            };
        }
    }
}