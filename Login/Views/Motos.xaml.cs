using OnlyCars.Models;

namespace OnlyCars.Views;

public partial class Motos : ContentPage    
{
	public List<Store> Stores { get; set; }
	public Motos()
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
            Logo="kawa.png",
            Name = "Kawasaki Ninja H2R",
            km = "357 km/h",
            Money  = 70000,
            Stock = 100,
            Rating = 4.5
            },
            new Store
            {
            Id = 2,
            Header="header",
            Logo="bmw.png",
            Name = "BMW S1000 RR",
            km = "316 km/h",
            Money = 16000,
            Stock = 1000,
            Rating = 5
            },
            new Store
            {
            Id = 3,
            Header="header",
            Logo="yr.png",
            Name = "Yamaha YZF-R6",
            km = "292 km/h",
            Money = 17000,
            Stock = 3000,
            Rating = 4
            },
            new Store
            {
            Id = 4,
            Header="header",
            Logo="duca.png",
            Name = "Ducati R1199 Panigale R",
            km = "310 km/h",
            Money = 20000,
            Stock = 10000,
            Rating = 3.5
            },
           new Store
            {
            Id = 5,
            Header="header",
            Logo="dogg.png",
            Name = "Dodge Tomahawk",
            km = "536 km/h",
            Money = 550000,
            Stock = 200,
            Rating = 5
            },
        };
    }
}