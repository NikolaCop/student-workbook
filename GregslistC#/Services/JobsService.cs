
using GregslistC_.Repositories;
using GregslistC_.Models;
using Dapper;
using System;
using System.Collections.Generic;

namespace GregslistC_.Services
{
    public class JobsService
    {
        private readonly JobRepository _repo;

        public JobsService(JobRepository repo)
        {
            _repo = repo;
        }
        //GET
        public IEnumerable<Job> Get()
        {
            return _repo.Get();
        }

        //GET
        internal Job GetById(string id)
        {
            Job job = _repo.Get(id);
            if (job == null)
            {
                throw new Exception("invalid id");
            }
            return job;
        }


        //CREATE/POST
        internal Job Create(Job newJob)
        {
            return _repo.Create(newJob);
        }

        //EDIT/PUT
        internal Job Edit(Job editJob)
        {
            Job original = GetById(editJob.Id);

            original.Title = editJob.Title != null ? editJob.Title : original.Title;
            original.Description = editJob.Description != null ? editJob.Description : original.Description;
            original.Rate = editJob.Rate != null ? editJob.Rate : original.Rate;

            return _repo.Edit(original);
        }

        //DELORT
        internal Job Delete(string id)
        {
            Job original = GetById(id);
            _repo.Delete(id);
            return original; ;
        }
    }
}