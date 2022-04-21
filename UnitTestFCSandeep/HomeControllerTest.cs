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
    public class HomeControllerTest
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationUser _auc;
       
        

        [Fact]
        public void Index()
        {
            HomeController controller = new HomeController(_auc, _logger);
            ViewResult result = controller.Index() as ViewResult;
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(result);
        }

        [Fact]
        public void Privacy()
        {
            HomeController controller = new HomeController(_auc, _logger);
            ViewResult result = controller.Privacy() as ViewResult;
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(result);
        }


        
    }
}
