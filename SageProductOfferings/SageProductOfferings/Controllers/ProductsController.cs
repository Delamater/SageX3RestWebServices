using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SageProductOfferings.Models;

namespace SageProductOfferings.Controllers
{
    public class ProductsController : ApiController
    {
        const string kAct = "Accounting";
        const string kErp = "Enterprise Resource Planning";
        const string kHRM = "Human Resource Planning";
        const string kPay = "Payroll";
        const string kCnstr = "Construction";
        const string kTrk = "Track Time";


        public Product[] Get()
        {
            return new Product[]
            {
                new Product {Id = 1,    Category = kAct,       Name = "Sage One" },
                new Product {Id = 2,    Category = kAct,       Name = "Sage Live"},
                new Product {Id = 3,    Category = kAct,       Name = "Sage 50"},
                new Product {Id = 11,   Category = kAct,       Name = "Sage 50c"},
                new Product {Id = 4,    Category = kErp,       Name = "Sage 100"},
                new Product {Id = 5,    Category = kErp,       Name = "Sage 300"},
                new Product {Id = 6,    Category = kErp,       Name = "Sage X3"},
                new Product {Id = 7,    Category = kCnstr,     Name = "Sage 100 Contractor"},
                new Product {Id = 8,    Category = kCnstr,     Name = "Sage Estimating"},
                new Product {Id = 9,    Category = kCnstr,     Name = "Sage 300 Construction and Real Estate"},
                new Product {Id = 10,   Category = kCnstr,     Name = "Sage Construction Anywhere"},
                new Product {Id = 11,   Category = kHRM,       Name = "Sage HRMS"},
                new Product {Id = 12,   Category = kTrk,       Name = "Sage Timeslips"},
                new Product {Id = 13,   Category = kTrk,       Name = "Sage Time"},
                new Product {Id = 14,   Category = kPay,       Name = "Sage Payroll Essentials"},
                new Product {Id = 15,   Category = kPay,       Name = "Sage Payroll Full Service"}
            };
        }
    }
}
