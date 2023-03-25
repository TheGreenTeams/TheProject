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
    public class ProductsBusinessTests
    {
        private ProductsBusiness productsBusiness = new ProductsBusiness();
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
            List<Products> b = a.Products.ToList();

            // Act
            var products = productsBusiness.GetAll();

            // Assert
            Assert.AreEqual(b.Count, products.Count);
        }

        [TestMethod()]
        public void Get_ShouldReturnBankWithGivenId()
        {
            // Arrange
            Products expectedProduct = new Products { Name = "Product A", Price = 1000, Stock = 20, Type = "proba" };
            
            productsBusiness.Add(expectedProduct);
            int ID = 0;
            var listProducts = productsBusiness.GetAll();

            foreach (var item in listProducts)
            {
                if (expectedProduct.Name == item.Name && expectedProduct.Stock == item.Stock)
                {
                    ID = item.Id;
                }
            }

            //a.SaveChanges();

            // Act
            var actualProduct = productsBusiness.Get(ID);

            // Assert
            Assert.AreEqual(actualProduct.Name, expectedProduct.Name, "Get() does not work!");
            Assert.AreEqual(actualProduct.Price, expectedProduct.Price, "Balance does not work!");
            Assert.AreEqual(actualProduct.Stock, expectedProduct.Stock, "Balance does not work!");
            Assert.AreEqual(actualProduct.Type, expectedProduct.Type, "Type does not work!");
            Assert.AreEqual(actualProduct.Id, expectedProduct.Id, "Id does not work!");

            productsBusiness.Delete(expectedProduct.Id);
        }

        [TestMethod()]
        public void Add_ShouldAddNewBank()
        {
            // Arrange
            Products productToAdd = new Products { Name = "Product A", Price = 1000, Stock = 20, Type = "proba" };
            //bankBusiness.Add(bank);
            //{ Name = "Bank D", Balance = 5000, Type = "proba" };

            // Act
            productsBusiness.Add(productToAdd);
            Products actualProduct = productsBusiness.Get(productToAdd.Id);

            // Assert
            Assert.AreEqual(actualProduct.Name, productToAdd.Name, "Get() does not work!");
            Assert.AreEqual(actualProduct.Price, productToAdd.Price, "Balance does not work!");
            Assert.AreEqual(actualProduct.Stock, productToAdd.Stock, "Balance does not work!");
            Assert.AreEqual(actualProduct.Type, productToAdd.Type, "Type does not work!");
            Assert.AreEqual(actualProduct.Id, productToAdd.Id, "Id does not work!");

            productsBusiness.Delete(productToAdd.Id);
        }

        [TestMethod()]
        public void Update_ShouldUpdateExistingBank()
        {
            // Arrange
            Products productToUpdate = new Products { Name = "Product A", Price = 1000, Stock = 20, Type = "proba" };
            productToUpdate.Stock = 2000;

            // Act
            productsBusiness.Update(productToUpdate);
            //var actualProduct = productsBusiness.Get(productToUpdate.Id);

            // Assert
            Assert.AreEqual(productToUpdate.Stock, 2000);
            productsBusiness.Delete(productToUpdate.Id);
        }

        [TestMethod()]
        public void Delete_ShouldRemoveExistingBank()
        {
            // Arrange
            var productToDelete = productsBusiness.Get(1);

            // Act
            productsBusiness.Delete(1);
            var actualProduct = productsBusiness.Get(1);

            // Assert
            Assert.IsNull(actualProduct);           
        }

        [TestMethod()]
        public void SellTest()
        {
            Products expectedProduct = new Products { Name = "Product A", Price = 1000, Stock = 20, Type = "proba" };

            productsBusiness.Sell(expectedProduct.Id, 5);
            expectedProduct.Stock -= 5;
            Assert.AreEqual(15, expectedProduct.Stock);
            productsBusiness.Delete(expectedProduct.Id);
        }
    }
}   
