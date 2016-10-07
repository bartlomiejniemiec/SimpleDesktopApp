using SimpleDesktopApp.Infrastructure.Concrete.Mvvm;
using SimpleDesktopApp.ViewModels;

namespace SimpleDesktopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Shell : BaseWindowView
    {
        public Shell(IShellViewModel shellViewModel) : base(shellViewModel)
        {
            InitializeComponent();
        }
    }
}
