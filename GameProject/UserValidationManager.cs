using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidation
    {
        public bool Validation(Gamer gamer)
        {
            if (gamer.BirthYear==2003 && gamer.FirstName=="YAKUP"&&gamer.LastName=="BEKAR"&&gamer.IdentityNumber==12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
