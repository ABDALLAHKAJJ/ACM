﻿using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            ProductRepository productRepository = new ProductRepository();
            Product expected = new Product(1)
            {
                ProductName = "product",
                ProductDisceiption = "info",
                CurrentPrice = 15.96M
            };
            var actual = productRepository.Retrieve(1);

            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDisceiption, actual.ProductDisceiption);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }
    }
}