using TruckEntryApp.ViewModels;
using TruckEntryApp.Services;
namespace TruckEntryApp;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
    	InitializeComponent();
        // Initialize your view model with the required dependencies
        var dbContext = new MyDbContext();
        var userService = new UserService(dbContext); // Assuming UserService has a parameterless constructor
        BindingContext = new LoginPageViewsModel(userService);
    }
}