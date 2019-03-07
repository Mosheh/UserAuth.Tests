using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserAuth.Domain;
using UserAuth.Infra;
using UserAuth.Servicee;

namespace UserAuth.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NaoDeveHaverNomeNulo()
        {
            User user = new User("Ler");

            Assert.AreNotEqual(null, user.Name);
        }

        [TestMethod]
        public void ObterUsuarioPorEmailAposInsercao()
        {
                     
        }
        [TestMethod]
        public void testeAtualizarUsuario()
        {
            //Inserir usuario
            //Obter usuario por email
            //Atualizar nome
            //Verificar se foi alterado
            User user = new User("Ler");
            user.SetPassword("123456", "123456");
            user.Email = "teste@.com";
            IUserService users = new UserService();
            users.Add(user);
            
            var userUpdated = users.GetUserByEmail(user.Email);
            userUpdated.SetName("Opa");
            users.Update(userUpdated);

            var foiAtualizado = users.GetUserByEmail(userUpdated.Email);
            Assert.AreEqual("Opa", user.Name);

        }
        [TestMethod]
        public void DeveLançarExceçãoCasoUsuarioNuloOuVazio ()
        {
            User user = new User("Ler");

            Assert.ThrowsException<Exception>(() => { new User(null); });
        }

        [TestMethod]
        public void SenhaNaoDeveSerNula()
        {
            User user = new User("Ler");
            user.SetPassword("123456", "123456");
            Assert.AreNotEqual(null, user.Password);
            Assert.AreNotEqual(string.Empty, user.Password);
        }

    }
}
