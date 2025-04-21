using Microsoft.UI.Xaml;

namespace EditorApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override void OnLaunched(LaunchActivatedEventArgs args)
    {
        new MainWindow().Activate();
    }
}
