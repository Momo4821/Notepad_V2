using System;
using System.Windows.Input;

namespace Notepad_V2.ViewModels;




public class FileMenuViewModel
{
    public Delegate OpenFile { get; set; } 
    public Delegate SaveFile { get; set; }
    public Delegate SaveAsFile { get; set; }
    public Delegate SaveAllFiles { get; set; }
    
    
    
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

        public event EventHandler CanExecuteChanged;
    }
    
    
    
    
}