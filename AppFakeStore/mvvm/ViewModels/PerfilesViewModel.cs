using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using AppFakeStore.mvvm.Models;
using AppFakeStore.mvvm.ViewModels;
using AppFakeStore.mvvm.Views;

namespace AppFakeStore.mvvm.ViewModels;

public partial class PerfilViewModel : BaseViewModel
{
    public PerfilViewModel()
    {
        Title = Constants.AppName;
    }
}
