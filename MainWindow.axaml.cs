using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Platform.Storage;

namespace Notepad_V2;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        
        //new mainviewmodel
        //intialize datacontext
        
      
        
        InitializeComponent();
        
    }
    
    //istorage for file handling
    
    //top level async method for file opening
    
    
    
    public void OpenButtonCommnad ()
    {
        DataContext = new Mainwindowviewmodel();

        async Task OpenFileAsync()
        {
            var toplevel = TopLevel.GetTopLevel(this);
            
            
            var files = await toplevel.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions
                    {
                        
                        
                        Title = "Open File",
                        AllowMultiple = false,
                      
                        
                    });
                FilePickerFileType file = new FilePickerFileType ("Text Files")
                {
                  
                    Patterns = new [] { "*.txt", "*.cs", "*.html", "*.css", "*.js", "*.json", "*.xml", "*.md" }
                    
                };
                
        }
       
        
    }
    
    
    public void NewFileButtonCommand()
    {
        DataContext = new Mainwindowviewmodel();
        var topvell = DataContext as Mainwindowviewmodel;
        
        
        
        
    }
   
    
    

    
    
    
    
    
    
}

