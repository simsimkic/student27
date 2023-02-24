// File:    Appointment.cs
// Created: Wednesday, April 15, 2020 11:59:57 AM
// Purpose: Definition of Class Appointment


using SimsProjekat2020.Repository.Interfaces;
using System;

namespace Model
{
   public class Appointment : IIdentifiable<long>
   {
        public long AppointmentId { get; set; }
        public AppointmentType AppointmentType { get; set; }

        public MedicalRecord MedicalRecord { get; set; }
        public Room Room { get; set; }
        public Term Term { get; set; }
        public Doctor Doctor { get; set; }

        public Appointment() { }
        public Appointment(long id, AppointmentType apType, MedicalRecord medRec, Room room, Term term, Doctor doc) {

            AppointmentId = id;
            AppointmentType = apType;
            MedicalRecord = medRec;
            Room = room;
            Term = term;
            Doctor = doc;
        }

        public long GetId() {
            return AppointmentId;
        }

        public void SetId(long id)
        {
            AppointmentId = id;
        }
    }
}