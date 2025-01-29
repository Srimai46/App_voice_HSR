using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;

namespace ProjectMid
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private async void charin1_Clicked(object sender, EventArgs e)
        {
            // URL �ͧ���䫵����ͧ����Դ
            string url = "https://wiki.hoyolab.com/pc/hsr/entry/2949";

            // �� Launcher �����Դ�ԧ��
            if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
            {
                await Launcher.OpenAsync(uri);
            }
            else
            {
                await DisplayAlert("Error", "Invalid URL.", "OK");
            }
        }

        private async void voice1_Clicked(object sender, EventArgs e)
        {
            // URL �ͧ���䫵����ͧ����Դ
            string url = "https://en.wikipedia.org/wiki/Shogo_Sakata";

            // �� Launcher �����Դ�ԧ��
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

        private async void fei(object sender, EventArgs e)
        {
            // URL �ͧ���䫵����ͧ����Դ
            string url = "https://wiki.hoyolab.com/pc/hsr/entry/2947";

            // �� Launcher �����Դ�ԧ��
            if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
            {
                await Launcher.OpenAsync(uri);
            }
            else
            {
                await DisplayAlert("Error", "Invalid URL.", "OK");
            }
        }

        private async void feiv(object sender, EventArgs e)
        {
            // URL �ͧ���䫵����ͧ����Դ
            string url = "https://en.wikipedia.org/wiki/Mikako_Komatsu";

            // �� Launcher �����Դ�ԧ��
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

        private async void march(object sender, EventArgs e)
        {
            // URL �ͧ���䫵����ͧ����Դ
            string url = "https://wiki.hoyolab.com/pc/hsr/entry/2657";

            // �� Launcher �����Դ�ԧ��
            if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
            {
                await Launcher.OpenAsync(uri);
            }
            else
            {
                await DisplayAlert("Error", "Invalid URL.", "OK");
            }
        }

        private async void marchv(object sender, EventArgs e)
        {
            // URL �ͧ���䫵����ͧ����Դ
            string url = "https://en.wikipedia.org/wiki/Yui_Ogura";

            // �� Launcher �����Դ�ԧ��
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

        private async void boothill(object sender, EventArgs e)
        {
            // URL �ͧ���䫵����ͧ����Դ
            string url = "https://wiki.hoyolab.com/pc/hsr/entry/2367";

            // �� Launcher �����Դ�ԧ��
            if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
            {
                await Launcher.OpenAsync(uri);
            }
            else
            {
                await DisplayAlert("Error", "Invalid URL.", "OK");
            }
        }

        private async void boothillv(object sender, EventArgs e)
        {
            // URL �ͧ���䫵����ͧ����Դ
            string url = "https://en.wikipedia.org/wiki/Katsuyuki_Konishi";

            // �� Launcher �����Դ�ԧ��
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

        private async void dr(object sender, EventArgs e)
        {
            // URL �ͧ���䫵����ͧ����Դ
            string url = "https://wiki.hoyolab.com/pc/hsr/entry/1639";

            // �� Launcher �����Դ�ԧ��
            if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
            {
                await Launcher.OpenAsync(uri);
            }
            else
            {
                await DisplayAlert("Error", "Invalid URL.", "OK");
            }
        }

        private async void drv(object sender, EventArgs e)
        {
            // URL �ͧ���䫵����ͧ����Դ
            string url = "https://en.wikipedia.org/wiki/Shunsuke_Takeuchi";

            // �� Launcher �����Դ�ԧ��
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

        private async void topaz(object sender, EventArgs e)
        {
            // URL �ͧ���䫵����ͧ����Դ
            string url = "https://wiki.hoyolab.com/pc/hsr/entry/1389";

            // �� Launcher �����Դ�ԧ��
            if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
            {
                await Launcher.OpenAsync(uri);
            }
            else
            {
                await DisplayAlert("Error", "Invalid URL.", "OK");
            }
        }

        private async void topazv(object sender, EventArgs e)
        {
            // URL �ͧ���䫵����ͧ����Դ
            string url = "https://en.wikipedia.org/wiki/Yoshino_Nanj%C5%8D";

            // �� Launcher �����Դ�ԧ��
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

        private async void yan(object sender, EventArgs e)
        {
            // URL �ͧ���䫵����ͧ����Դ
            string url = "https://wiki.hoyolab.com/pc/hsr/entry/28";

            // �� Launcher �����Դ�ԧ��
            if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
            {
                await Launcher.OpenAsync(uri);
            }
            else
            {
                await DisplayAlert("Error", "Invalid URL.", "OK");
            }
        }

        private async void yanv(object sender, EventArgs e)
        {
            // URL �ͧ���䫵����ͧ����Դ
            string url = "https://en.wikipedia.org/wiki/Marina_Inoue";

            // �� Launcher �����Դ�ԧ��
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

        private async void su(object sender, EventArgs e)
        {
            // URL �ͧ���䫵����ͧ����Դ
            string url = "https://wiki.hoyolab.com/pc/hsr/entry/27";

            // �� Launcher �����Դ�ԧ��
            if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
            {
                await Launcher.OpenAsync(uri);
            }
            else
            {
                await DisplayAlert("Error", "Invalid URL.", "OK");
            }
        }

        private async void suv(object sender, EventArgs e)
        {
            // URL �ͧ���䫵����ͧ����Դ
            string url = "https://en.wikipedia.org/wiki/Misato_Fukuen";

            // �� Launcher �����Դ�ԧ��
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

        private async void seele(object sender, EventArgs e)
        {
            // URL �ͧ���䫵����ͧ����Դ
            string url = "https://wiki.hoyolab.com/pc/hsr/entry/15";

            // �� Launcher �����Դ�ԧ��
            if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
            {
                await Launcher.OpenAsync(uri);
            }
            else
            {
                await DisplayAlert("Error", "Invalid URL.", "OK");
            }
        }

        private async void seelev(object sender, EventArgs e)
        {
            // URL �ͧ���䫵����ͧ����Դ
            string url = "https://en.wikipedia.org/wiki/Mai_Nakahara";

            // �� Launcher �����Դ�ԧ��
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

        private async void dan(object sender, EventArgs e)
        {
            // URL �ͧ���䫵����ͧ����Դ
            string url = "https://wiki.hoyolab.com/pc/hsr/entry/8";

            // �� Launcher �����Դ�ԧ��
            if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
            {
                await Launcher.OpenAsync(uri);
            }
            else
            {
                await DisplayAlert("Error", "Invalid URL.", "OK");
            }
        }

        private async void danv(object sender, EventArgs e)
        {
            // URL �ͧ���䫵����ͧ����Դ
            string url = "https://en.wikipedia.org/wiki/Kent_It%C5%8D";

            // �� Launcher �����Դ�ԧ��
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
}
