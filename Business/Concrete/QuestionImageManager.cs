using Business.Abstract;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class QuestionImageManager : IQuestionImageService
    {
        IQuestionImageDal _questionImageDal;

        public QuestionImageManager(IQuestionImageDal questionImageDal)
        {
            _questionImageDal = questionImageDal;
        }

        public IResult Add(QuestionImage entity)
        {
            //entity.ImagePath=FileHelper.Add()
            _questionImageDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(QuestionImage entity)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<QuestionImage>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<QuestionImage> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(QuestionImage entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
