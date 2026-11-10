

namespace ViewModels
{
    public class SimpleViewModel:BaseViewModel
    {
        // מאפיין לדוגמה שתרצה להציג ב-XAML
        private string _myCustomProperty = "שלום מהקוד מאחור!";

        public string MyCustomProperty
        {
            get => _myCustomProperty;
            set
            {
                if (_myCustomProperty != value)
                {
                    _myCustomProperty = value;
                    // שולח התראה ל-XAML שהערך השתנה
                    OnPropertyChanged();
                }
            }
        }
        public SimpleViewModel()
        {
            Title = "דף פשוט";
            MyCustomProperty = "שלום עדכון מהקוד מאחור Binding MyCustomProperty!";
        }
    }
}
