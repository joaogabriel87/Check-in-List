using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Check_in_List.Models;
using Check_in_List.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Check_in_List.Controllers
{
    [Route("[controller]")]
    public class TaskController : Controller
    {
        private readonly TaskRepository _repository;

        public TaskController(TaskRepository repository)
        {
            _repository = repository;

        }
       

        public IActionResult Index()
        {
            IEnumerable<TaskModel> AllTask = _repository.GetAllTarefas();
            return View (AllTask);
        }

       public IActionResult Adicionar(TaskModel taskModel)
       {
        _repository.AddTask(taskModel);
        return View();
       }

       public ActionResult<TaskModel> searchId(int id)
       {
        var Task = _repository.BuscarId(id);
        if (Task == null)
        {
            BadRequest();
        }

        return View();
       }

       public IActionResult Atualizar(int id, TaskModel atualizarTask)
       {
        var Tarefaexistente = _repository.Atualizar(id, atualizarTask);
        if (Tarefaexistente == null)
        {
            NotFound();
        }

        return View();
       }

       public IActionResult Delete(int id, TaskModel deleteTask)
       {
        var Tarefaexistente = _repository.Atualizar(id, deleteTask);
        if (Tarefaexistente == null)
        {
            NotFound();
        }

        return View();
       }

        
    }
}