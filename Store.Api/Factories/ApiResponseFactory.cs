using System.Net;
using Microsoft.AspNetCore.Mvc;
using Shared.ErrorModels;

namespace Store.Api.Factories
{
    public class ApiResponseFactory
    {
        public static ActionResult CustomValidationErrorResponse(ActionContext actionContext)
        {
            var errors = actionContext.ModelState.Where(error => error.Value.Errors.Any())
                         .Select(error => new ValidationError
                         {
                             Key = error.Key,
                             Errors = error.Value.Errors.Select(error => error.ErrorMessage)
                         });

            var validationErrorResponse = new ValidationErrorResponse
            {
                StatusCode = (int)HttpStatusCode.BadRequest,
                Errors = errors,
                ErrorMessage = "Validation Failed"
            };

            return new BadRequestObjectResult(validationErrorResponse);
        }
    }
}
