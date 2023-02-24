// File:    HospitalStay.cs
// Created: Thursday, April 16, 2020 9:48:26 AM
// Purpose: Definition of Class HospitalStay

using System;
using System.Collections.Generic;

namespace Model
{
   public class HospitalStay
   {
      private DateTime startDate;
      private DateTime endDate;
      
      private HospitalBedroom hospitalBedroom;
      public List<MedicalRecord> medicalRecord;

   
   }
}