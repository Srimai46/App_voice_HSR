namespace ProjectMid;

public partial class load : ContentPage
{
    public load()
    {
        InitializeComponent();
    }

    async private void tab(object sender, EventArgs e)
    {
        await image.ScaleTo(1.5, 1000, Easing.CubicInOut);

        await Navigation.PushAsync(new Menu());

        Application.Current.MainPage = new NavigationPage(new Menu());
    }
}