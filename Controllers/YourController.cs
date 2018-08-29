    using Microsoft.AspNetCore.Mvc;

    namespace FirstWebProject.Controllers     //be sure to use your own project's namespace!
    {
        public class YourController : Controller   //remember inheritance??
        {
            // // Other code
            // [HttpGet]
            // [Route("template/{name}")]
            // // public JsonResult Method(string name)
            // // {
            // //     // Method body
            // // }
            // // [HttpGet]
            // // [Route("template/{id}/{action}")]
            // // public JsonResult Method(int id, string action)
            // // {
            // //     // Method body
            // // }

            // public string Index()
            // {
            //     return "Hello World from HelloController!";
            // }

            //     ------------ REDIRECTION -------
            //     Other code
            //     //  Other code
            //     public IActionResult Method()
            //     {
            //         // Will redirect to the "OtherMethod" method
            //         return RedirectToAction("OtherMethod");
            //     }
            //     // Other code
            //     public IActionResult OtherMethod()
            //     {
            //         return View();
            //     }

            //     Other code
            //     public IActionResult Method()
            //     {
            //         // The anonymous object consists of keys and values
            //         // The keys should match the parameter names of the method being redirected to
            //         return RedirectToAction("OtherMethod", new { Food = "sandwiches", Quantity = 5 });
            //     }
                
            //     [HttpGet]
            //     [Route("other/{Food}/{Quantity}")]
            //     public IActionResult OtherMethod(string Food, int Quantity)
            //     {
            //         Console.WriteLine($"I ate {Quantity} {Food}.");
            //         // Writes "I ate 5 sandwiches."
            //     }


            //Other code
 
            [HttpGet]
            [Route("practice")]
            public IActionResult Index()
            {
                // Here we assign the value "Hello World!" to the property .Example
                // Property names are arbitrary and can be whatever you like
                ViewBag.Example = "Hello World!";
                return View();
            }

        }
    }