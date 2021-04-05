using MicroRabbit.Transfer.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace MicroRabbit.Transfer.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransferController : ControllerBase
    {
        private readonly ILogger<TransferController> _logger;
        private readonly ITransferService _transferService;

        public TransferController(ILogger<TransferController> logger, ITransferService transferService)
        {
            _logger = logger;
            _transferService = transferService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation(">>> Getting the list of TransferLogs");
            Console.WriteLine(">>> Getting the list of TransferLogs");
            return Ok(_transferService.GetTransferLogs());
        }
    }
}
