using System;
using System.Windows;

namespace SimpleDesktopApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            SimpleDesktopAppBootstrapper bootstrapper = new SimpleDesktopAppBootstrapper();
            bootstrapper.Run();
        }
    }
}
