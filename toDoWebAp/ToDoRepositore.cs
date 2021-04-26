using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace toDoWebAp
{
    public class ToDoRepositore
    {
        private static List<ToDo> Database = new List<ToDo>();

        private WorkDatabase WorkDatabase = new WorkDatabase();
        private class ToDo
        {
            public int Id { get; }
            public string Name { get; set; }
            public bool Done { get; set; }
            public DateTime CreationDate { get; }
            public ToDo(int id, string name, bool done)
            {
                Id = id;
                Name = name;
                Done = done;
                CreationDate = DateTime.Now;
            }
        }

        private int GetId()
        {
            if (Database.Count > 0)
            {
                return Database.Max(x => x.Id) + 1;
            }
            else
            {
                return 1;
            }
        }
        public List<ToDoDto> GetAll()
        {
            return WorkDatabase.ReadInformation();
        }

        public int Create(ToDoDto toDoDto)
        {
            int Id = GetId();
            ToDo todo = new ToDo( Id, toDoDto.Name, false);
            WorkDatabase.InsertInformation( toDoDto.Name );
            return Id;
        }

        public void Update(int id, ToDoDto toDoDto)
        {
            WorkDatabase.DeleteInformation(toDoDto.Name);
        }
    }
}
