using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfExamDal : EfEntityRepositoryBase<Exam, Context>, IExamDal
    {
        public ExamDetailDto GetExamDetailDto(string kod)
        {
            using (Context context = new Context())
            {
                var result = from exam in context.Exams
                             join question in context.Questions
                             on exam.Id equals question.Id
                             join answer in context.Answers
                             on question.Id equals answer.QuestionId
                             join questionImages in context.QuestionImages
                             on question.Id equals questionImages.QuestionId
                             where exam.ExamKod==kod
                             select new ExamDetailDto
                             {
                                 ExamKod = exam.ExamKod,
                                 StartDateTime = exam.StartDateTime,
                                 EndDateTime = exam.EndDateTime,
                                 Questions = (from i in context.Questions
                                              where i.ExamId == exam.Id
                                              select new Question
                                              {
                                                  Title = i.Title,
                                                  Image=new QuestionImage { ImagePath=i.Image.ImagePath},
                                                  Options=new Answer { OptionOne = i.Options.OptionOne, OptionTwo = i.Options.OptionTwo, OptionThree = i.Options.OptionThree, OptionFour = i.Options.OptionFour,OptionFive = i.Options.OptionFive},
                                                  CorrectAnswer=i.CorrectAnswer
                                                  //Image = from img in context.QuestionImages where img.QuestionId == i.Id select new QuestionImage { ImagePath = img.ImagePath },

                                              }).ToList(),
                                 //ImagePath = (from i in context.CarImages where i.CarId == car.Id select i.ImagePath).ToList(),
                                 //(from i in context.CarImages where i.CarId == car.Id select i.ImagePath).ToList()
                             };
                return result.SingleOrDefault();
            }
        }
    }
}
