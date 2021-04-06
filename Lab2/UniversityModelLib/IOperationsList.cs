using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModelLib
{
    interface IOperationsList
    {
        public void AddToList(string data, List<string> listStudent);
        public void DeleteList(List<string> listStudent);
        public void WriteList(List<string> listStudent);
        public string AddNewStudent();
    }
}
