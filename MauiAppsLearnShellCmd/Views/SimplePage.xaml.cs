using ViewModels;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Views;

// **For Binding property to the lable Text to XAML (Code Behind of the XAML)
// 1.Implement the INotifyPropertyChanged interface (interface) to notify the XAML when a property value changes
// (public partial class SimplePage : ContentPage, INotifyPropertyChanged)
// 2. Define Filed and Property for MyCustomProperty (in code behind) for Binding to XAML 
// 3. Define the constructor to set the BindingContext
// 4. BindingContext = this; // Set the BindingContext to the current instance of the page (this) so that the XAML can access the properties defined in the code behind
// 5. Set Bindings in XAML to the Property defined in code behind
// {Binding MyCustomProperty} in XAML will bind to the MyCustomProperty defined in code behind

// **For Binding property to the lable Text to XAML (MVVM)
// 1. Create a ViewModel class (SimpleViewModel) that inerhit from BaseViewModel (which implements INotifyPropertyChanged) and define the property (MyCustomProperty) in the ViewModel class
// 2. In the XMAL ContentPage, set link to the ViewModel class (SimpleViewModel)
// xmlns:vm="clr-namespace:ViewModels"
// x:DataType="vm:SimpleViewModel"
// 3. Set a Constructor injection to the ViewModel class in the SimplePage Code Behind
// 4. Set the BindingContext to the ViewModel instance in the SimplePage Code Behind (In the constructor)
// BindingContext = viewModel;
// 5. Define the Filed and Property for MyCustomProperty (in ViewModel) for Binding to XAML
// 6. Set Bindings in XAML to the Property defined in ViewModel
// {Binding MyCustomProperty} in XAML will bind to the MyCustomProperty defined in ViewModel


//public partial class SimplePage : ContentPage, INotifyPropertyChanged
public partial class SimplePage : ContentPage
{

    //// מאפיין לדוגמה שתרצה להציג ב-XAML
    //private string _myCustomProperty = "שלום מהקוד מאחור!";

    //public string MyCustomProperty
    //{
    //    get => _myCustomProperty;
    //    set
    //    {
    //        if (_myCustomProperty != value)
    //        {
    //            _myCustomProperty = value;
    //            // שולח התראה ל-XAML שהערך השתנה
    //            OnPropertyChanged();
    //        }
    //    }
    //}

    //public SimplePage()
    //{
    //    InitializeComponent();
    //    //BindingContext = this;
    //    //MyCustomProperty = "שלום עדכון מהקוד מאחור Binding MyCustomProperty!";
    //    //MyLabel.Text = "x:name שלום עדכון מהקוד מאחור!";
    //}


    public SimplePage() : this(new SimpleViewModel())
    {


    }
    public SimplePage(SimpleViewModel viewModel)
    {
        InitializeComponent();
        // הגדרת הדף הנוכחי כמקור המידע עבור ה-XAML
        //BindingContext = this;
        BindingContext = viewModel;
    }
}