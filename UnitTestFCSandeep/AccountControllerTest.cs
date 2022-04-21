using FinalCalculatorSandeep.Controllers;
using FinalCalculatorSandeep.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using Xunit;

namespace UnitTestFCSandeep
{
    [TestClass]
    public class AccountControllerTest
    {

        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationUser _auc;

      

        [Fact]
        public void Register()
        {
            AccountController controller = new AccountController(_auc);
            ViewResult result = controller.Register() as ViewResult;
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(result);
        }

        [Fact]
        public void Login()
        {
            AccountController controller = new AccountController(_auc);
            ViewResult result = controller.Login() as ViewResult;
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(result);
        }

        
    }
}
