
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Practices.ServiceLocation;
using Prism.Unity;
using VideoPlayControlServer;
using Prism.Modularity;

namespace VideoPlayControlServer
{
    public class appBootStrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return this.Container.TryResolve<Shell>();
        }
        protected override void ConfigureModuleCatalog()
        {
            ModuleCatalog catalog = this.ModuleCatalog as ModuleCatalog;
			catalog.AddModule(typeof(MainModule));

		}

        protected override void InitializeShell()
        {
            Application.Current.MainWindow = this.Shell as Window;
            Application.Current.MainWindow.Show();
        }
    }
}
