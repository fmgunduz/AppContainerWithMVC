using ContainerAppMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ContainerAppMvc.DataAccess.TodoApp
{
    public interface ITodoAppDal
    {
        void Add(TodoModel todoModel);
        void Delete(TodoModel todoModel);
        void Update(TodoModel todoModel);
        TodoModel Get(Expression<Func<TodoModel, bool>> filter = null);
        IQueryable<TodoModel> GetAll(Expression<Func<TodoModel, bool>> filter = null);
    }
}
