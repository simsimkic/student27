// File:    GuestAccount.cs
// Created: Wednesday, April 15, 2020 7:53:21 PM
// Purpose: Definition of Class GuestAccount

using SimsProjekat2020.Repository.Interfaces;
using System;

namespace Model
{
   public class GuestAccount : User, IIdentifiable<string>
   {
      public bool isGuest { get; set; }


        public GuestAccount(string firstName, string lastName, string personalId, DateTime dateOfBirth, string phoneNumber, string email, Adress adress, string username, string password, bool isGuest, Notification[] notification)
            : base(firstName, lastName, personalId, dateOfBirth, phoneNumber, email, username = null, password = null, adress)
        {
            isGuest = isGuest;
        }

    public GuestAccount(string firstName, string lastName, string personalId, DateTime dateOfBirth, string phoneNumber, string email, Gender gender,  string username, string password, Adress adress, bool isGuest)
            : base(firstName, lastName, personalId, dateOfBirth, phoneNumber, email, gender, username = null, password = null, adress)

        {
            isGuest = isGuest;
        }

    }
}