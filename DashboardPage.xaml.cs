using TruckEntryApp.ViewModels;
using TruckEntryApp.Services;
namespace TruckEntryApp;

public partial class DashboardPage : ContentPage
{
    public Microsoft.Maui.LineBreakMode LineBreakMode { get; set; }
    public DashboardPage()
	{       
        InitializeComponent();
        var dbContext = new MyDbContext();
        var dataService = new DataService(dbContext);
        var viewModel = new DashboardPageViewModel(dataService);
        viewModel.SearchResults.Clear();
        BindingContext = viewModel;
    }

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }
}