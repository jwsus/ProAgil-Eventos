using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProaAgil.API.Data;
using ProaAgil.API.Model;

namespace ProaAgil.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly DataContext _context;

        public WeatherForecastController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var result = _context.Events.ToList();
                return Ok(result);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Erro no banco de dados. Entre em contato com a SUlProg");
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Event> Get(int id)
        {
            return _context.Events.FirstOrDefault(x => x.EventId == id);
        }
    }
}
