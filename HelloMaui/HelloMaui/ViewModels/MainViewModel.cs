using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HelloMaui.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty] private int _count;
    [ObservableProperty] private string _countText = "Click me!";

    [RelayCommand] 
    private void Increment()
    {
        Count++;

        if (Count == 1) CountText = $"Clicked {Count} time";
        else CountText = $"Clicked {Count} times";
    } 

}
