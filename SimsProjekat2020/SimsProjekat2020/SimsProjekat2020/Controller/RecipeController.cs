using Model;
using SimsProjekat2020.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Controller
{
    class RecipeController : IController<Recipe, long>
    {
        RecipeService service;

        public RecipeController(RecipeService service)
        {
            this.service = service;
        }
        public Recipe Create(Recipe entity)
        {
            return service.Create(entity);
        }

        public void Delete(Recipe entity)
        {
            service.Delete(entity);
        }

        public Recipe Get(long id)
        {
            return service.Get(id);
        }

        public IEnumerable<Recipe> GetAll()
        {
            return service.GetAll();
        }

        public void Update(Recipe entity)
        {
            service.Update(entity);
        }
    }

}
