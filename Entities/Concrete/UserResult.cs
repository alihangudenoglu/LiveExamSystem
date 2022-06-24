using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class UserResult:IEntity
    {
        public int Id { get; set; }
        public string ExamKod { get; set; }
        public string Email { get; set; }
        public string Result { get; set; }
    }
}
