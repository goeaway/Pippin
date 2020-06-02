using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pippin.Core;

namespace Pippin.Tests.Site.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {
        private readonly IPinSetter _pinSetter;

        public TestController(IPinSetter pinSetter)
        {
            _pinSetter = pinSetter;
        }

        [HttpGet("")]
        public async Task<IActionResult> Test()
        {
            await _pinSetter.SetPinAsync(1, true);
            return Ok();
        }
    }
}
