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
        public string KeyPress(string answer, KeyProcessing key_down, OperationList NewStudent, List<string> ListStudent)
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
                        NewStudent.WriteList(ListStudent);
                        key_down.KeyPress(answer, key_down, NewStudent, ListStudent);
                        return key_down.answer;
                    };

                case ConsoleKey.F2:
                    {
                        NewStudent.DeleteList(ListStudent);
                        key_down.KeyPress(answer, key_down, NewStudent, ListStudent);
                        return key_down.answer;
                    };
            }
            key_down.answer = "don't work";
            return key_down.answer;
        }
    }
}
