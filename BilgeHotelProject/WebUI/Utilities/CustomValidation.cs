using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Utilities
{
    public class CustomValidation : IdentityErrorDescriber
    {
        //Password
        //PasswordRequiresNonAlphanumeric (false olacak) PasswordRequiresUniqueChars(false olacak)
        #region Password
        public override IdentityError PasswordTooShort(int length)
        {
            IdentityError error = new IdentityError();
            error.Code = "PasswordTooShort";
            error.Description = $"Şifreniz en az {length} karakter olmalı.";
            return error;
        }
        public override IdentityError PasswordMismatch()
        {
            IdentityError error = new IdentityError();
            error.Code = "PasswordMismatch";
            error.Description = "Girilen şifreler eşleşmemektedır.";
            return error;
        }
        public override IdentityError PasswordRequiresDigit()
        {
            IdentityError error = new IdentityError();
            error.Code = "PasswordRequiresDigit";
            error.Description = "Şifreniz rakam içermelidir.";
            return error;
        }
        public override IdentityError PasswordRequiresLower()
        {
            IdentityError error = new IdentityError();
            error.Code = "PasswordRequiresLower";
            error.Description = "Şifreniz küçük harf içermelidir.";
            return error;
        }
        public override IdentityError PasswordRequiresUpper()
        {
            IdentityError error = new IdentityError();
            error.Code = "PasswordRequiresUpper";
            error.Description = "Şifreniz büyük harf içermelidir.";
            return error;
        }
        public override IdentityError UserAlreadyHasPassword()
        {
            IdentityError error = new IdentityError();
            error.Code = "UserAlreadyHasPassword";
            error.Description = "Kullanıcıya ait zaten parala bulunmaktadır.";
            return error;
        }
        #endregion
        //Email
        #region Email
        public override IdentityError DuplicateEmail(string email)
        {
            IdentityError error = new IdentityError();
            error.Code = "DuplicateEmail";
            error.Description = $"{email} daha önce kaydedilmiş!";
            return error;
        }
        public override IdentityError InvalidEmail(string email)
        {
            IdentityError error = new IdentityError();
            error.Code = "InvalidEmail";
            error.Description = $"{email} Geçersizdir.";
            return error;
        }
        #endregion
    }
}
