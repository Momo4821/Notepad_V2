using System;
using System.Windows.Input;
using Avalonia.Controls;

namespace Notepad_V2.Commands;

public class Commands : MainWindow
{

    public class RelayCommand : ICommand

    {
        public bool CanExecute(object? parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }

        public event EventHandler? CanExecuteChanged;
    }

    public void OpenButtonCommnad()
    {
        
        
        
    }








}