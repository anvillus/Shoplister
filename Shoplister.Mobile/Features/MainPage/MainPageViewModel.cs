using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Shoplister.Mobile.Features;

internal partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(CounterText))]
    private int _count = 0;

    public string CounterText => Count == 0
        ? "Click me"
        : $"Clicked {Count} time{(Count > 1 ? "s" : "")}";

    [RelayCommand]
    private void IncrementCounter()
    {
        Count++;

        SemanticScreenReader.Announce(CounterText);
    }
}
