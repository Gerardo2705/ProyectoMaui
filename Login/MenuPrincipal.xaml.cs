using OnlyCars.Autos;
using OnlyCars.Views;

namespace Login;

public partial class MenuPrincipal : ContentPage
{
	public MenuPrincipal()
	{
		InitializeComponent();
	}

    private async void ImageButton_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Motos());

    }

    private async void ImageButton_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AutosOC());
    }

    private async void ImageButton_Clicked_3(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DeleteUserPage());
    }
}