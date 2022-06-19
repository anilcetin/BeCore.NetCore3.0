using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<CertificateManager>().As<ICertificateService>();
            builder.RegisterType<EfCertificateDal>().As<ICertificateDal>();

            builder.RegisterType<ContactManager>().As<IContactService>();
            builder.RegisterType<EfContactDal>().As<IContactDal>();

            builder.RegisterType<ContentManager>().As<IContentService>();
            builder.RegisterType<EfContentDal>().As<IContentDal>();

            builder.RegisterType<KnowledgeManager>().As<IKnowledgeService>();
            builder.RegisterType<EfKnowledgeDal>().As<IKnowledgeDal>();

            builder.RegisterType<EducationManager>().As<IEducationService>();
            builder.RegisterType<EfEducationDal>().As<IEducationDal>();

            builder.RegisterType<PortfolioManager>().As<IPortfolioService>();
            builder.RegisterType<EfPortfolioDal>().As<IPortfolioDal>();

            builder.RegisterType<SkillManager>().As<ISkillService>();
            builder.RegisterType<EfSkillDal>().As<ISkillDal>();

            builder.RegisterType<SocialManager>().As<ISocialService>();
            builder.RegisterType<EfSocialDal>().As<ISocialDal>();

            builder.RegisterType<TitleManager>().As<ITitleService>();
            builder.RegisterType<EfTitleDal>().As<ITitleDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
