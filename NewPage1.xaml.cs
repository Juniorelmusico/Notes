namespace Notes;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
        private async void LearnMore_Clicked(object sender, EventArgs e)
        {
            // Navigate to the specified URL in the system browser.
            await Launcher.Default.OpenAsync("https://aka.ms/maui");


        }
    }
}