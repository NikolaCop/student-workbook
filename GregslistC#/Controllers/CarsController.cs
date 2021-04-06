using System.Collections.Generic;
using GregslistC_.db;
using GregslistC_.Models;
using Microsoft.AspNetCore.Mvc;


namespace GregslistC_.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Car>> Get()
        {
            try
            {
                return Ok(FakeDB.Cars);
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpGet("{carId}")]
        public ActionResult<Car> GetCar(string carId)
        {
            try
            {
                Car carFound = FakeDB.Cars.Find(c => c.Id == carId);
                if (carFound == null)
                {
                    throw new System.Exception("That Car does not exist");
                }
                return Ok(carFound);

            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpPut]
        public ActionResult<Car> EditCar(string id, Car UpdatedCar)
        {
            try
            {
                FakeDB.Cars.Add(UpdatedCar);
                return Ok(UpdatedCar);
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }


        [HttpPost]
        public ActionResult<Car> Create([FromBody] Car newCar)
        {
            try
            {
                FakeDB.Cars.Add(newCar);
                return Ok(newCar);
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<string> DeleteCar(string id)
        {
            try
            {
                Car carToRemove = FakeDB.Cars.Find(c => c.Id == id);
                if (FakeDB.Cars.Remove(carToRemove))
                {
                    return Ok("Car Delorted");
                }
                else
                {
                    throw new System.Exception("This Car Does Not Exist");
                }
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}