// File:    Secretary.cs
// Created: Wednesday, April 15, 2020 6:34:21 PM
// Purpose: Definition of Class Secretary

using System;

namespace Model
{
   public class Secretary : Employee
   {
        public Secretary(string firstName, string lastName, string personalId, DateTime dateOfBirth, string phoneNumber, string email,  string username, string password, Adress adress, Notification[] notification, int employeeId, EmploymentStatus employmentStatus, Education levelOfEducation, Holiday holiday, Room room)
            : base(firstName, lastName, personalId, dateOfBirth, phoneNumber, email,  username, password, adress,  notification, employeeId, employmentStatus, levelOfEducation, holiday, room)
        {

        }

    }
}