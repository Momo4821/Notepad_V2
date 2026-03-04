using System;
using System.Windows.Input;
using Notepad_V2.Models;
using Notepad_V2.ViewModels;

namespace Notepad_V2.BaseCommands;

public class Commands : ICommand
{
    
    public event EventHandler? CanExecuteChanged;
    

    
    public bool CanExecute(object? parameter)
    {
        throw new NotImplementedException();
    }

    public void Execute(object? parameter)
    {
        throw new NotImplementedException();
    }

    
}
