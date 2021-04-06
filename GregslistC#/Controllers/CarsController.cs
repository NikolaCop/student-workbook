using System.Collections.Generic;
using GregslistC_.db;
using GregslistC_.Models;
using Microsoft.AspNetCore.Mvc;


namespace GregslistC_.Controllers
{
    [ApiController]
    [Route("[controller")]
    public class CarsController : ControllerBase
    {
        [HttpGet()]
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
        public ActionResult<string> GetById(string carId)
        {
            try
            {
                CarsController carFound = FakeDB.Cars.Find(carFound => carFound.Id == CarId);
                if (carFound == null)
                {
                    throw new System.Exception("Car does not exist");
                }
                return Ok(carFound);
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
                Car carToRemove = FakeDB.Cars.Find(c => c.id == id);
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