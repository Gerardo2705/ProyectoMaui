using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Proelium.otf", "ProeLi");
                    fonts.AddFont("Starz 2.ttf", "Starz");
                    fonts.AddFont("Cars.ttf", "Cars");
                    fonts.AddFont("MOTOB___.TTF", "MOTO");
                    fonts.AddFont("motorama.ttf", "Motorama");
                });

            // Aquí puedes registrar los servicios necesarios
            // builder.Services.AddSingleton<UserService>();  // Ejemplo de registro de un servicio

            return builder.Build();
        }
    }
}

