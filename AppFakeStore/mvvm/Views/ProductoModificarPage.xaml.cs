using AppFakeStore.mvvm.ViewModels;

namespace AppFakeStore.mvvm.Views;

public partial class ProductoModificarPage : ContentPage
{
    private ProductoModificarViewModel viewModel;

    public ProductoModificarPage()
	{
		BindingContext = viewModel = new ProductoModificarViewModel();
		InitializeComponent();
	}
}