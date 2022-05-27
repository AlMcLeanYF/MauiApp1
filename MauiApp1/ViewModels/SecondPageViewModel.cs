using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Models;
using MauiApp1.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    [INotifyPropertyChanged]
    public partial class SecondPageViewModel
    {
        private readonly TestDataService testDataService;
        IConfiguration configuration;

        public SecondPageViewModel(IConfiguration configuration, TestDataService testDataService)
        {
            this.configuration = configuration;
            this.testDataService = testDataService;
        }

        [ObservableProperty]
        //[AlsoNotifyCanExecuteFor(nameof(AddCharacterCommand))]
        private int echoThis = -1;

        [ObservableProperty]
        private String echoResponse = "No response yet";

        public async Task InitializeAsync()
        {
            MessagingCenter.Subscribe<object, int>(App.Current, "NextEchoValue", async (sender, arg) =>
            {
                EchoThis = arg;
            });

            MessagingCenter.Subscribe<object, String>(App.Current, "NextEchoResponse", async (sender, arg) =>
            {
                EchoResponse = arg;
            });
            R = new Random();
        }

        private static Random R;
        //[ICommand(CanExecute = nameof(CanAddCharacter), AllowConcurrentExecutions =false)]
        [ICommand]
        private async Task AddCharacter()
        {
            var settings = configuration.GetRequiredSection("Settings").Get<Settings>();


            var newId = R.Next(1, 2000);
            var newCharacter = await testDataService.GetCharacter(newId);
            Characters.Add(newCharacter);
        }
        private Boolean CanAddCharacter() => echoThis > 50;

        public ObservableCollection<ApiOfIceAndFireCharacter> Characters { get; set; } = new ObservableCollection<ApiOfIceAndFireCharacter>();
    }
}
