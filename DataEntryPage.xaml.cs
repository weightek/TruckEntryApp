using TruckEntryApp.ViewModels;
using TruckEntryApp.Services;

namespace TruckEntryApp;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
        var dbcontext = new MyDbContext();
        var dataService = new DataService(dbcontext);
        BindingContext = new DataEntryPageViewModel(dataService);
    }
}