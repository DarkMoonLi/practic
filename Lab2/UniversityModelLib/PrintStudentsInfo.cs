using System;

namespace UniversityModelLib
{
    public class PrintStudentsInfo : IStudent
    {
        public string Name;
        public string LastName;
        public int Age;
        public string MiddleName;
        public string Data;

        public string SetName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public string SetLastName
        {
            get
            {
                return LastName;
            }
            set
            {
                LastName = value;
            }
        }

        public string SetMiddleName
        {
            get
            {
                return MiddleName;
            }
            set
            {
                MiddleName = value;
            }           
        }
        public int SetAge
        {
            get
            {
                return Age;
            }
            set
            {
                Age = value;
            }
        }
        public string GetInfoStudent
        {
            get
            {
                return Data;
            }
            set
            {
                Data = value;
            }
        }
    }
}
