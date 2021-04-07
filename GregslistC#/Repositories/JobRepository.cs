
using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using GregslistC_.Models;

namespace GregslistC_.Repositories
{
    public class JobRepository
    {
        public readonly IDbConnection _db;

        public JobRepository(IDbConnection db)
        {
            _db = db;
        }

        public IEnumerable<Job> Get()
        {
            string sql = "SELECT * FROM jobs;";
            return _db.Query<Job>(sql);
        }

        internal Job Get(string Id)
        {
            string sql = "SELECT * FROM jobs WHERE id = @Id;";
            return _db.QueryFirstOrDefault<Job>(sql, new { Id });
        }

        internal Job Create(Job newJob)
        {
            string sql = @"
      INSERT INTO jobs
      (title, description, rate)
      VALUES
      (@Title, @Description, @Rate);
      SELECT LAST_INSERT_ID();";
            int id = _db.ExecuteScalar<int>(sql, newJob);
            newJob.id = id;
            return newJob;
        }

        internal Job Edit(Job jobToEdit)
        {
            string sql = @"
      UPDATE jobs
      SET
          title = @Title,
          description = @Description,
          rate = @Rate
          WHERE id = @Id;
          SELECT * FROM jobs WHERE id = @Id;";
            return _db.QueryFirstOrDefault<Job>(sql, jobToEdit);

        }

        internal void Delete(int id)
        {
            string sql = "DELETE FROM jobs WHERE id = @id;";
            _db.Execute(sql, new { id });
            return;
        }

        internal void Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}