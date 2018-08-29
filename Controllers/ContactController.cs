    using Microsoft.AspNetCore.Mvc;

    namespace FirstWebProject.Controllers 
    {
        public class ContactController : Controller 
        {
            [HttpGet]      
            [Route("contact")]    
            public IActionResult Index()
            {
                return View();
            }
        }
    }