using System.Windows.Input;

namespace ViewModels
{
    public class WelcomeViewModel : BaseViewModel
    {
        public ICommand GoToCalcAgeCommand { get; }
        public ICommand GoToCalculatorCommand { get; }

        public WelcomeViewModel()
        {
            Title = "ברוך הבא";
            GoToCalcAgeCommand = new Command(async () => await Shell.Current.GoToAsync("//CalcAge"));
            GoToCalculatorCommand = new Command(async () => await Shell.Current.GoToAsync("//CalculatorPage"));
        }
    }
}
