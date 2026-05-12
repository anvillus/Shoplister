namespace Shoplister.Mobile;

public partial class App : Application
{
    private readonly Page _rootPage;

    public App(IServiceProvider services)
    {
        InitializeComponent();

        _rootPage = services.GetRequiredService<Page>();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(_rootPage);
    }
}