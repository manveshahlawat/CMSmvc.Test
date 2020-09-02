using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using MyCMS.Controllers;

namespace MyCMS.Tests.Controllers
{
    /// <summary>
    /// Summary description for VendorControllerTest
    /// </summary>
    [TestClass]
    public class VendorControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            VendorsController controller = new VendorsController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("VENDORS", result.ViewBag.Message);
        }
    }
}
