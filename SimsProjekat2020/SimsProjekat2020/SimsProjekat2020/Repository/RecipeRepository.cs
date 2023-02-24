using Model;
using SimsProjekat2020.Repository.CSV;
using SimsProjekat2020.Repository.CSV.FileStream;
using SimsProjekat2020.Repository.Sequncer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Repository
{
    public class RecipeRepository : CSVRepository<Recipe, string>
    {
        public RecipeRepository(string entityName, ICSVStream<Recipe> stream) : base(entityName, stream)
        {
        }

        public RecipeRepository(string entityName, ICSVStream<Recipe> stream, ISequencer<string> sequencer) : base(entityName, stream, sequencer)
        {
        }
    }
}
