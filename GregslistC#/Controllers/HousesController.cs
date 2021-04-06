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
    public class HousesController : ControllerBase
    {
        [HttpGet()]
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
        public ActionResult<string> GetById(string houseId)
        {
            try
            {
                HousesController houseFound = FakeDB.Houses.Find(houseFound => houseFound.Id == HouseId);
                if (houseFound == null)
                {
                    throw new System.Exception("House does not exist");
                }
                return Ok(houseFound);
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
                House houseToRemove = FakeDB.Houses.Find(c => c.id == id);
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