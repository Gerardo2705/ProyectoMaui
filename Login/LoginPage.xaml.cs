using Login.services;

namespace Login;

public partial class LoginPage : ContentPage
{
    UserService userService;
    public LoginPage()
	{
		InitializeComponent();
        userService = new UserService();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        var user = await userService.GetUserAsync(username, password);

        if (user != null)
        {
            await DisplayAlert("Felicidades", "Inicio de sesion exitoso!", "OK");
            // Navigate to the page where users can be deleted
            await Navigation.PushAsync(new MenuPrincipal());
        }
        else
        {
            await DisplayAlert("Error", "Usuario o contraseña Incorrectos.", "OK");
        }

    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
        {
            await userService.SaveUserAsync(new Models.User { Username = username, Password = password });
            await DisplayAlert("Felicidades", "Usuario registrado exitosamente!", "OK");
        }
        else
        {
            await DisplayAlert("Error", "Porfavor relleno los campos solicitados.", "OK");
        }
    }
}