using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.MultipleImpInterfaces;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultiServiceController : ControllerBase
    {
        private readonly IService _aService;

        public MultiServiceController(ServiceResolver serviceAccessor)
        {
            _aService = serviceAccessor("A");
        }

        [HttpGet]
        public string UseServiceA()
        {
            //_aService.DoTheThing();

            return _aService.Hello();
        }
    }
}
