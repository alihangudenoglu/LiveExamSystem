using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Question:IEntity
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        public string Title { get; set; }
        public Answer Options { get; set; }
        public string CorrectAnswer { get; set; }

        public QuestionImage Image { get; set; }
        public Exam Exam { get; set; }
    }
}
