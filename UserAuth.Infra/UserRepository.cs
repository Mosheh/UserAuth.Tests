using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UserAuth.Domain;

namespace UserAuth.Infra
{
    public class UserRepository : IUserRepository
    {
        List<User> UsersInDatabase = new List<User>();
        public void Add(User user)
        {
           

            UsersInDatabase.Add(user);
        }

        public void Delete(string email)
        {
            throw new NotImplementedException();
        }

        public User GetByEmail(string email)
        {
            var user = UsersInDatabase.ToList().Find(c => c.Email == email);

            return user;
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            //Buscar o usuario na lista;
            //Substituir pelo novo registro
            var list = this.UsersInDatabase.Where(x => x.Email != user.Email).ToList();
            list.Add(user);
            this.UsersInDatabase = list;

        }

       
    }
}
