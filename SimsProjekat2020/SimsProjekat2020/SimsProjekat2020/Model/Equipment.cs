// File:    Equipment.cs
// Created: Wednesday, April 15, 2020 8:20:16 PM
// Purpose: Definition of Class Equipment

using SimsProjekat2020.Repository.Interfaces;
using System;

namespace Model
{
   public class Equipment : IIdentifiable<string>
    {
        public string EquipmentId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public EquipmentType EquipmentType { get; set; }

         public Equipment() { }
        
        public Equipment(string id, string name, int quantity, string description,EquipmentType equipmentType )
        {
            EquipmentId = id;
            Name = name;
            Quantity = quantity;
            Description = description;
            EquipmentType = equipmentType;
        }
        public string GetId()
        {
            return EquipmentId;
        }
     
        public void SetId(string id)
        {
            EquipmentId = id;
        }
    }
}