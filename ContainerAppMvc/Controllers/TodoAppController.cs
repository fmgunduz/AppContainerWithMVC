using ContainerAppMvc.DataAccess.TodoApp;
using ContainerAppMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ContainerAppMvc.Controllers
{
    public class TodoAppController : Controller
    {
        private readonly ITodoAppDal _todoAppDal; 
        public TodoAppController(ITodoAppDal todoAppDal)
        {
            _todoAppDal = todoAppDal;
        }
        public IActionResult Index()
        {
            var todoList = GetAll();
            return View(todoList);
        }
        public IActionResult Add(TodoModel todoModel)
        {
            if (todoModel.TodoContent.Length>0)
            {
                _todoAppDal.Add(todoModel);
                return Ok(todoModel);
            }
            return BadRequest(todoModel);   
        }
        public IActionResult Delete(TodoModel todoModel)
        {
            _todoAppDal.Delete(todoModel);
            return Ok(todoModel);
        }
        public IActionResult Update(TodoModel todoModel)
        {
            var entityToUpdate = _todoAppDal.Get(t => t.Id == todoModel.Id);
            entityToUpdate.IsDone = !entityToUpdate.IsDone;
            _todoAppDal.Update(entityToUpdate);
            return Ok(todoModel);
        }
        public List<TodoModel> GetAll()
        {
            return _todoAppDal.GetAll().ToList();

        }



    }
}
