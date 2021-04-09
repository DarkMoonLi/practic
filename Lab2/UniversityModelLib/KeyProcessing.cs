using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModelLib
{
    public class KeyProcessing : IKeyProcessing
    {
        public string answer;
        ConsoleKeyInfo key;
        public string PressKey(string answer, KeyProcessing keyDown, OperationList newStudent, List<string> listStudent)
        {
            key = Console.ReadKey();
            ConsoleKey PressKey = key.Key;

            switch (key.Key)
            {
                case ConsoleKey.Escape:
                    {
                        keyDown.answer = "don't work";
                        return keyDown.answer;
                    };

                case ConsoleKey.Enter:
                    {
                        keyDown.answer = "work";
                        return keyDown.answer;
                    };

                case ConsoleKey.F1:
                    {
                        newStudent.WriteList(listStudent);
                        keyDown.PressKey(answer, keyDown, newStudent, listStudent);
                        return keyDown.answer;
                    };

                case ConsoleKey.F2:
                    {
                        newStudent.DeleteList(listStudent);
                        keyDown.PressKey(answer, keyDown, newStudent, listStudent);
                        return keyDown.answer;
                    };
            }
            keyDown.answer = "don't work";
            return keyDown.answer;
        }
    }
}
