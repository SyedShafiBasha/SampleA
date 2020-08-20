using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SevenLake.BusineesLogic;
using SevenLake.DomainModel;

namespace SevenLake.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [FormatFilter]
    public class RouteController : ControllerBase
    {

        private readonly ILogger<RouteController> _logger;

        public RouteController(ILogger<RouteController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<FlattenedJson> Get(string format)
        {
            return RouteJsonLogic.GetFlattenedRouteJson();
        }

        //[HttpGet]
        //public IEnumerable<FlattenedJson> Get()
        //{
        //    return RouteJsonLogic.GetFlattenedRouteJson();
        //}
    }
}
