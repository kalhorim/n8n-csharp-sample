using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webapp.Models
{
    public class User
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool IsValid { get; set; }
        public bool IsGuest { get; set; }
    }
}
