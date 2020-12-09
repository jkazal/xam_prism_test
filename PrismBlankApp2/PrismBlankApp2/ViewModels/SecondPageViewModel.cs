using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismBlankApp2.ViewModels
{
    public class SecondPageViewModel : ViewModelBase
    {
        private string _bText = "";
        public string BText
        {
            get => _bText;
            set => SetProperty(ref _bText, value);
        }
        public SecondPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Second Page";
        }
    }
}
