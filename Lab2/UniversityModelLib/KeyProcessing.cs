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
        public string PressKey(string answer, KeyProcessing key_down, OperationList newStudent, List<string> listStudent)
        {
            key = Console.ReadKey();
            ConsoleKey PressKey = key.Key;

            switch (key.Key)
            {
                case ConsoleKey.Escape:
                    {
                        key_down.answer = "don't work";
                        return key_down.answer;
                    };

                case ConsoleKey.Enter:
                    {
                        key_down.answer = "work";
                        return key_down.answer;
                    };

                case ConsoleKey.F1:
                    {
                        newStudent.WriteList(listStudent);
                        key_down.PressKey(answer, key_down, newStudent, listStudent);
                        return key_down.answer;
                    };

                case ConsoleKey.F2:
                    {
                        newStudent.DeleteList(listStudent);
                        key_down.PressKey(answer, key_down, newStudent, listStudent);
                        return key_down.answer;
                    };
            }
            key_down.answer = "don't work";
            return key_down.answer;
        }
    }
}
