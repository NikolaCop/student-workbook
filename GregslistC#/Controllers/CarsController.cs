using System.Collections.Generic;
using GregslistC_.db;
using GregslistC_.Models;
using Microsoft.AspNetCore.Mvc;
using GregslistC_.Services;

namespace GregslistC_.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly CarsService _service;

        public CarsController(CarsService service)
        {
            _service = service;
        }


        [HttpGet] //Get
        public ActionResult<IEnumerable<Car>> Get()
        {
            try
            {
                return Ok(_service.Get());
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpGet("{carId}")] //Get By ID
        public ActionResult<Car> GetCar(string carId)
        {
            try
            {
                return Ok(_service.Get(carId))
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpPut("{carId}")] //EDIT
        public ActionResult<Car> editCar(string carId, Car updatedCar)
        {
            try
            {
                editCar.carId = id;
                return Ok(_service.Edit(editCar));

            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }


        [HttpPost] //Create
        public ActionResult<Car> Create([FromBody] Car newCar)
        {
            try
            {
                return Ok(_service.Create(newCar));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpDelete("{id}")] //Delort
        public ActionResult<string> DeleteCar(string id)
        {
            try
            {
                return Ok(_service.Delete(id));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}