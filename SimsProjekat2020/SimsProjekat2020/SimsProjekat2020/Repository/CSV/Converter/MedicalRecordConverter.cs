using Model;
using SimsProjekat2020.Repository.CSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimsProjekat2020.Repository.CSV
{
    class MedicalRecordConverter : ICSVConverter<MedicalRecord>
    {
        private readonly string delimiter;
        private readonly string dateTimeFormat;
        public string ConvertToCSV(MedicalRecord medicalRecord)
        {
            return string.Join(delimiter,
                medicalRecord.MedicalId,
                medicalRecord.IllnessHistory,
                medicalRecord.Diagnosis,
                medicalRecord.Allergies,
                medicalRecord.Vaccine,
                medicalRecord.Recipe);
        }

        public MedicalRecord ConvertToEntity(string CSVformat)
        {
            string[] tokens = CSVformat.Split(delimiter.ToCharArray());

            

            return new MedicalRecord(tokens[0],
                tokens[1],
                new Diagnosis(),
                new List<Allergies>(),
                new List<Vaccine>(),
                new List<Recipe>()
                );
        }
    }
}
