using FinalCalculatorSandeep.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FinalCalculatorSandeep.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationUser _auc;

        public HomeController(ApplicationUser auc, ILogger<HomeController> logger)
        {
            _auc = auc;
            _logger = logger;
        }

        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public ActionResult GetcalculateData([FromBody] Calculation objCalData)
        {

            String ReturnData = "";
            var result = _auc.CalculationHistory.ToList();
            if (result.Count > 0)
            {
                foreach (var data in result)
                {
                     ReturnData += "<tr><td>" + data.Data + "</td><td>=</td><td>" + data.Result + "</td><td>" + Convert.ToDateTime(data.RDate).ToString("dd-MMM HH:mm") + "</td></tr>";
                }
            }




            ReturnData = "<table class='historydata'><tr class='headertr'><td>Data</td><td>=</td><td>Result</td><td>Calculation Date</td></tr>" + ReturnData + "</table>";
            CalculationResponse objCalculationResponse = new CalculationResponse();
            objCalculationResponse.ResultData = ReturnData;
            return Json(objCalculationResponse);
        }
      
        public ActionResult calculateData([FromBody] Calculation objCalData)
        {
            String Data = objCalData.CData.Trim();

            String ReturnData = "0";

            if (Data != "")
            {
                try
                {
                    DataTable dt = new DataTable();
                    Decimal answer = (Decimal)Convert.ToDecimal(dt.Compute(Data, ""));
                    String RData = answer.ToString("0.00");
                    ReturnData = (RData);

                    CalcHistory objCalcHistory = new CalcHistory();
                    objCalcHistory.Data = Data;
                    objCalcHistory.Result = RData;
                    objCalcHistory.RDate = DateTime.Now;


                    _auc.Add(objCalcHistory);
                    _auc.SaveChanges();
                }
                catch (Exception)
                {
                    ReturnData = "0";
                }
            }
            else
            {
                ReturnData = "0";
            }

            CalculationResponse objCalculationResponse = new CalculationResponse();
            objCalculationResponse.ResultData = ReturnData;
            return Json(objCalculationResponse);
        }


        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
