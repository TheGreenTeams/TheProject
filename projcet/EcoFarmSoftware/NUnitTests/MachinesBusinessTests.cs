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
    public class MachinesBusinessTests
    {
        private MachinesBusiness machinesBusiness = new MachinesBusiness();
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
            List<Machines> b = a.Machines.ToList();

            // Act
            var machines = machinesBusiness.GetAll();

            // Assert
            Assert.AreEqual(b.Count, machines.Count);
        }

        [TestMethod()]
        public void Get_ShouldReturnBankWithGivenId()
        {
            // Arrange
            Machines expectedMachine = new Machines { Name = "Machine A", WorkingCapacity = 20, Type = "proba"};

            machinesBusiness.Add(expectedMachine);
            int ID = 0;
            var listEnergySources = machinesBusiness.GetAll();

            foreach (var item in listEnergySources)
            {
                if (expectedMachine.Name == item.Name && expectedMachine.WorkingCapacity == item.WorkingCapacity)
                {
                    ID = item.Id;
                }
            }

            //a.SaveChanges();

            // Act
            var actualMachine = machinesBusiness.Get(ID);

            // Assert
            Assert.AreEqual(actualMachine.Name, expectedMachine.Name, "Get() does not work!");
            Assert.AreEqual(actualMachine.WorkingCapacity, expectedMachine.WorkingCapacity, "WorkingCapacity does not work!");
            Assert.AreEqual(actualMachine.Type, expectedMachine.Type, "Type does not work!");
            

            machinesBusiness.Delete(expectedMachine.Id);
        }

        [TestMethod()]
        public void Add_ShouldAddNewBank()
        {
            // Arrange
            Machines machineToAdd = new Machines { Name = "Machine A", WorkingCapacity = 20, Type = "proba" };
            //bankBusiness.Add(bank);
            //{ Name = "Bank D", Balance = 5000, Type = "proba" };

            // Act
            machinesBusiness.Add(machineToAdd);
            Machines actualMachine = machinesBusiness.Get(machineToAdd.Id);

            // Assert
            Assert.AreEqual(actualMachine.Name, machineToAdd.Name, "Get() does not work!");          
            Assert.AreEqual(actualMachine.WorkingCapacity, machineToAdd.WorkingCapacity, "KWh does not work!");
            Assert.AreEqual(actualMachine.Type, machineToAdd.Type, "Type does not work!");
            Assert.AreEqual(actualMachine.Id, machineToAdd.Id, "Id does not work!");

            machinesBusiness.Delete(machineToAdd.Id);
        }

        [TestMethod()]
        public void Update_ShouldUpdateExistingBank()
        {
            // Arrange
            Machines machineToUpdate = new Machines { Name = "Machine A", WorkingCapacity = 20, Type = "proba" };
            machineToUpdate.WorkingCapacity = 2000;

            // Act
            machinesBusiness.Update(machineToUpdate);
            //var actualProduct = productsBusiness.Get(productToUpdate.Id);

            // Assert
            Assert.AreEqual(machineToUpdate.WorkingCapacity, 2000);
            machinesBusiness.Delete(machineToUpdate.Id);
        }

        [TestMethod()]
        public void Delete_ShouldRemoveExistingBank()
        {
            // Arrange
            var productToDelete = machinesBusiness.Get(1);

            // Act
            machinesBusiness.Delete(1);
            var actualProduct = machinesBusiness.Get(1);

            // Assert
            Assert.IsNull(actualProduct);
        }
    }
}