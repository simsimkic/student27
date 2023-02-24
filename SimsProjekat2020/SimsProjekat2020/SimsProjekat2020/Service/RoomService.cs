using Model;
using SimsProjekat2020.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Service
{
    class RoomService : IService<Room, long>
    {
        private RoomRepository repo;
        public RoomService(RoomRepository roomRepo)
        {
            repo = roomRepo;
        }

        public Room Create(Room entity)
        {
            return repo.Create(entity);
        }

        public void Delete(Room entity)
        {
            repo.Delete(entity);
        }

        public Room Get(long id)
        {
            return repo.Get(id);
        }

        public IEnumerable<Room> GetAll()
        {
            return GetAll();
        }

        public void Update(Room entity)
        {
            repo.Update(entity);
        }
    }
}
