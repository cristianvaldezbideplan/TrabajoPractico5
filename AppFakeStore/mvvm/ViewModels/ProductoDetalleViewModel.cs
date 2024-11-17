using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using AppFakeStore.mvvm.Models;
using AppFakeStore.mvvm.ViewModels;
using AppFakeStore.mvvm.Views;
using System.Collections.ObjectModel;

namespace AppFakeStore.mvvm.ViewModels;

public partial class ProductoDetalleViewModel : BaseViewModel
{

    //En este apartado de muestra los Detalles del Producto y se Modifica el producto tambien.


    [ObservableProperty]
    Producto producto;

    public ProductoDetalleViewModel()
    {
        Title = Constants.AppName;
    }

    //Navegar a la Pantalla anterior, y sacar de la pila la actual.
    [RelayCommand]
    private async Task GoBack()
    {
        await Application.Current.MainPage.Navigation.PopAsync();
    }

    [RelayCommand]
    public async Task GoPantallaModificar()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new ProductoModificarPage());
    }
}
