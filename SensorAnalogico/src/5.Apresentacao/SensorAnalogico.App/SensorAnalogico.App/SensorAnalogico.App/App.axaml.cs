using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using System.Globalization;
using SensorAnalogico.App.Views;

namespace SensorAnalogico.App;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        /* Os idiomas est�o na pasta Assets/Resources.resx, Assets/Resources.xx-YY.resx, onde xx=cultura; YY=Bigrama Pa�s */
        Assets.Resources.Culture = new CultureInfo("pt-BR"); // Portugu�s
        //Assets.Resources.Culture = new CultureInfo("en-US"); // Ingl�s
        //Assets.Resources.Culture = new CultureInfo("it-IT"); // Italiano
        //Assets.Resources.Culture = new CultureInfo("es-ES"); // Espanhol

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow();
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
        {
            singleViewPlatform.MainView = new MainView();
        }

        base.OnFrameworkInitializationCompleted();
    }

}