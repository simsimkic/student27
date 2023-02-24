// File:    Medicine.cs
// Created: Wednesday, April 15, 2020 7:09:56 PM
// Purpose: Definition of Class Medicine

using SimsProjekat2020.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Model
{
    public class Medicine : IIdentifiable<string>
    {
        public string Name { get; set; }
        public string MedicineId { get; set; }
        public List<string> Ingredients { get; set; }
        public string Description { get; set; }
        public string TypeOfUse { get; set; }
        public int Amount { get; set; }
        public bool Approved { get; set; }


        public Medicine() { }

        public Medicine(string id, string name, List<string> ingredients, string description, string type, int amount, bool approved)
        {
            MedicineId = id;
            Name = name;
            Ingredients = ingredients;
            Description = description;
            TypeOfUse = type;
            Amount = amount;
            Approved = approved;
        }

        public string GetId()
        {
            return MedicineId;
        }

        public void SetId(string id)
        {
            MedicineId = id;
        }
    }
}