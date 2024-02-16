using SunmiPOSLib;
namespace SunmiSampleApp.Views;

public partial class MainPage : ContentPage
{

   
    public MainPage()
    {
        try
        {
            InitializeComponent();
            LoadDemoDetails();
        }
        catch (Exception ex)
        {

        }
       
    }
    /// <summary>
    /// Adds a new icon to Homepage (Frame containing image and text)
    /// Adds to the new icon a function that will be executed when clicking it
    /// </summary>
    private void AddDemo(string nome, string iconPath, Func<Task> onTap)
    {

        var page = new Frame
        {
            // Looks up in the dictionary of App.xaml the color corresponding to "backgroundColor"
            BackgroundColor = (Color)Application.Current.Resources["backgroundColor"],
            HasShadow = false,
            BorderColor = (Color)Application.Current.Resources["borderColor"],
            Margin = new Thickness(-1),
            Content = new StackLayout
            {
                Padding = new Thickness(10, 0, 10, 0), //left, top, right, bottom
                Orientation = StackOrientation.Horizontal, // Set the orientation to horizontal

                Children =
        {
            new Microsoft.Maui.Controls.Image
            {
                Source = iconPath,
                Margin = new Thickness(5, 0, 5, 0),
            },
            new Label
            {
                Text = nome,
                TextColor = Colors.Red,
                HorizontalOptions = LayoutOptions.Center,
            },
        },
            }
        };

        var tapGestureRecognizer = new TapGestureRecognizer();
        tapGestureRecognizer.Tapped += async (s, e) => {
            await onTap();
        };

        page.GestureRecognizers.Add(tapGestureRecognizer);

        Pages.Children.Add(page);
    }


    /// <summary>
    /// Load all buttons that will be displayed on the Homepage
    /// </summary>
    public void LoadDemoDetails()
    {
        Pages.Children.Clear();
        AddDemo("QR Code", "function_qr.png", NavigateTo(nameof(QrcodePage)));
        AddDemo("Bar Code", "function_barcode.png", NavigateTo(nameof(BarcodePage)));
        AddDemo("Print", "function_text.png", NavigateTo(nameof(TextPage)));
        AddDemo("Form", "function_tab.png", NavigateTo(nameof(TablePage)));
        AddDemo("Advance Paper", "function_threeline.png", RunAdvancePaper());
        AddDemo("Exit Status", "function_status.png", RunPrintStatus());
    }
    /// <summary>
    /// Return a function that navigates to the specified page, implicitly converting string to uri
    /// </summary>
    private Func<Task> NavigateTo(string url)
    {
        return new Func<Task>(async () => await Shell.Current.GoToAsync(url));
    }

    async void OnSettingsClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SettingsPage));
    }

    /// <summary>
    /// Returns an asynchronous function that advances the machine`s paper
    /// </summary>
    private Func<Task> RunAdvancePaper()
    {
        return new Func<Task>(async () => await Task.Run(() =>
        {
            try
            {
                SunmiPrinter.Current.AdvancePaper();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }));

    }

    private Func<Task> RunPrintStatus()
    {
        return new Func<Task>(async () => await Task.Run(() => SunmiPrinter.Current.ShowPrinterStatus()));
    }
}


