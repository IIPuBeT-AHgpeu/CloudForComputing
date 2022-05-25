using Microsoft.AspNetCore.Mvc;

namespace AuthorizationService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorizationController : ControllerBase
    {
        [HttpGet(@"Login/{category}&{login}&{password}")]
        public object GetAuthorization(char category, string login, string password)
        {
            Service service = new Service(new TTG_ver3Context());

            return service.LogIn(category, login, password);
        }
    }
}