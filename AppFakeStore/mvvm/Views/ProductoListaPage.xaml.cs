using AppFakeStore.mvvm.ViewModels;
using AppFakeStore.mvvm.Models;
using AppFakeStore.mvvm.Views;

namespace AppFakeStore.mvvm.Views;

public partial class ProductoListaPage : ContentPage
{
    

    public ProductoListaPage(ProductoListaViewModel _viewModel)
	{
        BindingContext = _viewModel;
        InitializeComponent();

    }
}