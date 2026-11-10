using ViewModels;

namespace Views
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage() : this(new WelcomeViewModel())
        {
        }

        // חיבור ה-ViewModel ל-Binding Context
        public WelcomePage(WelcomeViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
