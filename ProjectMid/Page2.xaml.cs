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
            // URL ของเว็บไซต์ที่ต้องการเปิด
            string url = "https://wiki.hoyolab.com/pc/hsr/entry/2949";

            // ใช้ Launcher เพื่อเปิดลิงก์
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
            // URL ของเว็บไซต์ที่ต้องการเปิด
            string url = "https://en.wikipedia.org/wiki/Shogo_Sakata";

            // ใช้ Launcher เพื่อเปิดลิงก์
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
            // URL ของเว็บไซต์ที่ต้องการเปิด
            string url = "https://wiki.hoyolab.com/pc/hsr/entry/2947";

            // ใช้ Launcher เพื่อเปิดลิงก์
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
            // URL ของเว็บไซต์ที่ต้องการเปิด
            string url = "https://en.wikipedia.org/wiki/Mikako_Komatsu";

            // ใช้ Launcher เพื่อเปิดลิงก์
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
            // URL ของเว็บไซต์ที่ต้องการเปิด
            string url = "https://wiki.hoyolab.com/pc/hsr/entry/2657";

            // ใช้ Launcher เพื่อเปิดลิงก์
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
            // URL ของเว็บไซต์ที่ต้องการเปิด
            string url = "https://en.wikipedia.org/wiki/Yui_Ogura";

            // ใช้ Launcher เพื่อเปิดลิงก์
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
            // URL ของเว็บไซต์ที่ต้องการเปิด
            string url = "https://wiki.hoyolab.com/pc/hsr/entry/2367";

            // ใช้ Launcher เพื่อเปิดลิงก์
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
            // URL ของเว็บไซต์ที่ต้องการเปิด
            string url = "https://en.wikipedia.org/wiki/Katsuyuki_Konishi";

            // ใช้ Launcher เพื่อเปิดลิงก์
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
            // URL ของเว็บไซต์ที่ต้องการเปิด
            string url = "https://wiki.hoyolab.com/pc/hsr/entry/1639";

            // ใช้ Launcher เพื่อเปิดลิงก์
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
            // URL ของเว็บไซต์ที่ต้องการเปิด
            string url = "https://en.wikipedia.org/wiki/Shunsuke_Takeuchi";

            // ใช้ Launcher เพื่อเปิดลิงก์
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
            // URL ของเว็บไซต์ที่ต้องการเปิด
            string url = "https://wiki.hoyolab.com/pc/hsr/entry/1389";

            // ใช้ Launcher เพื่อเปิดลิงก์
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
            // URL ของเว็บไซต์ที่ต้องการเปิด
            string url = "https://en.wikipedia.org/wiki/Yoshino_Nanj%C5%8D";

            // ใช้ Launcher เพื่อเปิดลิงก์
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
            // URL ของเว็บไซต์ที่ต้องการเปิด
            string url = "https://wiki.hoyolab.com/pc/hsr/entry/28";

            // ใช้ Launcher เพื่อเปิดลิงก์
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
            // URL ของเว็บไซต์ที่ต้องการเปิด
            string url = "https://en.wikipedia.org/wiki/Marina_Inoue";

            // ใช้ Launcher เพื่อเปิดลิงก์
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
            // URL ของเว็บไซต์ที่ต้องการเปิด
            string url = "https://wiki.hoyolab.com/pc/hsr/entry/27";

            // ใช้ Launcher เพื่อเปิดลิงก์
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
            // URL ของเว็บไซต์ที่ต้องการเปิด
            string url = "https://en.wikipedia.org/wiki/Misato_Fukuen";

            // ใช้ Launcher เพื่อเปิดลิงก์
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
            // URL ของเว็บไซต์ที่ต้องการเปิด
            string url = "https://wiki.hoyolab.com/pc/hsr/entry/15";

            // ใช้ Launcher เพื่อเปิดลิงก์
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
            // URL ของเว็บไซต์ที่ต้องการเปิด
            string url = "https://en.wikipedia.org/wiki/Mai_Nakahara";

            // ใช้ Launcher เพื่อเปิดลิงก์
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
            // URL ของเว็บไซต์ที่ต้องการเปิด
            string url = "https://wiki.hoyolab.com/pc/hsr/entry/8";

            // ใช้ Launcher เพื่อเปิดลิงก์
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
            // URL ของเว็บไซต์ที่ต้องการเปิด
            string url = "https://en.wikipedia.org/wiki/Kent_It%C5%8D";

            // ใช้ Launcher เพื่อเปิดลิงก์
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
