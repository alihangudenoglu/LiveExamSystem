using Core.Entities;

namespace Entities.Concrete
{
    public class QuestionImage:IEntity
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string? ImagePath { get; set; }

        public Question  Question { get; set; }
    }
}
