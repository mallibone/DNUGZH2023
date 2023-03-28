using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace MauiBlazorApp;

public class CounterViewModel : ObservableObject
{
    private int _counter;

    public CounterViewModel()
    {
        ExecuteCounterIncrement = new RelayCommand(() => Counter++);
    }

    public int Counter { get => _counter; set => SetProperty(ref _counter, value); }

    public ICommand ExecuteCounterIncrement { get; }
}
