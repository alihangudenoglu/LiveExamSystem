using Core.Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserResultService
    {
        IResult Add(List<string> results, UserResult userResult);
    }
}
