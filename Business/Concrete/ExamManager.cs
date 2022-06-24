using Business.Abstract;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Business.Concrete
{
    public class ExamManager : IExamService
    {
        IExamDal _examDal;
        IAnswerService _answerService;
        IQuestionService _questionService;
        IQuestionImageService _questionImageService;

        public ExamManager(IExamDal examDal, IAnswerService answerService, IQuestionService questionService, IQuestionImageService questionImageService)
        {
            _examDal = examDal;
            _answerService = answerService;
            _questionImageService = questionImageService;
            _questionService = questionService;
        }

        
        public IResult Add(List<IFormFile> formFile, Exam entity)
        {
            entity.ExamKod = Guid.NewGuid().ToString("N");
            _examDal.Add(entity);
            
            for (int i = 0; i < entity.Questions.Count; i++)
            {
                entity.Questions[i].ExamId = entity.Id;
                _questionService.Add(entity.Questions[i]);

                entity.Questions[i].Options.QuestionId = entity.Questions[i].Id;
                _answerService.Add(entity.Questions[i].Options);

                QuestionImage questionImage = new QuestionImage();
                questionImage.QuestionId = entity.Questions[i].Id;
                questionImage.ImagePath = FileHelper.Add(formFile[i]);
                _questionImageService.Add(questionImage);
            }
            return new SuccessResult("Sınav Ekleme Başarılı");
            

        }

        public IDataResult<Exam> GetAll(string kod)
        {
            var result=_examDal.GetAll(x => x.ExamKod == kod).FirstOrDefault();
            return new SuccessDataResult<Exam>(result);
        }

        public IDataResult<ExamDetailDto> GetByExamDetails(string kod)
        {
            
            return new SuccessDataResult<ExamDetailDto>(_examDal.GetExamDetailDto(kod));
        }
    }
}
