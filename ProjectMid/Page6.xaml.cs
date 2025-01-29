namespace ProjectMid;

public partial class Page6 : ContentPage
{
	public Page6()
	{
		InitializeComponent();
	}

    private async void aven(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/1920";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void avenv(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Kengo_Kawanishi";

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

    private async void fu(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/804";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void fuv(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Miku_It%C5%8D";

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

    private async void mc2(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/23";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void mc2v(object sender, EventArgs e)
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

    private async void ge(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/17";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void gev(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Makoto_Furukawa";

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

    private async void ma(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/7";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void mav(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Yui_Ogura";

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