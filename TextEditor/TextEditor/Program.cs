using Core.DBService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace TextEditor
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

            UnityContainer unityContainer = new UnityContainer();

            unityContainer.RegisterInstance<IUnityContainer>(unityContainer);
            unityContainer.RegisterType(typeof(IRepo<>), typeof(EfRepo<>));
            unityContainer.RegisterType(typeof(IDbService), typeof(EfDbService));

            unityContainer.RegisterType<MainForm>(new ContainerControlledLifetimeManager());
            unityContainer.RegisterType<DownloadFileForm>(new ContainerControlledLifetimeManager());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(unityContainer.Resolve<MainForm>());
        }
    }
}
