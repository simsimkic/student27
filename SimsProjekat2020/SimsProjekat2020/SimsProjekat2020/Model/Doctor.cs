// File:    Doctor.cs
// Created: Wednesday, April 15, 2020 6:34:18 PM
// Purpose: Definition of Class Doctor

using SimsProjekat2020.Repository.Interfaces;
using System;

namespace Model
{
   public class Doctor : Employee , IIdentifiable<long>
   {
      public Department department;

        public Doctor(string firstName, string lastName, string personalId, DateTime dateOfBirth, string phoneNumber, string email,  string username, string password, Adress adress, Notification[] notification, int employeeId, EmploymentStatus employmentStatus, Education levelOfEducation, Holiday holiday, Room room, Department department)
            : base(firstName, lastName, personalId, dateOfBirth, phoneNumber, email, username, password, adress,  notification, employeeId, employmentStatus, levelOfEducation, holiday, room)
        {
            department = department;

        }

        

        

        public void SetId(long id)
        {
            this.employeeId = id ;
        }

        long IIdentifiable<long>.GetId()
        {
            throw new NotImplementedException();
        }
    }
}