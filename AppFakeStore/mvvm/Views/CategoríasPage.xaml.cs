using AppFakeStore.mvvm.ViewModels;
using AppFakeStore.mvvm.Views;
using AppFakeStore.mvvm.Models;

namespace AppFakeStore.mvvm.Views;

public partial class CategoríasPage : ContentPage
{
	private CategoriasViewModel viewModel;

    public CategoríasPage()
	{
		BindingContext = viewModel = new CategoriasViewModel();
		InitializeComponent();
	}
}