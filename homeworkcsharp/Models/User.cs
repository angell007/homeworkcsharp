using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homeworkcsharp.Models
{
    class User
    {

        private string name;
        private int idNumber;
        private string doctor;
        private string dateTime;
        private string hour;
        private string speciality;

        public string Name { get => name; set => name = value; }
        public int IdNumber { get => idNumber; set => idNumber = value; }
        public string Doctor { get => doctor; set => doctor = value; }
        public string DateTime { get => dateTime; set => dateTime = value; }
        public string Hour { get => hour; set => hour = value; }
        public string Speciality { get => speciality; set => speciality = value; }
    }
}
