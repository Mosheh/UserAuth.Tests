using System;
using System.Collections.Generic;
using System.Text;

namespace UserAuth.Domain
{
    public interface IUserRepository
    {
        void Add(User user);
        void Update(User user);
        void Delete(string email);

        User GetByEmail(string email);
        List<User> GetUsers();
    }
}
