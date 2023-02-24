using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ClassDiagramGroup19.Repository.Converter
{
    class EmployeeConverter
    {
        private readonly string dateTimeFormat;
        private readonly string delimiter;

        public EmployeeConverter(string delimiter, string dateTimeFormat)
        {
            this.delimiter = delimiter;
            this.dateTimeFormat = dateTimeFormat;
        }
        public string ConvertToCSV(Employee employee)
        {
            return string.Join(delimiter,
                employee.employeeId,
                employee.employmentStatus,
                employee.levelOfEducation,
                employee.workingHours,
                employee.Holiday,
                employee.Room);
        }

        public Employee ConvertToEntity(string CSVformat)
        {
            string[] tokens = CSVformat.Split(delimiter.ToCharArray());
            EmploymentStatus tokens1;
            if (tokens[1].Equals("fullTime"))
                tokens1 = EmploymentStatus.fullTime;
            else
                tokens1 = EmploymentStatus.indefiniteTime;
            Education tokens2;
            if (tokens[2].Equals("bachelor"))
                tokens2 = Education.bachelor;
            else if (tokens[2].Equals("doctor"))
                tokens2 = Education.doctor;
            else
                tokens2 = Education.master;


            return new Employee(long.Parse(tokens[0]),
                                tokens1,
                                tokens2,
                                new WorkingHours(),
                                new Holiday(),
                                new Room());
        }
    }
}
