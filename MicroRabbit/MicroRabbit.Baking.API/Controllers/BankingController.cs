using MicroRabbit.Banking.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Baking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountAppService;

        public BankingController(IAccountService accountAppService)
        {
            _accountAppService = accountAppService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_accountAppService.GetAccounts());
        }

        [HttpPost]
        public IActionResult Post([FromBody] AccountTransfer accountTransfer)
        {
            _accountAppService.Transfer(accountTransfer);
            return Ok(accountTransfer);
        }
    }
}
