using AppFakeStore.mvvm.ViewModels;
using AppFakeStore.mvvm.Views;
using AppFakeStore.mvvm.Models;

namespace AppFakeStore.mvvm.Views;

public partial class AcercaPage : ContentPage
{
    private AcercaViewModel viewModel;

    public AcercaPage()
	{
        BindingContext = viewModel = new AcercaViewModel();
		InitializeComponent();
	}    

    private void IconBtn_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage.DisplayAlert("Aviso", "Mostramos mensaje Alternativo!", "Aceptar");
    }

    private void BackBtn_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PopAsync();
    }
}