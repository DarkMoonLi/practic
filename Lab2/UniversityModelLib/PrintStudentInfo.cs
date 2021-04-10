using System;

namespace UniversityModelLib
{
    public class StudentInfo : IStudent
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string MiddleName { get; set; }
        public string Data { get; set; } 
    }
}
