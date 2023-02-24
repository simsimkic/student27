// File:    Department.cs
// Created: Wednesday, April 15, 2020 6:47:54 PM
// Purpose: Definition of Class Department

using SimsProjekat2020.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace Model
{
   public class Department : IIdentifiable<string>
   { 
        public string DepartmentName { get; set; }
        public List<Doctor> Doctor { get; set; }

        public Department() { }
        public Department(string departmentName, List<Doctor> doctors) {
            DepartmentName = departmentName;
            Doctor = doctors;
        }

        public string GetId()
        {
            return DepartmentName;
        }

        public void SetId(string id)
        {
            DepartmentName = id;
        }
    }
}