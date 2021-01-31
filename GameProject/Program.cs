using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.Id = 1;
            gamer.FirstName = "YAKUP";
            gamer.LastName = "BEKAR";
            gamer.BirthYear = 2003;
            gamer.IdentityNumber = 12345;
            
            //GamerManager gamerManager = new GamerManager(new UserValidationManager());
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer);
        }
    }
}
