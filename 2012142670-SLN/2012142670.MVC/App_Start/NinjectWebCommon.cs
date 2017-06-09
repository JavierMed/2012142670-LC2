[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(_2012142670.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(_2012142670.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace _2012142670.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using _2012142670_ENT.IRepositories;
    using _2012142670_PER.Repositories;
    using _2012142670_PER;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IUnityOfWork>().To<UnityOfWork>();
            kernel.Bind<_2012142670DBContext>().To<_2012142670DBContext>();

            kernel.Bind<ICentroAtencion>().To<CentroAtencionRepository>();
            kernel.Bind<ICliente>().To<ClienteRepository>();
            kernel.Bind<IContrato>().To<ContratoRepository>();
            kernel.Bind<IDepartamento>().To<DepartamentoRepository>();
            kernel.Bind<IDistrito>().To<DistritoRepository>();
            kernel.Bind<IEquipoCelular>().To<EquipoCelularRepository>();
            kernel.Bind<IEvaluacion>().To<EvaluacionRepository>();
            kernel.Bind<ILineaTelefonica>().To<LineaTelefonicaRepository>();
            kernel.Bind<IPlan>().To<PlanRepository>();
            kernel.Bind<IProvincia>().To<ProvinciaRepository>();
            kernel.Bind<ITrabajador>().To<TrabajadorRepository>();
            kernel.Bind<IUbigeo>().To<UbigeoRepository>();
            kernel.Bind<IVenta>().To<VentaRepository>();

        }
    }
}
