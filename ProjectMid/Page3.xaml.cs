namespace ProjectMid;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}

    private async void theherta(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/3285";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void thehertav(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Haruka_Yamazaki";

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

    private async void herta(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/13";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void rappa(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/3057";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void rappav(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Megumi_Han";

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

    private async void jade(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/2495";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void jadev(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Kotono_Mitsuishi";

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

    private async void agenti(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/1535";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void agentiv(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Shinnosuke_Tachibana";

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

    private async void yuan(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/26";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void yuanv(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Daisuke_Ono";

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

    private async void qing(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/24";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void qingv(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Arisa_Date";

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

    private async void serval(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/16";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void servalv(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Aimi_(actress)";

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

    private async void himeko(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/9";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void himekov(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Rie_Tanaka";

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