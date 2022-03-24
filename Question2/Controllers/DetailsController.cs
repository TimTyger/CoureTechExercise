using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Question2.Common;
using Question2.Interfaces;
using Question2.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DetailsController : ControllerBase
    {
        private readonly ILogger<DetailsController> _logger;
        private readonly IDetailsService _detailsService;

        public DetailsController(ILogger<DetailsController> logger, IDetailsService details)
        {
            _logger = logger;
            _detailsService = details;
        }

        [HttpGet]
        [Route("get-details-by-phonenumber")]
        [ProducesResponseType(typeof(DetailsResponse), 200)]
        [ProducesResponseType(typeof(ErrorResp), 400)]
        [ProducesResponseType(typeof(ErrorResp), 500)]
        public async Task<IActionResult> Get(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                var response = new ErrorResp
                {
                    Message = "Input valid phoneNumber",
                    ResponseCode = "400"
                };return StatusCode(400, response);
            }
            var result =await _detailsService.GetDetailsByPhoneNumber(phoneNumber);
            var output = new DetailsResponse
            {
                number = phoneNumber,
                country = result
            };
            return Ok(output);
        }
    }
}
