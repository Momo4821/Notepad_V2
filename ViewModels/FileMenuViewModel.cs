using System;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Input.Platform;
using Avalonia.Platform.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MsBox.Avalonia;
using MsBox.Avalonia.Base;
using MsBox.Avalonia.Dto;
using Notepad_V2.Models;
using Tmds.DBus.Protocol;
using MsBox.Avalonia.Enums;


namespace Notepad_V2.ViewModels;

public partial class FileMenuViewModel : ObservableObject
{
    private readonly FileMenuModel _fileMenuModel;
    
    
    
    
    
    public FileMenuViewModel (FileMenuModel model)
    {
        
        
       Content = model.Content;
       Filepath = model.Filepath;
     
    }
    
    
    [ObservableProperty]
    private string _content;
    
    [ObservableProperty]
    private string _filepath;
    

    
    
    
    
    [RelayCommand]
    public async Task OpenFile()
    {
        var box = MessageBoxManager
            .GetMessageBoxStandard("Title", "Do you wish to save File before Opening another File", ButtonEnum.YesNoCancel);
        
     var result = await box.ShowAsync();
        switch (result)
        {
            case ButtonResult.Yes:
                await SaveFile();
                break;
            case ButtonResult.No:
                break;
            case ButtonResult.Cancel:
            break;
        }
        
        
        
        var window = new MainWindowView();
        
        var toplevel = TopLevel.GetTopLevel(window);
        
        var files = await toplevel.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions

        {
            
            Title = "Open File",
            AllowMultiple = false,
            SuggestedFileType = FilePickerFileTypes.TextPlain,
            FileTypeFilter = new FilePickerFileType[]
            {
                new FilePickerFileType("Text Files")
                {
                    Patterns = new string[] { "*.txt" }
                },
                new FilePickerFileType("All Files")
                {
                    Patterns = new string[] { "*.*" }
                }
            },
            
            });
            
   
        
        
            
        
        if (files.Count >= 1)
        {
     
            using (StreamReader sr = new StreamReader(files[0].OpenReadAsync().GetAwaiter().GetResult()))
             {
                
               Content = sr.ReadToEnd();
               Filepath = files[0].TryGetLocalPath() ?? string.Empty;
                
                  
             }
           
           
            
        /*using var stream = await files[0].OpenReadAsync();            
         using var  streamreader = new StreamReader(stream);   
         FileMenuModel.Content = await streamreader.ReadToEndAsync();
        // FileMenuModel.Filepath = converter.ConvertFromString(files[0].Name)?.ToString() ?? "Untitled";*/
        }

        




    }
    
    [RelayCommand] 
    public async Task NewFile()
      {
      
      
      
      
      }
    
    [RelayCommand]
    public async Task SaveFile()
    {
        
        var window = new MainWindowView();
        
        var toplevel = TopLevel.GetTopLevel(window);
        
        var downloads = toplevel.StorageProvider.TryGetFolderFromPathAsync(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads");
        
        
        var file = await toplevel.StorageProvider.SaveFilePickerAsync(new FilePickerSaveOptions
        {
            Title = "Save File",
            SuggestedFileName = "Untitled",
            DefaultExtension = "txt",
            ShowOverwritePrompt = true,
            SuggestedStartLocation = downloads.GetAwaiter().GetResult()
            
            });
        
        
            if(_fileMenuModel.IsFile)
            {

                if (file !=null)
                {
                   
                    await using var stream = await file.OpenWriteAsync();
                    using var  streamwriter = new StreamWriter(stream);
                    await streamwriter.WriteLineAsync(_fileMenuModel.Content);
                    
                }
          
                
                
                
                
                
            }
            else
            {
                
                
                
            }
            
        
            
          
            
            
            
    
    }
    
    
    [RelayCommand]
    public async Task Saveas()
    {
                
                
                
    }
    
    [RelayCommand]
    public async Task Newwindow()
    {
        
        
    }
    
    [RelayCommand]
    public async Task Print()
    {
    }
    
    [RelayCommand]
    public async Task Exit()
    {
        var box = MessageBoxManager
            .GetMessageBoxStandard("Title", "Do you wish to save File before Exiting", ButtonEnum.YesNoCancel);
        
        var result = await box.ShowAsync();
        switch (result)
        {
            case ButtonResult.Yes:
                await SaveFile();
                break;
            case ButtonResult.No:
                Environment.Exit(0);
                break;
            case ButtonResult.Cancel:
                break;
        }
    
    
    
    
    
    
    
    
    
    }
    
    
    [RelayCommand]
    public async Task Undo()
    {
        
        
    }
    
    
    [RelayCommand]
    public async Task Cut()
    {
        
        
        
    }
    
    
    [RelayCommand]
    public async Task Copy()
    {
        
        
    }
    
    
    
    private bool _canPaste ()
    {
        
        return false;
    }
    
    
    [RelayCommand]
    public async Task Paste()
    {
        
        
    }
    
    private bool _canDelete ()
    {
        if(Content.Select(c => c).Count() > 0)
      {
          return true;
      }

        return false;

    }

  
    
    
    
    [RelayCommand(CanExecute = nameof(_canDelete))]
    public async Task Delete()
    {
        
        Content.Select(s => s).ToList().Clear();
     
        
    }
    
    
    
    
    
    
    }
