using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityModelLib;

namespace UniversityModelLib
{
    public class OperationList: IOperationsList
    {
        public void AddToList(string Data, List<string> ListStudent )
        {
            ListStudent.Add(Data);
        }

        public void DeleteList( List<string> ListStudent)
        {
            ListStudent.Clear();
        }

        public void WriteList( List<string> ListStudent)
        {
            foreach (var item in ListStudent)
            {
                Console.WriteLine(item);
            }
        }

        public string AddNewStudent()
        {
            StudentsInfo person = new StudentsInfo();
            string name = person.InfoStudentName();
            string lastName = person.InfoStudentLastName();
            string middleName = person.InfoStudentMiddleName();
            int age = person.InfoStudentAge();
            string data = person.GetInfoStudent(name, lastName, age, middleName);
            return data;
        }
    }
}
