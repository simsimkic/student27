// File:    MedicalRecord.cs
// Created: Wednesday, April 15, 2020 12:09:55 PM
// Purpose: Definition of Class MedicalRecord


using SimsProjekat2020.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace Model
{
   public class MedicalRecord : IIdentifiable<string>
   {
        public string id { get; set; }
      public string MedicalId { get; set; }
      public string IllnessHistory { get; set; }
      
      public Diagnosis Diagnosis { get; set; }
        
       public List<Allergies> Allergies { get; set; }


        public List<Vaccine> Vaccine { get; set; }



        

        public List<Recipe> Recipe { get; set; }

        public MedicalRecord() { }
        public MedicalRecord(string id, string illness, Diagnosis diag, List<Allergies> allergies, List<Vaccine> vac, List<Recipe> recipes) {
            MedicalId = id;
            IllnessHistory = illness;
            Diagnosis = diag;
            Allergies = allergies;
            Vaccine = vac;
            Recipe = recipes;

        }

        public MedicalRecord(string medicalId)
        {
            this.MedicalId = medicalId;
        }

        public string GetId()
        {
            return id;
        }

        public void SetId(string id)
        {
            this.id = id;
        }
    }
}