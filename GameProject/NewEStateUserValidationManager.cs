using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class NewEStateUserValidationManager : IUserValidation
    {
        public bool Validation(Gamer gamer)
        {
            return true;
        }
    }
}
