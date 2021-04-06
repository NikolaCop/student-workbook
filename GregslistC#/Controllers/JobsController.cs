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
    public class JobsController : ControllerBase
    {
        [HttpGet()]
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
        public ActionResult<string> GetById(string jobId)
        {
            try
            {
                JobsController jobFound = FakeDB.Jobs.Find(jobFound => jobFound.Id == JobId);
                if (jobFound == null)
                {
                    throw new System.Exception("Job does not exist");
                }
                return Ok(jobFound);
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
                Job jobToRemove = FakeDB.Jobs.Find(c => c.id == id);
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