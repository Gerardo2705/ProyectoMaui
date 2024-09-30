using Login.services;
using Login.Models;


namespace Login;

public partial class DeleteUserPage : ContentPage
{
    UserService userService;
    public DeleteUserPage()
	{
		InitializeComponent();
        userService = new UserService();
        LoadUsers();
    }
    private async void LoadUsers()
    {
        var users = await userService.GetUsersAsync();
        UsersListView.ItemsSource = users;


    }

   

    private async void UsersListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var user = e.Item as User;
        if (user != null)
        {
            // Confirmación antes de eliminar al usuario
            bool confirm = await DisplayAlert("Eliminar Usuario", $"¿Esta seguro de eliminar el usuario {user.Username}?", "Si", "No");
            if (confirm)
            {
                // Eliminar el usuario seleccionado de la base de datos
                await userService.DeleteUserAsync(user);

                // Mostrar un mensaje de éxito
                await DisplayAlert("Finalizado", "Usuario eliminado exitosamente.", "OK");

                // Recargar la lista de usuarios
                LoadUsers();
            }
        }

            // Deseleccionar el elemento
            ((ListView)sender).SelectedItem = null;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MenuPrincipal());
    }
}
