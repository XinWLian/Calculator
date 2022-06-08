using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Calculator.Model;
using Calculator.Stores;

namespace Calculator.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private NavigationStore _navigationStore;
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;
        public ViewModelBase SelectorViewModel { get; }
        public MainViewModel(CalculatorHistory calculations,NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
            SelectorViewModel = new SelectorViewModel(calculations, _navigationStore);
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
