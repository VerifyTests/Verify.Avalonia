using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TestableApp;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    double? _firstOperand, _secondOperand;

    [ObservableProperty]
    string? _result;

    [RelayCommand]
    void Add() =>
        Result = (FirstOperand + SecondOperand)?.ToString();

    [RelayCommand]
    void Subtract() =>
        Result = (FirstOperand - SecondOperand)?.ToString();

    [RelayCommand]
    void Multiply() =>
        Result = (FirstOperand * SecondOperand)?.ToString();

    [RelayCommand]
    void Divide() =>
        Result = SecondOperand == 0 ? "Cannot divide by zero!" : (FirstOperand / SecondOperand)?.ToString();
}
