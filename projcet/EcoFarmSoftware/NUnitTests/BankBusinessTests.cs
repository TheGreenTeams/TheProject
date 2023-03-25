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
    public class BankTests
    {
        private BankBusiness bankBusiness = new BankBusiness();
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
        public void GetAll_ShouldReturnAllBanks()
        {
            // Arrange
            List<Bank> b = a.Banks.ToList();

            // Act
            var banks = bankBusiness.GetAll();

            // Assert
            Assert.AreEqual(b.Count, banks.Count); 
        }

        [TestMethod()]
        public void Get_ShouldReturnBankWithGivenId()
        {
            // Arrange
            Bank expectedBank = new Bank {Name = "Bank A", Balance = 1000, Type = "proba" };
            int ID = 0;
            bankBusiness.Add(expectedBank);
            var listBank = bankBusiness.GetAll();
            
            foreach (var item in listBank)
            {
                if (expectedBank.Name == item.Name && expectedBank.Balance == item.Balance )
                {
                    ID = item.Id;
                }
            }
            
            //a.SaveChanges();

            // Act
            var actualBank = bankBusiness.Get(ID);

            // Assert
            Assert.AreEqual(actualBank.Name, expectedBank.Name, "Get() does not work!");
            Assert.AreEqual(actualBank.Balance, expectedBank.Balance, "Balance does not work!");
            Assert.AreEqual(actualBank.Type, expectedBank.Type, "Type does not work!");
            Assert.AreEqual(actualBank.Id, expectedBank.Id, "Id does not work!");

            bankBusiness.Delete(expectedBank.Id);
        }

        [TestMethod()]
        public void Add_ShouldAddNewBank()
        {
            // Arrange
            Bank bankToAdd = new Bank();
            bankToAdd.Name = "Bank D";
            bankToAdd.Balance = 5000;
            bankToAdd.Type = "proba";
            //bankBusiness.Add(bank);
            //{ Name = "Bank D", Balance = 5000, Type = "proba" };

            // Act
            bankBusiness.Add(bankToAdd);
            Bank actualBank = bankBusiness.Get(bankToAdd.Id);

            // Assert
            Assert.AreEqual(actualBank.Name, bankToAdd.Name, "Get() does not work!");
            Assert.AreEqual(actualBank.Balance, bankToAdd.Balance, "Balance does not work!");
            Assert.AreEqual(actualBank.Type, bankToAdd.Type, "Type does not work!");
            Assert.AreEqual(actualBank.Id, bankToAdd.Id, "Id does not work!");

            bankBusiness.Delete(bankToAdd.Id);
        }

        [TestMethod()]
        public void Update_ShouldUpdateExistingBank()
        {
            // Arrange
            var bankToUpdate = bankBusiness.Get(4);
            bankToUpdate.Balance = 2000;

            // Act
            bankBusiness.Update(bankToUpdate);
            var actualBank = bankBusiness.Get(4);

            // Assert
            Assert.AreEqual(bankToUpdate.Balance, actualBank.Balance);
        }

        [TestMethod()]
        public void Delete_ShouldRemoveExistingBank()
        {
            // Arrange
            var bankToDelete = bankBusiness.Get(1);

            // Act
            bankBusiness.Delete(1);
            var actualBank = bankBusiness.Get(1);

            // Assert
            Assert.IsNull(actualBank);
        }

        [TestMethod()]
        public void AddMoney_ShouldIncreaseBankBalance()
        {
            // Arrange
            var bank = bankBusiness.Get(4);
            decimal initialBalance = bank.Balance;
            decimal amountToAdd = 500;

            // Act
            bank.Balance += amountToAdd; 
            bankBusiness.Update(bank);
            //bankBusiness.AddMoney(2, amountToAdd);
            var updatedBank = bankBusiness.Get(4);

            // Assert
            Assert.AreEqual(initialBalance + amountToAdd, updatedBank.Balance);
        }

        [TestMethod()]
        public void TakeMoney_ShouldDecreaseBankBalance()
        {
            // Arrange
            var bank = bankBusiness.Get(4);
            var initialBalance = bank.Balance;
            var amountToTake = 500;

            // Act
            bank.Balance -= amountToTake;
            bankBusiness.Update(bank);
            var updatedBank = bankBusiness.Get(4);

            // Assert
            Assert.AreEqual(initialBalance - amountToTake, updatedBank.Balance);
        }
    }

    
}