
using MauiStarterapp.Models;
using MauiStarterapp.ViewModels;

namespace MauiStarterapp.Views;

public partial class SingleMonkeyPage : ContentPage
{
	public SingleMonkeyPage(SingleMonkeyViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
    }
}