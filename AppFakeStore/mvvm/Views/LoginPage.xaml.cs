using AppFakeStore.mvvm.ViewModels;
using AppFakeStore.mvvm.Views;
using AppFakeStore.mvvm.Models;

namespace AppFakeStore.mvvm.Views;

public partial class LoginPage : ContentPage
{
    private LoginViewModel viewModel;
    public LoginPage()
    {
        BindingContext = viewModel = new LoginViewModel();
        InitializeComponent();
    }
}