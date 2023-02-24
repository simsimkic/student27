// File:    Patient.cs
// Created: Wednesday, April 15, 2020 12:00:14 PM
// Purpose: Definition of Class Patient

using System;

namespace Model
{
   public class Patient : User
   {
      public MedicalRecord medicalRecord { get; set; }


        public Patient(string firstName, string lastName, string personalId, DateTime dateOfBirth, string phoneNumber, string email, 
            string username, string password, Adress adress, MedicalRecord medRec)
            : base(firstName, lastName, personalId, dateOfBirth, phoneNumber, email, username, password, adress)
        {
            medicalRecord = medRec;
        }
    }
}