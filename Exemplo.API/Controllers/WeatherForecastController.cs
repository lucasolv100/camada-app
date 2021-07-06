using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exemplo.Application.Interfaces;
using Exemplo.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Exemplo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _service;

        public UserController(ILogger<UserController> logger, IUserService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUserAsync(UserVM viewModel)
        {
            await _service.AddAsync(viewModel);
            return NoContent();
        }
    }
}
