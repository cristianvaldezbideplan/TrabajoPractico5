using AppFakeStore.mvvm.Models;
using AppFakeStore.mvvm.ViewModels;
using AppFakeStore.mvvm.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace AppFakeStore.mvvm.ViewModels;

public partial class ProductoListaViewModel : BaseViewModel
{

    // almacenar y actualizar dinámicamente una lista de elementos en la interfaz de usuario.
    [ObservableProperty] private ObservableCollection<Producto> _productos;

    [ObservableProperty] private bool isRefreshing;

    [ObservableProperty] private Producto _productoSeleccionado;

    public ProductoListaViewModel()
    {   
        //Busca y muestra el titulo que tiene la variable Appname en constants
        Title = Constants.AppName;

        // Para ejecutar el metodo GetProductos()
        Task.Run(async () => { await GetProductos(); }).Wait();
    }

    [RelayCommand]
    private async Task GetProductos()
    {
        IsBusy = IsRefreshing = true;

        var productos = await ApiService.GetProductos();

        if (productos != null)
        {
            Productos = new ObservableCollection<Producto>(productos);
        }

        IsBusy = IsRefreshing = false;
    }


    // En este apartado se dirije a la pantalla Detalle donde tambien se puede modificar el producto
    [RelayCommand]
    private async Task GoToDetalle()
    {
       await Application.Current.MainPage.Navigation.PushAsync(new ProductoDetallePage());        
    }


    // En este apartado se dirije a la pantalla Agregar Producto donde se da de alta un producto.
    [RelayCommand]
    private async Task NuevoProducto()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new CrearProductoPage());
    }

    [RelayCommand]
    private async Task CerrarSesion()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new LoginPage());
    }

}
