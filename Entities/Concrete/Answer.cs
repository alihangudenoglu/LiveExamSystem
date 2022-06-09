using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Answer
    {
        public int Id { get; set; }
        public Question QuestionId { get; set; }
        public string OptionOne { get; set; }
        public string OptionTwo { get; set; }
        public string OptionThree { get; set; }
        public string OptionFour { get; set; }
    }
}
