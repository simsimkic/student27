// File:    Recipe.cs
// Created: Wednesday, April 15, 2020 12:11:14 PM
// Purpose: Definition of Class Recipe

using SimsProjekat2020.Repository.Interfaces;
using System;

namespace Model
{
   public class Recipe:IIdentifiable<string>
   {
        public Recipe(String id,Medicine medicine, Doctor doctor,DateTime realiseDate)
        {
            this.medicine = medicine;
            this.doctor = doctor;
            this.id = id;
            this.realiseDate = realiseDate;
        }
        public Recipe( Medicine medicine, Doctor doctor)
        {
            this.medicine = medicine;
            this.doctor = doctor;

        }

        public DateTime realiseDate { get; set; }

        public Medicine medicine { get; set; }
        public Doctor doctor { get; set; }
        public String id { get; set; }

        public Recipe() { }
   

        public Recipe(String id )
        {
            this.id = id;
        }



        public string GetId()
        {
            return id;
        }

        public void SetId(string id)
        {
            id = id;
        }

    }
}