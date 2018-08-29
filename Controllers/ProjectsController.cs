    using Microsoft.AspNetCore.Mvc;

    namespace FirstWebProject.Controllers 
    {
        public class ProjectsController : Controller 
        {
            [HttpGet]    
            [Route("projects")]     
            public IActionResult Index()
            {
                return View();
            }
        }
    }