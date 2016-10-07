using Prism.Unity;
using SimpleDesktopApp.ViewModels;
using System.Windows;
using Microsoft.Practices.Unity;

namespace SimpleDesktopApp
{
    class SimpleDesktopAppBootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            Container.RegisterType<IShellViewModel, ShellViewModel>();

            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            Application.Current.MainWindow = (Window)Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
        }
        
    }
}
