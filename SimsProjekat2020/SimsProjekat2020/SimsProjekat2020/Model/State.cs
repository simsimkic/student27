// File:    State.cs
// Created: Wednesday, April 15, 2020 7:02:33 PM
// Purpose: Definition of Class State

using SimsProjekat2020.Repository.Interfaces;
using System;

namespace Model
{
   public class State : IIdentifiable<string>
   {

      public string Name { get; set; }
        public string Id { get; set; }
      
        public State(string id, string name)
        {
            Id = id;
            Name = name;

        }
        public State(string name) {
            this.Name = name;
        }
   
        

        /*public static implicit operator State(string v)
        {
            throw new NotImplementedException();
        }*/

        public string GetId()
        {
            return Id;
        }


        public void SetId(string id)
        {
            this.Id = id;
        }
        public override string ToString()
        {
            return Name;

        }
    }
}