using CommunityToolkit.Mvvm.ComponentModel;
using AppFakeStore.mvvm.Views;
using AppFakeStore.mvvm.ViewModels;
using AppFakeStore.mvvm.Models;
using CommunityToolkit.Mvvm.Input;

namespace AppFakeStore.mvvm.ViewModels;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    private bool isBusy;  

    [ObservableProperty]
    private string title = string.Empty;

}
