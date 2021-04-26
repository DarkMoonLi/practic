using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace toDoWebAp
{
    interface IWorkDatabase
    {
        public int InsertInformation(string taskName);
        public void DeleteInformation( string taskName );
    }
}
