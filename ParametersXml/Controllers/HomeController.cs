namespace ParametersXml.Controllers
{
   using System;
   using System.Web.Mvc;

   public class HomeController : Controller
   {
      [HttpGet]
      public ActionResult Index()
      {
         throw new Exception();
      }
   }
}