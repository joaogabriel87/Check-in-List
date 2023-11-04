using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Check_in_List.Models;
using Microsoft.EntityFrameworkCore;

namespace Check_in_List.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        
        }

        public DbSet<TaskModel> Tarefas { get; set; }
    }
}