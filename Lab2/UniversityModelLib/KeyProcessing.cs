using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModelLib
{
    public class KeyProcessing : IKeyProcessing
    {
        public string Answer;
        ConsoleKeyInfo key;
        public string PressKey(string answer, KeyProcessing keyDown, OperationList newStudent, List<string> listStudent)
        {
            key = Console.ReadKey();
            ConsoleKey PressKey = key.Key;

            switch (key.Key)
            {
                case ConsoleKey.Escape:
                    {
                        keyDown.Answer = "don't work";
                        return keyDown.Answer;
                    };

                case ConsoleKey.Enter:
                    {
                        keyDown.Answer = "work";
                        return keyDown.Answer;
                    };

                case ConsoleKey.F1:
                    {
                        newStudent.WriteList(listStudent);
                        keyDown.PressKey(answer, keyDown, newStudent, listStudent);
                        return keyDown.Answer;
                    };

                case ConsoleKey.F2:
                    {
                        newStudent.DeleteList(listStudent);
                        keyDown.PressKey(answer, keyDown, newStudent, listStudent);
                        return keyDown.Answer;
                    };
            }
            keyDown.Answer = "don't work";
            return keyDown.Answer;
        }
    }
}
