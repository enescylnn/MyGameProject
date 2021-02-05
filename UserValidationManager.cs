namespace MyGame
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2001 && gamer.FirstName == "Enes" && gamer.LastName == "Ceylan" && gamer.IdentityNumber == 12345)
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
