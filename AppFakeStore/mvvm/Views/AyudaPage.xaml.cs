using AppFakeStore.mvvm.ViewModels;
using AppFakeStore.mvvm.Views;
using AppFakeStore.mvvm.Models;

namespace AppFakeStore.mvvm.Views;

public partial class AyudaPage : ContentPage
{
	private AyudaViewModel _viewModel;
	public AyudaPage()
	{
		BindingContext = _viewModel = new AyudaViewModel();
		InitializeComponent();
	}
}