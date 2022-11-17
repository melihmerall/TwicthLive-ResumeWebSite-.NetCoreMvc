using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace Business.Utilities.DependencyResolves.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AboutManager>().As<IAboutService>();
            builder.RegisterType<EfAboutDal>().As<IAboutDal>();

            builder.RegisterType<EducationManager>().As<IEducationService>();
            builder.RegisterType<EfEducationDal>().As<IEducationDal>();

            builder.RegisterType<ExperienceManager>().As<IExperienceService>();
            builder.RegisterType<EfExperienceDal>().As<IExperienceDal>();

            builder.RegisterType<HobbyManager>().As<IHobbyService>();
            builder.RegisterType<EfHobbyDal>().As<IHobbyDal>();

            builder.RegisterType<LanguageManager>().As<ILanguageService>();
            builder.RegisterType<EfLanguageDal>().As<ILanguageDal>();

            builder.RegisterType<PortfolioManager>().As<IPortfolioService>();
            builder.RegisterType<EfPortfolioDal>().As<IPortfolioDal>();

            builder.RegisterType<ResumeManager>().As<IResumeService>();
            builder.RegisterType<EfResumeDal>().As<IResumeDal>();

            builder.RegisterType<SocialManager>().As<ISocialService>();
            builder.RegisterType<EfSocialDal>().As<EfSocialDal>();

            builder.RegisterType<TalentManager>().As<ITalentService>();
            builder.RegisterType<EfTalentDal>().As<ITalentDal>();

            builder.RegisterType<ReferenceManager>().As<IReferenceService>();
            builder.RegisterType<EfReferenceDal>().As<IReferenceDal>();



        }
    }
}
