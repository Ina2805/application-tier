using ApplicationTier.Services.Hosts;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationTier.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HostsController : ControllerBase
    {
        private readonly IHostsService _hostsService;

        public HostsController(IHostsService hostsService)
        {
            _hostsService = hostsService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateHost()
        {
            return Ok(await _hostsService.CreateHostAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetHostById(int id)
        {
            return Ok(await _hostsService.GetHostByIdAsync(id));
        }
    }
}
