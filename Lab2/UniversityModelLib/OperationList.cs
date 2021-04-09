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
        public void AddToList(string data, List<string> listStudent )
        {
            listStudent.Add(data);
        }

        public void DeleteList( List<string> listStudent)
        {
            listStudent.Clear();
        }

        public void WriteList( List<string> listStudent)
        {
            foreach (var item in listStudent)
            {
                Console.WriteLine(item);
            }
        }

        public string AddNewStudent()
        {
            StudentInfo person = new StudentInfo();

            Console.Write("Введите имя: ");
            person.Name = Console.ReadLine();
            string Name = person.Name;

            Console.Write("Введите фамилию: ");
            person.LastName = Console.ReadLine();
            string LastName = person.LastName;

            Console.Write("Введите отчество: ");
            person.MiddleName = Console.ReadLine();
            string MiddleName = person.MiddleName;

            Console.Write("Введите возраст: ");
            person.Age = Convert.ToInt32(Console.ReadLine());
            int Age = person.Age;

            Console.Write("Данные студента: ");
            string NewStudent = $"{LastName} {Name} {MiddleName} {Age}";
            person.Data = NewStudent;
            return person.Data;
        }
    }
}
