namespace AppFakeStore.Views;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private async void PanantallaIniciarSesion(object sender, EventArgs e)
    {
        // Navegar a la pagina principal
        await Navigation.PushAsync(new MainPage());
    }
 
    private async void PanantallaRegistrar(object sender, EventArgs e)
    {
        // Navegar a la pastalla Registrar
        await Navigation.PushAsync(new Registro());
    }
}