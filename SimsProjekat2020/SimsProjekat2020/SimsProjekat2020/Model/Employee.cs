// File:    Employee.cs
// Created: Wednesday, April 15, 2020 12:00:23 PM
// Purpose: Definition of Class Employee

using System;
using System.Collections.Generic;

namespace Model
{
   public class Employee : User
   {
      public long employeeId { get; set; }
      private EmploymentStatus employmentStatus;
      private Education levelOfEducation;
      
      private WorkingHours[] workingHours;
      private Holiday holiday;
      private Room room;

        public Employee(string firstName, string lastName, string personalId, DateTime dateOfBirth, string phoneNumber, string email, string username, string password, Adress adress, Notification[] notification, int employeeId, EmploymentStatus employmentStatus, Education levelOfEducation, Holiday holiday, Room room)
            : base(firstName, lastName, personalId, dateOfBirth, phoneNumber, email, username, password, adress)
        {
            this.employeeId = employeeId;
            this.employmentStatus = employmentStatus;
            this.levelOfEducation = levelOfEducation;
            this.holiday = holiday;
            this.room = room;
            //this.workingHours = workingHours; ?
        }

    }
}