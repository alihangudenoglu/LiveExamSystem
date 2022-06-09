using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Question
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        public string Title { get; set; }
        public Answer Options { get; set; }
        public string CorrectAnswer { get; set; }
        public string ImageUrl { get; set; }
    }
}
