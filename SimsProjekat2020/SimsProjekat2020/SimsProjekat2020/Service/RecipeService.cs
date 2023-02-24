using Model;
using SimsProjekat2020.Repository;
using SimsProjekat2020.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Service
{
    class RecipeService : IService<Recipe, long>
    {
        private RecipeRepository repo;

        public RecipeService(RecipeRepository recipeRepo)
        {
            repo = recipeRepo;
        }
        public Recipe Create(Recipe entity)
        {
            return repo.Create(entity);
        }
       

        public void Delete(Recipe entity)
        {
            repo.Delete(entity);
        }

        public Recipe Get(long id)
        {
            return repo.Get(id.ToString());
        }

        public IEnumerable<Recipe> GetAll()
        {
            throw new NotImplementedException();
        }

      

        public void Update(Recipe entity)
        {
            repo.Update(entity);
        }

        Recipe IService<Recipe, long>.Get(long id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Recipe> IService<Recipe, long>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
