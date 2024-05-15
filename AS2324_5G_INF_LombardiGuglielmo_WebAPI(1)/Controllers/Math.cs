using Microsoft.AspNetCore.Mvc;

namespace AS2324_5G_INF_LombardiGuglielmo_WebAPI_1_.Controllers
{
    public class Math : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("celsius_to_fahrenheit")]
        public JsonResult celsius_to_fahrenheit(double celsius)
        {

                double fahrenheit = (1.8 * celsius) + 32;
                return Json(new { output = $"La temperatura celsius inserita ({celsius}), convertita in  fahrenheit, risulta essere : ({fahrenheit})", status = "OK" });
            


        }
    }
}
