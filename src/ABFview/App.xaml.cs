using System.Windows;

namespace ABFview
{
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow window = new();

            if (e.Args.Length == 1)
                window.LoadAbf(e.Args[0]);

            window.Show();
        }
    }
}



