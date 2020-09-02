using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCMS.Controllers;
using System.Web.Mvc;

namespace MyCMS.Tests.Controllers
{
    /// <summary>
    /// Summary description for CustomersControllerTest
    /// </summary>
    [TestClass]
    public class CustomersControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            CustomersController controller = new CustomersController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Customers", result.ViewBag.Message);
        }



    }
}
