using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GregslistC_.Controllers
{
    [ApiController]
    [Route("[controller")]
    public class CarsController : ControllerBase
    {
        [HTTpDelete("{id}")]
        public ActionResult<string> DeleteCar(string id)
        {

        }
    }
}