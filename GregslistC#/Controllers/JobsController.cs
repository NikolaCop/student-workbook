using System.Collections.Generic;
using GregslistC_.db;
using GregslistC_.Models;
using Microsoft.AspNetCore.Mvc;
using GregslistC_.Services;

namespace GregslistC_.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobsController : ControllerBase
    {
        private readonly JobsService _service;

        public JobsController(JobsService service)
        {
            _service = service;
        }


        [HttpGet] //Get
        public ActionResult<IEnumerable<Job>> Get()
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

        [HttpGet("{jobId}")] //Get By ID
        public ActionResult<Job> GetById(string jobId)
        {
            try
            {
                return Ok(_service.GetById(jobId));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpPut("{jobId}")] //EDIT
        public ActionResult<Job> editJob(string jobId, Job editJob)
        {
            try
            {
                editJob.jobId = jobId;
                return Ok(_service.Edit(editJob));

            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }


        [HttpPost] //Create
        public ActionResult<Job> Create([FromBody] Job newJob)
        {
            try
            {
                return Ok(_service.Create(newJob));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpDelete("{id}")] //Delort
        public ActionResult<string> DeleteJob(string id)
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