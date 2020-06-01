using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CBA.Training.Talmate.Services.UserService;
using CBA.Training.Talmate.Models;
using AutoMapper;
using CBA.Training.Talmate.EntityModels;

namespace CBA.Training.Talmate.Api.Controllers
{
    [Authorize]
    [Route("api/user")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UsersController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpPost("/token")]
        public async Task<IActionResult> Authenticate([FromBody] UserDTO model)
        {

            var result = await _userService.Authenticate(model.Username, model.Password);

            if (result == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(result);
        }

        [HttpGet]
        [Authorize(Roles = "PM")]
        public async Task<IActionResult> GetAll()
        {
            var users = await _userService.GetAll();
            return Ok(users);
        }

        [HttpGet]
        [Authorize(Roles = "PM")]
        [Route("id")]
        public async Task<IActionResult> Get(int Id)
        {
            var users = await _userService.GetById(Id);
            return Ok(users);
        }

    }
}