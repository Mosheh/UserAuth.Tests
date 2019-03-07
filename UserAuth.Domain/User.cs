using System;
using System.Collections.Generic;
using System.Text;

namespace UserAuth.Domain
{
    public class User
    {
        public User(string name)
        {
            ValidateUserName(name);
            this.Name = name;
        }

        private void ValidateUserName(string name)
        {
            if (name == null || name.Length < 3)
                throw new Exception("Invalid user name");
        }

        public void Validate()
        {
            ValidateEmail();
            ValidatePassword();

        }

        private void ValidatePassword()
        {
            if (Password == null)
                throw new Exception("Senha nao definida");
        }

        private void ValidateEmail()
        {
            if (this.Email == null || !this.Email.Contains("@") || !this.Email.Contains("."))
                throw new Exception("Email invalido");                     
        }
      
        public void SetPassword(string password, string confirmPassword)
        {
            if (password != confirmPassword)
                throw new Exception("Passwords not matched");

            if (password == null || password.Length < 6)
                throw new Exception("Invalid password. Minimal characters must be 6");

            this.Password = password;
        }

        public void SetName(string name)
        {
            ValidateUserName(name);
            this.Name = name;
        }

        public string Name { get; private set; }
        public string Email { get; set; }
        public string Password { get; private set; }
    }
}
