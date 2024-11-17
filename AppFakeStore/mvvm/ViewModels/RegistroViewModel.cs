using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using AppFakeStore.mvvm.Models;
using AppFakeStore.mvvm.ViewModels;
using AppFakeStore.mvvm.Views;

namespace AppFakeStore.mvvm.ViewModels;

public partial class RegistroViewModel : BaseViewModel
{
    public RegistroViewModel()
    {
        Title = Constants.AppName;
    }

    [RelayCommand]
    public async Task PantallaIniciarSesison()
    {
        await Application.Current.MainPage.Navigation.PopAsync();
    }

}
