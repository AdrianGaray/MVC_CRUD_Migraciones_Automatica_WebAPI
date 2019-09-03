using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CRUD_Migraciones_Automatica_WebAPI.Controllers
{
    public class AJAXConceptController : Controller
    {
        // GET: AJAXConcept
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult JsonFactorial(int n)
        {
            // validar si el request es un formato Json
            if (!Request.IsAjaxRequest())
            {
                return null;
            }

            // se crea el objeto Json y tiene una propiedad q se llama Factorial
            var result = new JsonResult
            {
                Data = new
                {
                    Factorial = Factorial(n)
                }
            };

            return result;
        }

        private double Factorial(int n)
        {
            double factorial = 1;

            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}