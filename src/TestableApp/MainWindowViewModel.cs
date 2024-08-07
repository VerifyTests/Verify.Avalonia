﻿public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    double? firstOperand;

    [ObservableProperty]
    double? secondOperand;

    [ObservableProperty]
    string? result;

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
