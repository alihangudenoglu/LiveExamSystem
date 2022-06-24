using Core.Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IExamService
    {
        IDataResult<ExamDetailDto> GetByExamDetails(string kod);
        //IDataResult<List<T>> GetAll();
        IResult Add(List<IFormFile> formFile, Exam entity);
        IDataResult<Exam> GetAll(string kod);
    }
}
