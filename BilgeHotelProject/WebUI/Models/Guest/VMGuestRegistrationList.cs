using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Guest
{
    public class VMGuestRegistrationList : BaseVM
    {
        public int ID { get; set; }
        public string IdentificationNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string _fullName;
        public string FullName 
        { 
            get 
            {
                _fullName = FirstName +" "+ LastName;
                return _fullName;
            } 
        }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
