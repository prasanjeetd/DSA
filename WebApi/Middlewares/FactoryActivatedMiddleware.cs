
namespace WebApi.Middlewares
{
    public class FactoryActivatedMiddleware : IMiddleware
    {
        private readonly ILogger<FactoryActivatedMiddleware> _logger;

        public FactoryActivatedMiddleware(ILogger<FactoryActivatedMiddleware> logger)
        {
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await next(context);
        }
    }
}
