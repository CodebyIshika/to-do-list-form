using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListForm.Entity
{
    public class TaskEntity
    {
        public int TaskId { get; set; }

        public string TaskName { get; set; }

        public string Description { get; set; }

        public DateTime? DueDate { get; set; }

        public string Status { get; set; }
    }
}
