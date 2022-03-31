using ContainerAppMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace ContainerAppMvc.DataAccess.TodoApp
{
    public class EfTodoAppDal : ITodoAppDal
    {
        private readonly TodoAppDbContext _context;

        public EfTodoAppDal(TodoAppDbContext context)
        {
            _context = context;
        }
        public void Add(TodoModel todoModel)
        {
            var entityToAdded = _context.Entry(todoModel);
            entityToAdded.State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Delete(TodoModel todoModel)
        {
            var entitytoDelete = _context.Entry(todoModel);
            entitytoDelete.State = EntityState.Deleted;
            _context.SaveChanges();
   
        }
        public void Update(TodoModel todoModel)
        {
            var entitytoUpdate = _context.Entry(todoModel);
            entitytoUpdate.State = EntityState.Modified;
            _context.SaveChanges();
        }

        public IQueryable<TodoModel> GetAll(Expression<Func<TodoModel, bool>> filter = null)
        {
           return filter == null ? _context.Set<TodoModel>(): _context.Set<TodoModel>().Where(filter);
        }

        public TodoModel Get(Expression<Func<TodoModel,bool>> filter =null)
        {
            return _context.Set<TodoModel>().SingleOrDefault(filter);
        }
    }
}
