using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ExamManager>().As<IExamService>().SingleInstance();
            builder.RegisterType<EfExamDal>().As<IExamDal>().SingleInstance();
            builder.RegisterType<AnswerManager>().As<IAnswerService>().SingleInstance();
            builder.RegisterType<EfAnswerDal>().As<IAnswerDal>().SingleInstance();
            builder.RegisterType<QuestionManager>().As<IQuestionService>().SingleInstance();
            builder.RegisterType<EfQuestionDal>().As<IQuestionDal>().SingleInstance();
            builder.RegisterType<QuestionImageManager>().As<IQuestionImageService>().SingleInstance();
            builder.RegisterType<EfQuestionImageDal>().As<IQuestionImageDal>().SingleInstance();
            builder.RegisterType<UserResultManager>().As<IUserResultService>().SingleInstance();
            builder.RegisterType<EfUserResultDal>().As<IUserResultDal>().SingleInstance();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
