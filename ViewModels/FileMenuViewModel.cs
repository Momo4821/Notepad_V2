using System.IO;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Platform.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Notepad_V2.Models;


namespace Notepad_V2.ViewModels;
public partial class FileMenuViewModel : ObservableObject
{  
    
    private readonly FileMenuModel _menuModel;
    private readonly LowerLabelsModel _labels;
   
    
    
    public FileMenuViewModel (FileMenuModel model)
    {
        
     _menuModel = model;
     _labels = new LowerLabelsModel();   
        
        
        
    }
    
    
    
    public FileMenuModel Menu => _menuModel;
    public LowerLabelsModel Labels => _labels;
    
    
    
    public bool CanExecuteOpenFile 
    
    
    
    [RelayCommand]
    public async Task OpenFile()
    {
        var window = new MainWindowView();
        
        var toplevel = TopLevel.GetTopLevel(window);
        
        var files = await toplevel.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions

        {
            Title = "Open File",
            AllowMultiple = false,
            SuggestedFileType = FilePickerFileTypes.TextPlain,
            
            });
            
   
        
        if (files.Count >= 1)
        {
            
        using var stream = await files[0].OpenReadAsync();            
         using var  streamreader = new StreamReader(stream);   
         _menuModel.Content = await streamreader.ReadToEndAsync();
      
         
        }
     
            
        
        
        
    }
    
  
    
    [RelayCommand]
    public async Task SaveFile()
    {
        
        var window = new MainWindowView();
        
        var toplevel = TopLevel.GetTopLevel(window);
        
        
        var file = await toplevel.StorageProvider.SaveFilePickerAsync(new FilePickerSaveOptions
        {
            Title = "Save File",
            SuggestedFileName = "Untitled",
            DefaultExtension = "txt",
            ShowOverwritePrompt = true,
            });
        
        
        
        if (file != null)
        {
            await using var stream = await file.OpenWriteAsync();
            using var  streamwriter = new StreamWriter(stream);
            await streamwriter.WriteLineAsync(_menuModel.Content);
            
            
            
        }
        
        
        
            
    
    }
    
    
    
    
    }
    
  
    
  