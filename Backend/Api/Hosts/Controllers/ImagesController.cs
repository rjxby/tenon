using System;
using System.Net.Mime;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Tenon.Backend.Api.Hosts.Models;
using Tenon.Backend.Api.Services.Contracts;
using Tenon.Backend.Api.Services.Entities;

namespace Tenon.Backend.Api.Hosts.Controllers
{
    [ApiController]
    [Route("img")]
    public class ImagesController : ControllerBase
    {
        private readonly ILogger<ImagesController> _logger;
        private readonly IMapper _mapper;
        private readonly IImagesService _imagesService;

        public ImagesController(ILogger<ImagesController> logger, IMapper mapper, IImagesService imagesService)
        {
            _logger = logger;
            _mapper = mapper;
            _imagesService = imagesService;
        }

        [HttpGet]
        [Route("{id}")]
        [ActionName(nameof(GetAsync))]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ImageModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAsync(Guid id)
        {
            var img = await _imagesService.GetAsync(id);
            return Ok(_mapper.Map<ImageModel>(img));
        }

        [HttpPost]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ImageModel), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreatAsync(CreateImageModel model)
        {
            var imgForCreate = _mapper.Map<Image>(model);
            var img = await _imagesService.CreateAsync(imgForCreate);
            return CreatedAtAction(nameof(GetAsync), new { id = img.Id, }, _mapper.Map<ImageModel>(img));
        }
    }
}
