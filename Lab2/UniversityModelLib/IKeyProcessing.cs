using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModelLib
{
    interface IKeyProcessing
    {
        public string KeyPress( string answer, KeyProcessing key_down, OperationList NewStudent, List<string> ListStudent );
    }
}
