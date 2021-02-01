using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            if(gamer.FirstName == "Berke" && gamer.LastName == "Özden" && gamer.ID == 1 && gamer.IdendityNumber == 123123 && gamer.BirthYear == 1999)
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
