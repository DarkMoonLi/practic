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
            PrintStudentsInfo person = new PrintStudentsInfo();

            Console.Write("Введите имя: ");
            person.Name = Console.ReadLine();
            string Name = person.SetName;

            Console.Write("Введите фамилию: ");
            person.LastName = Console.ReadLine();
            string LastName = person.SetLastName;

            Console.Write("Введите отчество: ");
            person.MiddleName = Console.ReadLine();
            string MiddleName = person.SetMiddleName;

            Console.Write("Введите возраст: ");
            person.Age = Convert.ToInt32(Console.ReadLine());
            int Age = person.SetAge;

            Console.Write("Данные студента: ");
            string NewStudent = $"{LastName} {Name} {MiddleName} {Age}";
            person.Data = NewStudent;
            return person.Data;
        }
    }
}
