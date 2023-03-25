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
    public class EnergySourcesBusinessTests
    {
        private EnergySourcesBusiness energySourcesBusiness = new EnergySourcesBusiness();
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
            List<EnergySources> b = a.EnergySources.ToList();

            // Act
            var energySources = energySourcesBusiness.GetAll();

            // Assert
            Assert.AreEqual(b.Count, energySources.Count);
        }

        [TestMethod()]
        public void Get_ShouldReturnBankWithGivenId()
        {
            // Arrange
            EnergySources expectedEnergySources = new EnergySources { Name = "EnergySource A", Price = 1000, KWh = 20, Type = "proba", Area = 15};

            energySourcesBusiness.Add(expectedEnergySources);
            int ID = 0;
            var listEnergySources = energySourcesBusiness.GetAll();

            foreach (var item in listEnergySources)
            {
                if (expectedEnergySources.Name == item.Name && expectedEnergySources.KWh == item.KWh)
                {
                    ID = item.Id;
                }
            }

            //a.SaveChanges();

            // Act
            var actualEnergySource = energySourcesBusiness.Get(ID);

            // Assert
            Assert.AreEqual(actualEnergySource.Name, expectedEnergySources.Name, "Get() does not work!");
            Assert.AreEqual(actualEnergySource.Price, expectedEnergySources.Price, "Balance does not work!");
            Assert.AreEqual(actualEnergySource.KWh, expectedEnergySources.KWh, "KWh does not work!");
            Assert.AreEqual(actualEnergySource.Type, expectedEnergySources.Type, "Type does not work!");
            Assert.AreEqual(actualEnergySource.Area, expectedEnergySources.Area, "Area does not work!");
            Assert.AreEqual(actualEnergySource.Id, expectedEnergySources.Id, "Id does not work!");

            energySourcesBusiness.Delete(expectedEnergySources.Id);
        }

        [TestMethod()]
        public void Add_ShouldAddNewBank()
        {
            // Arrange
            EnergySources energySourcesToAdd = new EnergySources { Name = "EnergySource A", Price = 1000, KWh = 20, Type = "proba", Area = 15 };
            //bankBusiness.Add(bank);
            //{ Name = "Bank D", Balance = 5000, Type = "proba" };

            // Act
            energySourcesBusiness.Add(energySourcesToAdd);
            EnergySources actualEnergySource = energySourcesBusiness.Get(energySourcesToAdd.Id);

            // Assert
            Assert.AreEqual(actualEnergySource.Name, energySourcesToAdd.Name, "Get() does not work!");
            Assert.AreEqual(actualEnergySource.Price, energySourcesToAdd.Price, "Balance does not work!");
            Assert.AreEqual(actualEnergySource.KWh, energySourcesToAdd.KWh, "KWh does not work!");
            Assert.AreEqual(actualEnergySource.Type, energySourcesToAdd.Type, "Type does not work!");
            Assert.AreEqual(actualEnergySource.Area, energySourcesToAdd.Area, "Area does not work!");
            Assert.AreEqual(actualEnergySource.Id, energySourcesToAdd.Id, "Id does not work!");

            energySourcesBusiness.Delete(energySourcesToAdd.Id);
        }

        [TestMethod()]
        public void Update_ShouldUpdateExistingBank()
        {
            // Arrange
            EnergySources energySourcesToUpdate = new EnergySources { Name = "EnergySource A", Price = 1000, KWh = 20, Type = "proba", Area = 15 };
            energySourcesToUpdate.Area = 2000;

            // Act
            energySourcesBusiness.Update(energySourcesToUpdate);
            //var actualProduct = productsBusiness.Get(productToUpdate.Id);

            // Assert
            Assert.AreEqual(energySourcesToUpdate.Area, 2000);
            energySourcesBusiness.Delete(energySourcesToUpdate.Id);
        }

        [TestMethod()]
        public void Delete_ShouldRemoveExistingBank()
        {
            // Arrange
            var productToDelete = energySourcesBusiness.Get(1);

            // Act
            energySourcesBusiness.Delete(1);
            var actualProduct = energySourcesBusiness.Get(1);

            // Assert
            Assert.IsNull(actualProduct);
        }
    }
}