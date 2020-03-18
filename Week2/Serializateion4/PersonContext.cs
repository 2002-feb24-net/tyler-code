using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Serializateion4
    //The context represents the whole database and your ability to inheriet from the DB
{
    class PersonContext : DbContext
    {
        //Thigns you'll need DbSet properties one per table (one per type of data you want to stroe)
        public DbSet<Person> Persons { get; set; }

        //ini order to connect to any databases (or any other kind s of data source
        //we need a connectino string

            //we need the each dbContext instance a connection string..
            //one clumsy hardcoded easy one ins OnConfiging

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source../../..persons.dll";
            optionsBuilder.UseSqlite(connectionString);
        }
    }
}
