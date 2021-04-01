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
            OperationList NewStudent = new OperationList();
            KeyProcessing key_down = new KeyProcessing();

            Console.WriteLine("Для ввода нового студента нажмите Enter, для выхода-Escape");
            Console.WriteLine("F1-показать список, F2-очистить список");
            key_down.answer = "work";
            while (key_down.answer == "work")
            {
                string Data = NewStudent.AddNewStudent();
                Console.WriteLine(Data);
                NewStudent.AddToList(Data, ListStudent);
                key_down.KeyPress( key_down.answer, key_down, NewStudent, ListStudent );
            }
        }
    }
}
