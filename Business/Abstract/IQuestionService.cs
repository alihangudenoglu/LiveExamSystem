﻿using Core.Business.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IQuestionService : IEntityRepositoryService<Question>
    {
    }
}
