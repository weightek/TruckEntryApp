using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckEntryApp.ViewModels;

namespace TruckEntryApp
{
    public class MyDbContext : DbContext
    {
        public string ServerName()
        {
            string path = $@"D:\TruckEntryApp\TruckEntryApp\Services\Server.txt";
            string serverName = string.Empty;
            if(File.Exists(path))
            {
                serverName = File.ReadAllText(path).Trim();
            }
            else
            {
                App.Current.MainPage.DisplayAlert("File Error","File is missing","OK");
            }
            return serverName;
        }

        public DbSet<DataBaseModels> DataBaseModels { get; set; }
        public DbSet<Data> Data { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string sName = ServerName();
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = $@"Server={sName};Database=TruckEntry;User=sa;Password=123;TrustServerCertificate=true";

                optionsBuilder.UseSqlServer(connectionString);
            }
            else
            {
                base.OnConfiguring(optionsBuilder);
            }
        }
    }
}
