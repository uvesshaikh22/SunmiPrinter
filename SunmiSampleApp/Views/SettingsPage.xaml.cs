namespace SunmiSampleApp.Views;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}
    private async void OnConnectionClicked(object sender, System.EventArgs e)
    {
        string result = await DisplayActionSheet("Connection method", "Cancel", null, "API");
    }
    private async void OnInfoClicked(object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(PrinterInfoPage));
    }
}
