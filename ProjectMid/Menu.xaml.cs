namespace ProjectMid;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    async private void page1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page1());
    }

    async private void page2_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page2());
    }

    async private void page3_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page3());
    }

    async private void page4_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page4());
    }

    async private void page5_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page5());
    }

    async private void page6_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page6());
    }

    async private void page7_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page7());
    }

    async private void page8_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page8());
    }
}