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


        IEnumerable<TaskModel> GetAllTarefas()
        {
            return _context.Tarefas.ToList();
        }

         void AddTask (TaskModel taskModel)
        {
            _context.Tarefas.Add(taskModel);
            _context.SaveChanges();
        }

        TaskModel BuscarId (int id)
        {
           return _context.Tarefas.Find(id);
        } 

        void Atualizar(TaskModel atualizarTask)
        {
            var Tarefaexistente = _context.Tarefas.Find(atualizarTask.Id);
            Tarefaexistente.Name = atualizarTask.Name;
            Tarefaexistente.DateCreate = atualizarTask.DateCreate;
            Tarefaexistente.DateCompletion = atualizarTask.DateCompletion;
            Tarefaexistente.IsCompleted = atualizarTask.IsCompleted;

            _context.SaveChanges();

            
        }

        void Delete(TaskModel taskModel )
        {
            _context.Tarefas.Remove(taskModel);
            _context.SaveChanges();
        }
}
}
}