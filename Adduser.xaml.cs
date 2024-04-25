using TruckEntryApp.Services;
using TruckEntryApp.ViewModels;

namespace TruckEntryApp;

public partial class Adduser : ContentPage
{
	public Adduser()
	{
		InitializeComponent();
        var dbcontext = new MyDbContext();
        var dataService = new DataService(dbcontext);
        BindingContext = new AdduserPageViewModel(dataService);
    }
}