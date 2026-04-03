using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Input;
using Avalonia.Controls;
using Avalonia.Platform.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HarfBuzzSharp;
using Notepad_V2.BaseCommands;
using Notepad_V2.Models;
using Notepad_V2.Views;
using Tmds.DBus.Protocol;

namespace Notepad_V2.ViewModels;
public  partial class FileMenuViewModel : ObservableObject
{  
    FileModel _filemodel;
    LowerLabelsModel _lowerlabelsmodel;
    
    
    TextboxModel _textboxmodel;
    TextBoxView _textBoxview;
    TextBoxViewModel _textBoxViewModel;
    
    
    
    
    
    public FilemenuCommand NewFileButtonCommand {get;set;}

    public FilemenuCommand OpenButtonCommand {get;}
    public FilemenuCommand NewwindowMenuCommand  {get;set;}

    public FilemenuCommand SaveAsCommand   {get;set;}
    public FilemenuCommand SaveCommand  {get;set;}

    public FilemenuCommand PrintCommand   {get;set;}

    public FilemenuCommand ExitCommand  {get;set;}

    public FilemenuCommand UndoCommand  {get;set;}
    
    public FilemenuCommand CutMenuCommand  {get;set;}
    public FilemenuCommand CopyMenuCommand  {get;set;}
    public FilemenuCommand PasteMenuCommand  {get;set;}
    public FilemenuCommand DeleteMenuCommand  {get;set;}
    
    public FilemenuCommand FindNextMenuCommand  {get;set;}
    
    public FilemenuCommand ReplaceMenuCommand  {get;set;}
    
    public FilemenuCommand GotoMenuCommand  {get;set;}
    
    public FilemenuCommand SelectAllMenuItemCommand  {get;set;}
    public FilemenuCommand TimeDateMenuCommand  {get;set;}
    
    public FilemenuCommand Wordwrapcommand  {get;set;}
   
    public FilemenuCommand FontMenuCommand  {get;set;}
    
    public FilemenuCommand BulletinlistCommand  {get;set;}
    
    public FilemenuCommand NumberedListCommand  {get;set;}
    
    public FilemenuCommand ViewHelpCommand  {get;set;}
    
    public FilemenuCommand AboutMenuItemCommand  {get;set;}
    
    public FilemenuCommand LeaveReviewCommand {get;set;}
    
    public FileMenuViewModel()
    {   
        _filemodel =  new FileModel();
        _lowerlabelsmodel = new LowerLabelsModel();
        _textboxmodel = new TextboxModel();
        _textBoxview = new TextBoxView();
        _textBoxViewModel = new TextBoxViewModel();
      

     /*//File
     NewFileButtonCommand = new FilemenuCommand();
     NewwindowMenuCommand = new FilemenuCommand();*/
     OpenButtonCommand = new FilemenuCommand(_OpenButtonCommand);
    
     
     
     /*
     SaveAsCommand = new FilemenuCommand();
     SaveAsCommand = new FilemenuCommand();
     PrintCommand = new FilemenuCommand();
     ExitCommand = new FilemenuCommand();
     
        
     
     //Edit
     UndoCommand = new FilemenuCommand();
     CutMenuCommand = new FilemenuCommand();
     CopyMenuCommand = new FilemenuCommand();
     PasteMenuCommand = new FilemenuCommand();
     DeleteMenuCommand = new FilemenuCommand();
     FindNextMenuCommand = new FilemenuCommand();
     ReplaceMenuCommand = new FilemenuCommand();
     GotoMenuCommand = new FilemenuCommand();
     SelectAllMenuItemCommand = new FilemenuCommand();
     TimeDateMenuCommand = new FilemenuCommand();
     
        
     //Format
     Wordwrapcommand = new FilemenuCommand();
     FontMenuCommand = new FilemenuCommand();
     BulletinlistCommand = new FilemenuCommand();
     NumberedListCommand = new FilemenuCommand();
     
     
     //view
     ViewHelpCommand = new FilemenuCommand();
     AboutMenuItemCommand = new FilemenuCommand();
     LeaveReviewCommand = new FilemenuCommand();
     */
     
     
        
        
    }


    
    
    
    
    
    //Filemenu Execute Commadns
    
    
    //File
    
    [RelayCommand]
    public async void _OpenButtonCommand(  )
    { 
       
        
        var mainwindow = new MainWindowView(); 
    var toplevel = TopLevel.GetTopLevel(mainwindow);
    var files = await toplevel.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions
  
        {
        Title    = "Open File",
        AllowMultiple = true,
        FileTypeFilter = new List<FilePickerFileType>
        {
            new FilePickerFileType("Text Files")
            {
                Patterns = new[] { "*.txt" }
            },
            
            
            
        }});
    /*if(files!=null)

    {
    
        
        using StreamReader sr = new StreamReader();
        sr.ReadAsync(_t
        
        
    }*/

    
    
    //get file type for labels
    _filemodel.Filetype = files.GetType().ToString();
    _filemodel.Filetype = files.GetType().Name;







    }
    
 
    


    



    
    
    




    

    
    




}