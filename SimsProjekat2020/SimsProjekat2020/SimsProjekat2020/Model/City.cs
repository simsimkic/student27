// File:    City.cs
// Created: Wednesday, April 15, 2020 7:02:34 PM
// Purpose: Definition of Class City

using SimsProjekat2020.Repository.Interfaces;
using System;

namespace Model
{
   public class City : IIdentifiable<string>
   {
        

        public string Name { get; set; }
      public int PostCode { get; set; }
      public State State { get; set; }

        public string Id { get; set; }


        public City(string name, int postCode)
        {
            Name = name;
            PostCode = postCode;
         
        }

        public City(int postCode, string name, State state)
        {
            PostCode = postCode;
            Name = name;
            State = state;

        }
        public City(string id,int postCode, string name, State state)
        {
            this.Id = id;
            this.Name = name;
            this.PostCode = postCode;
            this.State = state;

        }
        public City(string name, State state)
        {
            Name = name;
            State = state;

        }
        public City(string name) {
            this.Name = name;
        }

        public string GetId()
        {
            return Id;
        }

        public void SetId(string id)
        {
            this.Id = id;
        }

        


    }
}