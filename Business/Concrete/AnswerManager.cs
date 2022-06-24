using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class AnswerManager : IAnswerService
    {
        IAnswerDal _answerDal;

        public AnswerManager(IAnswerDal answerDal)
        {
            _answerDal = answerDal;
        }

        public IResult Add(Answer entity)
        {
            _answerDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(Answer entity)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<Answer>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<Answer> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(Answer entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
