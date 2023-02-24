using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Repository.CSV.Converter
{
    public class EquipmentConverter : ICSVConverter<Equipment>
    {
        private readonly string delimiter;
        private readonly string equipmentId;
        private readonly string name;
        private readonly int quantity;
        private readonly string description;
        private readonly EquipmentType equipmentType;

        public EquipmentConverter(string delimiter)
        {
            this.delimiter = delimiter;
        }

        public string ConvertToCSV(Equipment equipment)
        {
            return string.Join(delimiter,
              equipment.EquipmentId,
              equipment.Name,
              equipment.Quantity,
              equipment.Description,
              equipment.EquipmentType);
        }

        public Equipment ConvertToEntity(string CSVformat)
        {
            string[] tokens = CSVformat.Split(delimiter.ToCharArray());

            EquipmentType type = new EquipmentType();
            if (tokens[4].Equals("consumable"))
                type = EquipmentType.consumable;
            else
                type = EquipmentType.nonconsumable;

            return new Equipment(tokens[0],
                tokens[1],
                int.Parse(tokens[2]),
                tokens[3],
                type);
          
        }
    }
}
