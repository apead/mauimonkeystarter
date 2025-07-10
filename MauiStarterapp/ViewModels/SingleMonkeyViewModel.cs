using Java.Time;
using MauiStarterapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiStarterapp.ViewModels
{
    [QueryProperty(nameof(Monkey), "Monkey")]
    public class SingleMonkeyViewModel : BaseViewModel
    {

        private Monkey _monkey;

        public Monkey Monkey
        {
            get { return _monkey; }
            set { _monkey = value;

                OnPropertyChanged();
            }
        }



        public SingleMonkeyViewModel()
        {

        }


    }
}
