using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatasController : ControllerBase
    {
        private IDataService _dataService;

        public DatasController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet("getbyid")]
        [Authorize(Roles = "admin")]
        public IActionResult GetById(int dataId)
        {
            var result = _dataService.GetById(dataId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        [Authorize(Roles = "admin,serveradmin")]
        public IActionResult Add(Data data)
        {
            var result = _dataService.Add(data);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPut("update")]
        [Authorize(Roles = "admin,serveradmin")]
        public IActionResult Update(Data data)
        {
            var result = _dataService.Update(data);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpDelete("delete")]
        [Authorize(Roles = "admin,serveradmin")]
        public IActionResult Delete(Data data)
        {
            var result = _dataService.Delete(data);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbyhexid")]
        public IActionResult GetByHexId(string hexId)
        {
            var result = _dataService.GetByHexId(hexId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getall")]
        [Authorize(Roles = "admin,serveradmin")]
        public IActionResult GetAll()
        {
            var result = _dataService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
    }
}
