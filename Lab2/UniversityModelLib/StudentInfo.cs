using System;

namespace UniversityModelLib
{
    public class StudentsInfo : IStudent
    {
        public string Name;
        public string LastName;
        public int Age;
        public string MiddleName;

        public string InfoStudentName()
        {
            Console.Write("Введите имя: ");
            this.Name = Console.ReadLine();
            return this.Name;

        }

        public string InfoStudentLastName()
        {
            Console.Write("Введите фамилию: ");
            this.LastName = Console.ReadLine();
            return this.LastName;
        }

        public string InfoStudentMiddleName()
        {
            Console.Write("Введите отчество: ");
            this.MiddleName = Console.ReadLine();
            return this.MiddleName;
        }
        public int InfoStudentAge()
        {
            Console.Write("Введите возраст: ");
            this.Age = Convert.ToInt32(Console.ReadLine());
            return this.Age;
        }
        public string GetInfoStudent( string Name, string LastName, int Age, string MiddleName )
        {
            Console.Write("Данные студента: ");
            string NewStudent = $"{LastName} {Name} {MiddleName} {Age}";
            return NewStudent;
        }
    }
}
