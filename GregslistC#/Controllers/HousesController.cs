using System.Collections.Generic;
using GregslistC_.db;
using GregslistC_.Models;
using Microsoft.AspNetCore.Mvc;
using GregslistC_.Services;

namespace GregslistC_.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HousesController : ControllerBase
    {
        private readonly HousesService _service;

        public HousesController(HousesService service)
        {
            _service = service;
        }


        [HttpGet] //Get
        public ActionResult<IEnumerable<House>> Get()
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

        [HttpGet("{houseId}")] //Get By ID
        public ActionResult<House> GetById(string houseId)
        {
            try
            {
                return Ok(_service.GetById(houseId));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpPut("{houseId}")] //EDIT
        public ActionResult<House> editHouse(string houseId, House editHouse)
        {
            try
            {
                editHouse.houseId = houseId;
                return Ok(_service.Edit(editHouse));

            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }


        [HttpPost] //Create
        public ActionResult<House> Create([FromBody] House newHouse)
        {
            try
            {
                return Ok(_service.Create(newHouse));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpDelete("{id}")] //Delort
        public ActionResult<string> DeleteHouse(string id)
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