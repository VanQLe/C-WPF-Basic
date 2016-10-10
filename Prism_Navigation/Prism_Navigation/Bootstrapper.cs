using Prism.Unity;
using Prism_Navigation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Practices.Unity;
using Prism_Navigation.ViewModels;

namespace Prism_Navigation
{
    public  class Bootstrapper: UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            Container.RegisterType(typeof(object), typeof(ViewAViewModel));
            Container.RegisterType(typeof(object), typeof(ViewBViewModel));
            Container.RegisterTypeForNavigation<ViewA>("ViewA");
            Container.RegisterTypeForNavigation<ViewB>("ViewB");
        }
    }
}
