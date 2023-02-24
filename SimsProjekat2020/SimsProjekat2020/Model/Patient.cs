// File:    Patient.cs
// Created: Wednesday, April 15, 2020 12:00:14 PM
// Purpose: Definition of Class Patient

using System;

namespace Model
{
   public class Patient : User
   {
      private MedicalRecord medicalRecord;

        public Patient(string firstName, string lastName, string personalId, DateTime dateOfBirth, string phoneNumber, string email, Gender gender, string username, string password, Adress adress, Notification[] notification,MedicalRecord medicalRecord)
            : base(firstName, lastName, personalId, dateOfBirth, phoneNumber, email, gender, username, password, adress, notification)
        {
            medicalRecord = medicalRecord;
        }

        public Patient(string v)
        {
            this.personalId = v;
        }
    }
}