// File:    User.cs
// Created: Wednesday, April 15, 2020 6:19:55 PM
// Purpose: Definition of Class User

using SimsProjekat2020.Repository.Interfaces;
using System;

namespace Model
{
   public class User : IIdentifiable<string>
   {
        public User(string firstName, string lastName, string personalId, DateTime dateOfBirth, string phoneNumber, string email, string username, string password, Adress adress)
        {
 
            this.firstName = firstName;
            this.lastName = lastName;
            this.personalId = personalId;
            this.dateOfBirth = dateOfBirth;
            this.phoneNumber = phoneNumber;
            this.email = email;
            //this.gender = gender; ovo sam obrisala jer nam realno ne treba
            this.username = username;
            this.password = password;
            this.adress = adress;
           
        }
        public User(string firstName, string lastName, string personalId, DateTime dateOfBirth, string phoneNumber, string email,Gender gender, string username, string password, Adress adress)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.personalId = personalId;
            this.dateOfBirth = dateOfBirth;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.gender = gender; 
            this.username = username;
            this.password = password;
            this.adress = adress;

        }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string personalId { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public Gender gender { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public Adress adress { get; set; }
        public Notification[] notification { get; set; }

		public string GetId()
		{
			return personalId;
		}

		public void SetId(string id)
		{
			if(personalId != id)
			{
				personalId = id;
			}
		}

        public override string ToString()
        {
            return firstName + "," + lastName + "," + personalId + "," + dateOfBirth + "," + email + "," + phoneNumber + "," + gender + "," + username + "," + password + "," + adress;
        }

    }
}