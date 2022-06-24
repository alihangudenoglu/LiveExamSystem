using Business.Abstract;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserResultManager : IUserResultService
    {
        IUserResultDal _userResultDal;
        IExamService _examService;

        public UserResultManager(IUserResultDal userResultDal, IExamService examService)
        {
            _userResultDal = userResultDal;
            _examService = examService;
        }

        public IResult Add(List<string> results, UserResult userResult)
        {
            int correctAnswer=0;
            var snc = _examService.GetByExamDetails(userResult.ExamKod);
            for (int i = 0; i < snc.Data.Questions.Count; i++)
            {
                for (int j = 0; j < results.Count; j++)
                {
                    if (snc.Data.Questions[i].CorrectAnswer==results[j])
                    {
                        correctAnswer++;
                    }
                }
            }

            for (int i = 0; i < results.Count; i++)
            {



                userResult.Id = 0;
                userResult.Result = results[i];
                _userResultDal.Add(userResult);
            }

            MailSend.Microsoft(userResult.Email, userResult.ExamKod + " Kodlu Sınavın Sonucu", correctAnswer + " Doğru cevabınız var");
            return new SuccessResult();
        }
    }
}
