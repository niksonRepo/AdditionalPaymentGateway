using System;
using Microsoft.AspNetCore.Mvc;
using AdditionalPaymentGateway.Api.Filter;
using AdditionalPaymentGateway.Api.Types;

namespace AdditionalPaymentGateway.Api.Controllers
{
    [ApiController]
    [Route ( "[controller]" )]
    public class GatewayController : Controller
    {
        [HttpGet]
        [ApiKeyAuth]
        public IActionResult Get ( BillingDetails billingDetails )
        {
            return BadRequest ( "Payment failed" );
        }
    }
}