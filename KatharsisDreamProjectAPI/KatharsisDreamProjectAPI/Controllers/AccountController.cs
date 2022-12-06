using KatharsisDream.Service.DTO.Account;
using KatharsisDream.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KatharsisDreamProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService accountService;

        public AccountController(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        [HttpPost("Register")]
        public async Task<ActionResult> RegisterAccount([FromBody] RegisterAccountDto registerAccountDto)
        {
            int accountId = await accountService.RegisterAccount(registerAccountDto);
            return Ok(accountId);
        }
    }
}
