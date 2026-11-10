using ViewModels;

namespace Views
{
    public partial class CalculatorPage : ContentPage
    {
        public CalculatorPage() : this(new CalculatorViewModel())
        {
        }

        // קבלת ה-ViewModel וחיבור ה-Binding Context
        public CalculatorPage(CalculatorViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
