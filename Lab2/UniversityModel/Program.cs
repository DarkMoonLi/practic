using System;
using System.Collections.Generic;
using UniversityModelLib;

namespace UniversityModel
{
    class Program
    {
        static void Main(string[] args)
        {
            var listStudent = new List<string>();
            OperationList newStudent = new OperationList();
            KeyProcessing keyDown = new KeyProcessing();

            Console.WriteLine("Для ввода нового студента нажмите Enter, для выхода-Escape");
            Console.WriteLine("F1-показать список, F2-очистить список");
            keyDown.Answer = "work";
            while (keyDown.Answer == "work")
            {
                string Data = newStudent.AddNewStudent();
                Console.WriteLine(Data);
                newStudent.AddToList(Data, listStudent);
                keyDown.PressKey( keyDown.Answer, keyDown, newStudent, listStudent );
            }
        }
    }
}
