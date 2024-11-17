using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using AppFakeStore.mvvm.Models;
using AppFakeStore.mvvm.ViewModels;
using AppFakeStore.mvvm.Views;

namespace AppFakeStore.mvvm.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    public MainViewModel()
    {
        Title = Constants.AppName;
    }

    [RelayCommand]
    public async Task GoToProductoLista()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new ProductoListaPage(new ProductoListaViewModel()));
    }

    [RelayCommand]
    public async Task GoToAcerca()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new AcercaPage());
    }

    [RelayCommand]
    public async Task Categorías()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new CategoríasPage());
    }

    [RelayCommand]
    public async Task MisFavoritos()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new MisFavoritosPages());
    }

    [RelayCommand]
    public async Task MisCompras()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new MisComprasPages());
    }

    [RelayCommand]
    public async Task CarritoDeCompras()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new CarritoDeCompraPages());
    }

    [RelayCommand]
    public async Task Perfil()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new PerfilesPage());
    }

    [RelayCommand]
    public async Task Ayuda()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new AyudaPage());
    }

    [RelayCommand]
    public async Task Exit()
    {

        if (await App.Current.MainPage.DisplayAlert("Salir", "¿Desea terminar la sesión y salir?", "Aceptar", "Cancelar"))
        {
            Application.Current.Quit();
        }
    }
}
