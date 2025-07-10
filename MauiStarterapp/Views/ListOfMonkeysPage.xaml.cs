using MauiStarterapp.Models;
using MauiStarterapp.Services;
using MauiStarterapp.ViewModels;
using System.Linq;

namespace MauiStarterapp.Views;

public partial class ListOfMonkeysPage : ContentPage
{
   

    public ListOfMonkeysPage(ListOfMonkeysViewModel vm)
	{
		InitializeComponent();

        BindingContext = vm;
	}

    protected async override void OnAppearing()
    {
      //  base.OnAppearing();
       
        ListOfMonkeysViewModel viewModel = BindingContext as ListOfMonkeysViewModel;

        viewModel.Refresh();

        MonkeysCollectionView.SelectedItem = null;
    }

 

    /*private async void MonkeysCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      /*  Monkey myMonkey = MonkeysCollectionView.SelectedItem as Monkey; //e.CurrentSelection[0] as Monkey;

        if (myMonkey != null)
        {
            await Navigation.PushAsync(new SingleMonkeyPage(myMonkey));
        }
      
      
    }*/
}