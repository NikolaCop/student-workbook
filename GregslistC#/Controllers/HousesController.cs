using System.Collections.Generic;
using GregslistC_.db;
using GregslistC_.Models;
using Microsoft.AspNetCore.Mvc;


namespace GregslistC_.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HousesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<House>> Get()
        {
            try
            {
                return Ok(FakeDB.Houses);
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpGet("{houseId}")]
        public ActionResult<House> GetHouse(string houseId)
        {
            try
            {
                House houseFound = FakeDB.Houses.Find(c => c.Id == houseId);
                if (houseFound == null)
                {
                    throw new System.Exception("That House does not exist");
                }
                return Ok(houseFound);

            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }


        [HttpPost]
        public ActionResult<House> Create([FromBody] House newHouse)
        {
            try
            {
                FakeDB.Houses.Add(newHouse);
                return Ok(newHouse);
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<string> DeleteHouse(string id)
        {
            try
            {
                House houseToRemove = FakeDB.Houses.Find(c => c.Id == id);
                if (FakeDB.Houses.Remove(houseToRemove))
                {
                    return Ok("House Delorted");
                }
                else
                {
                    throw new System.Exception("This House Does Not Exist");
                }
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}