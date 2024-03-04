using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApi.MultipleImpInterfaces;
using WebApi.OptionPattern;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultiServiceController : ControllerBase
    {
        private readonly IService _aService;
        private readonly PositionOptions _options;


        public MultiServiceController(
            ServiceResolver serviceAccessor, 
            IOptions<PositionOptions> options)
        {
            _aService = serviceAccessor("A");
            _options = options.Value;
        }

        [HttpGet]
        public string UseServiceA()
        {

            return $"{_aService.Hello()}  {_options.Name}";
        }
    }
}
