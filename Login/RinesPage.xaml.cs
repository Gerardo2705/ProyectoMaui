using System.Collections.ObjectModel;

namespace Login;

public partial class RinesPage : ContentPage
{
    public ObservableCollection<string> ImageCollection { get; set; }
    private bool isAutoSliding = true;

    public RinesPage()
	{
		InitializeComponent();

        ImageCollection = new ObservableCollection<string>
        {
            "dotnet_bot.png", // Asegúrate de que las imágenes existan en la carpeta Resources/Images
            "lock_icon.png",
            "image3.jpg"
        };
        BindingContext = this;

        StartAutoSlide();

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (carousel.Position > 0)
            carousel.Position -= 1;
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        if (carousel.Position < ImageCollection.Count - 1)
            carousel.Position += 1;
    }

    [Obsolete]
    private void StartAutoSlide()
    {
        // Usa el Dispatcher para cambiar la posición del carrusel cada 3 segundos
        Device.StartTimer(TimeSpan.FromSeconds(3), () =>
        {
            if (isAutoSliding)
            {
                if (carousel.Position < ImageCollection.Count - 1)
                {
                    carousel.Position += 1;
                }
                else
                {
                    carousel.Position = 0; // Reinicia el carrusel al inicio
                }
            }
            return true; // Regresa true para que el temporizador siga corriendo
        });
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        isAutoSliding = true; // Reactiva el deslizamiento automático cuando la página es visible
    }
    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        isAutoSliding = false; // Desactiva el deslizamiento automático cuando la página no es visible
    }

}
