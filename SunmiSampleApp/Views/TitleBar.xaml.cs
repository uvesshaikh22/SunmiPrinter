using SunmiPOSLib;

namespace SunmiSampleApp.Views;

public partial class TitleBar : StackLayout
{
    public string Subtitle { get; }
    ///<summary>
    ///Creates a Titlebar element's own property that can be used and changed
    ///directly in the xaml file where the Titlebar element is used
    ///</summary>
    public static readonly BindableProperty TitleProperty = BindableProperty.Create(
        nameof(TitleText),
        typeof(string),
        typeof(TitleBar),
        defaultValue: "Título",
        defaultBindingMode: BindingMode.OneWay,
        propertyChanged: TitleTextPropertyChanged);
    /// <summary>
    /// Performs the new property changes on the target element
    /// </summary>
    private static void TitleTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (TitleBar)bindable;
        control.NavTitle.Text = newValue?.ToString();
    }

    public string TitleText
    {
        get => GetValue(TitleProperty)?.ToString();

        set => SetValue(TitleProperty, value);
    }
    public TitleBar()
    {
        InitializeComponent();
        Subtitle = SunmiPrinter.Current.IsConnected() ? "Connected" : "No printer"; ;
        NavSubtitle.SetBinding(Label.TextProperty, new Binding("Subtitle", source: this));
    }
}
