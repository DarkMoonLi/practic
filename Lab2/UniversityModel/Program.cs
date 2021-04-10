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
            KeyProcessing KeyDown = new KeyProcessing();

            Console.WriteLine("Для ввода нового студента нажмите Enter, для выхода-Escape");
            Console.WriteLine("F1-показать список, F2-очистить список");
            KeyDown.answer = "work";
            while (KeyDown.answer == "work")
            {
                string Data = NewStudent.AddNewStudent();
                Console.WriteLine(Data);
                NewStudent.AddToList(Data, ListStudent);
                KeyDown.PressKey( KeyDown.answer, KeyDown, NewStudent, ListStudent );
            }
        }
    }
}
