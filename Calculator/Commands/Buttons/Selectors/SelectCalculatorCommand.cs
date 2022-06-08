using Calculator.Stores;
using Calculator.ViewModel;
using Calculator.Model;

namespace Calculator.Commands.Buttons.Selectors
{
    public class SelectCalculatorCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        private CalculatorHistory _calculations;
        public SelectCalculatorCommand(CalculatorHistory calculations, NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _calculations = calculations;
        }
        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new CalculatorViewModel(_calculations);
        }
    }
}
