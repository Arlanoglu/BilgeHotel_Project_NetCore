using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ActivationKey { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
