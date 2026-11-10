using System.Windows.Input;

namespace ViewModels
{
    public class CalculatorViewModel : BaseViewModel
    {
        private string _number1 = string.Empty;
        private string _number2 = string.Empty;
        private string _result = "0";

        public string Number1
        {
            get => _number1;
            set
            {
                if (_number1 != value)
                {
                    _number1 = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Number2
        {
            get => _number2;
            set
            {
                if (_number2 != value)
                {
                    _number2 = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Result
        {
            get => _result;
            set
            {
                if (_result != value)
                {
                    _result = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand AddCommand { get; }
        public ICommand SubtractCommand { get; }
        public ICommand MultiplyCommand { get; }
        public ICommand DivideCommand { get; }

        public CalculatorViewModel()
        {
            Title = "מחשבון";
            AddCommand = new Command(async () => await ComputeAsync("+"));
            SubtractCommand = new Command(async () => await ComputeAsync("-"));
            MultiplyCommand = new Command(async () => await ComputeAsync("*"));
            DivideCommand = new Command(async () => await ComputeAsync("/"));
        }

        private async Task ComputeAsync(string op)
        {
            if (!double.TryParse(Number1, out double num1) || !double.TryParse(Number2, out double num2))
            {
                await ShowAlertAsync("קלט לא תקין", "אנא הכנס מספרים תקינים בשתי התיבות", "אישור");
                return;
            }

            if (op == "/" && num2 == 0)
            {
                await ShowAlertAsync("שגיאה", "לא ניתן לחלק באפס!", "אישור");
                Result = "שגיאה";
                return;
            }

            double result = op switch
            {
                "+" => num1 + num2,
                "-" => num1 - num2,
                "*" => num1 * num2,
                "/" => num1 / num2,
                _ => 0
            };
            Result = result.ToString();
        }
    }
}
