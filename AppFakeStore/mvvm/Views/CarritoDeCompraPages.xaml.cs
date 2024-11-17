using AppFakeStore.mvvm.ViewModels;
using AppFakeStore.mvvm.Views;
using AppFakeStore.mvvm.Models;

namespace AppFakeStore.mvvm.Views;

public partial class CarritoDeCompraPages : ContentPage
{
	private CarritoDeComprasViewModel viewModel;
	public CarritoDeCompraPages()
	{
        BindingContext = viewModel = new CarritoDeComprasViewModel();
        InitializeComponent();
	}
}