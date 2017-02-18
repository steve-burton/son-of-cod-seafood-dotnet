using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCodSeafood.Controllers;
using SonOfCodSeafood.Models;
using Xunit;

namespace SonOfCodSeafood.Tests.ControllerTests
{
    public class RolesControllerTest
    {
        [Fact]
        public void Get_ViewResult_RolesIndex_Test()
        {
            //Arrange
            RolesController controller = new RolesController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ViewResult_RolesAssign_Test()
        {
            //Arrange
            RolesController controller = new RolesController();

            //Act
            var result = controller.Assign();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ViewResult_RolesCreate_Test()
        {
            //Arrange
            RolesController controller = new RolesController();

            //Act
            var result = controller.Create();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
