// File:    Room.cs
// Created: Wednesday, April 15, 2020 12:01:21 PM
// Purpose: Definition of Class Room

using SimsProjekat2020.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace Model
{
   public class Room : IIdentifiable<long>
   {
      public long roomId { get; set; }
      private bool availability;
      
        private RoomType roomType;
        public List<Equipment> equipment;
       

        public long GetId()
        {
            return roomId;
        }

        public void SetId(long id)
        {
            roomId = id;
        }
    }
}