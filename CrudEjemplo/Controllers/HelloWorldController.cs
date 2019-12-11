using System.Web;
using System.Web.Mvc; 
 
namespace CrudEjemplo.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hola " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}