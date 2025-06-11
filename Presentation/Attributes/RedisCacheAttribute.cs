using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using Services.Abstraction;

namespace Presentation.Attributes
{
    public class RedisCacheAttribute(int timeToLiveInSeconds = 60) : ActionFilterAttribute
    {
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var cacheService = context.HttpContext.RequestServices.GetRequiredService<IServiceManager>().cacheService;

            var key = GenerateCacheKey(context.HttpContext.Request);

            var value = await cacheService.GetAsync(key);

            if(value is not null) // then the value is in the cache then just return it without calling the database.
            {
                context.Result = new ContentResult
                {
                    Content = value,
                    ContentType = "application/json",
                    StatusCode = StatusCodes.Status200OK
                };

                return;
            }

            var actionExecutedContext = await next.Invoke(); // otherwize, continue and call the database for the data as it's not cached in the redis

            if(actionExecutedContext.Result is OkObjectResult result)
            {
                await cacheService.SetAsync(key, result.Value, TimeSpan.FromSeconds(timeToLiveInSeconds));
            }
        }
        private static string GenerateCacheKey(HttpRequest httpRequest)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(httpRequest.Path).Append("?");

            foreach (var item in httpRequest.Query.OrderBy(i => i.Key))
                builder.Append($"{item.Key}={item.Value}&");

            return builder.ToString().TrimEnd('&');
        }
    }
}
