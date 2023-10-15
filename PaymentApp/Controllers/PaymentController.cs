using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PaymentApp.Services;

namespace PaymentApp.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PaymentController : ControllerBase 
    {
        private readonly IPaymentService _service;

        public PaymentController(IPaymentService service)
        {
            _service = service;
        }
        
        [HttpGet]
        public async Task<ActionResult> AllPayments()
        {
            return Ok();
        }
    }
}