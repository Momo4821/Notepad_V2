
using System;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Notepad_V2.Models;
using Notepad_V2.ViewModels;
using Notepad_V2.Views;


namespace Notepad_V2.BaseCommands;

public class FilemenuCommand : ICommand
{
    FileModel _filemodel;
    LowerLabelsModel _lowerlabelsmodel;
    FileMenuViewModel _filemenuviewmodel;
    TextboxModel _textboxmodel;
    
    
    Action Action {get;set;}
    
    
    
    public FilemenuCommand (Action action)
    {
        
      Action = action;
        
    }
    
    
    public bool CanExecute(object? parameter)
    {
       return true;
    }

    public void Execute(object? parameter)
    {
        Action();
        
    }

    public event EventHandler? CanExecuteChanged;
}