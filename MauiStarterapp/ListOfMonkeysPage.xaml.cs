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

    private async void MonkeysCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Monkey myMonkey =  e.CurrentSelection[0] as Monkey;

        if (myMonkey != null)
        {
            await Navigation.PushAsync(new SingleMonkeyPage(myMonkey));
        }


    }
}