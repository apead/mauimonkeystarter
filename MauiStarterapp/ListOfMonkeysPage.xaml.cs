using MauiStarterapp.Models;
using MauiStarterapp.Services;

namespace MauiStarterapp;

public partial class ListOfMonkeysPage : ContentPage
{
    public List<Monkey> Monkeys { get; set; }

    public ListOfMonkeysPage()
	{
		InitializeComponent();

		

	//	BindingContext
	}

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        MonkeyService monkeyService = new MonkeyService();

        Monkeys = await monkeyService.GetLocalMonkeys();
        //MonkeysCollectionView.ItemsSource = Monkeys;
        BindingContext = this;

    }
}