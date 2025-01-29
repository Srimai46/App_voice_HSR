namespace ProjectMid;

public partial class Page8 : ContentPage
{
	public Page8()
	{
		InitializeComponent();
	}

    private async void rmc(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/3287";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void rmcv(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Junya_Enoki";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }
    // ---------------------------------------------------------

    private async void ar(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/3286";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void arv(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Aya_End%C5%8D";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }
    // ---------------------------------------------------------
}