namespace ProjectMid;

public partial class Page7 : ContentPage
{
	public Page7()
	{
		InitializeComponent();
	}

    private async void lin(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/2948";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void linv(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Kaori_Maeda";

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

    private async void gal(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/1924";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void galv(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Satoshi_Mikami";

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

    private async void hao(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/1533";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void haov(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Maria_Naganawa";

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

    private async void ly(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/1228";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void lyv(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Haruka_Terui";

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

    private async void luo(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/711";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void luov(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Akira_Ishida";

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

    private async void bai(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/29";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void baiv(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Emiri_Kat%C5%8D";

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

    private async void na(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/18";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void nav(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Yumi_Uchiyama";

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