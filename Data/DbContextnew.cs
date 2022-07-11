using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sample_crud.Model;

    public class DbContextnew : DbContext
    {
        public DbContextnew (DbContextOptions<DbContextnew> options)
            : base(options)
        {
        }

        public DbSet<sample_crud.Model.Employee> Employee { get; set; }

        public DbSet<sample_crud.Model.Persons> Persons { get; set; }
    }
