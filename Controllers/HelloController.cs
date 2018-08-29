    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    namespace FirstWebProject.Controllers     //be sure to use your own project's namespace!
    {
        public class HelloController : Controller   //remember inheritance??
        {
            //for each route this controller is to handle:
            [HttpGet]       //type of request
            [Route("hello/{name}")]     //associated route string (exclude the leading /)
            
            public string Index(string name="World")
            {
                return $"Hello {name} from HelloController!";
            }

            // public IActionResult Index()
            // {
            //     //return View();
            //     //OR
            //     return View("Index");
            //     //Both of these returns will render the same view (You only need one!)
            // }
        }
    }
