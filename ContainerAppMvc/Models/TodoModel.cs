using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContainerAppMvc.Models
{
    public class TodoModel
    {
        public int Id { get; set; }
        public string TodoContent { get; set; }
        public bool IsDone { get; set; }
    }
}
