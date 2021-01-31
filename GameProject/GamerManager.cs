using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidation _userValidation;

        public GamerManager(IUserValidation userValidation)
        {
            _userValidation = userValidation;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidation.Validation(gamer))
            {
                Console.WriteLine("Gamer Eklendi");
            }
            else
            {
                Console.WriteLine("Bilgiler yanlış");
            }

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer Güncellendi");
        }
    }
}
