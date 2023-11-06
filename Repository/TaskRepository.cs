using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Check_in_List.Data;
using Check_in_List.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Check_in_List.Repository
{
    public class TaskRepository
    {
        private readonly ApplicationDbContext _context;

        public TaskRepository(ApplicationDbContext context)
        {
            _context = context;
        }


         public IEnumerable<TaskModel> GetAllTarefas()
        {
            return _context.Tarefas.ToList();
        }

          public void AddTask (TaskModel taskModel)
        {
            _context.Tarefas.Add(taskModel);
             _context.SaveChanges();
              

            
        }

        public TaskModel BuscarId (int id)
        {
           return _context.Tarefas.Find(id);
        } 

        public TaskModel Atualizar(int id, TaskModel atualizarTask)
        {
            var Tarefaexistente = _context.Tarefas.FirstOrDefault(x=>x.Id == id);
            Tarefaexistente.Name = atualizarTask.Name;
            Tarefaexistente.DateCreate = atualizarTask.DateCreate;
            Tarefaexistente.DateCompletion = atualizarTask.DateCompletion;
            Tarefaexistente.IsCompleted = atualizarTask.IsCompleted;

            _context.Update(Tarefaexistente);
            _context.SaveChanges();
            return Tarefaexistente;

            
        }

        public TaskModel Delete(int id, TaskModel taskModel )
        {
            var Tarefaexistente = _context.Tarefas.FirstOrDefault(x=>x.Id == id);
            _context.Tarefas.Remove(taskModel);
            _context.SaveChanges();
            return Tarefaexistente;
        }
}
}
