using System;
using System.IO;
using System.Windows.Input;
using Avalonia.Controls;
using Avalonia.Platform.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HarfBuzzSharp;
using Notepad_V2.Models;
using Notepad_V2.Views;

namespace Notepad_V2.ViewModels;
public class FileMenuViewModel : ObservableObject
{  
    FileModel _filemodel;
    LowerLabelsModel _lowerlabelsmodel;
    TextboxModel _textboxmodel;
    
    public ICommand OpenButtonCommand {get;}
    
    
    
    public ICommand NewFileButtonCommand {get;set;}

    public ICommand NewwindowMenuCommand  {get;set;}

    public ICommand SaveAsCommand   {get;set;}

    public ICommand PrintCommand   {get;set;}

    public ICommand ExitCommand  {get;set;}

    public ICommand UndoCommand  {get;set;}
    
    public ICommand CutMenuCommand  {get;set;}
    public ICommand CopyMenuCommand  {get;set;}
    public ICommand PasteMenuCommand  {get;set;}
    public ICommand DeleteMenuCommand  {get;set;}
    
    public ICommand FindNextMenuCommand  {get;set;}
    
    public ICommand ReplaceMenuCommand  {get;set;}
    
    public ICommand GotoMenuCommand  {get;set;}
    
    public ICommand SelectAllMenuItemCommand  {get;set;}
    public ICommand TimeDateMenuCommand  {get;set;}
    
    public ICommand Wordwrapcommand  {get;set;}
   
    public ICommand FontMenuCommand  {get;set;}
    
    public ICommand BulletinlistCommand  {get;set;}
    
    public ICommand NumberedListCommand  {get;set;}
    
    public ICommand ViewHelpCommand  {get;set;}
    
    

    public FileMenuViewModel()
    {
   

        OpenButtonCommand = new RelayCommand(_OpenFile);
        SaveAsCommand = new RelayCommand(_saveAs);
    }


    public async void _OpenFile()
    {
        var _toplevel = TopLevel.GetTopLevel(new MainWindowView());
        var files = await _toplevel.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions());
        
          
        _toplevel.DataContext = _textboxmodel.Text;
        
        
    }
    
    
    public async void _saveAs()
    {
        var _toplevel = TopLevel.GetTopLevel(new MainWindowView());

        var files = await _toplevel.StorageProvider.SaveFilePickerAsync(new FilePickerSaveOptions());
        
        _filemodel.FileName = _toplevel.Name;
        _filemodel.Filetype =  _toplevel.GetType().ToString();
        _filemodel.Filepath = _toplevel.StorageProvider.TryGetFileFromPathAsync(_filemodel.Filetype).ToString();
      
        
        
        
    }
    
    
    
    
    
    
 
    


    



    
    
    




    

    
    




}