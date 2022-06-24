using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            optionsBuilder.UseSqlServer(@"server=DESKTOP-TFH3P0O;database=ExamDb; integrated security=true;");
        }

        public DbSet<Exam> Exams { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionImage> QuestionImages { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<UserResult> UserResults { get; set; }

    }
}
