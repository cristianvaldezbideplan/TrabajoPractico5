using AppFakeStore.mvvm.ViewModels;
using AppFakeStore.mvvm.Models;
using AppFakeStore.mvvm.Views;

namespace AppFakeStore.mvvm.Views;

public partial class PerfilesPage : ContentPage
{
    private PerfilViewModel viewModel;

	public PerfilesPage()
	{
        BindingContext = viewModel = new PerfilViewModel();
        InitializeComponent();
	}
    private async void GuardarCambios(object sender, EventArgs e)
    {
        // Navegar a la pagina principal y guarda los cambios
        await Navigation.PushAsync(new MainPage());
    }

}