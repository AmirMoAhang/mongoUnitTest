using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sample.Data.Entities;
using Sample.Data.Repository;
using Sample.Data.Services;

namespace Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserApi : ControllerBase
    {
        private readonly IUserService _service;

        public UserApi(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                await _service.InsertUser();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest($"{e.Message}:{e.InnerException.Message}");
            }
        }
    }
}
