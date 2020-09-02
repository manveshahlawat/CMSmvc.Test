using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using MyCMS.Controllers;

namespace MyCMS.Tests.Controllers
{
    /// <summary>
    /// Summary description for OrdersControllerTest
    /// </summary>
    [TestClass]
    public class OrdersControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            OrdersController controller = new OrdersController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("ORDERS HISTORY", result.ViewBag.Message);
        }
    }
}
