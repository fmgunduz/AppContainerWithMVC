using ContainerAppMvc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContainerAppMvc.DataAccess.TodoApp
{
    public class TodoAppDbContext:DbContext
    {
        public TodoAppDbContext(DbContextOptions<TodoAppDbContext> options):base(options)
        {

        }
        public DbSet<TodoModel> TodoTbl { get; set; }
    }
}
