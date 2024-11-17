using AppFakeStore.mvvm.ViewModels;
using AppFakeStore.mvvm.Models;
using AppFakeStore.mvvm.Views;

namespace AppFakeStore.mvvm.Views;

public partial class MisFavoritosPages : ContentPage
{
	private MisFavoritosViewModel viewModel;
	public MisFavoritosPages()
	{
		BindingContext = viewModel = new MisFavoritosViewModel();
		InitializeComponent();
	}
}