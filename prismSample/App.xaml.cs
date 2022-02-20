using Prism.Ioc;
using prismSample.ViewModels;
using prismSample.Views;
using System.Windows;

namespace prismSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA>();
            containerRegistry.RegisterForNavigation<ViewB>();
            containerRegistry.RegisterDialog<ViewC, ViewCViewModel>();
            containerRegistry.RegisterDialog<MessageBoxView, MessageBoxViewViewModel>();
        }
    }
}
