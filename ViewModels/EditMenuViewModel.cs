using System.Windows.Input;

namespace Notepad_V2.ViewModels;

public abstract class EditMenuViewModel 
{
    
    
    public ICommand UndoCommand { get; set; }
    public ICommand CutMenuCommand { get; set; }
    public ICommand CopyMenuCommand { get; set; }
    public ICommand PasteMenuCommand { get; set; }
    public ICommand DeleteMenuCommand { get; set; }
    
    public ICommand FindNextMenuCommand { get; set; }
    
    public ICommand ReplaceMenuCommand { get; set; }
    
    public ICommand GotoMenuCommand { get; set; }
    
    public ICommand SelectAllMenuItemCommand { get; set; }
    
    public ICommand TimeDateMenuCommand { get; set; }
    
    
    
    
    
    
    
    
}