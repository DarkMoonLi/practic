using System;
using System.Collections.Generic;
using UniversityModelLib;

namespace UniversityModel
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListStudent = new List<string>();

            string answer = "work";
            ConsoleKeyInfo key;

            OperationList NewStudent = new OperationList();
            Console.WriteLine("Для ввода нового студента нажмите Enter, для выхода-Escape");
            Console.WriteLine("F1-показать список, F2-очистить список");
            while (answer == "work")
            {
                string Data = NewStudent.AddNewStudent();
                Console.WriteLine(Data);
                NewStudent.AddToList(Data, ListStudent);
                key = Console.ReadKey();
                ConsoleKey keyPress = key.Key;

                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                };

                if (key.Key == ConsoleKey.Enter)
                {
                    answer = "work";
                };

                if (key.Key == ConsoleKey.F1)
                {
                    NewStudent.WriteList( ListStudent );
                    key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        break;
                    };
                };

                if (key.Key == ConsoleKey.F2)
                {
                    NewStudent.DeleteList( ListStudent );
                    key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        break;
                    };
                };
            };
        }
    }
}
