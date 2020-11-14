using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HTML_to_Doc.Models;
using ConvertApiDotNet;

namespace HTML_to_Doc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
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


        public async Task  CreateWord()
        {
            var docFile = "day01.html";
            var convertApi = new ConvertApi("GNfkcRzVmzd4DXsk");
            var convert = await convertApi.ConvertAsync("html", "docx", new ConvertApiFileParam("File", $@"C:\Users\jdubula\Desktop\Desktop\{docFile}"));
            await convert.SaveFilesAsync(@"C:\converted-files\");

        }


        public void test()
        {
            var a = 7;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
