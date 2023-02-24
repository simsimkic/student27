using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Repository.CSV.Converter
{
    public class PatientConverter : ICSVConverter<Patient>
    {
        private readonly string delimiter;
        private readonly string dateTimeFormat;
     

        public PatientConverter(string delimiter, string dateTimeFormat) {
        
            this.delimiter = delimiter;
            this.dateTimeFormat = dateTimeFormat;
        }

        public string ConvertToCSV(Patient patient)
        {
            return string.Join(delimiter,
                patient.firstName,
                patient.lastName,
                patient.personalId,
                patient.dateOfBirth.ToString(dateTimeFormat),
                patient.phoneNumber,
                patient.email,
                patient.username,
                patient.password,
                patient.adress.Id,
                patient.medicalRecord.MedicalId);
        }

        public Patient ConvertToEntity(string entityCSVformat)
        {
            string[] tokens = entityCSVformat.Split(delimiter.ToCharArray());
            Patient patient = new Patient(tokens[0], tokens[1], tokens[2], DateTime.Parse(tokens[3]),
                tokens[4], tokens[5], tokens[6], tokens[7], new Adress(long.Parse(tokens[8])), new MedicalRecord(tokens[9]));

            return patient;
        }
    }
}
