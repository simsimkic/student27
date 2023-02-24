using Model;
using SimsProjekat2020.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Controller
{
    class RoomController : IController<Room, long>
    {
        RoomService service;

        public RoomController(RoomService service)
        {
            this.service = service;
        }
        public Room Create(Room entity)
        {
            return service.Create(entity);
        }

        public void Delete(Room entity)
        {
            service.Delete(entity);
        }

        public Room Get(long id)
        {
            return service.Get(id);
        }

        public IEnumerable<Room> GetAll()
        {
            return service.GetAll();
        }

        public void Update(Room entity)
        {
            service.Update(entity);
        }
    }
}
