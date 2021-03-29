using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModelLib
{
    interface IOperationsList
    {
        public void AddToList(string Data, List<string> ListStudent);
        public void DeleteList(List<string> ListStudent);
        public void WriteList(List<string> ListStudent);
        public string AddNewStudent();
    }
}
