// File:    Survey.cs
// Created: Thursday, April 16, 2020 7:10:04 PM
// Purpose: Definition of Class Survey

using SimsProjekat2020.Repository.Interfaces;
using System;

namespace Model
{
   public class Survey : IIdentifiable<long>
   {
        public Survey() { }
        public Survey(string questions, int answer, string comment, Patient patient, Doctor doctor)
        {
            this.questions = questions;
            this.answer = answer;
            this.comment = comment;
            this.patient = patient;
            this.doctor = doctor;
        }

        public string questions { get; set; }
        public int answer { get; set; }
        public string comment { get; set; }

        public Patient patient { get; set; }
        public Doctor doctor { get; set; }

        public long GetId()
        {
            return doctor.employeeId;
        }

        public void SetId(long id)
        {
            doctor.employeeId = id;
        }
    }
}