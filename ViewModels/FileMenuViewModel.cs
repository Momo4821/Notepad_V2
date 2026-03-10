using System;
using System.IO;
using System.Windows.Input;
using Avalonia.Controls;
using Avalonia.Platform.Storage;
using HarfBuzzSharp;
using Notepad_V2.BaseCommands;
using Notepad_V2.Models;
using Notepad_V2.Views;

namespace Notepad_V2.ViewModels;
public class FileMenuViewModel
{  
    FileModel _filemodel;

    public FileMenuViewModel(FileModel filemodel, ICommand openButtonCommand, ICommand newFileButtonCommand, ICommand newwindowMenuCommand, ICommand saveAsCommand, ICommand printCommand, ICommand exitCommand)
    {
        _filemodel = filemodel;
        OpenButtonCommand = openButtonCommand;
        NewFileButtonCommand = newFileButtonCommand;
        NewwindowMenuCommand = newwindowMenuCommand;
        SaveAsCommand = saveAsCommand;
        PrintCommand = printCommand;
        ExitCommand = exitCommand;


        
        
        OpenButtonCommand.Execute(null);
        NewFileButtonCommand.Execute(null);
        NewwindowMenuCommand.Execute(null);
        SaveAsCommand.Execute(null);
        PrintCommand.Execute(null);
        ExitCommand.Execute(null);
        




    }
    public void Openfile()
    {
            
            
    }
    public ICommand OpenButtonCommand { get; set; }
    
    
    public ICommand NewFileButtonCommand {get;set;}

    public ICommand NewwindowMenuCommand  {get;set;}

    public ICommand SaveAsCommand   {get;set;}

    public ICommand PrintCommand   {get;set;}

    public ICommand ExitCommand  {get;set;}

  
    


    public async void _OpenFile()
    {
        _filemodel.Filepath = null;
        var _toplevel = TopLevel.GetTopLevel(new MainWindowView());

        var files = await _toplevel.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions());
    
        
        
    }
    
    
    
 
    


    



    
    
    




    

    
    




}