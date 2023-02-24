﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimsProjekat2020.Repository.Interfaces
{
    interface IRecipeRepository
    {
        IEnumerable<Recipe> GetRecipesByMedicalRecord(string id);

    }
}
