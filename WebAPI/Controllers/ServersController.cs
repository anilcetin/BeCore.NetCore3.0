using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServersController : ControllerBase
    {
        private IServerService _serverService;

        public ServersController(IServerService serverService)
        {
            _serverService = serverService;
        }

        [HttpGet("getbyid")]
        [Authorize(Roles = "admin")]
        public IActionResult GetById(string serverId)
        {
            var result = _serverService.GetById(serverId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        [Authorize(Roles = "admin")]
        public IActionResult Add(Server server)
        {
            var result = _serverService.Add(server);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPut("update")]
        [Authorize(Roles = "admin")]
        public IActionResult Update(Server server)
        {
            var result = _serverService.Update(server);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpDelete("delete")]
        [Authorize(Roles = "admin")]
        public IActionResult Delete(Server server)
        {
            var result = _serverService.Delete(server);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getall")]
        [Authorize(Roles = "admin")]
        public IActionResult GetList()
        {

            var result = _serverService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
    }
}
