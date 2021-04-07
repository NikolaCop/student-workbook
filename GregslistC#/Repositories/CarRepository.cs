
using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using GregslistC_.Models;

namespace GregslistC_.Repositories
{
    public class CarRepository
    {
        public readonly IDbConnection _db;

        public CarRepository(IDbConnection db)
        {
            _db = db;
        }

        public IEnumerable<Car> Get()
        {
            string sql = "SELECT * FROM cars;";
            return _db.Query<Car>(sql);
        }

        internal Car Get(string Id)
        {
            string sql = "SELECT * FROM cars WHERE id = @Id;";
            return _db.QueryFirstOrDefault<Car>(sql, new { Id });
        }

        internal Car Create(Car newCar)
        {
            string sql = @"
      INSERT INTO cars
      (make, model, year)
      VALUES
      (@Make, @Model, @Year);
      SELECT LAST_INSERT_ID();";
            int id = _db.ExecuteScalar<int>(sql, newCar);
            newCar.id = id;
            return newCar;
        }

        internal Car Edit(Car carToEdit)
        {
            string sql = @"
      UPDATE cars
      SET
          make = @Make,
          model = @Model,
          year = @Year
          WHERE id = @Id;
          SELECT * FROM cars WHERE id = @Id;";
            return _db.QueryFirstOrDefault<Car>(sql, carToEdit);

        }

        internal void Delete(int id)
        {
            string sql = "DELETE FROM cars WHERE id = @id;";
            _db.Execute(sql, new { id });
            return;
        }

        internal void Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}