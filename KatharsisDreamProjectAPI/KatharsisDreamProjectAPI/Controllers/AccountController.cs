using KatharsisDream.Service.DTO.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KatharsisDreamProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost("Register")]
        public async Task<ActionResult> RegisterAccount([FromBody] RegisterAccountDto registerAccountDto)
        {
            return Ok();
        }
    }
}
