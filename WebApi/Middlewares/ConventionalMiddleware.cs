namespace WebApi.Middlewares
{
    public class ConventionalMiddleware
    {
        private readonly RequestDelegate _next;

        public ConventionalMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var keyValue = context.Request.Query["key"];

            await _next(context);
        }
    }
}
