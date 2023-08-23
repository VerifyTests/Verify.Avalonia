using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

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
    void Divide()
    {
        if (SecondOperand == 0)
        {
            Result = "Cannot divide by zero!";
        }
        else
        {
            Result = (FirstOperand / SecondOperand)?.ToString();
        }
    }
}
