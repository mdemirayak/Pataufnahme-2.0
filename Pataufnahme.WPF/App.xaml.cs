using Pataufnahme.WPF.ViewModels;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Pataufnahme.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /*protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow main = new MainWindow()
            {
                DataContext = new MainViewModel()
            };
            main.Show();
            base.OnStartup(e);

        }*/


        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.DataContext = new MainViewModel();
            main.Show();
            base.OnStartup(e);

        }

    }

}
