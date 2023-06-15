using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class commentController : Controller
    {
        public IActionResult Index()
        {
            BreadandCircusContext context = HttpContext.RequestServices.GetService(typeof(WebApplication1.Models.BreadandCircusContext)) as BreadandCircusContext;
            return View(context.GetAllComments());
        }
    }
}
