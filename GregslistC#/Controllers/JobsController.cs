using System.Collections.Generic;
using GregslistC_.db;
using GregslistC_.Models;
using Microsoft.AspNetCore.Mvc;


namespace GregslistC_.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Job>> Get()
        {
            try
            {
                return Ok(FakeDB.Jobs);
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpGet("{jobId}")]
        public ActionResult<Job> GetJob(string jobId)
        {
            try
            {
                Job jobFound = FakeDB.Jobs.Find(c => c.Id == jobId);
                if (jobFound == null)
                {
                    throw new System.Exception("That Job does not exist");
                }
                return Ok(jobFound);

            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }


        [HttpPost]
        public ActionResult<Job> Create([FromBody] Job newJob)
        {
            try
            {
                FakeDB.Jobs.Add(newJob);
                return Ok(newJob);
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<string> DeleteJob(string id)
        {
            try
            {
                Job jobToRemove = FakeDB.Jobs.Find(c => c.Id == id);
                if (FakeDB.Jobs.Remove(jobToRemove))
                {
                    return Ok("Job Delorted");
                }
                else
                {
                    throw new System.Exception("This Job Does Not Exist");
                }
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}