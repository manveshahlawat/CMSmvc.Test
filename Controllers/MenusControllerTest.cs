using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCMS.Controllers;
using System.Web.Mvc;

namespace MyCMS.Tests.Controllers
{
    /// <summary>
    /// Summary description for MenusControllerTest
    /// </summary>
    [TestClass]
    public class MenusControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            MenusController controller = new MenusController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Menu", result.ViewBag.Message);
        }
        [TestMethod]
        public void ShowMenu()
        {
            // Arrange
            MenusController controller = new MenusController();

            // Act
            ViewResult result = controller.ShowMenu() as ViewResult;

            // Assert
            Assert.AreEqual("Menu", result.ViewBag.Message);
        }
    }
}
