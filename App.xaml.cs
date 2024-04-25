namespace TruckEntryApp
{
    public partial class App : Application
    {
        public static AppShell AppShell { get; private set; }
        public static DataBaseModels userDetails;
        public App()
        {   
            InitializeComponent();
            AppShell = new AppShell();
            MainPage = AppShell;
        }
    }
}
