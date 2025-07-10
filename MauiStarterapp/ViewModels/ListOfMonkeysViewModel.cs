
using MauiStarterapp.Models;
using MauiStarterapp.Services;
using MauiStarterapp.Views;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MauiStarterapp.ViewModels
{
    public class ListOfMonkeysViewModel : BaseViewModel
    {
        private MonkeyService _monkeyService;

        private List<Monkey> _monkeys;

      
        public ICommand MonkeySelectionChangedCommand { get; set; }

        private Monkey _currentSelectedMonkey;

        public Monkey CurrentSelectedMonkey
        {
            get { return _currentSelectedMonkey; }
            set { _currentSelectedMonkey = value;

               // OnPropertyChanged();
            }
        }


        public List<Monkey> Monkeys
        {
            get => _monkeys;
            set
            {
                _monkeys = value;
                OnPropertyChanged();
            }
        }


        // public List<Monkey> Monkeys { get; set; }

        public ListOfMonkeysViewModel(MonkeyService service)
        {
            _monkeyService = service;

            MonkeySelectionChangedCommand = new Command(NavigateToSingleMonkey);
        }
        public async void Refresh()
        {

            Monkeys = await _monkeyService.GetLocalMonkeys();
        }

        public async void NavigateToSingleMonkey(object param)
        {

            var pageParams = new ShellNavigationQueryParameters()
            {
                { "Monkey", CurrentSelectedMonkey }
            };

            await AppShell.Current.GoToAsync("monkeypage", pageParams);
        }

    }
}
