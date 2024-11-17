using AppFakeStore.mvvm.ViewModels;
using AppFakeStore.mvvm.Views;
using AppFakeStore.mvvm.Models;

namespace AppFakeStore.mvvm.Views;

public partial class MainPage : ContentPage
{
    private MainViewModel viewModel;
    public MainPage()
    {
        BindingContext = viewModel = new MainViewModel();
        InitializeComponent();
    }

}