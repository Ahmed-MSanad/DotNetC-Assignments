using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Abstraction;

namespace Presentation.Controllers
{
    public class PaymentController(IServiceManager serviceManager) : ApiController
    {
        [HttpPost("{basketId}")]
        public async Task<IActionResult> CreateOrUpdatePaymentIntent(string basketId)
        {
            var basket = await serviceManager.paymentService.CreateOrUpdatePaymentIntentAsync(basketId);
            return Ok(basket);
        }

        [HttpPost("webhook")]
        public async Task<IActionResult> Webhook() // This is the endpoint that Stripe will call to notify us about payment status changes
        {
            var request = await new StreamReader(HttpContext.Request.Body).ReadToEndAsync();

            await serviceManager.paymentService.UpdateOrderPaymentStatusAsync(request, Request.Headers["Stripe-Signature"]);

            return Ok();
        }
    }
}
