using System;
using UserAuth.Domain;
using UserAuth.Infra;

namespace UserAuth.Servicee
{
    public class UserService : IUserService
    {
        IUserRepository userRepository = new UserRepository();

        public void Add(User user)
        {
            user.Validate();
            var userInDatabaseWithSameEmail = GetUserByEmail(user.Email);
            if (userInDatabaseWithSameEmail != null)
                throw new Exception("User already exists");

            userRepository.Add(user);
        }

        public User GetUserByEmail(string userMail)
        {
            var user = userRepository.GetByEmail(userMail);
            if (user == null)
                throw new Exception("Usuario nao encontrado");

            return user;
        }

        public void Update(User user)
        {
            user.Validate();
            this.userRepository.Update(user);
        }
    }
}
