using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace MyWeb.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            var httpConnectionFeature = HttpContext.Features.Get<IHttpConnectionFeature>();
            var localIpAddress = httpConnectionFeature?.LocalIpAddress;
            return Ok("Hello " + localIpAddress);
        }
    }
}