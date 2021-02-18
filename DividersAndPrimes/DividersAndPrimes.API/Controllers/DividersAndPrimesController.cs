using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DividersAndPrimes.Service;
using DividersAndPrimes.API.Models;

namespace DividersAndPrimes.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DividersAndPrimesController : Controller
    {
        [HttpGet]
        public IActionResult Get([FromQuery] int number)
        {
            string dividers = String.Join(" ", MainClass.GetDividers(number));
            string dividersAndPrimes = String.Join(" ", MainClass.GetPrimeDividers(number));
            return Ok(new DividersAndPrimesDTO {
                EntryValue = number,
                Dividers = dividers,
                DividersAndPrimes = dividersAndPrimes,
            });
        }
    }
}
