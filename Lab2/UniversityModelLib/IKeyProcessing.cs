using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModelLib
{
    interface IKeyProcessing
    {
        public string PressKey( string answer, KeyProcessing key_down, OperationList newStudent, List<string> listStudent );
    }
}
