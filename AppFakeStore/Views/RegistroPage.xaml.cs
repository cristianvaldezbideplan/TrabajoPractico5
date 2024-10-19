namespace AppFakeStore.Views;

public partial class Registro : ContentPage
{
	public Registro()
	{
        InitializeComponent();
	}

    private async void PantallaIniciarSesison(object sender, EventArgs e)
    {
        // Navegar a la pagina principal
        await Navigation.PushAsync(new Login());
    }

}