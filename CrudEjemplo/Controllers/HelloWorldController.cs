using System.Web;
using System.Web.Mvc; 
 
namespace CrudEjemplo.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public string Index()
        {
            return "Este es el método <b>Por defecto</b> en acción...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
    }
}