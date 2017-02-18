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
    public class AccountControllerTest
    {
        [Fact]
        public void Get_ViewResult_AccountIndex_Test()
        {
            //Arrange
            AccountController controller = new AccountController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ViewResult_AccountLogin_Test()
        {
            //Arrange
            AccountController controller = new AccountController();

            //Act
            var result = controller.Login();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ViewResult_AccountSignup_Test()
        {
            //Arrange
            AccountController controller = new AccountController();

            //Act
            var result = controller.Signup();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
