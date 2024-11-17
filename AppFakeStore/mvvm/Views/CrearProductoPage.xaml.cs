using AppFakeStore.mvvm.ViewModels;
using AppFakeStore.mvvm.Views;
using AppFakeStore.mvvm.Models;

namespace AppFakeStore.mvvm.Views;

public partial class CrearProductoPage : ContentPage
{
	private ProductoAgregarViewModel viewModel;
	public CrearProductoPage()
	{
		BindingContext = viewModel = new ProductoAgregarViewModel();
		InitializeComponent();
	}

}