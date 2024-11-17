﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using AppFakeStore.mvvm.Models;
using AppFakeStore.mvvm.ViewModels;
using AppFakeStore.mvvm.Views;

namespace AppFakeStore.mvvm.ViewModels;

public partial class AyudaViewModel : BaseViewModel
{
    public AyudaViewModel()
    {
        Title = Constants.AppName;
    }
}
