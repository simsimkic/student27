using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimsProjekat2020.Repository.CSV
{
    public class AppointmentConverter : ICSVConverter<Appointment>
    {
        private readonly string dateTimeFormat;
        private readonly string delimiter;
        private readonly MedicalRecordRepository medRepo;
        private readonly RoomRepository roomRepo;
        private readonly DoctorRepository docRepo;
        private readonly TermRepository termRepo;

        public AppointmentConverter(string delimiter, MedicalRecordRepository medRepo, RoomRepository roomRepo, DoctorRepository docRepo,
        TermRepository termRepo) {
            this.delimiter = delimiter;
            this.medRepo = medRepo;
            this.roomRepo = roomRepo;
            this.docRepo = docRepo;
            this.termRepo = termRepo;
        }
        public string ConvertToCSV(Appointment appointment)
        {
            return string.Join(delimiter, 
                appointment.AppointmentId, 
                appointment.AppointmentType, 
                appointment.MedicalRecord.MedicalId, 
                appointment.Room.roomId, 
                appointment.Term.TermId, 
                appointment.Doctor.employeeId);
        }

        public Appointment ConvertToEntity(string CSVformat)
        {
            string[] tokens = CSVformat.Split(delimiter.ToCharArray());

            AppointmentType type = new AppointmentType();
            if (tokens[1].Equals("operation")) {
                type = AppointmentType.operation;
            } else if (tokens[1].Equals("regularAp")) {
                type = AppointmentType.regularAp;
            } else if (tokens[1].Equals("controlAp")) {
                type = AppointmentType.controlAp;
            }
            else {
                type = AppointmentType.hospitalStay;
            }

            return new Appointment(long.Parse(tokens[0]),
                type,
                medRepo.Get(tokens[2]),
                roomRepo.Get(long.Parse(tokens[3])),
                termRepo.Get(long.Parse(tokens[4])),
                docRepo.Get(long.Parse(tokens[5])));
     
        }
    }
}
