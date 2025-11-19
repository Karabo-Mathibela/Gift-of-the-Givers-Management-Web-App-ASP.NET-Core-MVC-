using LoginAndRegistration.Models;

namespace LoginAndRegistration.Services
{
    public class SecurityService
    {
        List<UserModel> knownUsers = new List<UserModel>();

        public SecurityService() 
        {
            knownUsers.Add(new UserModel { Id = 0, Username = "KaraboFish", Password = "bigbucks" });
            knownUsers.Add(new UserModel { Id = 1, Username = "KaraboM", Password = "mathibela" });
            knownUsers.Add(new UserModel { Id = 2, Username = "KaraboB", Password = "fish" });
        }
        public bool isValid(UserModel user) 
        {
            //THE METHOD WILL RETURN 'true' IF THE USER IS FOUND IN THE LIST
            return knownUsers.Any(x => x.Username == user.Username && x.Password == user.Password);
        }
    }
}
