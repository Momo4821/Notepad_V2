using System;
using System.Windows.Input;

namespace Notepad_V2.ViewModels;




public class FileMenuViewModel // create an instance of the viewmodel in the mainview
{
  

    public ICommand OpenButtonCommand {get;set;}
    
    public ICommand NewFileButtonCommand {get;set;}
    
    public ICommand NewwindowMenuCommand  {get;set;}
    
    public ICommand SaveAsCommand   {get;set;}
    
    public ICommand PrintCommand   {get;set;}
    
    public ICommand ExitCommand  {get;set;}
    
    





}