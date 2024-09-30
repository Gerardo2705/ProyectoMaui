using Login;
using OnlyCars.Models;

namespace OnlyCars.Autos;
public partial class AutosOC : ContentPage
{
    public List<Store> Stores { get; set; }
    public AutosOC()
	{
		InitializeComponent();
        LoadData();
        BindingContext = this;
    }
    public void LoadData()
    {
        Stores = new List<Store>
        {
            new Store
            {
                Id = 1,
                Header="header",
                Logo="dodge.png",
                Name = "Dodge Challenger 1970",
                km = "315km/h",
                Money  = 45000,
                Stock = 100,
                Rating = 4.5
            },
            new Store
            {
                Id = 2,
                Header="header",
                Logo="gtr.png",
                Name = "Nissan Skyline GTR R34",
                km = "266km/h",
                Money = 100000,
                Stock = 10,
                Rating = 5
            },
             new Store
            {
                Id = 3,
                Header="header",
                Logo="silvia.png",
                Name = "Nissan Silvia S15",
                km = "257Km/h",
                Money = 80000,
                Stock = 10,
                Rating = 4
            },
              new Store
            {
                Id = 4,
                Header="header",
                Logo="miata.png",
                Name = "Mazda MX 5 Miata",
                km = "195km/h",
                Money = 10000,
                Stock = 100,
                Rating = 3.5
            },
               new Store
            {
                Id = 5,
                Header="header",
                Logo="honda.png",
                Name = "Honda civic jaiba año 1998",
                km = "200/h",
                Money = 20000,
                Stock = 200,
                Rating = 5
            },
        };
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MenuPrincipal());
    }
}