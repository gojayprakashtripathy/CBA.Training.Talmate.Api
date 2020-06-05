using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CBA.Training.Talmate.Api.Filter;
using CBA.Training.Talmate.EntityModels;
using CBA.Training.Talmate.Services.ResourceDetailsservice;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CBA.Training.Talmate.Api.Controllers
{
    [Route("api/resource")]
    [ApiController]
    [ServiceFilter(typeof(TalmateActionFilterAttribute))]
    public class ResourceController : Controller
    {


        private readonly IResourceDetailsService _resourceService;
        private readonly IMapper _mapper;

        public ResourceController(IResourceDetailsService resourceService, IMapper mapper)
        {
            _resourceService = resourceService;
            _mapper = mapper;
        }
        [HttpGet]
        [Authorize(Roles = "BM")]
        public async Task<IActionResult> Get()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var response = await _resourceService.Get();
            return Ok(response);
        }
        [HttpPost]
        [Authorize(Roles = "PM")]
        public async Task<IActionResult> Post(ResourceDetail resource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var response = await _resourceService.Post(resource);
            return Ok(response);
        }
    }
}