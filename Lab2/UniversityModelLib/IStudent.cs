using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModelLib
{
    public interface IStudent
    {
        public string InfoStudentName();
        public string InfoStudentMiddleName();
        public string InfoStudentLastName();
        public int InfoStudentAge();
        string GetInfoStudent( string Name, string LastName, int Age, string MiddleName );
    }
}
