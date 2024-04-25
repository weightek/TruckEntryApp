
using TruckEntryApp;
using TruckEntryApp.ViewModels;
namespace TruckEntryApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            this.BindingContext = new AppSheelViewsModels();
            InitializeComponent();

            Routing.RegisterRoute(nameof(DashboardPage), typeof(DashboardPage));
            Routing.RegisterRoute(nameof(NewPage1), typeof(NewPage1));
            Routing.RegisterRoute(nameof(Adduser), typeof(Adduser));
        }

        public void UpdateUserRole(string role)
        {
            ((AppSheelViewsModels)BindingContext).UpdateUserRole(role);
        }
    }
}
