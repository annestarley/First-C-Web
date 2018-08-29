    using Microsoft.AspNetCore.Mvc;

    namespace FirstWebProject.Controllers 
    {
        public class IndexController : Controller 
        {
            [HttpGet]      
            [Route("")]     
            public IActionResult Index()
            {
                return View();
            }
        }
    }
