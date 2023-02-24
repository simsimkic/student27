// File:    Adress.cs
// Created: Thursday, April 16, 2020 7:02:33 PM
// Purpose: Definition of Class Adress

using SimsProjekat2020.Repository.Interfaces;
using System;

namespace Model
{
   public class Adress : IIdentifiable<long>
   {
        public long Id { get; set; }
        public string street { get; set; }
      

        public City city { get; set; }
         public Adress(string address)
         {
            //ovo ne valja, samo proba
             string[] addressPart = address.Split('-');
             street = addressPart[0];
            // number = Int32.Parse(addressPart[1]);
            // city = new City(addressPart[2]);
         }
        public Adress(long id) {
            this.Id = id;
        }

        public Adress(string street, City city)
        {
            
            this.street = street;

            this.city = city;
        }
        public Adress(long id, string street, City city)
        {
            this.Id = id;
            this.street = street;
            
            this.city = city;
        }


        public long GetId()
        {
            return Id;
        }

        public void SetId(long id)
        {
            this.Id = id;
        }

        public override string ToString()
        {
            return street + "-" + city;
        }


    }
}