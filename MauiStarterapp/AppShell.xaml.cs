
using MauiStarterapp.Views;

namespace MauiStarterapp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute("monkeypage", typeof(SingleMonkeyPage));
        }
    }
}
