using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SingerController : ControllerBase
    {
        private readonly ISingerService _singerService;

        public SingerController(ISingerService singerService)
        {
            _singerService = singerService;
        }

        [HttpGet]
        public IActionResult GetAllSingers()
        {
            SingerViewModel singerViewModel = _singerService.GetSingers();
            return Ok(singerViewModel);
        }
    }
}
