using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModelLib
{
    public interface IStudent
    {
        public string SetName { get; set; }
        public string SetMiddleName { get; set; }
        public string SetLastName { get; set; }
        public int SetAge { get; set; }
        string GetInfoStudent { get; set; }
    }
}
