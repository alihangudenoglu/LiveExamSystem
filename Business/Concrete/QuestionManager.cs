using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class QuestionManager : IQuestionService
    {
        IQuestionDal _questionDal;

        public QuestionManager(IQuestionDal questionDal)
        {
            _questionDal = questionDal;
        }

        public IResult Add(Question entity)
        {
            _questionDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(Question entity)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<Question>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<Question> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(Question entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
