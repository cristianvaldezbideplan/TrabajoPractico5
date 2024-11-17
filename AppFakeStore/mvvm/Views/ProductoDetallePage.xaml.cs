using AppFakeStore.mvvm.ViewModels;
using AppFakeStore.mvvm.Models;
using AppFakeStore.mvvm.Views;

namespace AppFakeStore.mvvm.Views;

public partial class ProductoDetallePage : ContentPage
{
	private ProductoDetalleViewModel viewModel;
	public ProductoDetallePage()
	{
        BindingContext = viewModel = new ProductoDetalleViewModel();
        InitializeComponent();
    }
}