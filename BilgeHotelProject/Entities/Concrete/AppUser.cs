using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            if (string.IsNullOrEmpty(CreatedDate.ToString()))
            {
                CreatedDate = DateTime.Now;
            }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid ActivationKey { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
