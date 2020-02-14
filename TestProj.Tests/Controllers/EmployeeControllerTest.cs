using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;

namespace TestProj.Tests.Controllers
{
    class EmployeeControllerTest
    {
        public void Employees()
        {
            // Arrange
            EmployeeControllerTest controller = new EmployeeControllerTest();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        private ViewResult Index()
        {
            throw new NotImplementedException();
        }
    }
}
