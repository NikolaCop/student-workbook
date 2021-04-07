
using GregslistC_.Repositories;
using GregslistC_.Models;
using Dapper;
using System;
using System.Collections.Generic;

namespace GregslistC_.Services
{
    public class CarsService
    {
        private readonly CarRepository _repo;

        public CarsService(CarRepository repo)
        {
            _repo = repo;
        }
        //GET
        public IEnumerable<Car> Get()
        {
            return _repo.Get();
        }

        //GET
        internal Car GetById(string id)
        {
            Car car = _repo.Get(id);
            if (car == null)
            {
                throw new Exception("invalid id");
            }
            return car;
        }


        //CREATE/POST
        internal Car Create(Car newCar)
        {
            return _repo.Create(newCar);
        }

        //EDIT/PUT
        internal Car Edit(Car editCar)
        {
            Car original = GetById(editCar.Id);

            original.Make = editCar.Make != null ? editCar.Make : original.Make;
            original.Model = editCar.Model != null ? editCar.Model : original.Model;
            original.Year = editCar.Year != null ? editCar.Year : original.Year;

            return _repo.Edit(original);
        }

        //DELORT
        internal Car Delete(string id)
        {
            Car original = GetById(id);
            _repo.Delete(id);
            return original; ;
        }
    }
}