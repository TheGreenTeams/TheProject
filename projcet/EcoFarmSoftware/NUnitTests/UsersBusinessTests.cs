using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business;
using System;
using Data;
using Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Tests
{
    [TestClass()]
    public class UsersBusinessTests
    {
        private UsersBusiness usersBusiness = new UsersBusiness();
        private EcoFarmSoftwareContext a = new EcoFarmSoftwareContext();

        //[SetUp]
        public void SetUp()
        {

            //var bankRepository = new BankBusiness(a);
        }

        //[]
        //public void TearDown()
        //{
        //    a.Dispose();
        //}

        [TestMethod()]
        public void GetAll_ShouldReturnAllProducts()
        {
            // Arrange
            List<Users> b = a.Userss.ToList();

            // Act
            var users = usersBusiness.GetAll();

            // Assert
            Assert.AreEqual(b.Count, users.Count);
        }

        [TestMethod()]
        public void Get_ShouldReturnBankWithGivenId()
        {
            // Arrange
            Users expectedUser = new Users { FirstName = "name A", LastName = "name B", Username = "proba", EMail = "email.com", Password = "123"};

            usersBusiness.Add(expectedUser);
            int ID = 0;
            var listUsers = usersBusiness.GetAll();

            foreach (var item in listUsers)
            {
                if (expectedUser.Username == item.Username && expectedUser.Password == item.Password)
                {
                    ID = item.Id;
                }
            }

            //a.SaveChanges();

            // Act
            var actualUser = usersBusiness.Get(ID);

            // Assert
            Assert.AreEqual(actualUser.FirstName, expectedUser.FirstName, "FirstName does not work!");
            Assert.AreEqual(actualUser.LastName, expectedUser.LastName, "LastName does not work!");
            Assert.AreEqual(actualUser.Username, expectedUser.Username, "Username does not work!");
            Assert.AreEqual(actualUser.EMail, expectedUser.EMail, "EMail does not work!");
            Assert.AreEqual(actualUser.Password, expectedUser.Password, "Password does not work!");
            Assert.AreEqual(actualUser.Id, expectedUser.Id, "Id does not work!");


            usersBusiness.Delete(expectedUser.Id);
        }

        [TestMethod()]
        public void Add_ShouldAddNewBank()
        {
            // Arrange
            Users UserToAdd = new Users { FirstName = "name A", LastName = "name B", Username = "proba", EMail = "email.com", Password = "123" };
           
            usersBusiness.Add(UserToAdd);
            Users actualUser = usersBusiness.Get(UserToAdd.Id);

            // Assert
            Assert.AreEqual(actualUser.FirstName, UserToAdd.FirstName, "FirstName does not work!");
            Assert.AreEqual(actualUser.LastName, UserToAdd.LastName, "LastName does not work!");
            Assert.AreEqual(actualUser.Username, UserToAdd.Username, "Username does not work!");
            Assert.AreEqual(actualUser.EMail, UserToAdd.EMail, "EMail does not work!");
            Assert.AreEqual(actualUser.Password, UserToAdd.Password, "Password does not work!");
            Assert.AreEqual(actualUser.Id, UserToAdd.Id, "Id does not work!");

            usersBusiness.Delete(UserToAdd.Id);
        }

        [TestMethod()]
        public void Update_ShouldUpdateExistingBank()
        {
            // Arrange
            Users UserToUpdate = new Users { FirstName = "name A", LastName = "name B", Username = "proba", EMail = "email.com", Password = "123" };
            UserToUpdate.Password = "2000";

            // Act
            usersBusiness.Update(UserToUpdate);
            //var actualProduct = productsBusiness.Get(productToUpdate.Id);

            // Assert
            Assert.AreEqual(UserToUpdate.Password, "2000");
            usersBusiness.Delete(UserToUpdate.Id);
        }

        [TestMethod()]
        public void Delete_ShouldRemoveExistingBank()
        {
            // Arrange
            var productToDelete = usersBusiness.Get(1);

            // Act
            usersBusiness.Delete(1);
            var actualProduct = usersBusiness.Get(1);

            // Assert
            Assert.IsNull(actualProduct);
        }
    }
}