using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using AppFakeStore.mvvm.Models;
using AppFakeStore.mvvm.ViewModels;
using AppFakeStore.mvvm.Views;
using System.Collections.ObjectModel;

namespace AppFakeStore.mvvm.ViewModels;

public partial class ProductoModificarViewModel : BaseViewModel
{
    public ProductoModificarViewModel()
    {
        Title = Constants.AppName;
    }

    [RelayCommand]
    private async Task Cancelar()
    {
        await Application.Current.MainPage.Navigation.PopAsync();
    }

    [RelayCommand]
    private async Task Grabar()
    {
        await Application.Current.MainPage.DisplayAlert("Producto", "Producto modificado", "Aceptar");
    }

}
