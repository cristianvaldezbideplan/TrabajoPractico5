using AppFakeStore.mvvm.ViewModels;
using AppFakeStore.mvvm.Models;
using AppFakeStore.mvvm.Views;

namespace AppFakeStore.mvvm.Views;

public partial class MisComprasPages : ContentPage
{
	private MisComprasViewModel viewModel;
    public MisComprasPages()
	{
        BindingContext = viewModel = new MisComprasViewModel();

        InitializeComponent();
	}
}