using AppFakeStore.mvvm.ViewModels;
using AppFakeStore.mvvm.Models;
using AppFakeStore.mvvm.Views;

namespace AppFakeStore.mvvm.Views;

public partial class RegistroPage : ContentPage
{
    private RegistroViewModel viewModel;
	public RegistroPage()
	{
        BindingContext = viewModel = new RegistroViewModel();
        InitializeComponent();
	}
}