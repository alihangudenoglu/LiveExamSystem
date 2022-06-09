using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Exam
    {
        public int Id { get; set; }
        public string ExamKod { get; set; }
        public List<Question> Questions { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
    }
}
