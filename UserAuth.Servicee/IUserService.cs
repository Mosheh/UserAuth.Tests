using System;
using System.Collections.Generic;
using System.Text;
using UserAuth.Domain;

namespace UserAuth.Servicee
{
    public interface IUserService
    {
        void Add(User user);
        User GetUserByEmail(String userMail);
        void Update(User user);
    }
}
