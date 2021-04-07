
using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using GregslistC_.Models;

namespace GregslistC_.Repositories
{
    public class HouseRepository
    {
        public readonly IDbConnection _db;

        public HouseRepository(IDbConnection db)
        {
            _db = db;
        }

        public IEnumerable<House> Get()
        {
            string sql = "SELECT * FROM houses;";
            return _db.Query<House>(sql);
        }

        internal House Get(string Id)
        {
            string sql = "SELECT * FROM houses WHERE id = @Id;";
            return _db.QueryFirstOrDefault<House>(sql, new { Id });
        }

        internal House Create(House newHouse)
        {
            string sql = @"
      INSERT INTO houses
      (name, bedrooms, price)
      VALUES
      (@Name, @Bedrooms, @Price);
      SELECT LAST_INSERT_ID();";
            int id = _db.ExecuteScalar<int>(sql, newHouse);
            newHouse.id = id;
            return newHouse;
        }

        internal House Edit(House houseToEdit)
        {
            string sql = @"
      UPDATE houses
      SET
          name = @Name,
          bedrooms = @Bedrooms,
          price = @Price
          WHERE id = @Id;
          SELECT * FROM houses WHERE id = @Id;";
            return _db.QueryFirstOrDefault<House>(sql, houseToEdit);

        }

        internal void Delete(int id)
        {
            string sql = "DELETE FROM houses WHERE id = @id;";
            _db.Execute(sql, new { id });
            return;
        }

        internal void Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}