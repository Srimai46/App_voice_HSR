using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;

namespace ProjectMid;


public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}

    private async void yunli(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/2642";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void shion(object sender, EventArgs e)
    {
        string url = "https://th.wikipedia.org/wiki/%E0%B8%8A%E0%B8%B4%E0%B8%AD%E0%B8%87_%E0%B8%A7%E0%B8%B2%E0%B8%81%E0%B8%B2%E0%B8%A2%E0%B8%B2%E0%B8%A1%E0%B8%B0";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }
    // -------

    private async void fire(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/2494";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void tomori(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Tomori_Kusunoki";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }
    // -------

    private async void mydei(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/3324";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void yohei(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Y%C5%8Dhei_Azakami";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }
    // -------

    private async void sam(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/2494";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void jun(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Jun_Kasama";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }
    // -------

    private async void misha(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/1808";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void matsui(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Eriko_Matsui";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }
    // -------

    private async void xueyi(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/1640";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void kawase(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Maki_Kawase";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }
    // -------

    private async void jingliu(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/1387";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void Houko(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Houko_Kuwashima";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }
    // -------

    // -------

    private async void danheng2(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/1226?lang=en-us";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void ito(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Kent_It%C5%8D";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }
    // -------

    // -------

    private async void blade(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/789";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void miki(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Shin-ichiro_Miki";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }
    // -------

    // -------

    private async void hook(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/22";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void sora(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Sora_Tokui";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }
    // -------

    // -------

    private async void clara(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/20";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void rina(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Rina_Hidaka";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }
    // -------

    // -------

    private async void arlan(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/11";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void ryoko(object sender, EventArgs e)
    {
        string url = "https://en.wikipedia.org/wiki/Ryoko_Shiraishi";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }
    // -------

    private async void mc1(object sender, EventArgs e)
    {
        string url = "https://wiki.hoyolab.com/pc/hsr/entry/6";

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            await Launcher.OpenAsync(uri);
        }
        else
        {
            await DisplayAlert("Error", "Invalid URL.", "OK");
        }
    }

    private async void junya(object sender, EventArgs e)
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
    // -------



}