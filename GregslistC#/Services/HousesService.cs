
using GregslistC_.Repositories;
using GregslistC_.Models;
using Dapper;
using System;
using System.Collections.Generic;

namespace GregslistC_.Services
{
    public class HousesService
    {
        private readonly HouseRepository _repo;

        public HousesService(HouseRepository repo)
        {
            _repo = repo;
        }
        //GET
        public IEnumerable<House> Get()
        {
            return _repo.Get();
        }

        //GET
        internal House GetById(string id)
        {
            House house = _repo.Get(id);
            if (house == null)
            {
                throw new Exception("invalid id");
            }
            return house;
        }


        //CREATE/POST
        internal House Create(House newHouse)
        {
            return _repo.Create(newHouse);
        }

        //EDIT/PUT
        internal House Edit(House editHouse)
        {
            House original = GetById(editHouse.Id);

            original.Name = editHouse.Name != null ? editHouse.Name : original.Name;
            original.Bedrooms = editHouse.Bedrooms != null ? editHouse.Bedrooms : original.Bedrooms;
            original.Price = editHouse.Price != null ? editHouse.Price : original.Price;

            return _repo.Edit(original);
        }

        //DELORT
        internal House Delete(string id)
        {
            House original = GetById(id);
            _repo.Delete(id);
            return original; ;
        }
    }
}