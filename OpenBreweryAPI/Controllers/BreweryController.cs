using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OpenBreweryAPI.Models;
using OpenBreweryAPI.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenBreweryAPI.Controllers
{
    [ApiController]
    public class BreweryController : ControllerBase
    {
        private readonly ILogger<BreweryController> _logger;
        private readonly IBreweryRepository _breweryRepository;
        private readonly IMapper _mapper;

        public BreweryController(ILogger<BreweryController> logger,
            IBreweryRepository breweryRepository,
            IMapper mapper)
        {
            _logger = logger;
            _breweryRepository = breweryRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("breweries")]
        public async Task<ActionResult<IEnumerable<BreweryDto>>> GetBreweries([FromQuery] string by_City)
        {
            var breweries = await _breweryRepository.GetBreweriesAsync(by_City);
            return Ok(_mapper.Map<IEnumerable<BreweryDto>>(breweries));

        }

        [HttpGet]
        [Route("breweries/{breweryId}")]
        public async Task<ActionResult<BreweryDto>> GetBrewery(int breweryId)
        {
            var brewery = await _breweryRepository.GetBreweryAsync(breweryId);
            if (brewery == null)
            {
                return NotFound();
            }
            _logger.LogInformation($"Request Hit for breweryId:{breweryId}");
            return Ok(_mapper.Map<BreweryDto>(brewery));
        }
    }
}
