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
    
    public ICommand OpenButtonCommand { get; set; }
    
    
    public ICommand NewFileButtonCommand {get;set;}

    public ICommand NewwindowMenuCommand  {get;set;}

    public ICommand SaveAsCommand   {get;set;}

    public ICommand PrintCommand   {get;set;}

    public ICommand ExitCommand  {get;set;}

    
   
    public FileMenuViewModel()
    {
        
        
      
        
        
        
       
        
        
    }
    
    
 


  
    


    public async void _OpenFile()
    {
        var _toplevel = TopLevel.GetTopLevel(new MainWindowView());
        var files = await _toplevel.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions());
        
        
        
        
    }
    
    
    public async void _saveAs()
    {
        var _toplevel = TopLevel.GetTopLevel(new MainWindowView());

        var files = await _toplevel.StorageProvider.SaveFilePickerAsync(new FilePickerSaveOptions());
        
        
    }
    
    
    
    
    
    
 
    


    



    
    
    




    

    
    




}