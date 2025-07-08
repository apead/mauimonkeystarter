
using MauiStarterapp.Models;
using MauiStarterapp.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiStarterapp.ViewModels
{
    public class ListOfMonkeysViewModel : BaseViewModel
    {
        private MonkeyService _monkeyService;

        private List<Monkey> _monkeys;
        
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
        }
        public async void Refresh()
        {

            Monkeys = await _monkeyService.GetLocalMonkeys();
        }


    }
}
