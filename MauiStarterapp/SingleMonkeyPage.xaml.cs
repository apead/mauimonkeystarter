
using MauiStarterapp.Models;

namespace MauiStarterapp;

public partial class SingleMonkeyPage : ContentPage
{
	public SingleMonkeyPage(Monkey monkey)
	{
		InitializeComponent();

		BindingContext = monkey;
    }
}