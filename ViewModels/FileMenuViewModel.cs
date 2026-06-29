using System;
using System.IO;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Platform.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MsBox.Avalonia;
using MsBox.Avalonia.Dto;
using Notepad_V2.Models;
using MsBox.Avalonia.Enums;
using Notepad_V2.Views;


namespace Notepad_V2.ViewModels;

public partial class FileMenuViewModel : ObservableObject
{ 
    private readonly FileModel  _fileModel;
    private readonly FileMenuView _view;
    
    public FileMenuViewModel (FileModel model, FileMenuView view)
    {

        _view = view;
        _fileModel = model;
        
    }


    #region CleaUi
    private void cleardata ()
    {
        Content = string.Empty;
        FileName = string.Empty;
        FileType = string.Empty;
        
    }
    
    
    #endregion
    #region ObservableProperties

    [ObservableProperty]
    private string _content;
    
    [ObservableProperty]
    private string _fileName;
    [ObservableProperty]
    private string _filePath;
    [ObservableProperty]
    private string _fileType; 
    
    [ObservableProperty]
    private bool _NewFileCreated;

    #endregion
   
    
    
    #region Filemenu
    [RelayCommand]
    private async Task NewFile ()
    {
        
        var newfilemessagebox = 
            MessageBoxManager.GetMessageBoxStandard("Title","Do you wish to save the current file before creating a new file?" ,ButtonEnum.YesNoCancel);
        var result = await newfilemessagebox.ShowAsync();

        switch (result)
        {
            
            case ButtonResult.Yes:
                await SaveFile();
                cleardata();
                break;
            case ButtonResult.No:
                cleardata();
                break;
            case ButtonResult.Cancel:
                break;
            
            
        }
        
        
    }
    
    
    [RelayCommand]
    private async Task NewWindow ()
    {
        
        var newwindw = new MainWindowView();
        newwindw.Show();
        
    }
    
    [RelayCommand]
    private async Task OpenFile ()
    {
      var openfilemessagebox = 
          MessageBoxManager.GetMessageBoxStandard("Title","Do you wish to save before opening a new file?",ButtonEnum.YesNoCancel);
      var result = await openfilemessagebox.ShowAsync();

      switch (result)
      {
          case ButtonResult.Yes:
              await SaveFile();
              cleardata();
              NewFileCreated = true;
              break;
          case ButtonResult.No:
              cleardata();
              NewFileCreated = true;
              break;
          case ButtonResult.Cancel:
              break;
      }
        
      
      
        var toplevel= TopLevel.GetTopLevel(_view);
        var files = await toplevel.StorageProvider.OpenFilePickerAsync
        (new FilePickerOpenOptions
        {
           Title = "Open file",
           AllowMultiple = false,
           SuggestedFileType = new FilePickerFileType("Text file"),
            
        });
        
            await using var stream = await files[0].OpenReadAsync();
            using(StreamReader sr = new StreamReader(stream))
            {
                Content =  await sr.ReadToEndAsync();
                
            }
            
        
    }
    
    
    
    [RelayCommand]
    private async Task SaveFile ()
    {
        
        
        
    }
    
    
    [RelayCommand]
    private async Task SaveFileas ()
    {
        
        
    }
    
    
    [RelayCommand]
    private async Task Print ()
    {
        
        
    }
    
    [RelayCommand]
    private async Task Exit()
    {
        
    }
    
    #endregion
    #region EditMenu
    [RelayCommand]
    private async Task Undo ()
    {
        
        
    }
    
    [RelayCommand]
    private async Task Cut ()
    {
        
        
    }
    

    [RelayCommand]
    private async Task Copy ()
    {
        
        
    }
    
    
    [RelayCommand]
    private async Task Paste ()
    {
        
        
    }
    
    [RelayCommand]
    private async Task Delete ()
    {
        
    }
    
  
    
    
    
    #endregion

    
    
    
    #region MyRegion

    

    #endregion
    
    
    
    
    
    
    }
    
    
    
    
    
    
    
    
    
    
    