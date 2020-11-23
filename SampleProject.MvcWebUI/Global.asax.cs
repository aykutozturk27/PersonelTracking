using FluentValidation.Mvc;
using SampleProject.Business.DependencyResolvers.Ninject;
using SampleProject.Core.CrossCuttingConcerns.Validation.FluentValidation;
using SampleProject.Core.Utilities.Mvc.Infrastructure;
using SampleProject.MvcWebUI.App_Start;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SampleProject.MvcWebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory(new BusinessModule(), new AutoMapperModule()));
            FluentValidationModelValidatorProvider.Configure(provider =>
            {
                provider.ValidatorFactory = new NinjectValidationFactory(new ValidationModule());
            });
        }
    }
}