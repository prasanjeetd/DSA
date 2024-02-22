namespace WebApi.Middlewares
{
    public class ConventionalMiddleware
    {
        private readonly RequestDelegate _next;

        public ConventionalMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async void Invoke(HttpContext context, ILogger logger)
        {
            var keyValue = context.Request.Query["key"];

            await _next(context);
        }
    }
}
