﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using AppFakeStore.mvvm.Models;
using AppFakeStore.mvvm.ViewModels;
using AppFakeStore.mvvm.Views;

namespace AppFakeStore.mvvm.ViewModels;

public partial class LoginViewModel : BaseViewModel
{
    public LoginViewModel()
    {
        Title = Constants.AppName;
#if DEBUG
        // solo para Desarrollo - reemplazar por credenciales de prueba
        Email = "cristian@gmail.com";
        password = "cristian";
#endif
    }

    [ObservableProperty] private string email = string.Empty;
    [ObservableProperty] private string password = string.Empty;
    [ObservableProperty] private string message = string.Empty;

    [RelayCommand]
    public async Task LoginAsync2()
    {
        // await Application.Current.MainPage.DisplayAlert("Login", "Login", "Ok");

        await Application.Current.MainPage.Navigation.PushAsync(new ProductoListaPage (new ProductoListaViewModel()));
    }

    [RelayCommand]
    public async Task LoginAsync()
    {
        if (!IsBusy)
        {
            IsBusy = true;

            // asignamos objeto con datos del usuario-establecimiento logueados
            if (Email != string.Empty && Password != String.Empty)
            {
                var apiClient = new ApiService();

                try
                {
                    LoginResponseDto login = await apiClient.ValidarLogin(Email, Password);

                    if (login != null)
                    {

                        // TODO: recuperar datos de usuario login
                        Transport.IdUsuario = login.Id;
                        Transport.RolUsuario = login.IdRol;
                        Transport.EmailUsuario = login.Email;
                        Transport.NombreUsuario = login.Nombre;
                        Transport.Token = login.Token;

                        Application.Current.MainPage = new NavigationPage(new ProductoListaPage(new ProductoListaViewModel()));
                    }
                    else
                    {
                        await Application.Current.MainPage.DisplayAlert("Atención", "Las credenciales ingresadas no son válidas", "Aceptar");
                    }
                }
                catch (Exception ex)
                {
                    await Application.Current.MainPage.DisplayAlert("Atención", "Error de Servidor. Reintente más tarde", "Aceptar");
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Atención", "Las credenciales son Obligatorias. Verifique!", "Aceptar");
            }

            IsBusy = false;
        }
    }

    [RelayCommand]
    public async Task PanantallaRegistrar()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new RegistroPage());
    }

}
